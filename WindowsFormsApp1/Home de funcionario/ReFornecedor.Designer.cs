namespace WindowsFormsApp1
{
    partial class ReVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReVendas));
            this.btnHBRFFun = new System.Windows.Forms.Button();
            this.lblRFFunT = new System.Windows.Forms.Label();
            this.pcxRFFunG1 = new System.Windows.Forms.PictureBox();
            this.pbxRFFunW1 = new System.Windows.Forms.PictureBox();
            this.lblRVFunP = new System.Windows.Forms.Label();
            this.cbxRVFunP = new System.Windows.Forms.ComboBox();
            this.lblRVFunQV = new System.Windows.Forms.Label();
            this.txtRVFunQV = new System.Windows.Forms.TextBox();
            this.lblRVFunV = new System.Windows.Forms.Label();
            this.txtRVFunV = new System.Windows.Forms.TextBox();
            this.lblRVFunD = new System.Windows.Forms.Label();
            this.mskRPFunD = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcxRFFunG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRFFunW1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHBRFFun
            // 
            this.btnHBRFFun.FlatAppearance.BorderSize = 0;
            this.btnHBRFFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHBRFFun.Image = ((System.Drawing.Image)(resources.GetObject("btnHBRFFun.Image")));
            this.btnHBRFFun.Location = new System.Drawing.Point(12, 12);
            this.btnHBRFFun.Name = "btnHBRFFun";
            this.btnHBRFFun.Size = new System.Drawing.Size(50, 50);
            this.btnHBRFFun.TabIndex = 3;
            this.btnHBRFFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHBRFFun.UseVisualStyleBackColor = true;
            this.btnHBRFFun.Click += new System.EventHandler(this.btnHBRPFun_Click);
            // 
            // lblRFFunT
            // 
            this.lblRFFunT.AutoSize = true;
            this.lblRFFunT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic);
            this.lblRFFunT.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRFFunT.Location = new System.Drawing.Point(16, 65);
            this.lblRFFunT.Name = "lblRFFunT";
            this.lblRFFunT.Size = new System.Drawing.Size(218, 117);
            this.lblRFFunT.TabIndex = 4;
            this.lblRFFunT.Text = "Relatórios\r\nde vendas\r\n(Fornecedor)\r\n";
            // 
            // pcxRFFunG1
            // 
            this.pcxRFFunG1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcxRFFunG1.BackColor = System.Drawing.Color.ForestGreen;
            this.pcxRFFunG1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcxRFFunG1.Location = new System.Drawing.Point(17, 189);
            this.pcxRFFunG1.Name = "pcxRFFunG1";
            this.pcxRFFunG1.Size = new System.Drawing.Size(408, 223);
            this.pcxRFFunG1.TabIndex = 5;
            this.pcxRFFunG1.TabStop = false;
            // 
            // pbxRFFunW1
            // 
            this.pbxRFFunW1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxRFFunW1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxRFFunW1.Location = new System.Drawing.Point(22, 194);
            this.pbxRFFunW1.Name = "pbxRFFunW1";
            this.pbxRFFunW1.Size = new System.Drawing.Size(397, 211);
            this.pbxRFFunW1.TabIndex = 14;
            this.pbxRFFunW1.TabStop = false;
            // 
            // lblRVFunP
            // 
            this.lblRVFunP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRVFunP.AutoSize = true;
            this.lblRVFunP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRVFunP.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRVFunP.Location = new System.Drawing.Point(44, 218);
            this.lblRVFunP.Name = "lblRVFunP";
            this.lblRVFunP.Size = new System.Drawing.Size(65, 16);
            this.lblRVFunP.TabIndex = 47;
            this.lblRVFunP.Text = "Produto:";
            // 
            // cbxRVFunP
            // 
            this.cbxRVFunP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRVFunP.FormattingEnabled = true;
            this.cbxRVFunP.Location = new System.Drawing.Point(47, 237);
            this.cbxRVFunP.Name = "cbxRVFunP";
            this.cbxRVFunP.Size = new System.Drawing.Size(291, 21);
            this.cbxRVFunP.TabIndex = 48;
            this.cbxRVFunP.SelectedIndexChanged += new System.EventHandler(this.cbxRVFunP_SelectedIndexChanged);
            // 
            // lblRVFunQV
            // 
            this.lblRVFunQV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRVFunQV.AutoSize = true;
            this.lblRVFunQV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRVFunQV.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRVFunQV.Location = new System.Drawing.Point(44, 274);
            this.lblRVFunQV.Name = "lblRVFunQV";
            this.lblRVFunQV.Size = new System.Drawing.Size(151, 16);
            this.lblRVFunQV.TabIndex = 49;
            this.lblRVFunQV.Text = "Quantidade vendida:";
            // 
            // txtRVFunQV
            // 
            this.txtRVFunQV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRVFunQV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRVFunQV.Location = new System.Drawing.Point(47, 293);
            this.txtRVFunQV.Name = "txtRVFunQV";
            this.txtRVFunQV.ReadOnly = true;
            this.txtRVFunQV.Size = new System.Drawing.Size(67, 23);
            this.txtRVFunQV.TabIndex = 50;
            // 
            // lblRVFunV
            // 
            this.lblRVFunV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRVFunV.AutoSize = true;
            this.lblRVFunV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRVFunV.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRVFunV.Location = new System.Drawing.Point(46, 329);
            this.lblRVFunV.Name = "lblRVFunV";
            this.lblRVFunV.Size = new System.Drawing.Size(48, 16);
            this.lblRVFunV.TabIndex = 51;
            this.lblRVFunV.Text = "Valor:";
            // 
            // txtRVFunV
            // 
            this.txtRVFunV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRVFunV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRVFunV.Location = new System.Drawing.Point(47, 348);
            this.txtRVFunV.Name = "txtRVFunV";
            this.txtRVFunV.ReadOnly = true;
            this.txtRVFunV.Size = new System.Drawing.Size(67, 23);
            this.txtRVFunV.TabIndex = 52;
            // 
            // lblRVFunD
            // 
            this.lblRVFunD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRVFunD.AutoSize = true;
            this.lblRVFunD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRVFunD.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRVFunD.Location = new System.Drawing.Point(215, 274);
            this.lblRVFunD.Name = "lblRVFunD";
            this.lblRVFunD.Size = new System.Drawing.Size(44, 16);
            this.lblRVFunD.TabIndex = 53;
            this.lblRVFunD.Text = "Data:";
            // 
            // mskRPFunD
            // 
            this.mskRPFunD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskRPFunD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskRPFunD.Location = new System.Drawing.Point(218, 293);
            this.mskRPFunD.Mask = "00/00/0000";
            this.mskRPFunD.Name = "mskRPFunD";
            this.mskRPFunD.ReadOnly = true;
            this.mskRPFunD.Size = new System.Drawing.Size(71, 23);
            this.mskRPFunD.TabIndex = 54;
            // 
            // ReVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 417);
            this.Controls.Add(this.mskRPFunD);
            this.Controls.Add(this.lblRVFunD);
            this.Controls.Add(this.txtRVFunV);
            this.Controls.Add(this.lblRVFunV);
            this.Controls.Add(this.txtRVFunQV);
            this.Controls.Add(this.lblRVFunQV);
            this.Controls.Add(this.cbxRVFunP);
            this.Controls.Add(this.lblRVFunP);
            this.Controls.Add(this.pbxRFFunW1);
            this.Controls.Add(this.pcxRFFunG1);
            this.Controls.Add(this.lblRFFunT);
            this.Controls.Add(this.btnHBRFFun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(456, 456);
            this.Name = "ReVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.ReVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcxRFFunG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRFFunW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHBRFFun;
        private System.Windows.Forms.Label lblRFFunT;
        private System.Windows.Forms.PictureBox pcxRFFunG1;
        private System.Windows.Forms.PictureBox pbxRFFunW1;
        private System.Windows.Forms.Label lblRVFunP;
        private System.Windows.Forms.ComboBox cbxRVFunP;
        private System.Windows.Forms.Label lblRVFunQV;
        private System.Windows.Forms.TextBox txtRVFunQV;
        private System.Windows.Forms.Label lblRVFunV;
        private System.Windows.Forms.TextBox txtRVFunV;
        private System.Windows.Forms.Label lblRVFunD;
        private System.Windows.Forms.MaskedTextBox mskRPFunD;
    }
}