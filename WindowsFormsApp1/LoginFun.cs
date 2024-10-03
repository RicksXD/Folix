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
using static WindowsFormsApp1.Utils.FormManager;

namespace WindowsFormsApp1
{
    public partial class LoginFUN : Form
    {
        public LoginFUN()
        {
            InitializeComponent();           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSPWFUN.Checked == true)
            {
                txtPWFUN.UseSystemPasswordChar = false;
            }

            else
            {
                txtPWFUN.UseSystemPasswordChar = true;
            }
        }

        private void txtUserFUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBLoginFun_Click(object sender, EventArgs e)
        {

        }

        private void btnBLoginFun_Click_1(object sender, EventArgs e)
        {
            Registro abreRegistro = new Registro();
            abreRegistro.Show();
            this.Hide();
            abreRegistro.FormClosed += (s, args) => this.Close();
        }

        private void btnLoginFun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserFUN.Text) || string.IsNullOrWhiteSpace(txtPWFUN.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios antes de prosseguir.");
            }
            else
            {
                string usuario = txtUserFUN.Text;
                string senha = txtPWFUN.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
                string query = "SELECT IDCadastro FROM Cadastro WHERE (email = @Usuario OR cpf = @Usuario) AND senha = @Senha";

                if (long.TryParse(usuario, out long cpf))
                {
                    query = "SELECT IDCadastro FROM Cadastro WHERE cpf = @Usuario AND senha = @Senha";
                }
                else
                {
                    query = "SELECT IDCadastro FROM Cadastro WHERE email = @Usuario AND senha = @Senha";
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
                            UserSession.UserId = idCadastro;
                            string insertLoginQuery = "INSERT INTO Login (IDCadastro) VALUES (@IDCadastro)";
                            SqlCommand insertCommand = new SqlCommand(insertLoginQuery, connection);
                            insertCommand.Parameters.AddWithValue("@IDCadastro", idCadastro);
                            insertCommand.ExecuteNonQuery();
                            HomeFun HomeFun = new HomeFun();
                            HomeFun.Show();
                            this.Hide();
                            HomeFun.FormClosed += (s, args) => this.Close();
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

        private void LoginFUN_Load(object sender, EventArgs e)
        {

        }
    }
}
