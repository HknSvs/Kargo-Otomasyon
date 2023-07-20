namespace HİGS_KARGO
{
    partial class SürücüUC
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
            this.labelSurucuAdi = new System.Windows.Forms.Label();
            this.dataGridViewAdresler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTeslimEdildi = new System.Windows.Forms.Button();
            this.buttonTeslimEdilemedi = new System.Windows.Forms.Button();
            this.textBoxTeslimEdilemedi = new System.Windows.Forms.TextBox();
            this.textBoxTeslimEdildi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdresler)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSurucuAdi
            // 
            this.labelSurucuAdi.AutoSize = true;
            this.labelSurucuAdi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSurucuAdi.Location = new System.Drawing.Point(327, 115);
            this.labelSurucuAdi.Name = "labelSurucuAdi";
            this.labelSurucuAdi.Size = new System.Drawing.Size(0, 16);
            this.labelSurucuAdi.TabIndex = 7;
            // 
            // dataGridViewAdresler
            // 
            this.dataGridViewAdresler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdresler.Location = new System.Drawing.Point(357, 156);
            this.dataGridViewAdresler.Name = "dataGridViewAdresler";
            this.dataGridViewAdresler.RowHeadersWidth = 51;
            this.dataGridViewAdresler.RowTemplate.Height = 24;
            this.dataGridViewAdresler.Size = new System.Drawing.Size(527, 326);
            this.dataGridViewAdresler.TabIndex = 9;
            this.dataGridViewAdresler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(522, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gidilecek Adresler";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonTeslimEdildi
            // 
            this.buttonTeslimEdildi.BackColor = System.Drawing.Color.Lime;
            this.buttonTeslimEdildi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTeslimEdildi.Location = new System.Drawing.Point(945, 308);
            this.buttonTeslimEdildi.Name = "buttonTeslimEdildi";
            this.buttonTeslimEdildi.Size = new System.Drawing.Size(148, 83);
            this.buttonTeslimEdildi.TabIndex = 11;
            this.buttonTeslimEdildi.Text = "Teslim Edildi";
            this.buttonTeslimEdildi.UseVisualStyleBackColor = false;
            this.buttonTeslimEdildi.Click += new System.EventHandler(this.buttonTeslimEdildi_Click);
            // 
            // buttonTeslimEdilemedi
            // 
            this.buttonTeslimEdilemedi.BackColor = System.Drawing.Color.Red;
            this.buttonTeslimEdilemedi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTeslimEdilemedi.Location = new System.Drawing.Point(159, 308);
            this.buttonTeslimEdilemedi.Name = "buttonTeslimEdilemedi";
            this.buttonTeslimEdilemedi.Size = new System.Drawing.Size(148, 83);
            this.buttonTeslimEdilemedi.TabIndex = 12;
            this.buttonTeslimEdilemedi.Text = "Teslim Edilemedi";
            this.buttonTeslimEdilemedi.UseVisualStyleBackColor = false;
            this.buttonTeslimEdilemedi.Click += new System.EventHandler(this.buttonTeslimEdilemedi_Click);
            // 
            // textBoxTeslimEdilemedi
            // 
            this.textBoxTeslimEdilemedi.Location = new System.Drawing.Point(159, 240);
            this.textBoxTeslimEdilemedi.Name = "textBoxTeslimEdilemedi";
            this.textBoxTeslimEdilemedi.Size = new System.Drawing.Size(148, 22);
            this.textBoxTeslimEdilemedi.TabIndex = 13;
            this.textBoxTeslimEdilemedi.TextChanged += new System.EventHandler(this.textBoxTeslimEdilemedi_TextChanged);
            // 
            // textBoxTeslimEdildi
            // 
            this.textBoxTeslimEdildi.Location = new System.Drawing.Point(945, 240);
            this.textBoxTeslimEdildi.Name = "textBoxTeslimEdildi";
            this.textBoxTeslimEdildi.Size = new System.Drawing.Size(148, 22);
            this.textBoxTeslimEdildi.TabIndex = 14;
            this.textBoxTeslimEdildi.TextChanged += new System.EventHandler(this.textBoxTeslimEdildi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(941, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Teslim Edilen\r\nKargo Takip No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Teslim Edilemeyen\r\n Kargo Takip No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SürücüUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTeslimEdildi);
            this.Controls.Add(this.textBoxTeslimEdilemedi);
            this.Controls.Add(this.buttonTeslimEdilemedi);
            this.Controls.Add(this.buttonTeslimEdildi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewAdresler);
            this.Controls.Add(this.labelSurucuAdi);
            this.Name = "SürücüUC";
            this.Size = new System.Drawing.Size(1346, 696);
            this.Load += new System.EventHandler(this.SürücüUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdresler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSurucuAdi;
        private System.Windows.Forms.DataGridView dataGridViewAdresler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTeslimEdildi;
        private System.Windows.Forms.Button buttonTeslimEdilemedi;
        private System.Windows.Forms.TextBox textBoxTeslimEdilemedi;
        private System.Windows.Forms.TextBox textBoxTeslimEdildi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
