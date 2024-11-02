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

namespace WindowsFormsApp1.Home_de_funcionario
{
    public partial class Abastecer : Form
    {
        private string nomeProduto;
        private SolicitaçõesFor solicitacoesForm;
        private int tabelaNum;

        public Abastecer(string nomeProduto, SolicitaçõesFor solicitacoesForm, int tabelaNum)
        {
            InitializeComponent();
            this.nomeProduto = nomeProduto;
            this.solicitacoesForm = solicitacoesForm;
            this.tabelaNum = tabelaNum;
            txtAP.Text = nomeProduto;
        }

        public Abastecer()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Abastecer_Load(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(txtAV.Text);
            int quantidade = int.Parse(txtAQ.Text);
            int idProduto = GetIDProduto(nomeProduto);

            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string updateProdutoQuery = "UPDATE Produto SET quantidadeProduto = quantidadeProduto + @quantidade WHERE IDProduto = @idProduto";
            string checkVendasQuery = "SELECT COUNT(*) FROM Vendas WHERE IDProduto = @idProduto";
            string updateVendasQuery = "UPDATE Vendas SET valor = @valor, quantidadeProdutos = quantidadeProdutos + @quantidade, dataVenda = @dataVenda WHERE IDProduto = @idProduto";
            string insertVendasQuery = "INSERT INTO Vendas (IDProduto, valor, quantidadeProdutos, dataVenda) VALUES (@idProduto, @valor, @quantidade, @dataVenda)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand updateCommand = new SqlCommand(updateProdutoQuery, connection);
                updateCommand.Parameters.AddWithValue("@quantidade", quantidade);
                updateCommand.Parameters.AddWithValue("@idProduto", idProduto);

                SqlCommand checkCommand = new SqlCommand(checkVendasQuery, connection);
                checkCommand.Parameters.AddWithValue("@idProduto", idProduto);

                SqlCommand updateVendasCommand = new SqlCommand(updateVendasQuery, connection);
                updateVendasCommand.Parameters.AddWithValue("@valor", valor);
                updateVendasCommand.Parameters.AddWithValue("@quantidade", quantidade);
                updateVendasCommand.Parameters.AddWithValue("@dataVenda", DateTime.Now);
                updateVendasCommand.Parameters.AddWithValue("@idProduto", idProduto);

                SqlCommand insertVendasCommand = new SqlCommand(insertVendasQuery, connection);
                insertVendasCommand.Parameters.AddWithValue("@idProduto", idProduto);
                insertVendasCommand.Parameters.AddWithValue("@valor", valor);
                insertVendasCommand.Parameters.AddWithValue("@quantidade", quantidade);
                insertVendasCommand.Parameters.AddWithValue("@dataVenda", DateTime.Now);

                try
                {
                    connection.Open();
                    updateCommand.ExecuteNonQuery();

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {                     
                        updateVendasCommand.ExecuteNonQuery();
                    }
                    else
                    {                        
                        insertVendasCommand.ExecuteNonQuery();
                    }

                    solicitacoesForm.AtualizarTextBox(tabelaNum, "Abastecido!");

                    VendaPoP vendaPoP = new VendaPoP();
                    vendaPoP.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
        }

        private int GetIDProduto(string nomeProduto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT IDProduto FROM Produto WHERE nomeProduto = @nomeProduto";
            int idProduto = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        idProduto = (int)result;
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }

            return idProduto;
        }
        private void txtAQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
