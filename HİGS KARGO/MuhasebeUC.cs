using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HİGS_KARGO
{
    public partial class MuhasebeUC : UserControl
    { 

        public MuhasebeUC()
        {
            InitializeComponent();
        }

        
       void kurlar()
        {
            string guncelKurlar = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(guncelKurlar);
            String USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'USD']/BanknoteSelling").InnerXml;
            String EU = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'EUR']/BanknoteSelling").InnerXml;
            String GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'GBP']/BanknoteSelling").InnerXml;
            String CHF = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'CHF']/BanknoteSelling").InnerXml;
            textBoxDolarKur.Text = String.Format(USD);
            textBoxEuroKur.Text = String.Format(EU);
            textBoxSterlinKur.Text = String.Format(GBP);
            textBoxCHFKur.Text = String.Format(CHF);

        }




        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=" +
                                                 "higskargo;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        DataView dv;
        void listeleme()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from AracSorgulama", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "AracSorgulama");
            dataGridViewArac.DataSource = ds.Tables["AracSorgulama"];

        }

        void listelemeIki() 
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from KargoTeslim", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "KargoTeslim");
            dataGridViewTeslim.DataSource = ds.Tables["KargoTeslim"];
        }

        void arac()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from AracSorgulama", baglan);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            baglan.Close();
            dv = new DataView(dt);
            dataGridViewArac.DataSource = dv;

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void buttonAracSat_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "Delete from AracSorgulama Where aracPlaka ='" + textBoxAracSorgula.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@aracPlaka", dataGridViewArac.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();// tüm satırı siler.
            MessageBox.Show("Araç satılsın mı?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            listeleme();
            baglan.Close();

            int aracDusum = int.Parse(textBoxAylıkYakıtGider.Text);
            int aracYup = aracDusum - 500;
            textBoxAylıkYakıtGider.Text = aracYup.ToString();
        }

        private void MuhasebeUC_Load(object sender, EventArgs e)
        {

            panel1.Visible = false;
            listeleme();
            arac();
            kurlar();
            listelemeIki();

            baglan.Open();
           
            SqlCommand komut = new SqlCommand("Select sum(toplamFiyat) from KargoTeslim", baglan);
            komut.Connection = baglan;
            int gelir = (Int32)komut.ExecuteScalar();
            textBoxGunlukGelir.Text = gelir.ToString();


            baglan.Close();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) From Kargolar", baglan);
            var count1 = cmd.ExecuteScalar();
            textBoxKargoAdet.Text = count1.ToString();
            baglan.Close();
            baglan.Open();
            SqlCommand aracSayisi = new SqlCommand("Select Count(*) From AracSorgulama", baglan);

            var count2 = aracSayisi.ExecuteScalar();
            textBoxAracSayi.Text = count2.ToString();

            int aracSayilari = (Int32)aracSayisi.ExecuteScalar();

            int aracGideri = aracSayilari * 500;

            textBoxAylıkYakıtGider.Text = aracGideri.ToString();

            baglan.Close();
            baglan.Open();
            SqlCommand query = new SqlCommand("SELECT SUM(elemanMaas) FROM Elemanlar");
            query.Connection = baglan;
            int toplamMaas = (Int32)query.ExecuteScalar();
            textBoxAylıkMaasGider.Text = toplamMaas.ToString();
            baglan.Close();

            int gider = toplamMaas + aracGideri;
            textBoxGunlukGider.Text = gider.ToString();

            int karZarar = gelir - gider;
            textBoxGunlukKarZarar.Text = karZarar.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAracAra_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxAracSorgula_TextChanged(object sender, EventArgs e)
        {

            dv = new DataView(dt);
            dv.RowFilter = string.Format("convert(aracPlaka, 'System.String') Like '%{0}%' ",
                             textBoxAracSorgula.Text);
            dataGridViewArac.DataSource = dv;
        }

        private void textBoxGunlukGelir_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalisanAnasayfa form3 = new CalisanAnasayfa();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "Insert into AracSorgulama (aracPlaka) values (@aracPlaka)";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@aracPlaka", textBoxPlakaBir.Text);
            komut.ExecuteNonQuery();
            baglan.Close();

            dataGridViewArac.Update();
            dataGridViewArac.Refresh();
            textBoxAracSayi.Update();
            textBoxAracSayi.Refresh();
            textBoxAylıkYakıtGider.Update();
            textBoxAylıkYakıtGider.Refresh();
            listeleme();
            panel1.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridViewTeslim.Update();
            dataGridViewTeslim.Refresh();
            listelemeIki();
        }
    }
}
