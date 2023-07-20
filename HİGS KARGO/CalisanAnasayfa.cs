using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HİGS_KARGO
{
    public partial class CalisanAnasayfa : Form
    {
        public CalisanAnasayfa()
        {
            InitializeComponent();
        }

        SürücüUC surucu = new SürücüUC();
        InsanKaynaklarıUC ik = new InsanKaynaklarıUC();
        DepoUC depo = new DepoUC();
        MuhasebeUC muhasebe = new MuhasebeUC(); 

        private void CalisanAnasayfa_Load(object sender, EventArgs e)
        {
            ınsanKaynaklarıUC2.Hide();
            depoUC1.Hide();
            sürücüUC2.Hide();
            muhasebeUC1.Hide();
        }

        private void buttonIK_Click(object sender, EventArgs e)
        {
            ınsanKaynaklarıUC2.Show();
            depoUC1.Hide();
            sürücüUC2.Hide();
            muhasebeUC1.Hide();

            surucu.Update();
            ik.Update();
            depo.Update();
            muhasebe.Update();
            surucu.Refresh();
            ik.Refresh();
            depo.Refresh();
            muhasebe.Refresh();

        }

        private void buttonMuhasebe_Click(object sender, EventArgs e)
        {
            ınsanKaynaklarıUC2.Hide();
            depoUC1.Hide();
            sürücüUC2.Hide();
            muhasebeUC1.Show();

            surucu.Update();
            ik.Update();
            depo.Update();
            muhasebe.Update();
            surucu.Refresh();
            ik.Refresh();
            depo.Refresh();
            muhasebe.Refresh();
            
        }

        private void buttonSurucu_Click(object sender, EventArgs e)
        {
            ınsanKaynaklarıUC2.Hide();
            depoUC1.Hide();
            sürücüUC2.Show();
            muhasebeUC1.Hide();

            surucu.Update();
            ik.Update();
            depo.Update();
            muhasebe.Update();
            surucu.Refresh();
            ik.Refresh();
            depo.Refresh();
            muhasebe.Refresh();
        }

        private void buttonDepo_Click(object sender, EventArgs e)
        {
            ınsanKaynaklarıUC2.Hide();
            depoUC1.Show();
            sürücüUC2.Hide();
            muhasebeUC1.Hide();

            surucu.Update();
            ik.Update();
            depo.Update();
            muhasebe.Update();
            surucu.Refresh();
            ik.Refresh();
            depo.Refresh();
            muhasebe.Refresh();
        }

        private void ınsanKaynaklarıUC2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Giris girisSayfasi = new Giris();
            girisSayfasi.Show();
            CalisanAnasayfa calisanAnasayfa = new CalisanAnasayfa();
            calisanAnasayfa.Hide();
        }

        private void depoUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
