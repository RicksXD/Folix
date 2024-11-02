using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Home_de_fornecedor
{
    public partial class LogoutFor : Form
    {
        public LogoutFor()
        {
            InitializeComponent();
        }

        private void btnLPoP_Click(object sender, EventArgs e)
        {
            Start abreStart = new Start();
            abreStart.Show();
            this.Hide();
            abreStart.FormClosed += (s, args) => this.Close();
        }
    }
}
