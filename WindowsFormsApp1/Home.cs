using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1
{
    public partial class HomeFun : Form
    {
        public HomeFun()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var relatorioForm = FormManager.GetRelatorioForm();
            relatorioForm.Show();
            this.Hide();
            relatorioForm.FormClosed += (s, args) => this.Close();
        }

        private void btnHfunE_Click(object sender, EventArgs e)
        {
            EstoqueFun abreEstoqueFun = new EstoqueFun();
            abreEstoqueFun.Show();
            this.Hide();
            abreEstoqueFun.FormClosed += (s, args) => this.Close();
        }

        private void HomeFun_Load(object sender, EventArgs e)
        {

        }

        private void btnLogoutFun_Click(object sender, EventArgs e)
        {
              Start abreStart = new Start();
              abreStart.Show();
              this.Hide();
              abreStart.FormClosed += (s, args) => this.Close();
        }
        public static class UserSession
        {
            public static int UserId { get; set; }
        }

        private void btnHFunRP_Click(object sender, EventArgs e)
        {
            RProdução abreRProdução = new RProdução();
            abreRProdução.Show();
            this.Hide();
            abreRProdução.FormClosed += (s, args) => this.Close();
        }

        private void btnHFunRF_Click(object sender, EventArgs e)
        {
            ReFornecedor abreReFornecedor = new ReFornecedor();
            abreReFornecedor.Show();
            this.Hide();
            abreReFornecedor.FormClosed += (s, args) => this.Close();
        }
    }
}
