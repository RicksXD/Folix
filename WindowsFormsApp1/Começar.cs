using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSfunc_Click(object sender, EventArgs e)
        {
            Registro abreRegistro = new Registro();
            abreRegistro.Show();
            this.Hide();
            abreRegistro.FormClosed += (s, args) => this.Close();
        }

        private void btnSforne_Click(object sender, EventArgs e)
        {
            RegistroF abreRegistroF = new RegistroF();
            abreRegistroF.Show();
            this.Hide();
            abreRegistroF.FormClosed += (s, args) => this.Close();
        }
    }
}
