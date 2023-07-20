namespace HİGS_KARGO
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGiris = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelKullanıcıAdı = new System.Windows.Forms.Label();
            this.kargoSorgulaPanel = new System.Windows.Forms.Panel();
            this.textBoxOrtalama = new System.Windows.Forms.TextBox();
            this.textBoxKargoDurum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelPlaka1 = new System.Windows.Forms.Label();
            this.labelSurucu1 = new System.Windows.Forms.Label();
            this.labelOrtalama1 = new System.Windows.Forms.Label();
            this.labelOrtalama = new System.Windows.Forms.Label();
            this.labelKargoDurumu = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.textBoxTakipNo = new System.Windows.Forms.TextBox();
            this.kargoNoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kargoGonderPanel = new System.Windows.Forms.Panel();
            this.kargoBoyOrta = new System.Windows.Forms.CheckBox();
            this.kargoBoyKucuk = new System.Windows.Forms.CheckBox();
            this.kargoBoyBuyuk = new System.Windows.Forms.CheckBox();
            this.kargoTipZarf = new System.Windows.Forms.CheckBox();
            this.kargoTipPoset = new System.Windows.Forms.CheckBox();
            this.kargoTipKoli = new System.Windows.Forms.CheckBox();
            this.buttonTamamla = new System.Windows.Forms.Button();
            this.textBoxAlıcıAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGondericiAdres = new System.Windows.Forms.TextBox();
            this.labelGonderenAdres = new System.Windows.Forms.Label();
            this.labelKargoBoyutu = new System.Windows.Forms.Label();
            this.labelKargoTipi = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.labelIsımSoyısım = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelIslemSecımı = new System.Windows.Forms.Panel();
            this.buttonKargoGonder = new System.Windows.Forms.Button();
            this.buttonKargoSorgula = new System.Windows.Forms.Button();
            this.labelIslem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelGiris.SuspendLayout();
            this.kargoSorgulaPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.kargoGonderPanel.SuspendLayout();
            this.panelIslemSecımı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGiris
            // 
            this.panelGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.panelGiris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGiris.Controls.Add(this.label1);
            this.panelGiris.Controls.Add(this.buttonGiris);
            this.panelGiris.Controls.Add(this.textBoxSifre);
            this.panelGiris.Controls.Add(this.textBoxKullaniciAdi);
            this.panelGiris.Controls.Add(this.labelSifre);
            this.panelGiris.Controls.Add(this.labelKullanıcıAdı);
            this.panelGiris.Location = new System.Drawing.Point(999, 261);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(326, 154);
            this.panelGiris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Çalışan Girişi";
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonGiris.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(225, 118);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(75, 29);
            this.buttonGiris.TabIndex = 6;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.BackColor = System.Drawing.Color.White;
            this.textBoxSifre.Location = new System.Drawing.Point(141, 76);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(160, 25);
            this.textBoxSifre.TabIndex = 3;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(141, 38);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(160, 25);
            this.textBoxKullaniciAdi.TabIndex = 2;
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(29, 76);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(36, 17);
            this.labelSifre.TabIndex = 1;
            this.labelSifre.Text = "Şifre";
            // 
            // labelKullanıcıAdı
            // 
            this.labelKullanıcıAdı.AutoSize = true;
            this.labelKullanıcıAdı.Location = new System.Drawing.Point(29, 45);
            this.labelKullanıcıAdı.Name = "labelKullanıcıAdı";
            this.labelKullanıcıAdı.Size = new System.Drawing.Size(83, 17);
            this.labelKullanıcıAdı.TabIndex = 0;
            this.labelKullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // kargoSorgulaPanel
            // 
            this.kargoSorgulaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.kargoSorgulaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kargoSorgulaPanel.Controls.Add(this.textBoxOrtalama);
            this.kargoSorgulaPanel.Controls.Add(this.textBoxKargoDurum);
            this.kargoSorgulaPanel.Controls.Add(this.panel1);
            this.kargoSorgulaPanel.Controls.Add(this.labelPlaka1);
            this.kargoSorgulaPanel.Controls.Add(this.labelSurucu1);
            this.kargoSorgulaPanel.Controls.Add(this.labelOrtalama1);
            this.kargoSorgulaPanel.Controls.Add(this.labelOrtalama);
            this.kargoSorgulaPanel.Controls.Add(this.labelKargoDurumu);
            this.kargoSorgulaPanel.Controls.Add(this.buttonAra);
            this.kargoSorgulaPanel.Controls.Add(this.textBoxTakipNo);
            this.kargoSorgulaPanel.Controls.Add(this.kargoNoLabel);
            this.kargoSorgulaPanel.Controls.Add(this.label2);
            this.kargoSorgulaPanel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kargoSorgulaPanel.Location = new System.Drawing.Point(398, 49);
            this.kargoSorgulaPanel.Name = "kargoSorgulaPanel";
            this.kargoSorgulaPanel.Size = new System.Drawing.Size(576, 549);
            this.kargoSorgulaPanel.TabIndex = 1;
            this.kargoSorgulaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.kargoSorgulaPanel_Paint);
            // 
            // textBoxOrtalama
            // 
            this.textBoxOrtalama.Location = new System.Drawing.Point(408, 210);
            this.textBoxOrtalama.Name = "textBoxOrtalama";
            this.textBoxOrtalama.Size = new System.Drawing.Size(110, 28);
            this.textBoxOrtalama.TabIndex = 14;
            // 
            // textBoxKargoDurum
            // 
            this.textBoxKargoDurum.Location = new System.Drawing.Point(135, 209);
            this.textBoxKargoDurum.Name = "textBoxKargoDurum";
            this.textBoxKargoDurum.Size = new System.Drawing.Size(110, 28);
            this.textBoxKargoDurum.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(40, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 251);
            this.panel1.TabIndex = 12;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(493, 251);
            this.webBrowser1.TabIndex = 0;
            // 
            // labelPlaka1
            // 
            this.labelPlaka1.AutoSize = true;
            this.labelPlaka1.Location = new System.Drawing.Point(172, 260);
            this.labelPlaka1.Name = "labelPlaka1";
            this.labelPlaka1.Size = new System.Drawing.Size(0, 20);
            this.labelPlaka1.TabIndex = 11;
            // 
            // labelSurucu1
            // 
            this.labelSurucu1.AutoSize = true;
            this.labelSurucu1.Location = new System.Drawing.Point(182, 283);
            this.labelSurucu1.Name = "labelSurucu1";
            this.labelSurucu1.Size = new System.Drawing.Size(0, 20);
            this.labelSurucu1.TabIndex = 9;
            // 
            // labelOrtalama1
            // 
            this.labelOrtalama1.AutoSize = true;
            this.labelOrtalama1.Location = new System.Drawing.Point(414, 210);
            this.labelOrtalama1.Name = "labelOrtalama1";
            this.labelOrtalama1.Size = new System.Drawing.Size(0, 20);
            this.labelOrtalama1.TabIndex = 7;
            // 
            // labelOrtalama
            // 
            this.labelOrtalama.AutoSize = true;
            this.labelOrtalama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrtalama.Location = new System.Drawing.Point(268, 210);
            this.labelOrtalama.Name = "labelOrtalama";
            this.labelOrtalama.Size = new System.Drawing.Size(132, 20);
            this.labelOrtalama.TabIndex = 6;
            this.labelOrtalama.Text = "Ortalama Varış:";
            // 
            // labelKargoDurumu
            // 
            this.labelKargoDurumu.AutoSize = true;
            this.labelKargoDurumu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKargoDurumu.Location = new System.Drawing.Point(6, 209);
            this.labelKargoDurumu.Name = "labelKargoDurumu";
            this.labelKargoDurumu.Size = new System.Drawing.Size(133, 20);
            this.labelKargoDurumu.TabIndex = 4;
            this.labelKargoDurumu.Text = "Kargo Durumu:";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(186, 112);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 39);
            this.buttonAra.TabIndex = 3;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // textBoxTakipNo
            // 
            this.textBoxTakipNo.Location = new System.Drawing.Point(15, 118);
            this.textBoxTakipNo.Name = "textBoxTakipNo";
            this.textBoxTakipNo.Size = new System.Drawing.Size(133, 28);
            this.textBoxTakipNo.TabIndex = 2;
            this.textBoxTakipNo.TextChanged += new System.EventHandler(this.textBoxTakipNo_TextChanged);
            // 
            // kargoNoLabel
            // 
            this.kargoNoLabel.AutoSize = true;
            this.kargoNoLabel.Location = new System.Drawing.Point(11, 84);
            this.kargoNoLabel.Name = "kargoNoLabel";
            this.kargoNoLabel.Size = new System.Drawing.Size(132, 20);
            this.kargoNoLabel.TabIndex = 1;
            this.kargoNoLabel.Text = "Takip Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kargo Sorgulama";
            // 
            // kargoGonderPanel
            // 
            this.kargoGonderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.kargoGonderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kargoGonderPanel.Controls.Add(this.kargoBoyOrta);
            this.kargoGonderPanel.Controls.Add(this.kargoBoyKucuk);
            this.kargoGonderPanel.Controls.Add(this.kargoBoyBuyuk);
            this.kargoGonderPanel.Controls.Add(this.kargoTipZarf);
            this.kargoGonderPanel.Controls.Add(this.kargoTipPoset);
            this.kargoGonderPanel.Controls.Add(this.kargoTipKoli);
            this.kargoGonderPanel.Controls.Add(this.buttonTamamla);
            this.kargoGonderPanel.Controls.Add(this.textBoxAlıcıAdres);
            this.kargoGonderPanel.Controls.Add(this.label5);
            this.kargoGonderPanel.Controls.Add(this.textBoxGondericiAdres);
            this.kargoGonderPanel.Controls.Add(this.labelGonderenAdres);
            this.kargoGonderPanel.Controls.Add(this.labelKargoBoyutu);
            this.kargoGonderPanel.Controls.Add(this.labelKargoTipi);
            this.kargoGonderPanel.Controls.Add(this.labelTc);
            this.kargoGonderPanel.Controls.Add(this.textBoxTC);
            this.kargoGonderPanel.Controls.Add(this.textBoxAdSoyad);
            this.kargoGonderPanel.Controls.Add(this.labelIsımSoyısım);
            this.kargoGonderPanel.Controls.Add(this.label3);
            this.kargoGonderPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kargoGonderPanel.Location = new System.Drawing.Point(398, 54);
            this.kargoGonderPanel.Name = "kargoGonderPanel";
            this.kargoGonderPanel.Size = new System.Drawing.Size(594, 558);
            this.kargoGonderPanel.TabIndex = 2;
            this.kargoGonderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.kargoGonderPanel_Paint);
            // 
            // kargoBoyOrta
            // 
            this.kargoBoyOrta.AutoSize = true;
            this.kargoBoyOrta.Location = new System.Drawing.Point(132, 283);
            this.kargoBoyOrta.Name = "kargoBoyOrta";
            this.kargoBoyOrta.Size = new System.Drawing.Size(57, 21);
            this.kargoBoyOrta.TabIndex = 23;
            this.kargoBoyOrta.Text = "Orta";
            this.kargoBoyOrta.UseVisualStyleBackColor = true;
            // 
            // kargoBoyKucuk
            // 
            this.kargoBoyKucuk.AutoSize = true;
            this.kargoBoyKucuk.Location = new System.Drawing.Point(227, 284);
            this.kargoBoyKucuk.Name = "kargoBoyKucuk";
            this.kargoBoyKucuk.Size = new System.Drawing.Size(69, 21);
            this.kargoBoyKucuk.TabIndex = 22;
            this.kargoBoyKucuk.Text = "Küçük";
            this.kargoBoyKucuk.UseVisualStyleBackColor = true;
            // 
            // kargoBoyBuyuk
            // 
            this.kargoBoyBuyuk.AutoSize = true;
            this.kargoBoyBuyuk.Location = new System.Drawing.Point(30, 284);
            this.kargoBoyBuyuk.Name = "kargoBoyBuyuk";
            this.kargoBoyBuyuk.Size = new System.Drawing.Size(68, 21);
            this.kargoBoyBuyuk.TabIndex = 21;
            this.kargoBoyBuyuk.Text = "Büyük";
            this.kargoBoyBuyuk.UseVisualStyleBackColor = true;
            // 
            // kargoTipZarf
            // 
            this.kargoTipZarf.AutoSize = true;
            this.kargoTipZarf.Location = new System.Drawing.Point(227, 212);
            this.kargoTipZarf.Name = "kargoTipZarf";
            this.kargoTipZarf.Size = new System.Drawing.Size(56, 21);
            this.kargoTipZarf.TabIndex = 20;
            this.kargoTipZarf.Text = "Zarf";
            this.kargoTipZarf.UseVisualStyleBackColor = true;
            this.kargoTipZarf.CheckedChanged += new System.EventHandler(this.kargoTipZarf_CheckedChanged);
            // 
            // kargoTipPoset
            // 
            this.kargoTipPoset.AutoSize = true;
            this.kargoTipPoset.Location = new System.Drawing.Point(132, 212);
            this.kargoTipPoset.Name = "kargoTipPoset";
            this.kargoTipPoset.Size = new System.Drawing.Size(63, 21);
            this.kargoTipPoset.TabIndex = 19;
            this.kargoTipPoset.Text = "Poşet";
            this.kargoTipPoset.UseVisualStyleBackColor = true;
            // 
            // kargoTipKoli
            // 
            this.kargoTipKoli.AutoSize = true;
            this.kargoTipKoli.Location = new System.Drawing.Point(30, 212);
            this.kargoTipKoli.Name = "kargoTipKoli";
            this.kargoTipKoli.Size = new System.Drawing.Size(54, 21);
            this.kargoTipKoli.TabIndex = 18;
            this.kargoTipKoli.Text = "Koli";
            this.kargoTipKoli.UseVisualStyleBackColor = true;
            // 
            // buttonTamamla
            // 
            this.buttonTamamla.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTamamla.Location = new System.Drawing.Point(479, 484);
            this.buttonTamamla.Name = "buttonTamamla";
            this.buttonTamamla.Size = new System.Drawing.Size(79, 24);
            this.buttonTamamla.TabIndex = 17;
            this.buttonTamamla.Text = "Tamamla";
            this.buttonTamamla.UseVisualStyleBackColor = true;
            this.buttonTamamla.Click += new System.EventHandler(this.buttonTamamla_Click);
            // 
            // textBoxAlıcıAdres
            // 
            this.textBoxAlıcıAdres.Location = new System.Drawing.Point(305, 343);
            this.textBoxAlıcıAdres.Multiline = true;
            this.textBoxAlıcıAdres.Name = "textBoxAlıcıAdres";
            this.textBoxAlıcıAdres.Size = new System.Drawing.Size(253, 135);
            this.textBoxAlıcıAdres.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(302, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Alıcı Adresi:";
            // 
            // textBoxGondericiAdres
            // 
            this.textBoxGondericiAdres.Location = new System.Drawing.Point(30, 343);
            this.textBoxGondericiAdres.Multiline = true;
            this.textBoxGondericiAdres.Name = "textBoxGondericiAdres";
            this.textBoxGondericiAdres.Size = new System.Drawing.Size(253, 135);
            this.textBoxGondericiAdres.TabIndex = 14;
            // 
            // labelGonderenAdres
            // 
            this.labelGonderenAdres.AutoSize = true;
            this.labelGonderenAdres.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGonderenAdres.Location = new System.Drawing.Point(30, 323);
            this.labelGonderenAdres.Name = "labelGonderenAdres";
            this.labelGonderenAdres.Size = new System.Drawing.Size(124, 17);
            this.labelGonderenAdres.TabIndex = 13;
            this.labelGonderenAdres.Text = "Gönderici Adresi:";
            // 
            // labelKargoBoyutu
            // 
            this.labelKargoBoyutu.AutoSize = true;
            this.labelKargoBoyutu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKargoBoyutu.Location = new System.Drawing.Point(27, 248);
            this.labelKargoBoyutu.Name = "labelKargoBoyutu";
            this.labelKargoBoyutu.Size = new System.Drawing.Size(105, 17);
            this.labelKargoBoyutu.TabIndex = 9;
            this.labelKargoBoyutu.Text = "Kargo Boyutu:";
            // 
            // labelKargoTipi
            // 
            this.labelKargoTipi.AutoSize = true;
            this.labelKargoTipi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKargoTipi.Location = new System.Drawing.Point(27, 172);
            this.labelKargoTipi.Name = "labelKargoTipi";
            this.labelKargoTipi.Size = new System.Drawing.Size(84, 17);
            this.labelKargoTipi.TabIndex = 5;
            this.labelKargoTipi.Text = "Kargo Tipi:";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.Location = new System.Drawing.Point(27, 123);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(57, 17);
            this.labelTc.TabIndex = 4;
            this.labelTc.Text = "TC No:";
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(103, 118);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(141, 25);
            this.textBoxTC.TabIndex = 3;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(103, 76);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(141, 25);
            this.textBoxAdSoyad.TabIndex = 2;
            // 
            // labelIsımSoyısım
            // 
            this.labelIsımSoyısım.AutoSize = true;
            this.labelIsımSoyısım.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIsımSoyısım.Location = new System.Drawing.Point(24, 80);
            this.labelIsımSoyısım.Name = "labelIsımSoyısım";
            this.labelIsımSoyısım.Size = new System.Drawing.Size(78, 17);
            this.labelIsımSoyısım.TabIndex = 1;
            this.labelIsımSoyısım.Text = "Ad, Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kargo Gönder/ Kurye Çagır";
            // 
            // panelIslemSecımı
            // 
            this.panelIslemSecımı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.panelIslemSecımı.Controls.Add(this.buttonKargoGonder);
            this.panelIslemSecımı.Controls.Add(this.buttonKargoSorgula);
            this.panelIslemSecımı.Controls.Add(this.labelIslem);
            this.panelIslemSecımı.Location = new System.Drawing.Point(27, 249);
            this.panelIslemSecımı.Name = "panelIslemSecımı";
            this.panelIslemSecımı.Size = new System.Drawing.Size(326, 187);
            this.panelIslemSecımı.TabIndex = 4;
            // 
            // buttonKargoGonder
            // 
            this.buttonKargoGonder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKargoGonder.Location = new System.Drawing.Point(83, 120);
            this.buttonKargoGonder.Name = "buttonKargoGonder";
            this.buttonKargoGonder.Size = new System.Drawing.Size(142, 46);
            this.buttonKargoGonder.TabIndex = 7;
            this.buttonKargoGonder.Text = "Kargo Gönder\r\nKurye Çağır";
            this.buttonKargoGonder.UseVisualStyleBackColor = true;
            this.buttonKargoGonder.Click += new System.EventHandler(this.buttonKargoGonder_Click);
            // 
            // buttonKargoSorgula
            // 
            this.buttonKargoSorgula.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKargoSorgula.Location = new System.Drawing.Point(83, 81);
            this.buttonKargoSorgula.Name = "buttonKargoSorgula";
            this.buttonKargoSorgula.Size = new System.Drawing.Size(142, 29);
            this.buttonKargoSorgula.TabIndex = 6;
            this.buttonKargoSorgula.Text = "Kargo Sorgulama";
            this.buttonKargoSorgula.UseVisualStyleBackColor = true;
            this.buttonKargoSorgula.Click += new System.EventHandler(this.buttonKargoSorgula_Click);
            // 
            // labelIslem
            // 
            this.labelIslem.AutoSize = true;
            this.labelIslem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIslem.Location = new System.Drawing.Point(4, 32);
            this.labelIslem.Name = "labelIslem";
            this.labelIslem.Size = new System.Drawing.Size(322, 40);
            this.labelIslem.TabIndex = 5;
            this.labelIslem.Text = "Değerli Müşterimiz,\r\nLütfen yapmak istediğiniz işlemi seçiniz.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HİGS_KARGO.Properties.Resources.Estd_2022_photoaidcom_cropped;
            this.pictureBox1.Location = new System.Drawing.Point(398, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(1313, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(1280, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 696);
            this.Controls.Add(this.kargoGonderPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelIslemSecımı);
            this.Controls.Add(this.panelGiris);
            this.Controls.Add(this.kargoSorgulaPanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGiris.ResumeLayout(false);
            this.panelGiris.PerformLayout();
            this.kargoSorgulaPanel.ResumeLayout(false);
            this.kargoSorgulaPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.kargoGonderPanel.ResumeLayout(false);
            this.kargoGonderPanel.PerformLayout();
            this.panelIslemSecımı.ResumeLayout(false);
            this.panelIslemSecımı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelKullanıcıAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPlaka1;
        private System.Windows.Forms.Label labelSurucu1;
        private System.Windows.Forms.Label labelOrtalama1;
        private System.Windows.Forms.Label labelOrtalama;
        private System.Windows.Forms.Label labelKargoDurumu;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.TextBox textBoxTakipNo;
        private System.Windows.Forms.Label kargoNoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAlıcıAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGondericiAdres;
        private System.Windows.Forms.Label labelGonderenAdres;
        private System.Windows.Forms.Label labelKargoBoyutu;
        private System.Windows.Forms.Label labelKargoTipi;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label labelIsımSoyısım;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelIslemSecımı;
        private System.Windows.Forms.Button buttonKargoGonder;
        private System.Windows.Forms.Button buttonKargoSorgula;
        private System.Windows.Forms.Label labelIslem;
        public System.Windows.Forms.Panel kargoSorgulaPanel;
        public System.Windows.Forms.Panel kargoGonderPanel;
        public System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonTamamla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox kargoBoyOrta;
        private System.Windows.Forms.CheckBox kargoBoyBuyuk;
        private System.Windows.Forms.CheckBox kargoTipZarf;
        private System.Windows.Forms.CheckBox kargoTipPoset;
        private System.Windows.Forms.CheckBox kargoTipKoli;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxOrtalama;
        private System.Windows.Forms.TextBox textBoxKargoDurum;
        public System.Windows.Forms.CheckBox kargoBoyKucuk;
    }
}

