namespace WindowsFormsApp1
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.lbl = new System.Windows.Forms.Label();
            this.btnOKError = new System.Windows.Forms.Button();
            this.picBoxE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxE)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl.Location = new System.Drawing.Point(69, 129);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(312, 24);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Erro no cadastro. Tente novamente.";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btnOKError
            // 
            this.btnOKError.BackColor = System.Drawing.Color.White;
            this.btnOKError.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOKError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKError.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOKError.Location = new System.Drawing.Point(169, 171);
            this.btnOKError.Name = "btnOKError";
            this.btnOKError.Size = new System.Drawing.Size(100, 39);
            this.btnOKError.TabIndex = 3;
            this.btnOKError.Text = "OK";
            this.btnOKError.UseVisualStyleBackColor = false;
            this.btnOKError.Click += new System.EventHandler(this.btnOKError_Click);
            // 
            // picBoxE
            // 
            this.picBoxE.BackColor = System.Drawing.Color.White;
            this.picBoxE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxE.Image = ((System.Drawing.Image)(resources.GetObject("picBoxE.Image")));
            this.picBoxE.Location = new System.Drawing.Point(169, 18);
            this.picBoxE.Name = "picBoxE";
            this.picBoxE.Size = new System.Drawing.Size(100, 92);
            this.picBoxE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxE.TabIndex = 22;
            this.picBoxE.TabStop = false;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 238);
            this.Controls.Add(this.picBoxE);
            this.Controls.Add(this.btnOKError);
            this.Controls.Add(this.lbl);
            this.Name = "Error";
            this.Text = "Erro de Registro";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnOKError;
        public System.Windows.Forms.PictureBox picBoxE;
    }
}