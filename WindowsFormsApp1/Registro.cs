using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Text.RegularExpressions;
using CpfLibrary;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{


    public partial class Registro : Form
    {

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public Registro()
        {
            InitializeComponent();
            mskAge.MaskInputRejected += new MaskInputRejectedEventHandler(mskBDate_MaskInputRejected);
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) ||
                !string.IsNullOrWhiteSpace(mskAge.Text) ||
                !string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !string.IsNullOrWhiteSpace(mskTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")) ||
                !string.IsNullOrWhiteSpace(mskCpf.Text) ||
                !string.IsNullOrWhiteSpace(txtPassword.Text) ||
                !string.IsNullOrWhiteSpace(txtPassWC.Text))
            {  
                string connectionString = ConfigurationManager.ConnectionStrings["Folix"].ConnectionString;
                string query = "INSERT INTO Cadastro (nomeCompleto, idade, email, telefone, cpf, senha) VALUES (@nomeCompleto, @idade, @Email, @telefone, @cpf, @senha)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomeCompleto", txtName.Text);
                    command.Parameters.AddWithValue("@idade", int.Parse(mskAge.Text));
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@telefone", long.Parse(mskTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")));
                    command.Parameters.AddWithValue("@cpf", long.Parse(mskCpf.Text));
                    command.Parameters.AddWithValue("@senha", txtPassword.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Welcome abreWelcome = new Welcome();
                        abreWelcome.Show();
                        this.Hide();
                        abreWelcome.FormClosed += (s, args) => this.Close();
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
                Error popup = new Error();
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ShowDialog();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtName.Clear();
            mskAge.Clear();
            txtEmail.Clear();
            mskTel.Clear();
            mskCpf.Clear();
            txtPassword.Clear();
            txtPassWC.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Por favor, digite um nome");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            mskTel.Clear();
            mskCpf.Clear();
            mskAge.Clear();
            txtEmail.Clear();
            txtPassword.Clear();



            MessageBox.Show("Campos de cadastro limpos");

        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider6.SetError(this.txtPassword, "Por favor, digite uma Senha");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }

            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassWC.Text)
            {
                errorProvider7.SetError(this.txtPassWC, "Por favor, digite uma senha correspondente");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbxShowPassC_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbxShowPassC.Checked == true)
                {
                    txtPassWC.UseSystemPasswordChar = false;
                }

                else
                {
                    txtPassWC.UseSystemPasswordChar = true;
                }

            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void mskBDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (string.IsNullOrEmpty(mskAge.Text.Replace(" ", "")))
            {
                errorProvider2.SetError(this.mskAge, "Por favor, digite a Idade");
            }
            else
            {
                errorProvider2.Clear();
            }
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                errorProvider3.SetError(this.txtEmail, "Por favor, digite um Email");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start abreStart = new Start();
            abreStart.Show();
            this.Hide();
            abreStart.FormClosed += (s, args) => this.Close();
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                errorProvider5.SetError(this.mskCpf, "Cpf inválido");
            }
            else
            {
                errorProvider5.SetError(this.mskCpf, string.Empty);
            }
        }

        private void llblLoginFun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFUN abreLoginFUN = new LoginFUN();
            abreLoginFUN.Show();
            this.Hide();
            abreLoginFUN.FormClosed += (s, args) => this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (string.IsNullOrEmpty(mskTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")))
            {
                errorProvider4.SetError(this.mskTel, "Por favor, digite um número de telefone válido");
            }
            else
            {
                errorProvider4.Clear();

            }
        }

        private void mskAge_Click(object sender, EventArgs e)
        {
            mskAge.Select(0, 0);
        }

        private void mskAge_Enter(object sender, EventArgs e)
        {
            mskAge.Select(0, 0);
        }

        private void mskTel_Click(object sender, EventArgs e)
        {
            mskTel.Select(0, 0);
        }

        private void mskTel_Enter(object sender, EventArgs e)
        {
            mskTel.Select(0, 0);
        }

        private void mskCpf_Click(object sender, EventArgs e)
        {
            mskCpf.Select(0, 0);
        }

        private void mskCpf_Enter(object sender, EventArgs e)
        {
            mskCpf.Select(0, 0);
        }
    }
}
