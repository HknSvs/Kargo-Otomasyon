namespace HİGS_KARGO
{
    partial class DepoUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHazırKargo = new System.Windows.Forms.DataGridView();
            this.buttonYukle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewYukluKargo = new System.Windows.Forms.DataGridView();
            this.textBoxYukle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOnay = new System.Windows.Forms.TextBox();
            this.buttonOnay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHazırKargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYukluKargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(187, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlemdeki\r\nKargolar";
            // 
            // dataGridViewHazırKargo
            // 
            this.dataGridViewHazırKargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHazırKargo.Location = new System.Drawing.Point(283, 31);
            this.dataGridViewHazırKargo.Name = "dataGridViewHazırKargo";
            this.dataGridViewHazırKargo.RowHeadersWidth = 51;
            this.dataGridViewHazırKargo.RowTemplate.Height = 24;
            this.dataGridViewHazırKargo.Size = new System.Drawing.Size(893, 161);
            this.dataGridViewHazırKargo.TabIndex = 3;
            this.dataGridViewHazırKargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHazırKargo_CellContentClick);
            // 
            // buttonYukle
            // 
            this.buttonYukle.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonYukle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYukle.Location = new System.Drawing.Point(1183, 387);
            this.buttonYukle.Name = "buttonYukle";
            this.buttonYukle.Size = new System.Drawing.Size(106, 37);
            this.buttonYukle.TabIndex = 4;
            this.buttonYukle.Text = "Araca Yükle";
            this.buttonYukle.UseVisualStyleBackColor = false;
            this.buttonYukle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(187, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Araçtaki\r\nKargolar";
            // 
            // dataGridViewYukluKargo
            // 
            this.dataGridViewYukluKargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYukluKargo.Location = new System.Drawing.Point(283, 488);
            this.dataGridViewYukluKargo.Name = "dataGridViewYukluKargo";
            this.dataGridViewYukluKargo.RowHeadersWidth = 51;
            this.dataGridViewYukluKargo.RowTemplate.Height = 24;
            this.dataGridViewYukluKargo.Size = new System.Drawing.Size(893, 161);
            this.dataGridViewYukluKargo.TabIndex = 11;
            this.dataGridViewYukluKargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYukluKargo_CellContentClick);
            // 
            // textBoxYukle
            // 
            this.textBoxYukle.Location = new System.Drawing.Point(1183, 359);
            this.textBoxYukle.Name = "textBoxYukle";
            this.textBoxYukle.Size = new System.Drawing.Size(105, 22);
            this.textBoxYukle.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 161);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(185, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Depodaki\r\nKargolar";
            // 
            // textBoxOnay
            // 
            this.textBoxOnay.Location = new System.Drawing.Point(1182, 130);
            this.textBoxOnay.Name = "textBoxOnay";
            this.textBoxOnay.Size = new System.Drawing.Size(105, 22);
            this.textBoxOnay.TabIndex = 23;
            // 
            // buttonOnay
            // 
            this.buttonOnay.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonOnay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOnay.Location = new System.Drawing.Point(1182, 158);
            this.buttonOnay.Name = "buttonOnay";
            this.buttonOnay.Size = new System.Drawing.Size(106, 37);
            this.buttonOnay.TabIndex = 22;
            this.buttonOnay.Text = "Onayla";
            this.buttonOnay.UseVisualStyleBackColor = false;
            this.buttonOnay.Click += new System.EventHandler(this.buttonOnay_Click);
            // 
            // DepoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.textBoxOnay);
            this.Controls.Add(this.buttonOnay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYukle);
            this.Controls.Add(this.dataGridViewYukluKargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonYukle);
            this.Controls.Add(this.dataGridViewHazırKargo);
            this.Controls.Add(this.label2);
            this.Name = "DepoUC";
            this.Size = new System.Drawing.Size(1598, 696);
            this.Load += new System.EventHandler(this.DepoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHazırKargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYukluKargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewHazırKargo;
        private System.Windows.Forms.Button buttonYukle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewYukluKargo;
        private System.Windows.Forms.TextBox textBoxYukle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOnay;
        private System.Windows.Forms.Button buttonOnay;
    }
}
