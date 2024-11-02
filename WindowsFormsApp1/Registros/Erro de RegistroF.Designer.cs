namespace WindowsFormsApp1
{
    partial class ErrorFor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorFor));
            this.picBoxEF = new System.Windows.Forms.PictureBox();
            this.lblEF = new System.Windows.Forms.Label();
            this.btnEF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEF)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxEF
            // 
            this.picBoxEF.BackColor = System.Drawing.Color.White;
            this.picBoxEF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxEF.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEF.Image")));
            this.picBoxEF.Location = new System.Drawing.Point(169, 18);
            this.picBoxEF.Name = "picBoxEF";
            this.picBoxEF.Size = new System.Drawing.Size(100, 92);
            this.picBoxEF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEF.TabIndex = 23;
            this.picBoxEF.TabStop = false;
            // 
            // lblEF
            // 
            this.lblEF.AutoSize = true;
            this.lblEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEF.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblEF.Location = new System.Drawing.Point(69, 129);
            this.lblEF.Name = "lblEF";
            this.lblEF.Size = new System.Drawing.Size(312, 24);
            this.lblEF.TabIndex = 24;
            this.lblEF.Text = "Erro no cadastro. Tente novamente.";
            // 
            // btnEF
            // 
            this.btnEF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEF.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEF.Location = new System.Drawing.Point(172, 169);
            this.btnEF.Name = "btnEF";
            this.btnEF.Size = new System.Drawing.Size(100, 37);
            this.btnEF.TabIndex = 25;
            this.btnEF.Text = "OK";
            this.btnEF.UseVisualStyleBackColor = true;
            this.btnEF.Click += new System.EventHandler(this.btnEF_Click);
            // 
            // ErrorFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 238);
            this.Controls.Add(this.btnEF);
            this.Controls.Add(this.lblEF);
            this.Controls.Add(this.picBoxEF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ErrorFor";
            this.Text = "Erro de registro";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBoxEF;
        private System.Windows.Forms.Label lblEF;
        private System.Windows.Forms.Button btnEF;
    }
}