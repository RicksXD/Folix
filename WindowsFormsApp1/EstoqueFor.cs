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
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1
{
    public partial class EstoqueFor : Form
    {
        private Relatórios relatorioForm;
        public EstoqueFor()
        {
            InitializeComponent();
        }
        public EstoqueFor(Relatórios relatorioForm)
        {
            InitializeComponent();
            this.relatorioForm = relatorioForm ?? throw new ArgumentNullException(nameof(relatorioForm));
        }
        public void SetRelatorioForm(Relatórios relatorioForm)
        {
            this.relatorioForm = relatorioForm ?? throw new ArgumentNullException(nameof(relatorioForm));
        }
        private void CarregarDadosEstoqueFornecedor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
            string query = "SELECT IDProduto, nomeProduto, produtoImagem, quantidadeProduto FROM Produto WHERE IDProduto BETWEEN 1 AND 10 ORDER BY IDProduto";

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

                            
                            Control[] lbls = this.Controls.Find("lblEForF" + tabelaNum, true);
                            if (lbls.Length > 0)
                            {
                                lbls[0].Text = nomeProduto;
                            }

                           
                            Control[] pbxs = this.Controls.Find("pbxEForItem" + tabelaNum, true);
                            if (pbxs.Length > 0 && pbxs[0] is PictureBox)
                            {
                                PictureBox pbx = (PictureBox)pbxs[0];
                                pbx.Image = Image.FromFile(caminhoImagem);
                                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                            }

                            
                            Control[] txtQuantidades = this.Controls.Find("txtEForQ" + tabelaNum, true);
                            if (txtQuantidades.Length > 0)
                            {
                                txtQuantidades[0].Text = quantidadeProduto.ToString();
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
            HomeFor abreHomeFor = new HomeFor();
            abreHomeFor.Show();
            this.Hide();
            abreHomeFor.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEforG10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEforG", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível bom");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForOK10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForOK", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível ok");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void btnEForA10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tabelaNum = int.Parse(btn.Name.Replace("btnEForA", ""));
            FormManager.AtualizarEstoqueNoRelatorio(tabelaNum, "Nível baixo");
            RelatórioForPop abreRelatórioForPop = new RelatórioForPop();
            abreRelatórioForPop.Show();
        }

        private void EstoqueFor_Load(object sender, EventArgs e)
        {
            CarregarDadosEstoqueFornecedor();
            Relatórios relatorioForm = new Relatórios();
            EstoqueFor estoqueFor = new EstoqueFor(relatorioForm);
        }
    }
}
