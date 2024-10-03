namespace WindowsFormsApp1
{
    partial class AdicionarPop
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
            this.lblEFunAPop = new System.Windows.Forms.Label();
            this.btnEFunAPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEFunAPop
            // 
            this.lblEFunAPop.AutoSize = true;
            this.lblEFunAPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEFunAPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblEFunAPop.Location = new System.Drawing.Point(96, 34);
            this.lblEFunAPop.Name = "lblEFunAPop";
            this.lblEFunAPop.Size = new System.Drawing.Size(179, 24);
            this.lblEFunAPop.TabIndex = 2;
            this.lblEFunAPop.Text = "Produto adicionado!";
            // 
            // btnEFunAPop
            // 
            this.btnEFunAPop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEFunAPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEFunAPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEFunAPop.Location = new System.Drawing.Point(126, 85);
            this.btnEFunAPop.Name = "btnEFunAPop";
            this.btnEFunAPop.Size = new System.Drawing.Size(117, 41);
            this.btnEFunAPop.TabIndex = 3;
            this.btnEFunAPop.Text = "OK";
            this.btnEFunAPop.UseVisualStyleBackColor = true;
            this.btnEFunAPop.Click += new System.EventHandler(this.btnEFunAPop_Click);
            // 
            // AdicionarPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnEFunAPop);
            this.Controls.Add(this.lblEFunAPop);
            this.Name = "AdicionarPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto adicionado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEFunAPop;
        private System.Windows.Forms.Button btnEFunAPop;
    }
}