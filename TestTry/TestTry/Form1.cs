using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            int[] numbers = new int[4];

            for (int index = 0;  index < numbers.Length; index++)
            {          
                numbers[index] = index * 4;

            }

            foreach (int val in numbers)

            {

                lblResult.Text = lblResult.Text + ", " + val.ToString();

            }

        }
    }
}
