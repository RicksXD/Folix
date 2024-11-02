using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Home_de_funcionario
{
    public partial class Logout : Form
    {
        private HomeFun homeFunForm;

        public Logout(HomeFun homeFunForm)
        {
            InitializeComponent();
            this.homeFunForm = homeFunForm;
        }
        public Logout()
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
