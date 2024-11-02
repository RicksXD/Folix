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

namespace WindowsFormsApp1
{
    public partial class LoginFor : Form
    {
        public LoginFor()
        {
            InitializeComponent();
        }

        private void cbxSPWFOR_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSPWFOR.Checked == true)
            {
                txtPWFOR.UseSystemPasswordChar = false;
            }

            else
            {
                txtPWFOR.UseSystemPasswordChar = true;
            }
        }

        private void txtUserFOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBLoginFor_Click(object sender, EventArgs e)
        {
            RegistroF abreRegistroF = new RegistroF();
            abreRegistroF.Show();
            this.Hide();
            abreRegistroF.FormClosed += (s, args) => this.Close();
        }

        private void btnLoginFor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserFOR.Text) || string.IsNullOrWhiteSpace(txtPWFOR.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios antes de prosseguir.");
            }
            else
            {
                string usuario = txtUserFOR.Text;
                string senha = txtPWFOR.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
                string query = "SELECT IDCadastroFornecedor FROM CadastroFornecedor WHERE (email = @Usuario OR cpf = @Usuario) AND senha = @Senha";

                if (long.TryParse(usuario, out long cpf))
                {
                    query = "SELECT IDCadastroFornecedor FROM CadastroFornecedor WHERE cpf = @Usuario AND senha = @Senha";
                }
                else
                {
                    query = "SELECT IDCadastroFornecedor FROM CadastroFornecedor WHERE email = @Usuario AND senha = @Senha";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int idCadastro = Convert.ToInt32(result);
                            string insertLoginQuery = "INSERT INTO LoginFornecedor (IDCadastroFornecedor) VALUES (@IDCadastroFornecedor)";
                            SqlCommand insertCommand = new SqlCommand(insertLoginQuery, connection);
                            insertCommand.Parameters.AddWithValue("@IDCadastroFornecedor", idCadastro);
                            insertCommand.ExecuteNonQuery();
                            HomeFor HomeFor = new HomeFor();
                            HomeFor.Show();
                            this.Hide();
                            HomeFor.FormClosed += (s, args) => this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }
        }

        private void LoginFor_Load(object sender, EventArgs e)
        {

        }
    }
}
