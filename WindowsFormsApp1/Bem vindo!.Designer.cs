namespace WindowsFormsApp1
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.lblWelCheck = new System.Windows.Forms.Label();
            this.btnOKCheck = new System.Windows.Forms.Button();
            this.picBoxW = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxW)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelCheck
            // 
            this.lblWelCheck.AutoSize = true;
            this.lblWelCheck.BackColor = System.Drawing.Color.White;
            this.lblWelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWelCheck.Location = new System.Drawing.Point(62, 125);
            this.lblWelCheck.Name = "lblWelCheck";
            this.lblWelCheck.Size = new System.Drawing.Size(328, 24);
            this.lblWelCheck.TabIndex = 1;
            this.lblWelCheck.Text = "Usuario registrado! Bem vindo a Folix!";
            this.lblWelCheck.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOKCheck
            // 
            this.btnOKCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOKCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOKCheck.Location = new System.Drawing.Point(172, 169);
            this.btnOKCheck.Name = "btnOKCheck";
            this.btnOKCheck.Size = new System.Drawing.Size(100, 37);
            this.btnOKCheck.TabIndex = 2;
            this.btnOKCheck.Text = "OK";
            this.btnOKCheck.UseVisualStyleBackColor = true;
            this.btnOKCheck.Click += new System.EventHandler(this.btnOKCheck_Click);
            // 
            // picBoxW
            // 
            this.picBoxW.BackColor = System.Drawing.Color.White;
            this.picBoxW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxW.Image = ((System.Drawing.Image)(resources.GetObject("picBoxW.Image")));
            this.picBoxW.Location = new System.Drawing.Point(172, 19);
            this.picBoxW.Name = "picBoxW";
            this.picBoxW.Size = new System.Drawing.Size(100, 92);
            this.picBoxW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxW.TabIndex = 22;
            this.picBoxW.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 238);
            this.Controls.Add(this.picBoxW);
            this.Controls.Add(this.btnOKCheck);
            this.Controls.Add(this.lblWelCheck);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem vindo!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelCheck;
        private System.Windows.Forms.Button btnOKCheck;
        public System.Windows.Forms.PictureBox picBoxW;
    }
}