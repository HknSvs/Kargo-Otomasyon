namespace HİGS_KARGO
{
    partial class MuhasebeUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGunlukGelir = new System.Windows.Forms.TextBox();
            this.textBoxGunlukGider = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDolarKur = new System.Windows.Forms.TextBox();
            this.textBoxEuroKur = new System.Windows.Forms.TextBox();
            this.textBoxSterlinKur = new System.Windows.Forms.TextBox();
            this.textBoxCHFKur = new System.Windows.Forms.TextBox();
            this.textBoxGunlukKarZarar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxKargoAdet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewArac = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxAracSorgula = new System.Windows.Forms.TextBox();
            this.buttonAracSat = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxAylıkYakıtGider = new System.Windows.Forms.TextBox();
            this.textBoxAylıkMaasGider = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxAracSayi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPlakaBir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewTeslim = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArac)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeslim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kar/ Zarar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gelir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gider";
            // 
            // textBoxGunlukGelir
            // 
            this.textBoxGunlukGelir.Location = new System.Drawing.Point(219, 113);
            this.textBoxGunlukGelir.Name = "textBoxGunlukGelir";
            this.textBoxGunlukGelir.Size = new System.Drawing.Size(112, 25);
            this.textBoxGunlukGelir.TabIndex = 3;
            this.textBoxGunlukGelir.TextChanged += new System.EventHandler(this.textBoxGunlukGelir_TextChanged);
            // 
            // textBoxGunlukGider
            // 
            this.textBoxGunlukGider.Location = new System.Drawing.Point(219, 153);
            this.textBoxGunlukGider.Name = "textBoxGunlukGider";
            this.textBoxGunlukGider.Size = new System.Drawing.Size(112, 25);
            this.textBoxGunlukGider.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(78, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kurlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "İsviçre Frangı/ CHF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sterlin/ GBP £";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Euro/ EU €";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dolar/USD $";
            // 
            // textBoxDolarKur
            // 
            this.textBoxDolarKur.Location = new System.Drawing.Point(243, 306);
            this.textBoxDolarKur.Name = "textBoxDolarKur";
            this.textBoxDolarKur.Size = new System.Drawing.Size(88, 25);
            this.textBoxDolarKur.TabIndex = 10;
            // 
            // textBoxEuroKur
            // 
            this.textBoxEuroKur.Location = new System.Drawing.Point(243, 366);
            this.textBoxEuroKur.Name = "textBoxEuroKur";
            this.textBoxEuroKur.Size = new System.Drawing.Size(88, 25);
            this.textBoxEuroKur.TabIndex = 11;
            // 
            // textBoxSterlinKur
            // 
            this.textBoxSterlinKur.Location = new System.Drawing.Point(243, 426);
            this.textBoxSterlinKur.Name = "textBoxSterlinKur";
            this.textBoxSterlinKur.Size = new System.Drawing.Size(88, 25);
            this.textBoxSterlinKur.TabIndex = 12;
            // 
            // textBoxCHFKur
            // 
            this.textBoxCHFKur.Location = new System.Drawing.Point(243, 491);
            this.textBoxCHFKur.Name = "textBoxCHFKur";
            this.textBoxCHFKur.Size = new System.Drawing.Size(88, 25);
            this.textBoxCHFKur.TabIndex = 13;
            // 
            // textBoxGunlukKarZarar
            // 
            this.textBoxGunlukKarZarar.Location = new System.Drawing.Point(219, 197);
            this.textBoxGunlukKarZarar.Name = "textBoxGunlukKarZarar";
            this.textBoxGunlukKarZarar.Size = new System.Drawing.Size(112, 25);
            this.textBoxGunlukKarZarar.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(78, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kar/ Zarar";
            // 
            // textBoxKargoAdet
            // 
            this.textBoxKargoAdet.Location = new System.Drawing.Point(903, 146);
            this.textBoxKargoAdet.Name = "textBoxKargoAdet";
            this.textBoxKargoAdet.Size = new System.Drawing.Size(112, 25);
            this.textBoxKargoAdet.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(670, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Depo/ Filo Durumu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(699, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Depo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(703, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Filo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(730, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Kargo Adedi";
            // 
            // dataGridViewArac
            // 
            this.dataGridViewArac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArac.Location = new System.Drawing.Point(733, 434);
            this.dataGridViewArac.Name = "dataGridViewArac";
            this.dataGridViewArac.RowHeadersWidth = 51;
            this.dataGridViewArac.RowTemplate.Height = 24;
            this.dataGridViewArac.Size = new System.Drawing.Size(292, 118);
            this.dataGridViewArac.TabIndex = 35;
            this.dataGridViewArac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(740, 407);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 17);
            this.label20.TabIndex = 36;
            this.label20.Text = "Araç Sorgula";
            // 
            // textBoxAracSorgula
            // 
            this.textBoxAracSorgula.Location = new System.Drawing.Point(903, 399);
            this.textBoxAracSorgula.Name = "textBoxAracSorgula";
            this.textBoxAracSorgula.Size = new System.Drawing.Size(122, 25);
            this.textBoxAracSorgula.TabIndex = 37;
            this.textBoxAracSorgula.Text = "örn. 34 ABC 123";
            this.textBoxAracSorgula.TextChanged += new System.EventHandler(this.textBoxAracSorgula_TextChanged);
            // 
            // buttonAracSat
            // 
            this.buttonAracSat.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAracSat.Location = new System.Drawing.Point(1031, 482);
            this.buttonAracSat.Name = "buttonAracSat";
            this.buttonAracSat.Size = new System.Drawing.Size(84, 70);
            this.buttonAracSat.TabIndex = 39;
            this.buttonAracSat.Text = "Araç Sat";
            this.buttonAracSat.UseVisualStyleBackColor = false;
            this.buttonAracSat.Click += new System.EventHandler(this.buttonAracSat_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(384, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 20);
            this.label21.TabIndex = 41;
            this.label21.Text = "Giderler";
            // 
            // textBoxAylıkYakıtGider
            // 
            this.textBoxAylıkYakıtGider.Location = new System.Drawing.Point(524, 189);
            this.textBoxAylıkYakıtGider.Name = "textBoxAylıkYakıtGider";
            this.textBoxAylıkYakıtGider.Size = new System.Drawing.Size(85, 25);
            this.textBoxAylıkYakıtGider.TabIndex = 47;
            // 
            // textBoxAylıkMaasGider
            // 
            this.textBoxAylıkMaasGider.Location = new System.Drawing.Point(524, 132);
            this.textBoxAylıkMaasGider.Name = "textBoxAylıkMaasGider";
            this.textBoxAylıkMaasGider.Size = new System.Drawing.Size(85, 25);
            this.textBoxAylıkMaasGider.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(385, 132);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 17);
            this.label22.TabIndex = 45;
            this.label22.Text = "Maaş Gideri";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(385, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 17);
            this.label23.TabIndex = 44;
            this.label23.Text = "Yakıt Gideri";
            // 
            // textBoxAracSayi
            // 
            this.textBoxAracSayi.Location = new System.Drawing.Point(903, 310);
            this.textBoxAracSayi.Name = "textBoxAracSayi";
            this.textBoxAracSayi.Size = new System.Drawing.Size(57, 25);
            this.textBoxAracSayi.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(730, 317);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Araç Sayısı";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.Location = new System.Drawing.Point(990, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 37);
            this.button3.TabIndex = 50;
            this.button3.Text = "Araç Al";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBoxPlakaBir);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(813, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 193);
            this.panel1.TabIndex = 51;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tamam";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 34);
            this.label15.TabIndex = 2;
            this.label15.Text = "Alınan Arabanın \r\nPlakasını Girin:\r\n";
            // 
            // textBoxPlakaBir
            // 
            this.textBoxPlakaBir.Location = new System.Drawing.Point(22, 107);
            this.textBoxPlakaBir.Name = "textBoxPlakaBir";
            this.textBoxPlakaBir.Size = new System.Drawing.Size(100, 25);
            this.textBoxPlakaBir.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Araç Satın Al";
            // 
            // dataGridViewTeslim
            // 
            this.dataGridViewTeslim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeslim.Location = new System.Drawing.Point(388, 306);
            this.dataGridViewTeslim.Name = "dataGridViewTeslim";
            this.dataGridViewTeslim.RowHeadersWidth = 51;
            this.dataGridViewTeslim.RowTemplate.Height = 24;
            this.dataGridViewTeslim.Size = new System.Drawing.Size(234, 246);
            this.dataGridViewTeslim.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(385, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 17);
            this.label16.TabIndex = 53;
            this.label16.Text = "Teslim Edilen Kargolar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HİGS_KARGO.Properties.Resources.png_transparent_computer_icons_synchronization_encapsulated_postscript_icon_design_update_button_angle_text_logo;
            this.pictureBox1.Location = new System.Drawing.Point(628, 523);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MuhasebeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridViewTeslim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxAylıkYakıtGider);
            this.Controls.Add(this.textBoxAylıkMaasGider);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonAracSat);
            this.Controls.Add(this.textBoxAracSorgula);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridViewArac);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxAracSayi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxKargoAdet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxGunlukKarZarar);
            this.Controls.Add(this.textBoxCHFKur);
            this.Controls.Add(this.textBoxSterlinKur);
            this.Controls.Add(this.textBoxEuroKur);
            this.Controls.Add(this.textBoxDolarKur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGunlukGider);
            this.Controls.Add(this.textBoxGunlukGelir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MuhasebeUC";
            this.Size = new System.Drawing.Size(1132, 703);
            this.Load += new System.EventHandler(this.MuhasebeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArac)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeslim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGunlukGelir;
        private System.Windows.Forms.TextBox textBoxGunlukGider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDolarKur;
        private System.Windows.Forms.TextBox textBoxEuroKur;
        private System.Windows.Forms.TextBox textBoxSterlinKur;
        private System.Windows.Forms.TextBox textBoxCHFKur;
        private System.Windows.Forms.TextBox textBoxGunlukKarZarar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxKargoAdet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewArac;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxAracSorgula;
        private System.Windows.Forms.Button buttonAracSat;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxAylıkYakıtGider;
        private System.Windows.Forms.TextBox textBoxAylıkMaasGider;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxAracSayi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxPlakaBir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewTeslim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
