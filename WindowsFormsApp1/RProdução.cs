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
    public partial class RProdução : Form
    {
        public RProdução()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RProdução_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        public class ComboBoxItem
        {
            public int IDProduto { get; set; }
            public string NomeProduto { get; set; }

            public override string ToString()
            {
                return NomeProduto;
            }
        }

        private void cbxRPFun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRPFun.SelectedItem is ComboBoxItem selectedItem)
            {
                int idProduto = selectedItem.IDProduto;

                string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
                string query = @"
            SELECT 
                L.IDLote, 
                R.pHDoSolo, 
                R.nutrientesOrganicos, 
                R.sensorDeIrrigacao, 
                R.controleDePraga,
                R.dataRelatorio
            FROM 
                Lote L
            INNER JOIN 
                RelatorioDeProducao R ON L.IDLote = R.IDLote
            WHERE 
                L.IDProduto = @IDProduto";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDProduto", idProduto);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtRPFunL.Text = reader["IDLote"].ToString();
                                txtRPFunPH.Text = reader["pHDoSolo"].ToString();
                                txtRPFunNO.Text = reader["nutrientesOrganicos"].ToString();
                                txtRPFunSI.Text = reader["sensorDeIrrigacao"].ToString();
                                txtRPFunCP.Text = reader["controleDePraga"].ToString();

                                
                                DateTime dataRelatorio = (DateTime)reader["dataRelatorio"];
                                mskRPFunDR.Text = dataRelatorio.ToString("dd/MM/yyyy"); 
                            }
                            else
                            {
                                txtRPFunL.Clear();
                                txtRPFunPH.Clear();
                                txtRPFunNO.Clear();
                                txtRPFunSI.Clear();
                                txtRPFunCP.Clear();
                                mskRPFunDR.Clear(); 
                                MessageBox.Show("Nenhum lote encontrado para o produto selecionado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }
        }

        private void btnRPFunS_Click(object sender, EventArgs e)
        {

            int idLote;
            if (!int.TryParse(txtRPFunL.Text, out idLote))
            {
                MessageBox.Show("Por favor, selecione um lote válido.");
                return;
            }

            
            int idProduto = ObterIDProdutoSelecionado();
            if (idProduto == -1)
            {
                MessageBox.Show("Por favor, selecione um produto válido.");
                return;
            }

            
            DateTime dataRelatorio;
            if (!DateTime.TryParse(mskRPFunDR.Text, out dataRelatorio))
            {
                MessageBox.Show("Por favor, insira uma data válida.");
                return;
            }

            
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "INSERT INTO RelatorioDeProducao (IDLote, IDProduto, dataRelatorio) VALUES (@IDLote, @IDProduto, @dataRelatorio)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDLote", idLote);
                command.Parameters.AddWithValue("@IDProduto", idProduto);  
                command.Parameters.AddWithValue("@dataRelatorio", dataRelatorio);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Relatório de produção inserido com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir no banco de dados: " + ex.Message);
                }
            }
        }



        private void CarregarProdutos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT IDProduto, nomeProduto FROM Produto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ComboBoxItem item = new ComboBoxItem
                            {
                                IDProduto = (int)reader["IDProduto"],
                                NomeProduto = reader["nomeProduto"].ToString()
                            };
                            cbxRPFun.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }
            }
        }
        private int ObterIDProdutoSelecionado()
        {
            if (cbxRPFun.SelectedItem is ComboBoxItem selectedItem)
            {
                return selectedItem.IDProduto;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto.");
                return -1;
            }
        }

        private void pbxRPFunW1_Click(object sender, EventArgs e)
        {

        }
    }
}
