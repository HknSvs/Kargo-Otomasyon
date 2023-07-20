using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Markup;
using System.Data.Sql;



namespace HİGS_KARGO
{
    public partial class InsanKaynaklarıUC : UserControl
    {

       
        public InsanKaynaklarıUC()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=" +
                                                 "higskargo;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        DataView dv;
      
        void listeleme()
        {
          
            SqlDataAdapter da = new SqlDataAdapter("Select * from Elemanlar", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "Elemanlartab");
            dataGridViewEleman.DataSource = ds.Tables["Elemanlartab"];
            this.dataGridViewEleman.Columns["elemanSifre"].Visible = false;
            this.dataGridViewEleman.Columns["elemanId"].Visible = false;

        }

        void getir() 
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Elemanlar", baglan);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            baglan.Close();
            dv = new DataView(dt);
            dataGridViewEleman.DataSource = dv;

        }

        private void InsanKaynaklarıUC_Load(object sender, EventArgs e)
        {
            listeleme();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMaas_Click(object sender, EventArgs e)
        {
            listeleme();    
        }

        private void buttonIstenCik_Click(object sender, EventArgs e)
        {
            
              

                string sorgu = "DELETE FROM Elemanlar WHERE elemanTC='" + textBoxSil.Text + "'";
                SqlCommand komut = new SqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@elemanTC", dataGridViewEleman.CurrentRow.Cells[0].Value.ToString());
                baglan.Open();
                komut.ExecuteNonQuery();
                
                MessageBox.Show("Bu çalışanı işten çıkartmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Kayıt Silindi!");
                komut.Parameters.AddWithValue("@elemanTC", dataGridViewEleman.CurrentRow.Cells[0].Value.ToString());
                listeleme();
                baglan.Close();

        }

       

        private void buttonIseAl_Click(object sender, EventArgs e)
        {
            {
                baglan.Open();
                string sorgu = "Insert into Elemanlar (elemanTC, elemanAd, elemanSoyad, elemanMaas, elemanPozisyon, elemanSifre) values (@elemanTC, @elemanAd, @elemanSoyad, @elemanMaas, @elemanPozisyon, @elemanSifre)"; 
                SqlCommand komut = new SqlCommand(sorgu, baglan);
               
                komut.Parameters.AddWithValue("@elemanTC", textBoxTcBir.Text);
                komut.Parameters.AddWithValue("@elemanAd", textBoxAdBir.Text);
                komut.Parameters.AddWithValue("@elemanSoyad", textBoxSoyadBir.Text);
                komut.Parameters.AddWithValue("@elemanMaas", textBoxMaasBir.Text);
                komut.Parameters.AddWithValue("@elemanPozisyon", comboBoxPozisyonlar.Text);

                
               
                Random rnd = new Random();
                int random = rnd.Next(1000, 10000);
                var randomSifre = random.ToString();
                komut.Parameters.AddWithValue("@elemanSifre", randomSifre);

                MessageBox.Show(textBoxAdBir.Text + " " + textBoxSoyadBir.Text + " isimli çalışan işe alınmıştır. Şifresi " + randomSifre + "'dir!");

                listeleme();
                komut.ExecuteNonQuery();
                baglan.Close();

                dataGridViewEleman.Update();
                dataGridViewEleman.Refresh();
                listeleme();
            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {

        }

        

        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {
            getir();
            dv = new DataView(dt);
            dv.RowFilter = "elemanAd LIKE '" + textBoxAd.Text + "%'";
            dataGridViewEleman.DataSource = dv;
        }

        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {
            getir();
            dv = new DataView(dt);
            dv.RowFilter = "elemanSoyad LIKE '" + textBoxSoyad.Text + "%'";
            dataGridViewEleman.DataSource = dv;
        }

        private void textBoxMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPozisyon_TextChanged(object sender, EventArgs e)
        {
            getir();
            dv = new DataView(dt);
            dv.RowFilter = "elemanPozisyon LIKE '" + textBoxPozisyon.Text + "%'";
            dataGridViewEleman.DataSource = dv;
        }

        private void dataGridViewEleman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTcBir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
