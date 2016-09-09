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
    public partial class frmMain : Form
    {
        private Person newUser = new Person();          //creates a new instance of the person class that will be used by this program
        private frmPredict predict = new frmPredict();  //creates a new instance of the Prediction form so it can be altered later on

        public frmMain()
        {
            InitializeComponent();
        }

        // Method to check that all of the input on the form is valid and within range.
        private bool validateInput()
        {
            byte currentAge;    //variable used to hold the age value for comparison

            //This first statement checks to make sure that the user entered some text in the Name text box
            if (String.IsNullOrEmpty(txtName.Text))                
            {
                //Displays a warning that they should enter their name.
                MessageBox.Show("Please enter your name.");

                // Returns a value of false so that the calling method will not move forward.
                return false;
            }
            else
            {
                //If the there is some text in the name box, it then checks to see if they selected an item in the food combo box.
                if (cmbFood.SelectedIndex > -1)
                {
                    //Next it checks to see if they entered a valid byte-sized integer into the age box.
                    if (byte.TryParse(txtAge.Text, out currentAge))
                    {
                        //Once the number has been validated for byte, it then checks to ensure the number is less than 120, making it a valid age.
                        if (currentAge <= 120)
                        {
                            //Once everything is successfully validated, the entered values are assigned to their respective class properties.
                            newUser.Name = txtName.Text;
                            newUser.Food = cmbFood.Text;
                            newUser.Age = currentAge;

                            //Returns a value of True to let the calling method know that validation was successful.
                            return true;
                        }
                        else
                        {
                            //Displays a warning that they can only enter valid ages into the Age Text Box.
                            MessageBox.Show("Please enter a number between 1 and 120 into the age text box");

                            // Returns a value of false so that the calling method will not move forward.
                            return false;
                        }
                    }
                    else
                    {
                        //Displays a warning that they can only enter valid ages into the Age Text Box.
                        MessageBox.Show("Please enter a number between 1 and 120 into the age text box");

                        // Returns a value of false so that the calling method will not move forward.
                        return false;
                    }
                    
                }
                else
                {
                    //Displays a warning that they should select a favorite food.
                    MessageBox.Show("Please select your favorite food.");

                    // Returns a value of false so that the calling method will not move forward.
                    return false;
                }               
            }
        }

        //This method calls the SetGreeting method and applies the returned text to the Greeting Label. It then makes the greeting label visible.
        private void greetingOutput()
        {
            lblGreet.Text = newUser.SetGreeting();
            lblGreet.Visible = true;
        }


        //This is the click event handler for the Predict button. It runs the input validation method, and if that method succeeds,
        //it sets the prediction form's label with the output of the SetPrediction method. It then opens the Prediction form as
        //a modal form.
        private void btnPredict_Click(object sender, EventArgs e)
        {
           if (validateInput())
            {
                predict.lblPredict.Text = newUser.SetPrediction();

                predict.ShowDialog();
            }
        }

        //This is the click event handler for the Greet button. It runs the input validation method, and if that method succeeds,
        //it calls the greetingOutput method to set the Greeting label.
        private void btnGreet_Click(object sender, EventArgs e)
        {
          if (validateInput())
            {
                greetingOutput();                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the Form
            this.Close();
        }
    }
}
