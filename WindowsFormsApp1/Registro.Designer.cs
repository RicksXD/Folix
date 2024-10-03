namespace WindowsFormsApp1
{
    partial class Registro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBDate = new System.Windows.Forms.Label();
            this.mskAge = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbxShowPass = new System.Windows.Forms.CheckBox();
            this.txtPassWC = new System.Windows.Forms.TextBox();
            this.cbxShowPassC = new System.Windows.Forms.CheckBox();
            this.lblPassWC = new System.Windows.Forms.Label();
            this.picBoxR = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLfunR = new System.Windows.Forms.Label();
            this.llblLoginFun = new System.Windows.Forms.LinkLabel();
            this.lblTel = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.Location = new System.Drawing.Point(250, 592);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(98, 34);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblName.Location = new System.Drawing.Point(35, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 44);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome\r\ncompleto:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEmail.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblEmail.Location = new System.Drawing.Point(35, 235);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPassword.Location = new System.Drawing.Point(35, 396);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 22);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Senha:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCpf.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCpf.Location = new System.Drawing.Point(35, 340);
            this.lblCpf.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 22);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "Cpf:";
            this.lblCpf.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(148, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCpf.Location = new System.Drawing.Point(148, 339);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(96, 23);
            this.mskCpf.TabIndex = 12;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCpf_MaskInputRejected);
            this.mskCpf.Click += new System.EventHandler(this.mskCpf_Click);
            this.mskCpf.Enter += new System.EventHandler(this.mskCpf_Enter);
            this.mskCpf.Leave += new System.EventHandler(this.mskCpf_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(148, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 23);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblBDate.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblBDate.Location = new System.Drawing.Point(35, 182);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(59, 22);
            this.lblBDate.TabIndex = 13;
            this.lblBDate.Text = "Idade:";
            this.lblBDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskAge
            // 
            this.mskAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskAge.Location = new System.Drawing.Point(148, 182);
            this.mskAge.Mask = "00";
            this.mskAge.Name = "mskAge";
            this.mskAge.Size = new System.Drawing.Size(23, 23);
            this.mskAge.TabIndex = 14;
            this.mskAge.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskBDate_MaskInputRejected);
            this.mskAge.Click += new System.EventHandler(this.mskAge_Click);
            this.mskAge.Enter += new System.EventHandler(this.mskAge_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnClear.Location = new System.Drawing.Point(132, 592);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Limpar Campos";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(148, 396);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(96, 23);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbxShowPass
            // 
            this.cbxShowPass.AutoSize = true;
            this.cbxShowPass.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxShowPass.Location = new System.Drawing.Point(148, 425);
            this.cbxShowPass.Name = "cbxShowPass";
            this.cbxShowPass.Size = new System.Drawing.Size(83, 17);
            this.cbxShowPass.TabIndex = 17;
            this.cbxShowPass.Text = "Exibir senha";
            this.cbxShowPass.UseVisualStyleBackColor = true;
            this.cbxShowPass.CheckedChanged += new System.EventHandler(this.cbxShowPass_CheckedChanged);
            // 
            // txtPassWC
            // 
            this.txtPassWC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassWC.Location = new System.Drawing.Point(148, 472);
            this.txtPassWC.Name = "txtPassWC";
            this.txtPassWC.Size = new System.Drawing.Size(96, 23);
            this.txtPassWC.TabIndex = 18;
            this.txtPassWC.UseSystemPasswordChar = true;
            this.txtPassWC.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbxShowPassC
            // 
            this.cbxShowPassC.AutoSize = true;
            this.cbxShowPassC.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxShowPassC.Location = new System.Drawing.Point(148, 500);
            this.cbxShowPassC.Name = "cbxShowPassC";
            this.cbxShowPassC.Size = new System.Drawing.Size(83, 17);
            this.cbxShowPassC.TabIndex = 19;
            this.cbxShowPassC.Text = "Exibir senha";
            this.cbxShowPassC.UseVisualStyleBackColor = true;
            this.cbxShowPassC.CheckedChanged += new System.EventHandler(this.cbxShowPassC_CheckedChanged);
            // 
            // lblPassWC
            // 
            this.lblPassWC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPassWC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPassWC.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPassWC.Location = new System.Drawing.Point(35, 461);
            this.lblPassWC.Name = "lblPassWC";
            this.lblPassWC.Size = new System.Drawing.Size(93, 46);
            this.lblPassWC.TabIndex = 20;
            this.lblPassWC.Text = "Confirmar senha:";
            this.lblPassWC.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // picBoxR
            // 
            this.picBoxR.BackColor = System.Drawing.Color.White;
            this.picBoxR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxR.Image = ((System.Drawing.Image)(resources.GetObject("picBoxR.Image")));
            this.picBoxR.Location = new System.Drawing.Point(213, 12);
            this.picBoxR.Name = "picBoxR";
            this.picBoxR.Size = new System.Drawing.Size(100, 92);
            this.picBoxR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxR.TabIndex = 21;
            this.picBoxR.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBack.Location = new System.Drawing.Point(5, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 42);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLfunR
            // 
            this.lblLfunR.AutoSize = true;
            this.lblLfunR.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLfunR.Location = new System.Drawing.Point(36, 543);
            this.lblLfunR.Name = "lblLfunR";
            this.lblLfunR.Size = new System.Drawing.Size(103, 13);
            this.lblLfunR.TabIndex = 23;
            this.lblLfunR.Text = "Já possui um Login?";
            // 
            // llblLoginFun
            // 
            this.llblLoginFun.AutoSize = true;
            this.llblLoginFun.LinkColor = System.Drawing.Color.Black;
            this.llblLoginFun.Location = new System.Drawing.Point(136, 543);
            this.llblLoginFun.Name = "llblLoginFun";
            this.llblLoginFun.Size = new System.Drawing.Size(102, 13);
            this.llblLoginFun.TabIndex = 24;
            this.llblLoginFun.TabStop = true;
            this.llblLoginFun.Text = "Vá pra tela de Login";
            this.llblLoginFun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLoginFun_LinkClicked);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTel.Location = new System.Drawing.Point(35, 286);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(86, 22);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefone:";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskTel.Location = new System.Drawing.Point(148, 287);
            this.mskTel.Mask = "(00) 0000-00000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(101, 23);
            this.mskTel.TabIndex = 25;
            this.mskTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mskTel.Click += new System.EventHandler(this.mskTel_Click);
            this.mskTel.Enter += new System.EventHandler(this.mskTel_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Registro
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(511, 649);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.llblLoginFun);
            this.Controls.Add(this.lblLfunR);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picBoxR);
            this.Controls.Add(this.lblPassWC);
            this.Controls.Add(this.cbxShowPassC);
            this.Controls.Add(this.txtPassWC);
            this.Controls.Add(this.cbxShowPass);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.mskAge);
            this.Controls.Add(this.lblBDate);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRegister);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.MaskedTextBox mskAge;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxShowPass;
        private System.Windows.Forms.TextBox txtPassWC;
        private System.Windows.Forms.CheckBox cbxShowPassC;
        private System.Windows.Forms.Label lblPassWC;
        public System.Windows.Forms.PictureBox picBoxR;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel llblLoginFun;
        private System.Windows.Forms.Label lblLfunR;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
    }
}

