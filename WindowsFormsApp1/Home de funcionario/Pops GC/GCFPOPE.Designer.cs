namespace WindowsFormsApp1
{
    partial class GCFPOPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCFPOPE));
            this.lblGCPOPE = new System.Windows.Forms.Label();
            this.btnGCPOPN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGCPOPE
            // 
            this.lblGCPOPE.AutoSize = true;
            this.lblGCPOPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGCPOPE.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblGCPOPE.Location = new System.Drawing.Point(89, 29);
            this.lblGCPOPE.Name = "lblGCPOPE";
            this.lblGCPOPE.Size = new System.Drawing.Size(193, 24);
            this.lblGCPOPE.TabIndex = 2;
            this.lblGCPOPE.Text = "Funcionário excluido!";
            // 
            // btnGCPOPN
            // 
            this.btnGCPOPN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGCPOPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGCPOPN.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGCPOPN.Location = new System.Drawing.Point(127, 73);
            this.btnGCPOPN.Name = "btnGCPOPN";
            this.btnGCPOPN.Size = new System.Drawing.Size(117, 41);
            this.btnGCPOPN.TabIndex = 4;
            this.btnGCPOPN.Text = "OK";
            this.btnGCPOPN.UseVisualStyleBackColor = true;
            this.btnGCPOPN.Click += new System.EventHandler(this.button1_Click);
            // 
            // GCFPOPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnGCPOPN);
            this.Controls.Add(this.lblGCPOPE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 207);
            this.MinimumSize = new System.Drawing.Size(394, 207);
            this.Name = "GCFPOPE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário excluido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGCPOPE;
        private System.Windows.Forms.Button btnGCPOPN;
    }
}