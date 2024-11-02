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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOKCheck_Click(object sender, EventArgs e)
        {                 
            LoginFUN abreLoginFUN = new LoginFUN();
            abreLoginFUN.Show();
            this.Hide();
            abreLoginFUN.FormClosed += (s, args) => this.Close();
        }
    }
}
