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
    public partial class Wfor : Form
    {
        public Wfor()
        {
            InitializeComponent();
        }

        private void btnWF_Click(object sender, EventArgs e)
        {
            LoginFor abreLoginFor = new LoginFor();
            abreLoginFor.Show();
            this.Hide();
            abreLoginFor.FormClosed += (s, args) => this.Close();
        }
    }
}
