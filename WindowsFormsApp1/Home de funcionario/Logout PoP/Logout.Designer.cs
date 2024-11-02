namespace WindowsFormsApp1.Home_de_funcionario
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            this.lblLPoP = new System.Windows.Forms.Label();
            this.btnLPoP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLPoP
            // 
            this.lblLPoP.AutoSize = true;
            this.lblLPoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLPoP.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLPoP.Location = new System.Drawing.Point(101, 37);
            this.lblLPoP.Name = "lblLPoP";
            this.lblLPoP.Size = new System.Drawing.Size(168, 24);
            this.lblLPoP.TabIndex = 1;
            this.lblLPoP.Text = "Usuario deslogado";
            // 
            // btnLPoP
            // 
            this.btnLPoP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLPoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLPoP.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLPoP.Location = new System.Drawing.Point(126, 85);
            this.btnLPoP.Name = "btnLPoP";
            this.btnLPoP.Size = new System.Drawing.Size(117, 41);
            this.btnLPoP.TabIndex = 2;
            this.btnLPoP.Text = "OK";
            this.btnLPoP.UseVisualStyleBackColor = true;
            this.btnLPoP.Click += new System.EventHandler(this.btnLPoP_Click);
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnLPoP);
            this.Controls.Add(this.lblLPoP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 207);
            this.MinimumSize = new System.Drawing.Size(394, 207);
            this.Name = "Logout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLPoP;
        private System.Windows.Forms.Button btnLPoP;
    }
}