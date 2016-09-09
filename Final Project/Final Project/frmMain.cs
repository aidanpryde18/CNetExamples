using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class frmMain : Form
    {
        //Creates an instance of the ADD User form
        frmAdd add = new frmAdd();
        
        public frmMain()
        {
            InitializeComponent();
        }


        //Add button event handler method
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Calls the Add User form as a modal dialog. If the dialog completes sucessfully, it calls the Address Creation Method
            if (add.ShowDialog() == DialogResult.OK)
            {
                CreateAddress();
            }
                                  
        }

        //Remove button event handler method. Calls the Address removal method on click.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveAddress();
        }

        //Exit button event handler. Closes the application on click.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Import menu item event handler. Calls the File open dialog on click.
        private void mnuImport_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        //Export menu item event handler. Calls the File save dialog on click.
        private void mnuExport_Click(object sender, EventArgs e)
        {
            SaveDialog();
        }

        //Exit menu item event handler. Closes the application on click.
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Item removal method. Removes the item in the list box at the index number passed from the RemoveAddress Method.
        private void RemoveItems(int index)
        {
            lstName.Items.RemoveAt(index);
        }

        //Address creation method. 
        private void CreateAddress()
        {
            //Pulls the address object from the add user form and creates it on the main form by calling the SendObject method on the Add user form.
            Address address = add.SendObject();
            //Calls the AddToList method and passes the newly created address object to the method.
            AddToList(address);
        }

        //The Address removal method. 
        private void RemoveAddress()
        {
            //Checks to make sure that an Address item in the list is selected. If not, it calls a Message Box to inform the user that 
            //they must select an item to remove.
            if (lstName.SelectedIndex > -1)
            {
                //If an item is selected, it creates a modal dialog asking them to confirm that they want to remove the item.
                if (MessageBox.Show("Are you sure you want to remove this record?", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    //If they confirm the dialog, the Item Removal method is called and the index value is passed.
                    RemoveItems(lstName.SelectedIndex);
                }

            }
            else
            {
                MessageBox.Show("Please select an item from the list that you want to remove");
            }
        }

        //Address addition method. It creates a new item in the list box with each property in the address object separated by spaces and a pipe character
        private void AddToList(Address address)
        {
            lstName.Items.Add(address.Name + "   |   " + address.EMail + "   |   " + address.Phone + "   |   " + address.Comments);
        }      

        /*   Method for opening the Open File Dialog. Called in mnuImportItem_Click event.
        *   It creates a variable to store the data from the selected file
        *   and then passes that data to the ImportAddress method to be processed.
        *   Once it's processed successfully, it closes the file.
        *   The Message Box in the else statement ensures that an error is handled without
        *   crashing the program. 
        */
        private void OpenDialog()
        {
            StreamReader inputFile;

            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(dlgOpenFile.FileName);

                ImportAddress(inputFile);

                inputFile.Close();
            }
            else
            {
                MessageBox.Show("Operation Canceled.");
            }
        }

        /*  This method is similar to the OpenDialog method, but it is called when someone
        *  goes to save their address list to a file.
        */
        private void SaveDialog()
        {
            StreamWriter outputFile;

            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {

                outputFile = File.CreateText(dlgSaveFile.FileName);

                ExportAddress(outputFile);

                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Operation Canceled.");
            }
        }

        //Once a file is successfully chosen, this method writes each address record to its own line in the file.
        private void ExportAddress(StreamWriter exportFile)
        {
            try
            {
                int listCount = lstName.Items.Count;   //Variable for the for loop so it knows how many times to loop based on the list length

                for (int i = 0; i < listCount; i++)
                {
                    //writes each item in the list to its own line in the file
                    exportFile.WriteLine(lstName.Items[i]);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //  Method called during the open file dialog that creates address records for each line of the selected file. It's enclosed in a
        //  try-catch block to make sure that any errors do not crash the program.
        private void ImportAddress(StreamReader importFile)
        {
            try
            {
                lstName.Items.Clear();   //Clears the list box to make it ready for the import.

                while (!importFile.EndOfStream)
                {
                    string nextAddress = importFile.ReadLine();  //Stores the next line from the file

                    //This line creates an array variable. It then fills the array by splitting the nextAddress variable at each pipe character
                    string[] line = nextAddress.Split('|');

                    //  Creates a new address object and passes the lina array values to the constructor. .Trim is used to make sure that
                    //  no unnecessary whitespace is sent with the values. This prevents whitespace from building up is a file is imported and
                    //  exported over and over.
                    Address address = new Address(line[0].Trim(), line[1].Trim(), line[2].Trim(), line[3].Trim());

                    //Calls the addToList method and passes the new address object to be added.
                    AddToList(address);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
