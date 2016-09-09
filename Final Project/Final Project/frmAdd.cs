using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmAdd : Form
    {
        string name;                //Variable used to store the contents of the name text box
        string email;               //Variable used to store the contents of the email text box
        string phoneNumber;         //Variable used to store the contents of the phone number text box
        string comment;             //Variable used to store the contents of the comments text box

        public frmAdd()
        {
            InitializeComponent();
        }


        //Send Object method is called from the main form and is used to create an address object and send that object to the main form.
        public Address SendObject()
        {           
            return new Address(name, email, phoneNumber, comment);
        }

        //Calls the Clear Form method to ensure that all of the text boxes are blank and the name text box has focus.
        private void frmAdd_Load(object sender, EventArgs e)
        {
            ClearForm();            
        }

        //Ensures that all of the text boxes are blank and the name text box has focus.
        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtComment.Text = "None"; //None is used as a default comment so if the user has no comment, they can skip entry
            txtName.Focus();
        }

        //Copies the input text to the form-level variables. The String.Format formats the phone number 
        //from a plain number string into an easily readable form.
        private void SetValues(long phone)
        {
            name = txtName.Text;
            email = txtEmail.Text;
            phoneNumber = String.Format("{0:(###) ###-####}", phone);
            comment = txtComment.Text;
        }

        //Closes the form on the cancel button click.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //OK Button event handler. It runs the input validation method. If the method completes successfully, it closes the form, 
        // clears it's contents for next time and sends the DialogResult=OK so the main form knows how to proceed.
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InputValidation() == true)
            {               
                Close();
                ClearForm();
                DialogResult = DialogResult.OK;
            }
            
        }

        //Input Validation method
        private bool InputValidation()
        {
            long phone; //Variable to store the phone number as a number for processing
            
            if (txtName.Text.Length > 0) //Verifies that the name text box is not empty
            {
                if (txtEmail.Text.Length > 0) //Verifies that the email text box isn't blank.
                {
                    if (txtPhone.Text.Length == 10) //Verifies that the user entered 10 characters in the phone text box.
                    {
                        if (long.TryParse(txtPhone.Text, out phone)) //Verifies that only numbers are in the phone text box
                        {
                            if (txtComment.Text.Length > 0) //Verifies that the comment text box isn't blank.
                            {
                                SetValues(phone); //Calls the Set Values method and passes the phone variable for processing
                                                                                                             
                                return true; //Returns true to the click event handler so it knows to continue running.
                            }

                            //Opens a message box letting the user know that they must insert a comment.
                            //Sets the focus to the comment text box and returns false to let the user add a comment and try again.
                            else
                            {
                                MessageBox.Show("Please enter a comment in the comment text box");
                                txtComment.Focus();
                                return false;
                            }
                        }

                        //Opens a message box letting the user know that they must only enter a 10 digit phone number..
                        //Sets the focus to the phone text box and returns false to let the user add a phone numbert and try again.
                        else
                        {
                            MessageBox.Show("Please enter a 10-digit phone number into the Phone text box");
                            txtPhone.Focus();
                            return false;
                        }
                        
                    }

                    //Opens a message box letting the user know that they must only enter a 10 digit phone number..
                    //Sets the focus to the phone text box and returns false to let the user add a phone number and try again.
                    else
                    {
                        MessageBox.Show("Please enter a 10-digit phone number into the Phone text box");
                        txtPhone.Focus();
                        return false;
                    }
                }

                //Opens a message box letting the user know that they must enter an e-mail address.
                //Sets the focus to the email text box and returns false to let the user add an email and try again.
                else
                {
                    MessageBox.Show("Please ente an e-mail address into the Email text box");
                    txtEmail.Focus();
                    return false;
                }
                
            }

            //Opens a message box letting the user know that they must enter a name.
            //Sets the focus to the name text box and returns false to let the user add a name and try again.
            else
            {
                MessageBox.Show("Please enter a name in the Name text box");
                txtName.Focus();
                return false;
            }
        }
    }
}
