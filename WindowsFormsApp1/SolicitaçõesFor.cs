using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SolicitaçõesFor : Form
    {
        private Dictionary<int, string> solicitacoes = new Dictionary<int, string>();
        public SolicitaçõesFor()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.SolicitaçõesFor_Load);
        }

        public void SolicitarReabastecimento(int tabelaNum, string mensagem)
        {
            solicitacoes[tabelaNum] = mensagem;
            AtualizarSolicitacoes();
        }

        private void AtualizarSolicitacoes()
        {
            for (int i = 1; i <= 10; i++)
            {
                Control[] txts = this.Controls.Find("txtSForT" + i, true);
                if (txts.Length > 0 && txts[0] is TextBox)
                {
                    if (solicitacoes.ContainsKey(i))
                    {
                        ((TextBox)txts[0]).Text = solicitacoes[i];
                    }
                    else
                    {
                        ((TextBox)txts[0]).Text = "";
                    }
                }
            }

        }

        private void btnHBRFun_Click(object sender, EventArgs e)
        {
            HomeFor abreHomeFor = new HomeFor();
            abreHomeFor.Show();
            this.Hide();
            abreHomeFor.FormClosed += (s, args) => this.Close();
        }

        private void SolicitaçõesFor_Load(object sender, EventArgs e)
        {
            AtualizarSolicitacoes();
        }

        private void btnSForT1_Click(object sender, EventArgs e)
        {
            txtSForT1.Text = string.Empty;
            txtSForT1.Text = "Abastecido!";
        }

        private void btnSForT2_Click(object sender, EventArgs e)
        {
            txtSForT2.Text = string.Empty;
            txtSForT2.Text = "Abastecido!";
        }

        private void btnSForT3_Click(object sender, EventArgs e)
        {
            txtSForT3.Text = string.Empty;
            txtSForT3.Text = "Abastecido!";
        }

        private void btnSForT4_Click(object sender, EventArgs e)
        {
            txtSForT4.Text = string.Empty;
            txtSForT4.Text = "Abastecido!";
        }

        private void btnSForT5_Click(object sender, EventArgs e)
        {
            txtSForT5.Text = string.Empty;
            txtSForT5.Text = "Abastecido!";
        }

        private void btnSForT6_Click(object sender, EventArgs e)
        {
            txtSForT6.Text = string.Empty;
            txtSForT6.Text = "Abastecido!";
        }

        private void btnSForT7_Click(object sender, EventArgs e)
        {
            txtSForT7.Text = string.Empty;
            txtSForT7.Text = "Abastecido!";
        }

        private void btnSForT8_Click(object sender, EventArgs e)
        {
            txtSForT8.Text = string.Empty;
            txtSForT8.Text = "Abastecido!";
        }

        private void btnSForT9_Click(object sender, EventArgs e)
        {
            txtSForT9.Text = string.Empty;
            txtSForT9.Text = "Abastecido!";
        }

        private void btnSForT10_Click(object sender, EventArgs e)
        {
            txtSForT10.Text = string.Empty;
            txtSForT10.Text = "Abastecido!";
        }
    }
}
