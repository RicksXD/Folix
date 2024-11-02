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
using WindowsFormsApp1.Home_de_fornecedor;
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
            LogoutFor();

            LogoutFor logoutFor = new LogoutFor();
            logoutFor.Show();
            this.Hide();
            logoutFor.FormClosed += (s, args) => this.Close();
        }

        private void LogoutFor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string deleteQuery = "DELETE FROM LoginFornecedor";

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
    }
}
