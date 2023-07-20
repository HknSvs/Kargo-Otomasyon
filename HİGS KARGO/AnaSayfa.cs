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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=" +
                                                 "higskargo;Integrated Security=True");




        private void Form1_Load(object sender, EventArgs e)
        {
            kargoGonderPanel.Visible = false;
            kargoSorgulaPanel.Visible = false;
            
        }

        private void buttonKargoSorgula_Click(object sender, EventArgs e)
        {
            kargoSorgulaPanel.Show();
            kargoGonderPanel.Hide();
        }

        private void buttonKargoGonder_Click(object sender, EventArgs e)
        {
            kargoSorgulaPanel.Hide();
            kargoGonderPanel.Show();
           
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Elemanlar WHERE elemanAd ='" + textBoxKullaniciAdi.Text + "' AND " +
                                                    "elemanSifre ='" + textBoxSifre.Text + "'", baglan);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
           
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                CalisanAnasayfa calisanAnasayfa = new CalisanAnasayfa();
                calisanAnasayfa.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");

           

        }

        void maps()
        {
            string teslimAdres = textBoxAlıcıAdres.Text;
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://google.com/maps?q=");

            if (teslimAdres != string.Empty)
            {
                queryaddress.Append(teslimAdres + "," + "+");
            }

            webBrowser1.Navigate(queryaddress.ToString());
        }

       
        private void buttonAra_Click(object sender, EventArgs e)
        {
            maps();
            if (textBoxTakipNo.Text != "")
            {
                
                SqlCommand cmdKargoGonder = new SqlCommand("Select kargoDurum, ortalamaVaris From KargoGonder Where kargoTakipNo = '" + textBoxTakipNo.Text + "'", baglan);
                baglan.Open();
                cmdKargoGonder.Parameters.AddWithValue("@kargoTakipNo", textBoxTakipNo.Text);
                SqlDataReader daKargoGonder = cmdKargoGonder.ExecuteReader();

                while (daKargoGonder.Read())
                {
                    textBoxKargoDurum.Text = daKargoGonder.GetValue(0).ToString();
                    textBoxOrtalama.Text = daKargoGonder.GetValue(1).ToString();
                }
                baglan.Close();
                //------------------------------------------------------------------
                SqlCommand cmdKargolar = new SqlCommand("Select kargoDurum, ortalamaVaris From Kargolar Where kargoTakipNo = '" + textBoxTakipNo.Text + "'", baglan);
                baglan.Open();
                cmdKargolar.Parameters.AddWithValue("@kargoTakipNo", textBoxTakipNo.Text);
                SqlDataReader daKargolar = cmdKargolar.ExecuteReader();

                while (daKargolar.Read())
                {
                    textBoxKargoDurum.Text = daKargolar.GetValue(0).ToString();
                    textBoxOrtalama.Text = daKargolar.GetValue(1).ToString();
                }
                baglan.Close();
                //-------------------------------------------------------------------
                SqlCommand cmdKargoDepo = new SqlCommand("Select kargoDurum, ortalamaVaris From KargoDepo Where kargoTakipNo = '" + textBoxTakipNo.Text + "'", baglan);
                baglan.Open();
                cmdKargoDepo.Parameters.AddWithValue("@kargoTakipNo", textBoxTakipNo.Text);
                SqlDataReader daDepo = cmdKargoDepo.ExecuteReader();

                while (daDepo.Read())
                {
                    textBoxKargoDurum.Text = daDepo.GetValue(0).ToString();
                    textBoxOrtalama.Text = daDepo.GetValue(1).ToString();
                }
                baglan.Close();

                textBoxOrtalama.Update();
                textBoxKargoDurum.Update();
                textBoxOrtalama.Refresh();
                textBoxKargoDurum.Refresh();

            }

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kargoGonderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kargoSorgulaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTamamla_Click(object sender, EventArgs e)
        {

            

            int toplamFiyat = 0;
            baglan.Open();
            string sorgu = "Insert into Kargolar (gonderenAdSoyad, gonderenTC, " +
                           "toplamFiyat,kargoTip, kargoBoyut, gonderenAdres, aliciAdres, kargoTakipNo) " +
                           "values (@gonderenAdSoyad, @gonderenTC, @toplamFiyat, @kargoTip, @kargoBoyut, " +
                           "@gonderenAdres, @aliciAdres, @kargoTakipNo)";
            
            SqlCommand komut = new SqlCommand(sorgu, baglan);

            Random rnd = new Random();
            int randomTakip = rnd.Next(1000, 10000);
            String kargoTakipNo = "HİGS" + randomTakip.ToString();

            komut.Parameters.AddWithValue("@gonderenAdSoyad", textBoxAdSoyad.Text);
            komut.Parameters.AddWithValue("@gonderenTC", textBoxTC.Text);
           

            if(kargoTipKoli.Checked) 
            {
                komut.Parameters.AddWithValue("@kargoTip", kargoTipKoli.Text);
                kargoBoyBuyuk.Show();
                kargoBoyOrta.Show();
                kargoBoyKucuk.Show();
                toplamFiyat += 5000;
            }
            else if (kargoTipPoset.Checked) 
            {
                komut.Parameters.AddWithValue("@kargoTip", kargoTipPoset.Text);
                kargoBoyBuyuk.Show();
                kargoBoyOrta.Show();
                kargoBoyKucuk.Show();
                toplamFiyat += 4000;
            }
            else if (kargoTipZarf.Checked) 
            {
                komut.Parameters.AddWithValue("@kargoTip", kargoTipZarf.Text);
               
                toplamFiyat += 3000;
            }
            else { MessageBox.Show("Eksik Yerleri Doldurunuz!"); }



            if (kargoBoyKucuk.Checked) 
            {
                komut.Parameters.AddWithValue("@kargoBoyut", kargoBoyKucuk.Text);
                toplamFiyat += 1000;
            }
            else if (kargoBoyOrta.Checked)
            {
                komut.Parameters.AddWithValue("@kargoBoyut", kargoBoyOrta.Text);
                toplamFiyat += 2000;
            }
            else if (kargoBoyBuyuk.Checked)
            {
                komut.Parameters.AddWithValue("@kargoBoyut", kargoBoyBuyuk.Text);
                toplamFiyat += 3000;
            }
            else 
            {
               
                 MessageBox.Show("Boşlukları Doldurunuz!"); 
            }


            komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
            komut.Parameters.AddWithValue("@kargoTakipNo", kargoTakipNo);
            MessageBox.Show("Kargo Takip Numaranız: " + kargoTakipNo + " Ödemeniz gereken tutar " +
                "" + toplamFiyat);
            komut.Parameters.AddWithValue("@gonderenAdres", textBoxGondericiAdres.Text);
            komut.Parameters.AddWithValue("@aliciAdres", textBoxAlıcıAdres.Text);
            komut.ExecuteNonQuery();
            baglan.Close(); 

            baglan.Open();
            string sorguDurum = "UPDATE Kargolar SET kargoDurum = @aİşlemde";
            SqlCommand sqlDurum = new SqlCommand(sorguDurum, baglan);
            string islemde = "İşlemde";
            sqlDurum.Parameters.AddWithValue("@aİşlemde", islemde );
            sqlDurum.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            string sorguVaris = "UPDATE Kargolar SET ortalamaVaris = @aBeşGün";
            SqlCommand sqlVaris = new SqlCommand(sorguVaris, baglan);
            string varis = "BeşGün";
            sqlVaris.Parameters.AddWithValue("@aBeşGün", varis);
            sqlVaris.ExecuteNonQuery();
            baglan.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
       
        private void kargoTipZarf_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxTakipNo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
