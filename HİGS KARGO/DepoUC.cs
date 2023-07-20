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

namespace HİGS_KARGO
{
    public partial class DepoUC : UserControl
    {

        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=" +
                                                "higskargo;Integrated Security=True");

        

        public DepoUC()
        {
            InitializeComponent();
        }

        void listeleme()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Kargolar", baglan);//veri tabanının icine yazmak istenilenler close kadar yazılmalıdır.
            DataSet ds = new DataSet();// veri tabanının ıcınden cekıp doldurma
            da.Fill(ds, "Kargolartab");// bunun ıcerısıne dolduruyor.
            dataGridViewHazırKargo.DataSource = ds.Tables["Kargolartab"];// gosterme islemini burada gerceklestiriyor.
            


        }

        void listelemeIki()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from KargoGonder", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "KargoGondertab");
            dataGridViewYukluKargo.DataSource = ds.Tables["KargoGondertab"];
            this.dataGridViewYukluKargo.Columns["kargoId"].Visible = false;

        }

        void listelemeUc() 
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from KargoDepo", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "KargoDepotab");
            dataGridView1.DataSource = ds.Tables["KargoDepotab"];
            this.dataGridView1.Columns["toplamFiyat"].Visible = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepoUC_Load(object sender, EventArgs e)
        {
            listeleme();
            listelemeIki();
            listelemeUc();


        }

        private void textBoxDepoKapasite_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDepoDurum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewHazırKargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewYukluKargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                baglan.Open();
                string sorguTransfer = ("Insert Into KargoGonder(kargoTakipNo, kargoTip, kargoBoyut, aliciAdres, toplamFiyat) Select kargoTakipNo, kargoTip, kargoBoyut, aliciAdres, toplamFiyat From KargoDepo Where kargoTakipNo = '" + textBoxYukle.Text + "'");
                SqlCommand komutTransfer = new SqlCommand(sorguTransfer, baglan);
                komutTransfer.Parameters.AddWithValue("@kargoTakipNo", textBoxYukle.Text);
                komutTransfer.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                string sorgu = "Delete from KargoDepo Where kargoTakipNo = '" + textBoxYukle.Text + "'";
                SqlCommand komut = new SqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@kargoTakipNo", dataGridViewHazırKargo.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                string sorguVaris = "UPDATE KargoGonder SET ortalamaVaris = @Bugünİçinde";
                SqlCommand sqlVaris = new SqlCommand(sorguVaris, baglan);
                string varis = "Bugünİçinde";
                sqlVaris.Parameters.AddWithValue("@Bugünİçinde", varis);
                sqlVaris.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                string sorguDurum = "UPDATE KargoGonder SET kargoDurum = @Araçta";
                SqlCommand sqlDurum = new SqlCommand(sorguDurum, baglan);
                string arac = "Araçta";
                sqlDurum.Parameters.AddWithValue("@Araçta", arac);
                sqlDurum.ExecuteNonQuery();
                baglan.Close();
            
                
            
            dataGridViewYukluKargo.Update();
            dataGridViewYukluKargo.Refresh();
            dataGridViewHazırKargo.Update();
            dataGridViewHazırKargo.Refresh();
            dataGridView1.Update();
            dataGridView1.Refresh();
            listeleme();
            listelemeIki();
            listelemeUc();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalisanAnasayfa form2 = new CalisanAnasayfa();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOnay_Click(object sender, EventArgs e)
        {
            
                baglan.Open();
                string sorguTransfer = ("Insert Into KargoDepo(kargoTakipNo, kargoTip, kargoBoyut, aliciAdres, toplamFiyat) Select kargoTakipNo, kargoTip, kargoBoyut, aliciAdres, toplamFiyat From Kargolar Where kargoTakipNo = '" + textBoxOnay.Text + "'");
                SqlCommand komutTransfer = new SqlCommand(sorguTransfer, baglan);
                komutTransfer.Parameters.AddWithValue("@kargoTakipNo", textBoxOnay.Text);
                komutTransfer.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                string sorgu = "Delete from Kargolar Where kargoTakipNo = '" + textBoxOnay.Text + "'";
                SqlCommand komut = new SqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@kargoTakipNo", dataGridViewHazırKargo.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                string sorguVaris = "UPDATE KargoDepo SET ortalamaVaris = @ÜçGün";
                SqlCommand sqlVaris = new SqlCommand(sorguVaris, baglan);
                string varis = "ÜçGün";
                sqlVaris.Parameters.AddWithValue("@ÜçGün", varis);
                sqlVaris.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                string sorguDurum = "UPDATE KargoDepo SET kargoDurum = @Depoda";
                SqlCommand sqlDurum = new SqlCommand(sorguDurum, baglan);
                string depo = "Depoda";
                sqlDurum.Parameters.AddWithValue("@Depoda", depo);
                sqlDurum.ExecuteNonQuery();
                baglan.Close();

                
          
            dataGridViewYukluKargo.Update();
            dataGridViewYukluKargo.Refresh();
            dataGridViewHazırKargo.Update();
            dataGridViewHazırKargo.Refresh();
            dataGridView1.Update();
            dataGridView1.Refresh();
            listeleme();
            listelemeIki();
            listelemeUc();  
        }
    }
}
