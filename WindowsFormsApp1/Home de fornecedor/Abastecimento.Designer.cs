namespace WindowsFormsApp1.Home_de_funcionario
{
    partial class Abastecer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abastecer));
            this.lblAV = new System.Windows.Forms.Label();
            this.lblAQ = new System.Windows.Forms.Label();
            this.lblAPN = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtAV = new System.Windows.Forms.TextBox();
            this.txtAQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAV
            // 
            this.lblAV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAV.AutoSize = true;
            this.lblAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAV.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAV.Location = new System.Drawing.Point(47, 82);
            this.lblAV.Name = "lblAV";
            this.lblAV.Size = new System.Drawing.Size(48, 16);
            this.lblAV.TabIndex = 34;
            this.lblAV.Text = "Valor:";
            // 
            // lblAQ
            // 
            this.lblAQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAQ.AutoSize = true;
            this.lblAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAQ.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAQ.Location = new System.Drawing.Point(47, 136);
            this.lblAQ.Name = "lblAQ";
            this.lblAQ.Size = new System.Drawing.Size(91, 16);
            this.lblAQ.TabIndex = 43;
            this.lblAQ.Text = "Quantidade:";
            // 
            // lblAPN
            // 
            this.lblAPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAPN.AutoSize = true;
            this.lblAPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAPN.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAPN.Location = new System.Drawing.Point(47, 30);
            this.lblAPN.Name = "lblAPN";
            this.lblAPN.Size = new System.Drawing.Size(65, 16);
            this.lblAPN.TabIndex = 44;
            this.lblAPN.Text = "Produto:";
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnA.Location = new System.Drawing.Point(157, 176);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(90, 42);
            this.btnA.TabIndex = 88;
            this.btnA.Text = "Abastecer";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // txtAP
            // 
            this.txtAP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAP.ForeColor = System.Drawing.Color.Black;
            this.txtAP.Location = new System.Drawing.Point(144, 29);
            this.txtAP.MaximumSize = new System.Drawing.Size(266, 20);
            this.txtAP.Name = "txtAP";
            this.txtAP.ReadOnly = true;
            this.txtAP.Size = new System.Drawing.Size(119, 20);
            this.txtAP.TabIndex = 89;
            // 
            // txtAV
            // 
            this.txtAV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAV.ForeColor = System.Drawing.Color.Black;
            this.txtAV.Location = new System.Drawing.Point(144, 78);
            this.txtAV.MaximumSize = new System.Drawing.Size(266, 20);
            this.txtAV.Name = "txtAV";
            this.txtAV.Size = new System.Drawing.Size(46, 20);
            this.txtAV.TabIndex = 90;
            this.txtAV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtAQ
            // 
            this.txtAQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAQ.ForeColor = System.Drawing.Color.Black;
            this.txtAQ.Location = new System.Drawing.Point(144, 132);
            this.txtAQ.MaximumSize = new System.Drawing.Size(266, 20);
            this.txtAQ.Name = "txtAQ";
            this.txtAQ.Size = new System.Drawing.Size(59, 20);
            this.txtAQ.TabIndex = 91;
            this.txtAQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAQ_KeyPress);
            // 
            // Abastecer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 230);
            this.Controls.Add(this.txtAQ);
            this.Controls.Add(this.txtAV);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblAPN);
            this.Controls.Add(this.lblAQ);
            this.Controls.Add(this.lblAV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abastecer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abastecimento";
            this.Load += new System.EventHandler(this.Abastecer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAV;
        private System.Windows.Forms.Label lblAQ;
        private System.Windows.Forms.Label lblAPN;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtAV;
        private System.Windows.Forms.TextBox txtAQ;
    }
}