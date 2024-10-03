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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class EstoqueFun : Form
    {
        public EstoqueFun()
        {
            InitializeComponent();
        }      
        private void CarregarDadosEstoque()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT IDProduto, nomeProduto, produtoImagem, quantidadeProduto, valorKg FROM Produto WHERE IDProduto BETWEEN 1 AND 10 ORDER BY IDProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int tabelaNum = 1;
                        while (reader.Read() && tabelaNum <= 10)
                        {
                            int idProduto = (int)reader["IDProduto"];
                            string nomeProduto = reader["nomeProduto"].ToString();
                            string caminhoImagem = reader["produtoImagem"].ToString();
                            int quantidadeProduto = (int)reader["quantidadeProduto"];
                            decimal valorKg = (decimal)reader["valorKg"];

                            
                            Control[] lbls = this.Controls.Find("lblEFunF" + tabelaNum, true);
                            if (lbls.Length > 0)
                            {
                                lbls[0].Text = nomeProduto;
                            }

                            
                            Control[] pbxs = this.Controls.Find("pbxEFunItem" + tabelaNum, true);
                            if (pbxs.Length > 0 && pbxs[0] is PictureBox)
                            {
                                PictureBox pbx = (PictureBox)pbxs[0];
                                pbx.Image = Image.FromFile(caminhoImagem);
                                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                            }

                            
                            Control[] txtQuantidades = this.Controls.Find("txtEFunQ" + tabelaNum, true);
                            if (txtQuantidades.Length > 0)
                            {
                                txtQuantidades[0].Text = quantidadeProduto.ToString();
                            }

                            
                            Control[] txtPrecos = this.Controls.Find("txtEFunP" + tabelaNum, true);
                            if (txtPrecos.Length > 0)
                            {
                                txtPrecos[0].Text = valorKg.ToString();
                            }

                            tabelaNum++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados do banco de dados: " + ex.Message);
                }
            }
        }

        private void btnHBEFun_Click(object sender, EventArgs e)
        {
            HomeFun abreHomeFun = new HomeFun();
            abreHomeFun.Show();
            this.Hide();
            abreHomeFun.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEFunF2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblEFunRC_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idProduto = int.Parse(txtEFunRC.Text); 
            int tabelaNum = int.Parse(txtEFunRT.Text); 

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT nomeProduto, produtoImagem FROM Produto WHERE IDProduto = @idProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProduto", idProduto);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomeProduto = reader["nomeProduto"].ToString();

                            
                            if (tabelaNum >= 1 && tabelaNum <= 10)
                            {
                               
                                Control[] lbls = this.Controls.Find("lblEFunF" + tabelaNum, true);
                                if (lbls.Length > 0)
                                {
                                    lbls[0].Text = "(           )";
                                }

                              
                                Control[] pbxs = this.Controls.Find("pbxEFunItem" + tabelaNum, true);
                                if (pbxs.Length > 0 && pbxs[0] is PictureBox)
                                {
                                    PictureBox pbx = (PictureBox)pbxs[0];
                                    pbx.Image = null; 
                                }
                            }

                            reader.Close();
                            
                            string updateQuery = "UPDATE Produto SET quantidadeProduto = 0, valorKg = 0 WHERE IDProduto = @idProduto";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@idProduto", idProduto);
                                updateCommand.ExecuteNonQuery();
                            }

                            RemoverPop abreRemoverPop = new RemoverPop();
                            abreRemoverPop.Show();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
            txtEFunRC.Clear();
            txtEFunRT.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idProduto = int.Parse(txtEFunAC.Text);
            int tabelaNum = int.Parse(txtEFunAT.Text);

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT nomeProduto, produtoImagem FROM Produto WHERE IDProduto = @idProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProduto", idProduto);

                try
                {
                    connection.Open();

                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomeProduto = reader["nomeProduto"].ToString();
                            string produtoImagem = reader["produtoImagem"].ToString();

                            
                            if (tabelaNum >= 1 && tabelaNum <= 10)
                            {
                                Control[] lbls = this.Controls.Find("lblEFunF" + tabelaNum, true);
                                if (lbls.Length > 0)
                                {
                                    lbls[0].Text = nomeProduto;
                                }

                                Control[] pbxs = this.Controls.Find("pbxEFunItem" + tabelaNum, true);
                                if (pbxs.Length > 0 && pbxs[0] is PictureBox)
                                {
                                    PictureBox pbx = (PictureBox)pbxs[0];
                                    pbx.Image = Image.FromFile(produtoImagem);
                                    pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }

                           
                            AdicionarPop abreAdicionarPop = new AdicionarPop();
                            abreAdicionarPop.Show();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado!");
                            return; 
                        }
                    } 

                    
                    string insertLoteQuery = "INSERT INTO Lote (IDProduto, dataProducao, dataVencimento, kgLote) VALUES (@IDProduto, @dataProducao, @dataVencimento, @kgLote)";

                    
                    DateTime dataProducao = DateTime.Parse(mskEFunADP.Text); 
                    DateTime dataVencimento = DateTime.Parse(mskEFunADV.Text); 
                    decimal kgLote = decimal.Parse(txtEFunAKG.Text); 

                    
                    using (SqlCommand insertCommand = new SqlCommand(insertLoteQuery, connection))
                    {
                        
                        insertCommand.Parameters.AddWithValue("@IDProduto", idProduto);
                        insertCommand.Parameters.AddWithValue("@dataProducao", dataProducao);
                        insertCommand.Parameters.AddWithValue("@dataVencimento", dataVencimento);
                        insertCommand.Parameters.AddWithValue("@kgLote", kgLote);

                        
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Dados do lote inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }

           
            txtEFunAC.Clear();
            txtEFunAT.Clear();
            mskEFunADP.Clear(); 
            mskEFunADV.Clear(); 
            txtEFunAKG.Clear(); 
        }

        private void btnEFunA1_Click(object sender, EventArgs e)
        {
            
            int quantidade = int.Parse(txtEFunQ1.Text);
            decimal valorKg = decimal.Parse(txtEFunP1.Text);
            string nomeProduto = lblEFunF1.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA2_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ2.Text);
            decimal valorKg = decimal.Parse(txtEFunP2.Text);
            string nomeProduto = lblEFunF2.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA3_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ3.Text);
            decimal valorKg = decimal.Parse(txtEFunP3.Text);
            string nomeProduto = lblEFunF3.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA4_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ4.Text);
            decimal valorKg = decimal.Parse(txtEFunP4.Text);
            string nomeProduto = lblEFunF4.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA5_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ5.Text);
            decimal valorKg = decimal.Parse(txtEFunP5.Text);
            string nomeProduto = lblEFunF5.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA6_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ6.Text);
            decimal valorKg = decimal.Parse(txtEFunP6.Text);
            string nomeProduto = lblEFunF6.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA7_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ7.Text);
            decimal valorKg = decimal.Parse(txtEFunP7.Text);
            string nomeProduto = lblEFunF7.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA8_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ8.Text);
            decimal valorKg = decimal.Parse(txtEFunP8.Text);
            string nomeProduto = lblEFunF8.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA9_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ9.Text);
            decimal valorKg = decimal.Parse(txtEFunP9.Text);
            string nomeProduto = lblEFunF9.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void btnEFunA10_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtEFunQ10.Text);
            decimal valorKg = decimal.Parse(txtEFunP10.Text);
            string nomeProduto = lblEFunF10.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "UPDATE Produto SET quantidadeProduto = @quantidade, valorKg = @valorKg WHERE nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@valorKg", valorKg);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o banco de dados: " + ex.Message);
                }
            }
        }

        private void pbxEFunItem1_Click(object sender, EventArgs e)
        {

        }

        private void EstoqueFun_Load(object sender, EventArgs e)
        {
            CarregarDadosEstoque();
        }
    }
}

