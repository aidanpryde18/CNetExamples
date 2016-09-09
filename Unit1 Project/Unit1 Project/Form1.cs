using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1_Project
{
    public partial class frmIntrodution : Form
    {
        public frmIntrodution()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            short first, second;

            first = 300;
            second = 50;

            lblName.Text = Convert.ToString(first + second);
        }
    }
}
