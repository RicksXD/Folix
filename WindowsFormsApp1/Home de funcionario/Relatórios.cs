using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1
{
    public partial class Relatórios : Form
    {
        private Button btnSolicitarReabastecimento;
        private Dictionary<int, string> niveis = new Dictionary<int, string>();
        private SolicitaçõesFor solicitacoesForm;
        public Relatórios()
        {
            InitializeComponent();
        }

        public Relatórios(SolicitaçõesFor solicitacoesForm)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Relatórios_Load);
            this.solicitacoesForm = solicitacoesForm ?? throw new ArgumentNullException(nameof(solicitacoesForm));
        }
        private void btnHBRFun_Click(object sender, EventArgs e)
        {
            HomeFun abreHomeFun = new HomeFun();
            abreHomeFun.Show();
            this.Hide();
            abreHomeFun.FormClosed += (s, args) => this.Close();
        }

        private void pbxRFunG1_Click(object sender, EventArgs e)
        {

        }

        private void btnRFunT1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void btnRFunT10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnRFunT", ""));
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.SolicitarReabastecimento(tabelaNum, "Reabastecimento solicitado");
            RelatórioPop abreRelatórioPop = new RelatórioPop();
            abreRelatórioPop.Show();
        }

        private void Relatórios_Load(object sender, EventArgs e)
        {
           
        }

        public void AtualizarNivel(int tabelaNum, string nivelEstoque)
        {
            
            Control[] txts = this.Controls.Find("txtRFunT" + tabelaNum, true);

            if (txts.Length > 0 && txts[0] is TextBox)
            {
                
                ((TextBox)txts[0]).Text = nivelEstoque;
            }
        }
    }
}
