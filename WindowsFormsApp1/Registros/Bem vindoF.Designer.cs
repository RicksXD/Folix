namespace WindowsFormsApp1
{
    partial class Wfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wfor));
            this.picBoxWF = new System.Windows.Forms.PictureBox();
            this.lblWF = new System.Windows.Forms.Label();
            this.btnWF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWF)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxWF
            // 
            this.picBoxWF.BackColor = System.Drawing.Color.White;
            this.picBoxWF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxWF.Image = ((System.Drawing.Image)(resources.GetObject("picBoxWF.Image")));
            this.picBoxWF.Location = new System.Drawing.Point(169, 18);
            this.picBoxWF.Name = "picBoxWF";
            this.picBoxWF.Size = new System.Drawing.Size(100, 92);
            this.picBoxWF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxWF.TabIndex = 23;
            this.picBoxWF.TabStop = false;
            // 
            // lblWF
            // 
            this.lblWF.AutoSize = true;
            this.lblWF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWF.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWF.Location = new System.Drawing.Point(69, 129);
            this.lblWF.Name = "lblWF";
            this.lblWF.Size = new System.Drawing.Size(328, 24);
            this.lblWF.TabIndex = 24;
            this.lblWF.Text = "Usuario registrado! Bem vindo a Folix!";
            // 
            // btnWF
            // 
            this.btnWF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnWF.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnWF.Location = new System.Drawing.Point(172, 169);
            this.btnWF.Name = "btnWF";
            this.btnWF.Size = new System.Drawing.Size(100, 37);
            this.btnWF.TabIndex = 25;
            this.btnWF.Text = "OK";
            this.btnWF.UseVisualStyleBackColor = true;
            this.btnWF.Click += new System.EventHandler(this.btnWF_Click);
            // 
            // Wfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 238);
            this.Controls.Add(this.btnWF);
            this.Controls.Add(this.lblWF);
            this.Controls.Add(this.picBoxWF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Wfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-vindo, fornecedor!";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBoxWF;
        private System.Windows.Forms.Label lblWF;
        private System.Windows.Forms.Button btnWF;
    }
}