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

namespace WindowsFormsApp1
{
    public partial class SolicitaçõesFor : Form
    {
        private Dictionary<int, string> solicitacoes = new Dictionary<int, string>();
        public SolicitaçõesFor()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.SolicitaçõesFor_Load);
        }

        public void SolicitarReabastecimento(int tabelaNum, string mensagem)
        {
            solicitacoes[tabelaNum] = mensagem;
            AtualizarSolicitacoes();
        }

        private void AtualizarSolicitacoes()
        {
            for (int i = 1; i <= 10; i++)
            {
                Control[] txts = this.Controls.Find("txtSForT" + i, true);
                if (txts.Length > 0 && txts[0] is TextBox)
                {
                    if (solicitacoes.ContainsKey(i))
                    {
                        ((TextBox)txts[0]).Text = solicitacoes[i];
                    }
                    else
                    {
                        ((TextBox)txts[0]).Text = "";
                    }
                }
            }

        }
        private void btnHBRFun_Click(object sender, EventArgs e)
        {
            HomeFor abreHomeFor = new HomeFor();
            abreHomeFor.Show();
            this.Hide();
            abreHomeFor.FormClosed += (s, args) => this.Close();
        }

        private void SolicitaçõesFor_Load(object sender, EventArgs e)
        {
            AtualizarSolicitacoes();
        }

        public void AtualizarTextBox(int tabelaNum, string mensagem)
        {
            Control[] txts = this.Controls.Find("txtSForT" + tabelaNum, true);
            if (txts.Length > 0 && txts[0] is TextBox)
            {
                ((TextBox)txts[0]).Text = mensagem;
            }
        }

        private void btnSForT1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private void btnSForT10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnSForT", ""));
            string nomeProduto = GetNomeProdutoFromID(tabelaNum);

            Abastecer abastecerForm = new Abastecer(nomeProduto, this, tabelaNum);
            abastecerForm.ShowDialog();
        }

        private string GetNomeProdutoFromID(int idProduto)
        {
            string nomeProduto = "";
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT nomeProduto FROM Produto WHERE IDProduto = @idProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProduto", idProduto);

                try
                {
                    connection.Open();
                    nomeProduto = command.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }

            return nomeProduto;
        }
    }
}
