namespace WindowsFormsApp1
{
    partial class RemoverPop
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
            this.lblEFunRPop = new System.Windows.Forms.Label();
            this.btnEFunRPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEFunRPop
            // 
            this.lblEFunRPop.AutoSize = true;
            this.lblEFunRPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEFunRPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblEFunRPop.Location = new System.Drawing.Point(102, 35);
            this.lblEFunRPop.Name = "lblEFunRPop";
            this.lblEFunRPop.Size = new System.Drawing.Size(165, 24);
            this.lblEFunRPop.TabIndex = 1;
            this.lblEFunRPop.Text = "Produto removido!";
            // 
            // btnEFunRPop
            // 
            this.btnEFunRPop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEFunRPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEFunRPop.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEFunRPop.Location = new System.Drawing.Point(129, 92);
            this.btnEFunRPop.Name = "btnEFunRPop";
            this.btnEFunRPop.Size = new System.Drawing.Size(117, 41);
            this.btnEFunRPop.TabIndex = 2;
            this.btnEFunRPop.Text = "OK";
            this.btnEFunRPop.UseVisualStyleBackColor = true;
            this.btnEFunRPop.Click += new System.EventHandler(this.btnEFunRPop_Click);
            // 
            // RemoverPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.Controls.Add(this.btnEFunRPop);
            this.Controls.Add(this.lblEFunRPop);
            this.Name = "RemoverPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto Removido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEFunRPop;
        private System.Windows.Forms.Button btnEFunRPop;
    }
}