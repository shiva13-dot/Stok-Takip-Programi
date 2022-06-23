namespace ProductStock
{
    partial class formCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCategory));
            this.label1 = new System.Windows.Forms.Label();
            this.CTGRYTXTB = new System.Windows.Forms.TextBox();
            this.CTGRYDGW = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DELETEBTTN = new System.Windows.Forms.Button();
            this.UPDATEBTTN = new System.Windows.Forms.Button();
            this.ADDBTTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CTGRYDGW)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // CTGRYTXTB
            // 
            this.CTGRYTXTB.Location = new System.Drawing.Point(177, 33);
            this.CTGRYTXTB.Name = "CTGRYTXTB";
            this.CTGRYTXTB.Size = new System.Drawing.Size(150, 20);
            this.CTGRYTXTB.TabIndex = 1;
            // 
            // CTGRYDGW
            // 
            this.CTGRYDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTGRYDGW.Location = new System.Drawing.Point(12, 167);
            this.CTGRYDGW.Name = "CTGRYDGW";
            this.CTGRYDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CTGRYDGW.Size = new System.Drawing.Size(421, 271);
            this.CTGRYDGW.TabIndex = 5;
            this.CTGRYDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CTGRYDGW_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CTGRYTXTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // DELETEBTTN
            // 
            this.DELETEBTTN.Image = ((System.Drawing.Image)(resources.GetObject("DELETEBTTN.Image")));
            this.DELETEBTTN.Location = new System.Drawing.Point(189, 96);
            this.DELETEBTTN.Name = "DELETEBTTN";
            this.DELETEBTTN.Size = new System.Drawing.Size(73, 65);
            this.DELETEBTTN.TabIndex = 20;
            this.DELETEBTTN.UseVisualStyleBackColor = true;
            this.DELETEBTTN.Click += new System.EventHandler(this.DELETEBTTN_Click);
            // 
            // UPDATEBTTN
            // 
            this.UPDATEBTTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UPDATEBTTN.Image = ((System.Drawing.Image)(resources.GetObject("UPDATEBTTN.Image")));
            this.UPDATEBTTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPDATEBTTN.Location = new System.Drawing.Point(362, 96);
            this.UPDATEBTTN.Name = "UPDATEBTTN";
            this.UPDATEBTTN.Size = new System.Drawing.Size(71, 65);
            this.UPDATEBTTN.TabIndex = 19;
            this.UPDATEBTTN.UseVisualStyleBackColor = true;
            this.UPDATEBTTN.Click += new System.EventHandler(this.UPDATEBTTN_Click);
            // 
            // ADDBTTN
            // 
            this.ADDBTTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ADDBTTN.Image = ((System.Drawing.Image)(resources.GetObject("ADDBTTN.Image")));
            this.ADDBTTN.Location = new System.Drawing.Point(12, 96);
            this.ADDBTTN.Name = "ADDBTTN";
            this.ADDBTTN.Size = new System.Drawing.Size(73, 65);
            this.ADDBTTN.TabIndex = 18;
            this.ADDBTTN.UseVisualStyleBackColor = true;
            this.ADDBTTN.Click += new System.EventHandler(this.ADDBTTN_Click);
            // 
            // formCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.DELETEBTTN);
            this.Controls.Add(this.UPDATEBTTN);
            this.Controls.Add(this.ADDBTTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CTGRYDGW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCategory";
            this.Text = "Kategori Ekle";
            this.Load += new System.EventHandler(this.formCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTGRYDGW)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CTGRYTXTB;
        private System.Windows.Forms.DataGridView CTGRYDGW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DELETEBTTN;
        private System.Windows.Forms.Button UPDATEBTTN;
        private System.Windows.Forms.Button ADDBTTN;
    }
}