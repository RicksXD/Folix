namespace WindowsFormsApp1
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.lblStext = new System.Windows.Forms.Label();
            this.picBoxS = new System.Windows.Forms.PictureBox();
            this.pbxSG = new System.Windows.Forms.PictureBox();
            this.lblShowS = new System.Windows.Forms.Label();
            this.btnSfunc = new System.Windows.Forms.Button();
            this.btnSforne = new System.Windows.Forms.Button();
            this.pbxSW = new System.Windows.Forms.PictureBox();
            this.lblVW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSW)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStext
            // 
            this.lblStext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStext.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStext.Location = new System.Drawing.Point(240, 153);
            this.lblStext.Name = "lblStext";
            this.lblStext.Size = new System.Drawing.Size(315, 194);
            this.lblStext.TabIndex = 0;
            this.lblStext.Text = "Folix desktop para colaboradores da fazenda urbana\r\n\r\nAcesso somente por cadastro" +
    " e login\r\n\r\nVersão Beta (V0.1.0)\r\n";
            this.lblStext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxS
            // 
            this.picBoxS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxS.BackColor = System.Drawing.Color.White;
            this.picBoxS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxS.Image = ((System.Drawing.Image)(resources.GetObject("picBoxS.Image")));
            this.picBoxS.Location = new System.Drawing.Point(333, 12);
            this.picBoxS.Name = "picBoxS";
            this.picBoxS.Size = new System.Drawing.Size(135, 119);
            this.picBoxS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxS.TabIndex = 22;
            this.picBoxS.TabStop = false;
            // 
            // pbxSG
            // 
            this.pbxSG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSG.BackColor = System.Drawing.Color.ForestGreen;
            this.pbxSG.Location = new System.Drawing.Point(237, 150);
            this.pbxSG.Name = "pbxSG";
            this.pbxSG.Size = new System.Drawing.Size(322, 200);
            this.pbxSG.TabIndex = 23;
            this.pbxSG.TabStop = false;
            // 
            // lblShowS
            // 
            this.lblShowS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblShowS.AutoSize = true;
            this.lblShowS.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblShowS.Location = new System.Drawing.Point(307, 384);
            this.lblShowS.Name = "lblShowS";
            this.lblShowS.Size = new System.Drawing.Size(173, 13);
            this.lblShowS.TabIndex = 24;
            this.lblShowS.Text = "Como o Sr(a) gostaria de começar?";
            this.lblShowS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSfunc
            // 
            this.btnSfunc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSfunc.AutoSize = true;
            this.btnSfunc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSfunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSfunc.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSfunc.Location = new System.Drawing.Point(288, 404);
            this.btnSfunc.Name = "btnSfunc";
            this.btnSfunc.Size = new System.Drawing.Size(101, 37);
            this.btnSfunc.TabIndex = 25;
            this.btnSfunc.Text = "Funcionário";
            this.btnSfunc.UseVisualStyleBackColor = true;
            this.btnSfunc.Click += new System.EventHandler(this.btnSfunc_Click);
            // 
            // btnSforne
            // 
            this.btnSforne.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSforne.AutoSize = true;
            this.btnSforne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSforne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSforne.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSforne.Location = new System.Drawing.Point(408, 404);
            this.btnSforne.Name = "btnSforne";
            this.btnSforne.Size = new System.Drawing.Size(101, 38);
            this.btnSforne.TabIndex = 26;
            this.btnSforne.Text = "Fornecedor";
            this.btnSforne.UseVisualStyleBackColor = true;
            this.btnSforne.Click += new System.EventHandler(this.btnSforne_Click);
            // 
            // pbxSW
            // 
            this.pbxSW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxSW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSW.Location = new System.Drawing.Point(262, 378);
            this.pbxSW.Name = "pbxSW";
            this.pbxSW.Size = new System.Drawing.Size(274, 73);
            this.pbxSW.TabIndex = 27;
            this.pbxSW.TabStop = false;
            // 
            // lblVW
            // 
            this.lblVW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVW.AutoSize = true;
            this.lblVW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVW.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblVW.Location = new System.Drawing.Point(5, 494);
            this.lblVW.Name = "lblVW";
            this.lblVW.Size = new System.Drawing.Size(75, 24);
            this.lblVW.TabIndex = 28;
            this.lblVW.Text = "(V0.1.0)";
            this.lblVW.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 523);
            this.Controls.Add(this.lblVW);
            this.Controls.Add(this.btnSforne);
            this.Controls.Add(this.btnSfunc);
            this.Controls.Add(this.lblShowS);
            this.Controls.Add(this.picBoxS);
            this.Controls.Add(this.lblStext);
            this.Controls.Add(this.pbxSG);
            this.Controls.Add(this.pbxSW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(823, 562);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Começar";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStext;
        public System.Windows.Forms.PictureBox picBoxS;
        private System.Windows.Forms.PictureBox pbxSG;
        private System.Windows.Forms.Label lblShowS;
        private System.Windows.Forms.Button btnSfunc;
        private System.Windows.Forms.Button btnSforne;
        private System.Windows.Forms.PictureBox pbxSW;
        private System.Windows.Forms.Label lblVW;
    }
}