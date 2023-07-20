namespace HİGS_KARGO
{
    partial class InsanKaynaklarıUC
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelPozisyon = new System.Windows.Forms.Label();
            this.textBoxPozisyon = new System.Windows.Forms.TextBox();
            this.dataGridViewEleman = new System.Windows.Forms.DataGridView();
            this.buttonIstenCikart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonIseAl = new System.Windows.Forms.Button();
            this.textBoxMaasBir = new System.Windows.Forms.TextBox();
            this.labelPozisyonBir = new System.Windows.Forms.Label();
            this.labelMaasBir = new System.Windows.Forms.Label();
            this.textBoxAdBir = new System.Windows.Forms.TextBox();
            this.textBoxSoyadBir = new System.Windows.Forms.TextBox();
            this.textBoxTcBir = new System.Windows.Forms.TextBox();
            this.labelTcBir = new System.Windows.Forms.Label();
            this.labelAdBir = new System.Windows.Forms.Label();
            this.labelSoyadBir = new System.Windows.Forms.Label();
            this.comboBoxPozisyonlar = new System.Windows.Forms.ComboBox();
            this.higskargoDataSet = new HİGS_KARGO.higskargoDataSet();
            this.higskargoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.higskargoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.higskargoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleman Sorgula";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.Location = new System.Drawing.Point(83, 147);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(55, 17);
            this.labelSoyad.TabIndex = 1;
            this.labelSoyad.Text = "Soyadı:";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(83, 104);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(36, 17);
            this.labelAd.TabIndex = 2;
            this.labelAd.Text = "Adı:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(231, 140);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(130, 25);
            this.textBoxSoyad.TabIndex = 5;
            this.textBoxSoyad.TextChanged += new System.EventHandler(this.textBoxSoyad_TextChanged);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(231, 101);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(130, 25);
            this.textBoxAd.TabIndex = 6;
            this.textBoxAd.TextChanged += new System.EventHandler(this.textBoxAd_TextChanged);
            // 
            // labelPozisyon
            // 
            this.labelPozisyon.AutoSize = true;
            this.labelPozisyon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPozisyon.Location = new System.Drawing.Point(83, 188);
            this.labelPozisyon.Name = "labelPozisyon";
            this.labelPozisyon.Size = new System.Drawing.Size(70, 17);
            this.labelPozisyon.TabIndex = 8;
            this.labelPozisyon.Text = "Pozisyon:";
            // 
            // textBoxPozisyon
            // 
            this.textBoxPozisyon.Location = new System.Drawing.Point(231, 182);
            this.textBoxPozisyon.Name = "textBoxPozisyon";
            this.textBoxPozisyon.Size = new System.Drawing.Size(130, 25);
            this.textBoxPozisyon.TabIndex = 9;
            this.textBoxPozisyon.TextChanged += new System.EventHandler(this.textBoxPozisyon_TextChanged);
            // 
            // dataGridViewEleman
            // 
            this.dataGridViewEleman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleman.Location = new System.Drawing.Point(496, 101);
            this.dataGridViewEleman.Name = "dataGridViewEleman";
            this.dataGridViewEleman.RowHeadersWidth = 51;
            this.dataGridViewEleman.RowTemplate.Height = 24;
            this.dataGridViewEleman.Size = new System.Drawing.Size(555, 354);
            this.dataGridViewEleman.TabIndex = 12;
            this.dataGridViewEleman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEleman_CellContentClick);
            // 
            // buttonIstenCikart
            // 
            this.buttonIstenCikart.BackColor = System.Drawing.Color.IndianRed;
            this.buttonIstenCikart.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIstenCikart.Location = new System.Drawing.Point(827, 500);
            this.buttonIstenCikart.Name = "buttonIstenCikart";
            this.buttonIstenCikart.Size = new System.Drawing.Size(75, 52);
            this.buttonIstenCikart.TabIndex = 15;
            this.buttonIstenCikart.Text = "İşten Çıkart";
            this.buttonIstenCikart.UseVisualStyleBackColor = false;
            this.buttonIstenCikart.Click += new System.EventHandler(this.buttonIstenCik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Yeni Eleman";
            // 
            // buttonIseAl
            // 
            this.buttonIseAl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIseAl.Location = new System.Drawing.Point(254, 506);
            this.buttonIseAl.Name = "buttonIseAl";
            this.buttonIseAl.Size = new System.Drawing.Size(75, 41);
            this.buttonIseAl.TabIndex = 27;
            this.buttonIseAl.Text = "İşe Al";
            this.buttonIseAl.UseVisualStyleBackColor = true;
            this.buttonIseAl.Click += new System.EventHandler(this.buttonIseAl_Click);
            // 
            // textBoxMaasBir
            // 
            this.textBoxMaasBir.Location = new System.Drawing.Point(231, 435);
            this.textBoxMaasBir.Name = "textBoxMaasBir";
            this.textBoxMaasBir.Size = new System.Drawing.Size(130, 25);
            this.textBoxMaasBir.TabIndex = 26;
            // 
            // labelPozisyonBir
            // 
            this.labelPozisyonBir.AutoSize = true;
            this.labelPozisyonBir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPozisyonBir.Location = new System.Drawing.Point(83, 484);
            this.labelPozisyonBir.Name = "labelPozisyonBir";
            this.labelPozisyonBir.Size = new System.Drawing.Size(70, 17);
            this.labelPozisyonBir.TabIndex = 24;
            this.labelPozisyonBir.Text = "Pozisyon:";
            // 
            // labelMaasBir
            // 
            this.labelMaasBir.AutoSize = true;
            this.labelMaasBir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMaasBir.Location = new System.Drawing.Point(83, 441);
            this.labelMaasBir.Name = "labelMaasBir";
            this.labelMaasBir.Size = new System.Drawing.Size(49, 17);
            this.labelMaasBir.TabIndex = 23;
            this.labelMaasBir.Text = "Maaş:";
            // 
            // textBoxAdBir
            // 
            this.textBoxAdBir.Location = new System.Drawing.Point(231, 354);
            this.textBoxAdBir.Name = "textBoxAdBir";
            this.textBoxAdBir.Size = new System.Drawing.Size(130, 25);
            this.textBoxAdBir.TabIndex = 22;
            // 
            // textBoxSoyadBir
            // 
            this.textBoxSoyadBir.Location = new System.Drawing.Point(231, 393);
            this.textBoxSoyadBir.Name = "textBoxSoyadBir";
            this.textBoxSoyadBir.Size = new System.Drawing.Size(130, 25);
            this.textBoxSoyadBir.TabIndex = 21;
            // 
            // textBoxTcBir
            // 
            this.textBoxTcBir.Location = new System.Drawing.Point(231, 313);
            this.textBoxTcBir.Name = "textBoxTcBir";
            this.textBoxTcBir.Size = new System.Drawing.Size(130, 25);
            this.textBoxTcBir.TabIndex = 20;
            this.textBoxTcBir.TextChanged += new System.EventHandler(this.textBoxTcBir_TextChanged);
            // 
            // labelTcBir
            // 
            this.labelTcBir.AutoSize = true;
            this.labelTcBir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTcBir.Location = new System.Drawing.Point(83, 316);
            this.labelTcBir.Name = "labelTcBir";
            this.labelTcBir.Size = new System.Drawing.Size(113, 17);
            this.labelTcBir.TabIndex = 19;
            this.labelTcBir.Text = "T.C. Kimlik No:";
            // 
            // labelAdBir
            // 
            this.labelAdBir.AutoSize = true;
            this.labelAdBir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdBir.Location = new System.Drawing.Point(83, 357);
            this.labelAdBir.Name = "labelAdBir";
            this.labelAdBir.Size = new System.Drawing.Size(36, 17);
            this.labelAdBir.TabIndex = 18;
            this.labelAdBir.Text = "Adı:";
            // 
            // labelSoyadBir
            // 
            this.labelSoyadBir.AutoSize = true;
            this.labelSoyadBir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadBir.Location = new System.Drawing.Point(83, 400);
            this.labelSoyadBir.Name = "labelSoyadBir";
            this.labelSoyadBir.Size = new System.Drawing.Size(55, 17);
            this.labelSoyadBir.TabIndex = 17;
            this.labelSoyadBir.Text = "Soyadı:";
            // 
            // comboBoxPozisyonlar
            // 
            this.comboBoxPozisyonlar.FormattingEnabled = true;
            this.comboBoxPozisyonlar.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "İnsan Kaynakları",
            "Muhasebe",
            "Depo",
            "Sürücü"});
            this.comboBoxPozisyonlar.Location = new System.Drawing.Point(231, 474);
            this.comboBoxPozisyonlar.Name = "comboBoxPozisyonlar";
            this.comboBoxPozisyonlar.Size = new System.Drawing.Size(130, 25);
            this.comboBoxPozisyonlar.TabIndex = 28;
            // 
            // higskargoDataSet
            // 
            this.higskargoDataSet.DataSetName = "higskargoDataSet";
            this.higskargoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // higskargoDataSetBindingSource
            // 
            this.higskargoDataSetBindingSource.DataSource = this.higskargoDataSet;
            this.higskargoDataSetBindingSource.Position = 0;
            // 
            // textBoxSil
            // 
            this.textBoxSil.Location = new System.Drawing.Point(661, 515);
            this.textBoxSil.Name = "textBoxSil";
            this.textBoxSil.Size = new System.Drawing.Size(133, 25);
            this.textBoxSil.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(606, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "TC No:";
            // 
            // InsanKaynaklarıUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSil);
            this.Controls.Add(this.comboBoxPozisyonlar);
            this.Controls.Add(this.buttonIseAl);
            this.Controls.Add(this.textBoxMaasBir);
            this.Controls.Add(this.labelPozisyonBir);
            this.Controls.Add(this.labelMaasBir);
            this.Controls.Add(this.textBoxAdBir);
            this.Controls.Add(this.textBoxSoyadBir);
            this.Controls.Add(this.textBoxTcBir);
            this.Controls.Add(this.labelTcBir);
            this.Controls.Add(this.labelAdBir);
            this.Controls.Add(this.labelSoyadBir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIstenCikart);
            this.Controls.Add(this.dataGridViewEleman);
            this.Controls.Add(this.textBoxPozisyon);
            this.Controls.Add(this.labelPozisyon);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "InsanKaynaklarıUC";
            this.Size = new System.Drawing.Size(1236, 689);
            this.Load += new System.EventHandler(this.InsanKaynaklarıUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.higskargoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.higskargoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label labelPozisyon;
        private System.Windows.Forms.TextBox textBoxPozisyon;
        private System.Windows.Forms.DataGridView dataGridViewEleman;
        private System.Windows.Forms.Button buttonIstenCikart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIseAl;
        private System.Windows.Forms.TextBox textBoxMaasBir;
        private System.Windows.Forms.Label labelPozisyonBir;
        private System.Windows.Forms.Label labelMaasBir;
        private System.Windows.Forms.TextBox textBoxAdBir;
        private System.Windows.Forms.TextBox textBoxSoyadBir;
        private System.Windows.Forms.TextBox textBoxTcBir;
        private System.Windows.Forms.Label labelTcBir;
        private System.Windows.Forms.Label labelAdBir;
        private System.Windows.Forms.Label labelSoyadBir;
        private System.Windows.Forms.ComboBox comboBoxPozisyonlar;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.BindingSource higskargoDataSetBindingSource;
        private higskargoDataSet higskargoDataSet;
        private System.Windows.Forms.TextBox textBoxSil;
        private System.Windows.Forms.Label label3;
    }
}
