namespace WindowsFormsApp1
{
    partial class GCFPOPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCFPOPC));
            this.lblGCPOPC = new System.Windows.Forms.Label();
            this.btnGCFPOPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGCPOPC
            // 
            this.lblGCPOPC.AutoSize = true;
            this.lblGCPOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGCPOPC.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblGCPOPC.Location = new System.Drawing.Point(105, 29);
            this.lblGCPOPC.Name = "lblGCPOPC";
            this.lblGCPOPC.Size = new System.Drawing.Size(160, 24);
            this.lblGCPOPC.TabIndex = 1;
            this.lblGCPOPC.Text = "Alterações salvas!";
            // 
            // btnGCFPOPC
            // 
            this.btnGCFPOPC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGCFPOPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGCFPOPC.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGCFPOPC.Location = new System.Drawing.Point(128, 78);
            this.btnGCFPOPC.Name = "btnGCFPOPC";
            this.btnGCFPOPC.Size = new System.Drawing.Size(117, 41);
            this.btnGCFPOPC.TabIndex = 2;
            this.btnGCFPOPC.Text = "OK";
            this.btnGCFPOPC.UseVisualStyleBackColor = true;
            this.btnGCFPOPC.Click += new System.EventHandler(this.btnGCFPOPC_Click);
            // 
            // GCFPOPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnGCFPOPC);
            this.Controls.Add(this.lblGCPOPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 207);
            this.MinimumSize = new System.Drawing.Size(394, 207);
            this.Name = "GCFPOPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterações feitas!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGCPOPC;
        private System.Windows.Forms.Button btnGCFPOPC;
    }
}