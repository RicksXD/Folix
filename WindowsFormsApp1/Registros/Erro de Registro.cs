using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnOKError_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
