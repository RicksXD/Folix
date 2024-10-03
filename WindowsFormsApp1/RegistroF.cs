using CpfLibrary;
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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class RegistroF : Form
    {
        public RegistroF()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBackRF_Click(object sender, EventArgs e)
        {
            txtNameF.Clear();
            mskCpfF.Clear();
            txtEmailF.Clear();
            mskTelF.Clear();
            mskCNPJF.Clear();
            txtPWF.Clear();
            txtPWCF.Clear();

            MessageBox.Show("Campos de cadastro limpos");
        }

        private void btnBackF_Click(object sender, EventArgs e)
        {
            Start abreStartf = new Start();
            abreStartf.Show();
            this.Hide();
            abreStartf.FormClosed += (s, args) => this.Close();
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassF.Checked == true)
            {
                txtPWF.UseSystemPasswordChar = false;
            }

            else
            {
                txtPWF.UseSystemPasswordChar = true;
            }
        }

        private void txtPWF_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPWF.Text) == true)
            {
                errorProvider7F.SetError(this.txtPWF, "Por favor, digite uma Senha");
            }
            else
            {
                errorProvider7F.Clear();
            }
        }

        private void cbxShowPassCF_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassCF.Checked == true)
            {
                txtPWCF.UseSystemPasswordChar = false;
            }

            else
            {
                txtPWCF.UseSystemPasswordChar = true;
            }
        }

        private void mskBdateF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string telefone = mskTelF.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (string.IsNullOrEmpty(telefone) || telefone.Length != 10 && telefone.Length != 11)
            {
                errorProvider4F.SetError(mskTelF, "Por favor, digite um telefone válido.");
            }
            else
            {
                errorProvider4F.Clear();
            }
        }

        private void txtNameF_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameF.Text) == true)
            {
                errorProvider1F.SetError(this.txtNameF, "Por favor, digite um nome");
            }
            else
            {
                errorProvider1F.Clear();
            }
        }

        private void txtSurnameF_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mskAgeF.Text) == true)
            {
                errorProvider2F.SetError(this.mskAgeF, "Por favor, digite uma idade");
            }
            else
            {
                errorProvider2F.Clear();
            }
        }

        private void mskCNPJF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmailF_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailF.Text) == true)
            {
                errorProvider3F.SetError(this.txtEmailF, "Por favor, digite um Email");
            }
            else
            {
                errorProvider3F.Clear();
            }
        }

        private void txtPWCF_TextChanged(object sender, EventArgs e)
        {
            if (txtPWCF.Text != txtPWF.Text)
            {
                errorProvider8F.SetError(this.txtPWCF, "Por favor, digite uma senha correspondente");
            }
            else
            {
                errorProvider8F.Clear();
            }
        }

        private void btnRegisterF_Click(object sender, EventArgs e)
        {

            string cnpj = mskCNPJF.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "");

            if (!string.IsNullOrWhiteSpace(txtNameF.Text) ||
                !string.IsNullOrWhiteSpace(mskAgeF.Text) ||
                !string.IsNullOrWhiteSpace(txtEmailF.Text) ||
                !string.IsNullOrWhiteSpace(mskTelF.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")) ||
                !string.IsNullOrWhiteSpace(mskCpfF.Text) ||
                !string.IsNullOrWhiteSpace(cnpj) && cnpj.Length == 14 ||
                !string.IsNullOrWhiteSpace(txtPWF.Text) ||
                !string.IsNullOrWhiteSpace(txtPWCF.Text))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
                string query = "INSERT INTO CadastroFornecedor (nomeCompleto, idade, email, telefone, cpf, cnpj, senha) VALUES (@nomeCompleto, @idade, @Email, @telefone, @cpf, @cnpj, @senha)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomeCompleto", txtNameF.Text);
                    command.Parameters.AddWithValue("@idade", int.Parse(mskAgeF.Text));
                    command.Parameters.AddWithValue("@Email", txtEmailF.Text);
                    command.Parameters.AddWithValue("@telefone", long.Parse(mskTelF.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")));
                    command.Parameters.AddWithValue("@cpf", long.Parse(mskCpfF.Text.Replace(".", "").Replace("-", "").Replace(" ", "")));
                    command.Parameters.AddWithValue("@cnpj", long.Parse(cnpj));
                    command.Parameters.AddWithValue("@senha", txtPWF.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Wfor popup = new Wfor();
                        popup.Show();
                        this.Hide();
                        popup.FormClosed += (s, args) => this.Close();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }
            else
            {
                ErrorFor popup = new ErrorFor();
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ShowDialog();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtNameF.Clear();
            mskAgeF.Clear();
            txtEmailF.Clear();
            mskTelF.Clear();
            mskCNPJF.Clear();
            mskCpfF.Clear();
            txtPWF.Clear();
            txtPWCF.Clear();
        }
        private bool HasErrors()
        {
            foreach (Control control in this.Controls)
            {
                if (errorProvider1F.GetError(control) != string.Empty ||
                    errorProvider2F.GetError(control) != string.Empty ||
                    errorProvider3F.GetError(control) != string.Empty ||
                    errorProvider4F.GetError(control) != string.Empty ||
                    errorProvider6F.GetError(control) != string.Empty ||
                    errorProvider7F.GetError(control) != string.Empty ||
                    errorProvider8F.GetError(control) != string.Empty
                    )
                {
                    return true;
                }
            }
            return false;
        }

        private void mskCNPJF_Leave(object sender, EventArgs e)
        {
            string cnpj = mskCNPJF.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "");
            cnpj = new string(mskCNPJF.Text.Where(char.IsDigit).ToArray());

            if (cnpj.Length != 14)
            {
                errorProvider5F.SetError(this.mskCNPJF, "CNPJ inválido");
            }
            else
            {
                errorProvider5F.SetError(this.mskCNPJF, string.Empty);

            }
        }

        private void llblLoginFor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFor abreLoginFor = new LoginFor();
            abreLoginFor.Show();
            this.Hide();
            abreLoginFor.FormClosed += (s, args) => this.Close();
        }

        private void RegistroF_Load(object sender, EventArgs e)
        {

        }

        private void mskA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (string.IsNullOrEmpty(mskAgeF.Text.Replace(" ", "")))
            {
                errorProvider2F.SetError(this.mskAgeF, "Por favor, digite a Idade");
            }
            else
            {
                errorProvider2F.Clear();
            }
        }

        private void mskAgeF_Click(object sender, EventArgs e)
        {
            mskAgeF.Select(0, 0);
        }

        private void mskAgeF_Enter(object sender, EventArgs e)
        {
            mskAgeF.Select(0, 0);
        }

        private void mskBtelF_Click(object sender, EventArgs e)
        {
            mskTelF.Select(0, 0);
        }

        private void mskTelF_Enter(object sender, EventArgs e)
        {
            mskTelF.Select(0, 0);
        }

        private void mskCNPJF_Click(object sender, EventArgs e)
        {
            mskCNPJF.Select(0, 0);
        }

        private void mskCNPJF_Enter(object sender, EventArgs e)
        {
            mskCNPJF.Select(0, 0);
        }

        private void mskCpfF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = mskCpfF.Text.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            {
                errorProvider5F.SetError(mskCpfF, "Por favor, digite um CPF válido.");
            }
            else
            {
                errorProvider5F.Clear();
            }
        }

        private void mskCpfF_Enter(object sender, EventArgs e)
        {
            mskCpfF.Select(0, 0);
        }

        private void mskCpfF_Leave(object sender, EventArgs e)
        {
            string cpf = mskCpfF.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
            
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            {
                errorProvider5F.SetError(mskCpfF, "Por favor, digite um CPF válido.");
            }
            else
            {
                errorProvider5F.Clear();
            }
        }

        private void mskCpfF_Click(object sender, EventArgs e)
        {
            mskCpfF.Select(0, 0);
        }
    }
}
