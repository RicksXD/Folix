namespace WindowsFormsApp1
{
    partial class RelatórioForPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatórioForPop));
            this.lblRForPop = new System.Windows.Forms.Label();
            this.btnRForPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRForPop
            // 
            this.lblRForPop.AutoSize = true;
            this.lblRForPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRForPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRForPop.Location = new System.Drawing.Point(65, 30);
            this.lblRForPop.Name = "lblRForPop";
            this.lblRForPop.Size = new System.Drawing.Size(246, 24);
            this.lblRForPop.TabIndex = 1;
            this.lblRForPop.Text = "Relatório enviado, obrigado!";
            this.lblRForPop.Click += new System.EventHandler(this.lblRFunPop_Click);
            // 
            // btnRForPop
            // 
            this.btnRForPop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRForPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRForPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRForPop.Location = new System.Drawing.Point(127, 78);
            this.btnRForPop.Name = "btnRForPop";
            this.btnRForPop.Size = new System.Drawing.Size(117, 41);
            this.btnRForPop.TabIndex = 2;
            this.btnRForPop.Text = "OK";
            this.btnRForPop.UseVisualStyleBackColor = true;
            this.btnRForPop.Click += new System.EventHandler(this.btnRForPop_Click);
            // 
            // RelatórioForPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnRForPop);
            this.Controls.Add(this.lblRForPop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 207);
            this.MinimumSize = new System.Drawing.Size(394, 207);
            this.Name = "RelatórioForPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório gerado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRForPop;
        private System.Windows.Forms.Button btnRForPop;
    }
}