namespace WindowsFormsApp1.Home_de_funcionario
{
    partial class VendaPoP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendaPoP));
            this.lblVendaPoP = new System.Windows.Forms.Label();
            this.btnVendaPoP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVendaPoP
            // 
            this.lblVendaPoP.AutoSize = true;
            this.lblVendaPoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblVendaPoP.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblVendaPoP.Location = new System.Drawing.Point(58, 34);
            this.lblVendaPoP.Name = "lblVendaPoP";
            this.lblVendaPoP.Size = new System.Drawing.Size(264, 24);
            this.lblVendaPoP.TabIndex = 2;
            this.lblVendaPoP.Text = "Abastecimento feito, obrigado!";
            // 
            // btnVendaPoP
            // 
            this.btnVendaPoP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVendaPoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaPoP.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnVendaPoP.Location = new System.Drawing.Point(125, 84);
            this.btnVendaPoP.Name = "btnVendaPoP";
            this.btnVendaPoP.Size = new System.Drawing.Size(117, 41);
            this.btnVendaPoP.TabIndex = 3;
            this.btnVendaPoP.Text = "OK";
            this.btnVendaPoP.UseVisualStyleBackColor = true;
            this.btnVendaPoP.Click += new System.EventHandler(this.btnVendaPoP_Click);
            // 
            // VendaPoP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnVendaPoP);
            this.Controls.Add(this.lblVendaPoP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 207);
            this.MinimumSize = new System.Drawing.Size(394, 207);
            this.Name = "VendaPoP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucesso!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendaPoP;
        private System.Windows.Forms.Button btnVendaPoP;
    }
}