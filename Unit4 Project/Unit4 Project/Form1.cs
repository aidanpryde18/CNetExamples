using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit4_Project
{
    public partial class frmPurchases : Form
    {
        public frmPurchases()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close The Program
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Variable to hold the user-entered car value
            int carValue;

            //Variable to hold the count of the number of items currently in the list
            int listCount;

            //Variable to hold the total value of all purchased cars. Reset to 0 each time the add button is clicked to ensure no duplication
            int totalValue = 0;

            //Checks to make sure that the entered text is actually an integer
            if (int.TryParse(txtInputValue.Text, out carValue))
            {
                //Ensures that the integer entered is below $40,000
                if (carValue < 40000)
                {
                    //Once validated, the number entered is added to the end of the list
                    lstValues.Items.Add(carValue);

                    //listCount variable is set to the current number of list items
                    listCount = lstValues.Items.Count;

                    //Creates an array for storage of the list items for processing later. Sets the size to match the number of list items.
                    int[] valuesArray = new int[listCount];

                    //Loop that copies each list item to a space in the array
                    for (int i = 0; i < listCount; i++)
                    {
                        //Converts the list item from string to int and then stores it in the matching space in the array
                        valuesArray[i] = Convert.ToInt32(lstValues.Items[i]);
                    }

                    //This loop goes through the now-filled array and totals up the car values
                    foreach (int val in valuesArray)
                    {
                        //Calculates the running total as the array is processed
                        totalValue = totalValue + val;
                    }

                    //Adds the total value to the text of the output label and formats it as a dollar amount
                    lblDisplayTotal.Text = totalValue.ToString("C");

                    //These two lines clear the input text box and set the cursor inside of the text box to make it ready for the next entry
                    txtInputValue.Text = "";
                    txtInputValue.Focus();                    
                }
                else
                {
                    //If the value entered was too high, this displays an error to the user and clears out the text box for a new entry
                    MessageBox.Show("Please enter a value less than $40,000");
                    txtInputValue.Text = "";
                    txtInputValue.Focus();
                } 
            }
            else
            {
                //If the value entered was not a valid integer, this displays an error to the user and clears out the text box for a new entry
                MessageBox.Show("Please Enter a Number into the Text Box");
                txtInputValue.Text = "";
                txtInputValue.Focus();
            }
        }

        private void frmPurchases_Load(object sender, EventArgs e)
        {

        }
    }
}
