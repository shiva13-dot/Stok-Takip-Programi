namespace ProductStock
{
    partial class formUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUnit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UNITTXTB = new System.Windows.Forms.TextBox();
            this.UNITDGW = new System.Windows.Forms.DataGridView();
            this.DELETEBTTN = new System.Windows.Forms.Button();
            this.UPDATEBTTN = new System.Windows.Forms.Button();
            this.ADDBTTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UNITDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UNITTXTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 78);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birim Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birim Adı";
            // 
            // UNITTXTB
            // 
            this.UNITTXTB.Location = new System.Drawing.Point(167, 32);
            this.UNITTXTB.Name = "UNITTXTB";
            this.UNITTXTB.Size = new System.Drawing.Size(150, 20);
            this.UNITTXTB.TabIndex = 1;
            // 
            // UNITDGW
            // 
            this.UNITDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UNITDGW.Location = new System.Drawing.Point(12, 167);
            this.UNITDGW.Name = "UNITDGW";
            this.UNITDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UNITDGW.Size = new System.Drawing.Size(421, 271);
            this.UNITDGW.TabIndex = 21;
            this.UNITDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UNITDGW_CellClick);
            // 
            // DELETEBTTN
            // 
            this.DELETEBTTN.Image = ((System.Drawing.Image)(resources.GetObject("DELETEBTTN.Image")));
            this.DELETEBTTN.Location = new System.Drawing.Point(189, 96);
            this.DELETEBTTN.Name = "DELETEBTTN";
            this.DELETEBTTN.Size = new System.Drawing.Size(73, 65);
            this.DELETEBTTN.TabIndex = 25;
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
            this.UPDATEBTTN.TabIndex = 24;
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
            this.ADDBTTN.TabIndex = 23;
            this.ADDBTTN.UseVisualStyleBackColor = true;
            this.ADDBTTN.Click += new System.EventHandler(this.ADDBTTN_Click);
            // 
            // formUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.DELETEBTTN);
            this.Controls.Add(this.UPDATEBTTN);
            this.Controls.Add(this.ADDBTTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UNITDGW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formUnit";
            this.Text = "Birim Ekle";
            this.Load += new System.EventHandler(this.formUnit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UNITDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UNITTXTB;
        private System.Windows.Forms.DataGridView UNITDGW;
        private System.Windows.Forms.Button DELETEBTTN;
        private System.Windows.Forms.Button UPDATEBTTN;
        private System.Windows.Forms.Button ADDBTTN;
    }
}