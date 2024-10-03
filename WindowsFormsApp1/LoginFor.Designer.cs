namespace WindowsFormsApp1
{
    partial class LoginFor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFor));
            this.picBoxLFor = new System.Windows.Forms.PictureBox();
            this.lblUserFor = new System.Windows.Forms.Label();
            this.lblPWFor = new System.Windows.Forms.Label();
            this.txtPWFOR = new System.Windows.Forms.TextBox();
            this.cbxSPWFOR = new System.Windows.Forms.CheckBox();
            this.btnLoginFor = new System.Windows.Forms.Button();
            this.txtUserFOR = new System.Windows.Forms.TextBox();
            this.EPLoginFor = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPPWFor = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBLoginFor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLoginFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPPWFor)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLFor
            // 
            this.picBoxLFor.BackColor = System.Drawing.Color.White;
            this.picBoxLFor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxLFor.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLFor.Image")));
            this.picBoxLFor.Location = new System.Drawing.Point(233, 21);
            this.picBoxLFor.Name = "picBoxLFor";
            this.picBoxLFor.Size = new System.Drawing.Size(100, 92);
            this.picBoxLFor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLFor.TabIndex = 22;
            this.picBoxLFor.TabStop = false;
            // 
            // lblUserFor
            // 
            this.lblUserFor.AutoSize = true;
            this.lblUserFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserFor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUserFor.Location = new System.Drawing.Point(35, 131);
            this.lblUserFor.Name = "lblUserFor";
            this.lblUserFor.Size = new System.Drawing.Size(123, 44);
            this.lblUserFor.TabIndex = 23;
            this.lblUserFor.Text = "Usuário\r\n(email ou cpf):";
            // 
            // lblPWFor
            // 
            this.lblPWFor.AutoSize = true;
            this.lblPWFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPWFor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPWFor.Location = new System.Drawing.Point(35, 197);
            this.lblPWFor.Name = "lblPWFor";
            this.lblPWFor.Size = new System.Drawing.Size(67, 22);
            this.lblPWFor.TabIndex = 24;
            this.lblPWFor.Text = "Senha:";
            // 
            // txtPWFOR
            // 
            this.txtPWFOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPWFOR.Location = new System.Drawing.Point(154, 198);
            this.txtPWFOR.Name = "txtPWFOR";
            this.txtPWFOR.Size = new System.Drawing.Size(287, 23);
            this.txtPWFOR.TabIndex = 26;
            this.txtPWFOR.UseSystemPasswordChar = true;
            // 
            // cbxSPWFOR
            // 
            this.cbxSPWFOR.AutoSize = true;
            this.cbxSPWFOR.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxSPWFOR.Location = new System.Drawing.Point(466, 202);
            this.cbxSPWFOR.Name = "cbxSPWFOR";
            this.cbxSPWFOR.Size = new System.Drawing.Size(83, 17);
            this.cbxSPWFOR.TabIndex = 27;
            this.cbxSPWFOR.Text = "Exibir senha";
            this.cbxSPWFOR.UseVisualStyleBackColor = true;
            this.cbxSPWFOR.CheckedChanged += new System.EventHandler(this.cbxSPWFOR_CheckedChanged);
            // 
            // btnLoginFor
            // 
            this.btnLoginFor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoginFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginFor.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLoginFor.Location = new System.Drawing.Point(245, 237);
            this.btnLoginFor.Name = "btnLoginFor";
            this.btnLoginFor.Size = new System.Drawing.Size(98, 34);
            this.btnLoginFor.TabIndex = 28;
            this.btnLoginFor.Text = "Fazer Login";
            this.btnLoginFor.UseVisualStyleBackColor = true;
            this.btnLoginFor.Click += new System.EventHandler(this.btnLoginFor_Click);
            // 
            // txtUserFOR
            // 
            this.txtUserFOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserFOR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUserFOR.Location = new System.Drawing.Point(154, 152);
            this.txtUserFOR.Name = "txtUserFOR";
            this.txtUserFOR.Size = new System.Drawing.Size(287, 23);
            this.txtUserFOR.TabIndex = 25;
            this.txtUserFOR.TextChanged += new System.EventHandler(this.txtUserFOR_TextChanged);
            // 
            // EPLoginFor
            // 
            this.EPLoginFor.ContainerControl = this;
            // 
            // EPPWFor
            // 
            this.EPPWFor.ContainerControl = this;
            // 
            // btnBLoginFor
            // 
            this.btnBLoginFor.FlatAppearance.BorderSize = 0;
            this.btnBLoginFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBLoginFor.Image = ((System.Drawing.Image)(resources.GetObject("btnBLoginFor.Image")));
            this.btnBLoginFor.Location = new System.Drawing.Point(-1, 1);
            this.btnBLoginFor.Name = "btnBLoginFor";
            this.btnBLoginFor.Size = new System.Drawing.Size(35, 42);
            this.btnBLoginFor.TabIndex = 29;
            this.btnBLoginFor.UseVisualStyleBackColor = true;
            this.btnBLoginFor.Click += new System.EventHandler(this.btnBLoginFor_Click);
            // 
            // LoginFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 287);
            this.Controls.Add(this.btnBLoginFor);
            this.Controls.Add(this.btnLoginFor);
            this.Controls.Add(this.cbxSPWFOR);
            this.Controls.Add(this.txtPWFOR);
            this.Controls.Add(this.txtUserFOR);
            this.Controls.Add(this.lblPWFor);
            this.Controls.Add(this.lblUserFor);
            this.Controls.Add(this.picBoxLFor);
            this.Name = "LoginFor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de fornecedor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLoginFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPPWFor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBoxLFor;
        private System.Windows.Forms.Label lblUserFor;
        private System.Windows.Forms.Label lblPWFor;
        private System.Windows.Forms.TextBox txtPWFOR;
        private System.Windows.Forms.CheckBox cbxSPWFOR;
        private System.Windows.Forms.Button btnLoginFor;
        private System.Windows.Forms.TextBox txtUserFOR;
        private System.Windows.Forms.ErrorProvider EPLoginFor;
        private System.Windows.Forms.ErrorProvider EPPWFor;
        private System.Windows.Forms.Button btnBLoginFor;
    }
}