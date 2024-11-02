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
    public partial class ReVendas : Form
    {
        public ReVendas()
        {
            InitializeComponent();
        }

        private void btnHBRPFun_Click(object sender, EventArgs e)
        {
            HomeFun abreHomeFun = new HomeFun();
            abreHomeFun.Show();
            this.Hide();
            abreHomeFun.FormClosed += (s, args) => this.Close();
        }

        private void ReVendas_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT DISTINCT Produto.nomeProduto FROM Produto JOIN Vendas ON Produto.IDProduto = Vendas.IDProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbxRVFunP.Items.Add(reader["nomeProduto"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar nomes dos produtos: " + ex.Message);
                }
            }
        }

        private void cbxRVFunP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = cbxRVFunP.SelectedItem.ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = @"SELECT Vendas.quantidadeProdutos, Vendas.valor, Vendas.dataVenda 
                     FROM Vendas
                     JOIN Produto ON Vendas.IDProduto = Produto.IDProduto
                     WHERE Produto.nomeProduto = @nomeProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeProduto", selectedProductName);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtRVFunQV.Text = reader["quantidadeProdutos"].ToString();
                        txtRVFunV.Text = reader["valor"].ToString();
                        DateTime dataVenda = (DateTime)reader["dataVenda"];
                        mskRPFunD.Text = dataVenda.ToString("dd/MM/yyyy");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados da venda: " + ex.Message);
                }
            }
        }
    }
}
