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

namespace HİGS_KARGO
{
    public partial class SürücüUC : UserControl
    {
        public SürücüUC()
        {
            InitializeComponent();
        }

        

        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=" +
                                                 "higskargo;Integrated Security=True");
        void listeleme()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from KargoGonder", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "KargoGondertab");
            dataGridViewAdresler.DataSource = ds.Tables["KargoGondertab"];
            this.dataGridViewAdresler.Columns["kargoId"].Visible = false;
            this.dataGridViewAdresler.Columns["kargoTip"].Visible = false;
            this.dataGridViewAdresler.Columns["kargoBoyut"].Visible = false;
            this.dataGridViewAdresler.Columns["kargoDurum"].Visible = false;
            this.dataGridViewAdresler.Columns["ortalamaVaris"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SürücüUC_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalisanAnasayfa form4 = new CalisanAnasayfa();
            form4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void buttonTeslimEdildi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorguTransfer = ("Insert Into KargoTeslim(kargoTakipNo, toplamFiyat) Select kargoTakipNo, toplamFiyat From KargoGonder Where kargoTakipNo = '" + textBoxTeslimEdildi.Text + "'");
            SqlCommand komutTransfer = new SqlCommand(sorguTransfer, baglan);
            komutTransfer.Parameters.AddWithValue("@kargoTakipNo", textBoxTeslimEdildi.Text);
            komutTransfer.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            string sorgu = "Delete from KargoGonder Where kargoTakipNo = '" + textBoxTeslimEdildi.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@kargoTakipNo", dataGridViewAdresler.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            baglan.Close();

            dataGridViewAdresler.Update();
            dataGridViewAdresler.Refresh();
            listeleme();

        }

        private void buttonTeslimEdilemedi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorguTransfer = ("Insert Into KargoDepo(kargoTakipNo, toplamFiyat) Select kargoTakipNo, toplamFiyat From Kargolar Where kargoTakipNo = '" + textBoxTeslimEdilemedi.Text + "'");
            SqlCommand komutTransfer = new SqlCommand(sorguTransfer, baglan);
            komutTransfer.Parameters.AddWithValue("@kargoTakipNo", textBoxTeslimEdilemedi.Text);
            komutTransfer.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            string sorgu = "Delete from KargoGonder Where kargoTakipNo = '" + textBoxTeslimEdilemedi.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@kargoTakipNo", dataGridViewAdresler.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            baglan.Close();

            dataGridViewAdresler.Update();
            dataGridViewAdresler.Refresh();
            listeleme();

        }

        private void textBoxTeslimEdilemedi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTeslimEdildi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
