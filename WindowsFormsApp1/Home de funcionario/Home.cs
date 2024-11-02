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
using WindowsFormsApp1.Home_de_funcionario;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1
{
    public partial class HomeFun : Form
    {
        public HomeFun()
        {
            InitializeComponent();
        }
        private void Deslogar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string deleteQuery = "DELETE FROM Login";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
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
        private void btnLogoutFun_Click(object sender, EventArgs e)
        {
            Deslogar();
            Logout logout = new Logout();
            logout.Show();
            this.Hide();
            logout.FormClosed += (s, args) => this.Close();
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
            ReVendas abreReFornecedor = new ReVendas();
            abreReFornecedor.Show();
            this.Hide();
            abreReFornecedor.FormClosed += (s, args) => this.Close();
        }

        private void btnHFunGC_Click(object sender, EventArgs e)
        {
            GerenciarCadastros abreGC = new GerenciarCadastros();
            abreGC.Show();
            this.Hide();
            abreGC.FormClosed += (s, args) => this.Close();
        }
    }
}
