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
    public partial class HomeFor: Form
    {
        public HomeFor()
        {
            InitializeComponent();          
        }

        private void btnHforE_Click(object sender, EventArgs e)
        {
            EstoqueFor estoqueForForm = new EstoqueFor();
            estoqueForForm.Show();
            this.Hide();
            estoqueForForm.FormClosed += (s, args) => this.Close();
        }

        private void btnHForS_Click(object sender, EventArgs e)
        {
            var solicitacoesForm = FormManager.GetSolicitacoesForm();
            solicitacoesForm.Show();
            this.Hide();
            solicitacoesForm.FormClosed += (s, args) => this.Close();
        }

        private void HomeFor_Load(object sender, EventArgs e)
        {

        }

        private void btnLogoutFor_Click(object sender, EventArgs e)
        {
            Start abreStart = new Start();
            abreStart.Show();
            this.Hide();
            abreStart.FormClosed += (s, args) => this.Close();
        }
    }

}
