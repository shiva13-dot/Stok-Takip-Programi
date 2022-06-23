namespace ProductStock
{
    partial class formProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProduct));
            this.BARCODETXTB = new System.Windows.Forms.TextBox();
            this.NAMETXTB = new System.Windows.Forms.TextBox();
            this.PRCHSPRCTXTB = new System.Windows.Forms.TextBox();
            this.SALEPRCTXTB = new System.Windows.Forms.TextBox();
            this.AMOUNTTXTB = new System.Windows.Forms.TextBox();
            this.UNITCMBBX = new System.Windows.Forms.ComboBox();
            this.CTGRYCMBBX = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DELETEBTTN = new System.Windows.Forms.Button();
            this.UPDATEBTTN = new System.Windows.Forms.Button();
            this.ADDBTTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PRODUCTSDGW = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UNITBTTN = new System.Windows.Forms.Button();
            this.CATEGORYBTTN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SEARCHBARCODETXTB = new System.Windows.Forms.TextBox();
            this.SEARCHNAMETXTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTSDGW)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BARCODETXTB
            // 
            this.BARCODETXTB.Location = new System.Drawing.Point(110, 29);
            this.BARCODETXTB.Name = "BARCODETXTB";
            this.BARCODETXTB.Size = new System.Drawing.Size(150, 20);
            this.BARCODETXTB.TabIndex = 1;
            // 
            // NAMETXTB
            // 
            this.NAMETXTB.Location = new System.Drawing.Point(110, 59);
            this.NAMETXTB.Name = "NAMETXTB";
            this.NAMETXTB.Size = new System.Drawing.Size(150, 20);
            this.NAMETXTB.TabIndex = 2;
            // 
            // PRCHSPRCTXTB
            // 
            this.PRCHSPRCTXTB.Location = new System.Drawing.Point(110, 120);
            this.PRCHSPRCTXTB.Name = "PRCHSPRCTXTB";
            this.PRCHSPRCTXTB.Size = new System.Drawing.Size(150, 20);
            this.PRCHSPRCTXTB.TabIndex = 3;
            // 
            // SALEPRCTXTB
            // 
            this.SALEPRCTXTB.Location = new System.Drawing.Point(110, 153);
            this.SALEPRCTXTB.Name = "SALEPRCTXTB";
            this.SALEPRCTXTB.Size = new System.Drawing.Size(150, 20);
            this.SALEPRCTXTB.TabIndex = 4;
            // 
            // AMOUNTTXTB
            // 
            this.AMOUNTTXTB.Location = new System.Drawing.Point(366, 59);
            this.AMOUNTTXTB.Name = "AMOUNTTXTB";
            this.AMOUNTTXTB.Size = new System.Drawing.Size(150, 20);
            this.AMOUNTTXTB.TabIndex = 5;
            // 
            // UNITCMBBX
            // 
            this.UNITCMBBX.FormattingEnabled = true;
            this.UNITCMBBX.Location = new System.Drawing.Point(366, 29);
            this.UNITCMBBX.Name = "UNITCMBBX";
            this.UNITCMBBX.Size = new System.Drawing.Size(150, 21);
            this.UNITCMBBX.TabIndex = 6;
            // 
            // CTGRYCMBBX
            // 
            this.CTGRYCMBBX.FormattingEnabled = true;
            this.CTGRYCMBBX.Location = new System.Drawing.Point(110, 90);
            this.CTGRYCMBBX.Name = "CTGRYCMBBX";
            this.CTGRYCMBBX.Size = new System.Drawing.Size(150, 21);
            this.CTGRYCMBBX.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DELETEBTTN);
            this.groupBox1.Controls.Add(this.UPDATEBTTN);
            this.groupBox1.Controls.Add(this.ADDBTTN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BARCODETXTB);
            this.groupBox1.Controls.Add(this.NAMETXTB);
            this.groupBox1.Controls.Add(this.CTGRYCMBBX);
            this.groupBox1.Controls.Add(this.PRCHSPRCTXTB);
            this.groupBox1.Controls.Add(this.UNITCMBBX);
            this.groupBox1.Controls.Add(this.SALEPRCTXTB);
            this.groupBox1.Controls.Add(this.AMOUNTTXTB);
            this.groupBox1.Location = new System.Drawing.Point(146, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 196);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // DELETEBTTN
            // 
            this.DELETEBTTN.Image = ((System.Drawing.Image)(resources.GetObject("DELETEBTTN.Image")));
            this.DELETEBTTN.Location = new System.Drawing.Point(360, 108);
            this.DELETEBTTN.Name = "DELETEBTTN";
            this.DELETEBTTN.Size = new System.Drawing.Size(73, 65);
            this.DELETEBTTN.TabIndex = 17;
            this.DELETEBTTN.UseVisualStyleBackColor = true;
            this.DELETEBTTN.Click += new System.EventHandler(this.DELETEBTTN_Click);
            // 
            // UPDATEBTTN
            // 
            this.UPDATEBTTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UPDATEBTTN.Image = ((System.Drawing.Image)(resources.GetObject("UPDATEBTTN.Image")));
            this.UPDATEBTTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPDATEBTTN.Location = new System.Drawing.Point(443, 108);
            this.UPDATEBTTN.Name = "UPDATEBTTN";
            this.UPDATEBTTN.Size = new System.Drawing.Size(71, 65);
            this.UPDATEBTTN.TabIndex = 16;
            this.UPDATEBTTN.UseVisualStyleBackColor = true;
            this.UPDATEBTTN.Click += new System.EventHandler(this.UPDATEBTTN_Click);
            // 
            // ADDBTTN
            // 
            this.ADDBTTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ADDBTTN.Image = ((System.Drawing.Image)(resources.GetObject("ADDBTTN.Image")));
            this.ADDBTTN.Location = new System.Drawing.Point(281, 108);
            this.ADDBTTN.Name = "ADDBTTN";
            this.ADDBTTN.Size = new System.Drawing.Size(73, 65);
            this.ADDBTTN.TabIndex = 15;
            this.ADDBTTN.UseVisualStyleBackColor = true;
            this.ADDBTTN.Click += new System.EventHandler(this.ADDBTTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ürünün Birimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürünün Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürünün Satış Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ürünün Alış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürünün Kategorisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ürünün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürünün Barkodu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PRODUCTSDGW);
            this.groupBox2.Location = new System.Drawing.Point(146, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 316);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // PRODUCTSDGW
            // 
            this.PRODUCTSDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PRODUCTSDGW.Location = new System.Drawing.Point(16, 25);
            this.PRODUCTSDGW.Name = "PRODUCTSDGW";
            this.PRODUCTSDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PRODUCTSDGW.Size = new System.Drawing.Size(800, 278);
            this.PRODUCTSDGW.TabIndex = 0;
            this.PRODUCTSDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PRODUCTSDGW_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.UNITBTTN);
            this.panel1.Controls.Add(this.CATEGORYBTTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 552);
            this.panel1.TabIndex = 10;
            // 
            // UNITBTTN
            // 
            this.UNITBTTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UNITBTTN.Image = ((System.Drawing.Image)(resources.GetObject("UNITBTTN.Image")));
            this.UNITBTTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UNITBTTN.Location = new System.Drawing.Point(3, 68);
            this.UNITBTTN.Name = "UNITBTTN";
            this.UNITBTTN.Size = new System.Drawing.Size(134, 50);
            this.UNITBTTN.TabIndex = 17;
            this.UNITBTTN.Text = "Birim Ekle";
            this.UNITBTTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UNITBTTN.UseVisualStyleBackColor = true;
            this.UNITBTTN.Click += new System.EventHandler(this.UNITBTTN_Click);
            // 
            // CATEGORYBTTN
            // 
            this.CATEGORYBTTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CATEGORYBTTN.Image = ((System.Drawing.Image)(resources.GetObject("CATEGORYBTTN.Image")));
            this.CATEGORYBTTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CATEGORYBTTN.Location = new System.Drawing.Point(3, 12);
            this.CATEGORYBTTN.Name = "CATEGORYBTTN";
            this.CATEGORYBTTN.Size = new System.Drawing.Size(134, 50);
            this.CATEGORYBTTN.TabIndex = 16;
            this.CATEGORYBTTN.Text = "Kategori Ekle";
            this.CATEGORYBTTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CATEGORYBTTN.UseVisualStyleBackColor = true;
            this.CATEGORYBTTN.Click += new System.EventHandler(this.CATEGORYBTTN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.SEARCHBARCODETXTB);
            this.groupBox3.Controls.Add(this.SEARCHNAMETXTB);
            this.groupBox3.Location = new System.Drawing.Point(685, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 196);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Arama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ürünün Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ürünün Barkodu";
            // 
            // SEARCHBARCODETXTB
            // 
            this.SEARCHBARCODETXTB.Location = new System.Drawing.Point(123, 29);
            this.SEARCHBARCODETXTB.Name = "SEARCHBARCODETXTB";
            this.SEARCHBARCODETXTB.Size = new System.Drawing.Size(150, 20);
            this.SEARCHBARCODETXTB.TabIndex = 10;
            this.SEARCHBARCODETXTB.TextChanged += new System.EventHandler(this.SEARCHBARCODETXTB_TextChanged);
            // 
            // SEARCHNAMETXTB
            // 
            this.SEARCHNAMETXTB.Location = new System.Drawing.Point(123, 59);
            this.SEARCHNAMETXTB.Name = "SEARCHNAMETXTB";
            this.SEARCHNAMETXTB.Size = new System.Drawing.Size(150, 20);
            this.SEARCHNAMETXTB.TabIndex = 11;
            this.SEARCHNAMETXTB.TextChanged += new System.EventHandler(this.SEARCHNAMETXTB_TextChanged);
            // 
            // formProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(984, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formProduct";
            this.Text = "Stok Takip Programı";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTSDGW)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox BARCODETXTB;
        private System.Windows.Forms.TextBox NAMETXTB;
        private System.Windows.Forms.TextBox PRCHSPRCTXTB;
        private System.Windows.Forms.TextBox SALEPRCTXTB;
        private System.Windows.Forms.TextBox AMOUNTTXTB;
        private System.Windows.Forms.ComboBox UNITCMBBX;
        private System.Windows.Forms.ComboBox CTGRYCMBBX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DELETEBTTN;
        private System.Windows.Forms.Button UPDATEBTTN;
        private System.Windows.Forms.Button ADDBTTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PRODUCTSDGW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CATEGORYBTTN;
        private System.Windows.Forms.Button UNITBTTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SEARCHBARCODETXTB;
        private System.Windows.Forms.TextBox SEARCHNAMETXTB;
    }
}

