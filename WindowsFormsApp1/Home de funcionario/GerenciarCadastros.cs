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
    public partial class GerenciarCadastros : Form
    {
        public GerenciarCadastros()
        {
            InitializeComponent();
        }

        private void btnHBGCFun_Click(object sender, EventArgs e)
        {
            HomeFun abreHomeFun = new HomeFun();
            abreHomeFun.Show();
            this.Hide();
            abreHomeFun.FormClosed += (s, args) => this.Close();
        }

        private void GerenciarCadastros_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;

            
            string queryFuncionarios = "SELECT nomeCompleto FROM Cadastro";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryFuncionarios, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxGCFun.Items.Add(reader["nomeCompleto"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar nomes de funcionários: " + ex.Message);
                }
            }
            
            string queryFornecedores = "SELECT nomeCompleto FROM CadastroFornecedor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryFornecedores, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxGCFor.Items.Add(reader["nomeCompleto"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar nomes de fornecedores: " + ex.Message);
                }
            }
        }

        private void cbxGCFun_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cbxGCFun.SelectedItem.ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT * FROM Cadastro WHERE nomeCompleto = @nomeCompleto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeCompleto", selectedName);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtGCFN.Text = reader["nomeCompleto"].ToString();
                        mskGCFA.Text = reader["idade"].ToString();
                        txtGCFE.Text = reader["email"].ToString();
                        mskGCFT.Text = reader["telefone"].ToString();
                        mskGCFC.Text = reader["cpf"].ToString();
                        txtGCFP.Text = reader["senha"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados do funcionário: " + ex.Message);
                }
            }
        }

        private void btnGCFS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGCFN.Text) ||
                string.IsNullOrWhiteSpace(mskGCFA.Text) ||
                string.IsNullOrWhiteSpace(txtGCFE.Text) ||
                string.IsNullOrWhiteSpace(mskGCFT.Text) ||
                string.IsNullOrWhiteSpace(mskGCFC.Text) ||
                string.IsNullOrWhiteSpace(txtGCFP.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }


            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string updateQuery = @"UPDATE Cadastro
                           SET nomeCompleto = @nomeCompleto, idade = @idade, email = @telefone, telefone = @telefone, cpf = @cpf, senha = @senha
                           WHERE nomeCompleto = @nomeCompletoAntigo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@nomeCompleto", txtGCFN.Text);
                command.Parameters.AddWithValue("@idade", int.Parse(mskGCFA.Text));
                command.Parameters.AddWithValue("@telefone", long.Parse(mskGCFT.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")));
                command.Parameters.AddWithValue("@cpf", long.Parse(mskGCFC.Text.Replace(".", "").Replace("-", "")));
                command.Parameters.AddWithValue("@senha", txtGCFP.Text);


                command.Parameters.AddWithValue("@nomeCompletoAntigo", cbxGCFun.SelectedItem.ToString());

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        GCFPOPC abreGCFPOPC = new GCFPOPC();
                        abreGCFPOPC.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar informações.");
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    MessageBox.Show("Erro: Email ou CPF já cadastrado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnGCFE_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string deleteLoginQuery = "DELETE FROM Login WHERE IDCadastro = (SELECT IDCadastro FROM Cadastro WHERE nomeCompleto = @nomeCompleto)";
            string deleteCadastroQuery = "DELETE FROM Cadastro WHERE nomeCompleto = @nomeCompleto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand deleteLoginCommand = new SqlCommand(deleteLoginQuery, connection);
                SqlCommand deleteCadastroCommand = new SqlCommand(deleteCadastroQuery, connection);
                deleteLoginCommand.Parameters.AddWithValue("@nomeCompleto", cbxGCFun.SelectedItem.ToString());
                deleteCadastroCommand.Parameters.AddWithValue("@nomeCompleto", cbxGCFun.SelectedItem.ToString());

                try
                {
                    connection.Open();

                    
                    deleteLoginCommand.ExecuteNonQuery();

                    
                    int rowsAffected = deleteCadastroCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        GCFPOPE abreGCFPOPE = new GCFPOPE();
                        abreGCFPOPE.Show();
                        cbxGCFun.Items.Remove(cbxGCFun.SelectedItem);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o funcionário.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            txtGCFN.Text = "";
            mskGCFA.Text = "";
            txtGCFE.Text = "";
            mskGCFT.Text = "";
            mskGCFC.Text = "";
            txtGCFP.Text = "";
        }

        private void cbxGCFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cbxGCFor.SelectedItem.ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT * FROM CadastroFornecedor WHERE nomeCompleto = @nomeCompleto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeCompleto", selectedName);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtGCForN.Text = reader["nomeCompleto"].ToString();
                        mskGCForA.Text = reader["idade"].ToString();
                        txtGCForE.Text = reader["email"].ToString();
                        mskGCForT.Text = reader["telefone"].ToString();
                        mskGCForC.Text = reader["cpf"].ToString();
                        mskGCForCN.Text = reader["cnpj"].ToString();
                        txtGCForP.Text = reader["senha"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados do fornecedor: " + ex.Message);
                }
            }
        }

        private void btnGCForS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGCForN.Text) ||
                string.IsNullOrWhiteSpace(mskGCForA.Text) ||
                string.IsNullOrWhiteSpace(txtGCForE.Text) ||
                string.IsNullOrWhiteSpace(mskGCForT.Text) ||
                string.IsNullOrWhiteSpace(mskGCForC.Text) ||
                string.IsNullOrWhiteSpace(mskGCForCN.Text) ||
                string.IsNullOrWhiteSpace(txtGCForP.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string updateQuery = @"UPDATE CadastroFornecedor
                           SET nomeCompleto = @nomeCompleto, idade = @idade, email = @email, telefone = @telefone, cpf = @cpf, cnpj = @cnpj, senha = @senha
                           WHERE nomeCompleto = @nomeCompletoAntigo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@nomeCompleto", txtGCForN.Text);
                command.Parameters.AddWithValue("@idade", int.Parse(mskGCForA.Text));
                command.Parameters.AddWithValue("@email", txtGCForE.Text);
                command.Parameters.AddWithValue("@telefone", long.Parse(mskGCForT.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")));
                command.Parameters.AddWithValue("@cpf", long.Parse(mskGCForC.Text.Replace(".", "").Replace("-", "")));
                command.Parameters.AddWithValue("@cnpj", long.Parse(mskGCForCN.Text.Replace(".", "").Replace("/", "").Replace("-", "")));
                command.Parameters.AddWithValue("@senha", txtGCForP.Text);

                command.Parameters.AddWithValue("@nomeCompletoAntigo", cbxGCFor.SelectedItem.ToString());

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        GCFPOPC abreGCFPOPC = new GCFPOPC();
                        abreGCFPOPC.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar informações do fornecedor.");
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    MessageBox.Show("Erro: Email ou CPF já cadastrado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnGCForE_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string deleteQuery = "DELETE FROM CadastroFornecedor WHERE nomeCompleto = @nomeCompleto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@nomeCompleto", cbxGCFor.SelectedItem.ToString());

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        GCFPOPE abreGCFPOPE = new GCFPOPE();
                        abreGCFPOPE.Show();
                        cbxGCFor.Items.Remove(cbxGCFor.SelectedItem);
                        
                        LimparCamposFornecedor();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o fornecedor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
        }

        private void LimparCamposFornecedor()
        {
            txtGCForN.Text = "";
            mskGCForA.Text = "";
            txtGCForE.Text = "";
            mskGCForT.Text = "";
            mskGCForC.Text = "";
            mskGCForCN.Text = "";
            txtGCForP.Text = "";
        }
    }
}
