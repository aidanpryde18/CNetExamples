using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit6_Project
{
    public partial class frmPredict : Form
    {
        public frmPredict()
        {
            InitializeComponent();
        }

        private void frmPredict_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the Prediction Form
            this.Close();
        }
    }
}
