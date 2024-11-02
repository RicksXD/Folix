namespace WindowsFormsApp1
{
    partial class LoginFUN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFUN));
            this.picBoxLFun = new System.Windows.Forms.PictureBox();
            this.lblUserFun = new System.Windows.Forms.Label();
            this.lblPWFUN = new System.Windows.Forms.Label();
            this.txtUserFUN = new System.Windows.Forms.TextBox();
            this.txtPWFUN = new System.Windows.Forms.TextBox();
            this.cbxSPWFUN = new System.Windows.Forms.CheckBox();
            this.btnLoginFun = new System.Windows.Forms.Button();
            this.EPLoginFun = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPPWFun = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBLoginFun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLFun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLoginFun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPPWFun)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLFun
            // 
            this.picBoxLFun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxLFun.BackColor = System.Drawing.Color.White;
            this.picBoxLFun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxLFun.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLFun.Image")));
            this.picBoxLFun.Location = new System.Drawing.Point(233, 21);
            this.picBoxLFun.Name = "picBoxLFun";
            this.picBoxLFun.Size = new System.Drawing.Size(100, 92);
            this.picBoxLFun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLFun.TabIndex = 22;
            this.picBoxLFun.TabStop = false;
            // 
            // lblUserFun
            // 
            this.lblUserFun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserFun.AutoSize = true;
            this.lblUserFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserFun.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUserFun.Location = new System.Drawing.Point(35, 131);
            this.lblUserFun.Name = "lblUserFun";
            this.lblUserFun.Size = new System.Drawing.Size(123, 44);
            this.lblUserFun.TabIndex = 23;
            this.lblUserFun.Text = "Usuário\r\n(email ou cpf):";
            // 
            // lblPWFUN
            // 
            this.lblPWFUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPWFUN.AutoSize = true;
            this.lblPWFUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPWFUN.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPWFUN.Location = new System.Drawing.Point(35, 199);
            this.lblPWFUN.Name = "lblPWFUN";
            this.lblPWFUN.Size = new System.Drawing.Size(67, 22);
            this.lblPWFUN.TabIndex = 24;
            this.lblPWFUN.Text = "Senha:";
            // 
            // txtUserFUN
            // 
            this.txtUserFUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserFUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserFUN.Location = new System.Drawing.Point(154, 152);
            this.txtUserFUN.Name = "txtUserFUN";
            this.txtUserFUN.Size = new System.Drawing.Size(287, 23);
            this.txtUserFUN.TabIndex = 26;
            this.txtUserFUN.TextChanged += new System.EventHandler(this.txtUserFUN_TextChanged);
            // 
            // txtPWFUN
            // 
            this.txtPWFUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPWFUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPWFUN.Location = new System.Drawing.Point(154, 198);
            this.txtPWFUN.Name = "txtPWFUN";
            this.txtPWFUN.Size = new System.Drawing.Size(287, 23);
            this.txtPWFUN.TabIndex = 27;
            this.txtPWFUN.UseSystemPasswordChar = true;
            // 
            // cbxSPWFUN
            // 
            this.cbxSPWFUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSPWFUN.AutoSize = true;
            this.cbxSPWFUN.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxSPWFUN.Location = new System.Drawing.Point(466, 203);
            this.cbxSPWFUN.Name = "cbxSPWFUN";
            this.cbxSPWFUN.Size = new System.Drawing.Size(83, 17);
            this.cbxSPWFUN.TabIndex = 28;
            this.cbxSPWFUN.Text = "Exibir senha";
            this.cbxSPWFUN.UseVisualStyleBackColor = true;
            this.cbxSPWFUN.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLoginFun
            // 
            this.btnLoginFun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoginFun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoginFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginFun.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLoginFun.Location = new System.Drawing.Point(245, 237);
            this.btnLoginFun.MinimumSize = new System.Drawing.Size(98, 34);
            this.btnLoginFun.Name = "btnLoginFun";
            this.btnLoginFun.Size = new System.Drawing.Size(98, 34);
            this.btnLoginFun.TabIndex = 29;
            this.btnLoginFun.Text = "Fazer Login";
            this.btnLoginFun.UseVisualStyleBackColor = true;
            this.btnLoginFun.Click += new System.EventHandler(this.btnLoginFun_Click);
            // 
            // EPLoginFun
            // 
            this.EPLoginFun.ContainerControl = this;
            // 
            // EPPWFun
            // 
            this.EPPWFun.ContainerControl = this;
            // 
            // btnBLoginFun
            // 
            this.btnBLoginFun.FlatAppearance.BorderSize = 0;
            this.btnBLoginFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBLoginFun.Image = ((System.Drawing.Image)(resources.GetObject("btnBLoginFun.Image")));
            this.btnBLoginFun.Location = new System.Drawing.Point(0, 3);
            this.btnBLoginFun.Name = "btnBLoginFun";
            this.btnBLoginFun.Size = new System.Drawing.Size(35, 42);
            this.btnBLoginFun.TabIndex = 30;
            this.btnBLoginFun.UseVisualStyleBackColor = true;
            this.btnBLoginFun.Click += new System.EventHandler(this.btnBLoginFun_Click_1);
            // 
            // LoginFUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 287);
            this.Controls.Add(this.btnBLoginFun);
            this.Controls.Add(this.btnLoginFun);
            this.Controls.Add(this.cbxSPWFUN);
            this.Controls.Add(this.txtPWFUN);
            this.Controls.Add(this.txtUserFUN);
            this.Controls.Add(this.lblPWFUN);
            this.Controls.Add(this.lblUserFun);
            this.Controls.Add(this.picBoxLFun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(577, 326);
            this.Name = "LoginFUN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de funcionário";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginFUN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLFun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLoginFun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPPWFun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBoxLFun;
        private System.Windows.Forms.Label lblUserFun;
        private System.Windows.Forms.Label lblPWFUN;
        private System.Windows.Forms.TextBox txtUserFUN;
        private System.Windows.Forms.TextBox txtPWFUN;
        private System.Windows.Forms.CheckBox cbxSPWFUN;
        private System.Windows.Forms.Button btnLoginFun;
        private System.Windows.Forms.ErrorProvider EPLoginFun;
        private System.Windows.Forms.ErrorProvider EPPWFun;
        private System.Windows.Forms.Button btnBLoginFun;
    }
}