namespace WindowsFormsApp1
{
    partial class RelatórioPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatórioPop));
            this.lblRFunPop = new System.Windows.Forms.Label();
            this.btnRFunPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRFunPop
            // 
            this.lblRFunPop.AutoSize = true;
            this.lblRFunPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRFunPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRFunPop.Location = new System.Drawing.Point(65, 34);
            this.lblRFunPop.Name = "lblRFunPop";
            this.lblRFunPop.Size = new System.Drawing.Size(244, 24);
            this.lblRFunPop.TabIndex = 0;
            this.lblRFunPop.Text = "Reabastecimento solicitado!";
            // 
            // btnRFunPop
            // 
            this.btnRFunPop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRFunPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFunPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRFunPop.Location = new System.Drawing.Point(129, 79);
            this.btnRFunPop.Name = "btnRFunPop";
            this.btnRFunPop.Size = new System.Drawing.Size(117, 41);
            this.btnRFunPop.TabIndex = 1;
            this.btnRFunPop.Text = "OK";
            this.btnRFunPop.UseVisualStyleBackColor = true;
            this.btnRFunPop.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelatórioPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnRFunPop);
            this.Controls.Add(this.lblRFunPop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 207);
            this.MinimumSize = new System.Drawing.Size(394, 207);
            this.Name = "RelatórioPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reabastecimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRFunPop;
        private System.Windows.Forms.Button btnRFunPop;
    }
}