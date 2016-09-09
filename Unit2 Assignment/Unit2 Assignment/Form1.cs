using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit2_Assignment
{
    public partial class frmGreetings : Form
    {
        public frmGreetings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the Form
            this.Close();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            //Declares Age variables for testing and for calculation for String Output
            int currentAge, futureAge;

            //Verifies that the user has entered a valid integer into the Age Text Box
            if (int.TryParse(txtAge.Text, out currentAge))
            {
                //Verifies that the user has selected a favorite food.
                if (cmbFood.SelectedIndex > -1)
                {                  
                    //Adds 10 years to the user's entered current age
                    futureAge = currentAge + 10;

                    //Opens a Message Box that tells the user their age in 10 years and that they will still love their current favorite food.
                    MessageBox.Show("In 10 years, your age will be " + futureAge.ToString() + " and still like " + cmbFood.Text + " the most.");       
                }
                else
                {
                    //Displays a warning that they should select a favorite food.
                    MessageBox.Show("Please select your favorite food.");
                }
               
            }
            else
            {
                //Displays a warning that they can only enter integers into the Age Text Box.
                MessageBox.Show("Please enter a number into the age text box");
            }           
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            if (cmbFood.SelectedIndex > -1)
            {
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    //Displays a warning that they should enter their name.
                    MessageBox.Show("Please enter your name.");
                }
                else
                {
                    //Unhides the Greeting label box
                    lblGreet.Visible = true;

                    //Displays the Greeting in the Greeting Label
                    lblGreet.Text = "Hi " + txtName.Text + ", my favorite food is " + cmbFood.Text + " too!";
                }
                   
            }
            else
            {
                //Displays a warning that they should select a favorite food.
                MessageBox.Show("Please select your favorite food.");
            }
           
                        
        }
    }
}
