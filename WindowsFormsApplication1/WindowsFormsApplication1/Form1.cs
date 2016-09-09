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

namespace Unit5Project
{
    public partial class frmTask : Form
    {
        public frmTask()
        {
            InitializeComponent();
        }

        /*   Method for opening the Open File Dialog. Called in mnuImportItem_Click event.
         *   It creates a variable to store the data from the selected file
         *   and then passes that data to the ImportTasks method to be processed.
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

                ImportTasks(inputFile);

                inputFile.Close();
            }
            else
            {
                MessageBox.Show("Operation Canceled.");
            }
        }

        /*  This method is similar to the OpenDialog method, but it is called when someone
         *  goes to save their task list to a file.
         */

        private void SaveDialog()
        {
            StreamWriter outputFile;

            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {

                outputFile = File.CreateText(dlgOpenFile.FileName);

                ExportTasks(outputFile);

                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Operation Canceled.");
            }
        }

        /*  This method processes the file data that is passed from the OpenDialog method.
         *  First it clears the list box so that data isn't appended, then it reads each
         *  line of the text file and adds it to the next line of the list box. 
         *  It is run inside of a Try-Catch block to handle any possible errors.
         */

        private void ImportTasks(StreamReader importFile)
        {
            try
            {
                lstTasks.Items.Clear();

                while (!importFile.EndOfStream)
                {
                    string nextTask;

                    nextTask = importFile.ReadLine();

                    lstTasks.Items.Add(nextTask);

                }
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*  This method is used to write the tasks in the list box to a text file. The file name
         *  and location are passed to it from the SaveDialog method. It stores the count of the 
         *  number of tasks in the task list to the listCount variable and uses it to run a 
         *  for loop to write each item in the list box to its own line in the destination file. 
         *  It is run inside of a Try-Catch block to handle any possible errors.
         */

        private void ExportTasks(StreamWriter exportFile)
        {
            try
            {
                int listCount = lstTasks.Items.Count;

                for (int i = 0; i < listCount; i++)
                {
                    exportFile.WriteLine(lstTasks.Items[i]);
                }
            }

            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /*  The AddTasks method takes the input from the txtTask text box and adds it to the end of the 
         *  list box. It is run in an if statement to ensure that there is actually some input in the 
         *  text box. If there is no input, a message box is displayed that informs the user that they
         *  must enter a task before it will be added to the list. After input is validated, the item 
         *  is added to the list box, the group box is hidden again and the text box is cleared so that
         *  it is ready for fresh input next time the method is called. Otherwise, when the method is 
         *  called again, the last task will still be in the text box and the user will have to clear
         *  it manually.
         */

        private void AddTasks()
        {
            if (txtTask.Text.Length > 0)
            {
                lstTasks.Items.Add(txtTask.Text);
                grpAdd.Visible = false;
                txtTask.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a task into the text box");
            }         
        }

        /*  The RemoveTask method is used to clear the selected task from the list box. The if statement
         *  looks at the value of SelectedIndex for the list box. If no item is selected, the value is -1
         *  If no item is selected, a message box is displayed informing the user that they must first select
         *  an item to be removed. Once this is validated, the built-in Remove method is used to remove the selected
         *  item. 
         */

        private void RemoveTask()
        {
            if (lstTasks.SelectedIndex > -1)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item from the list that you want to remove");
            }
        }

        /*  I know that you didn't specifically ask for this function, but it was simple enough to code and it added good
         *  functionality to the program. This is called from the Clear Tasks menu item.
         */

        private void ClearTasks()
        {

            lstTasks.Items.Clear();
                       
        }

        private void mnuCloseItem_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        private void mnuAddItem_Click(object sender, EventArgs e)
        {
            //This makes the Add Item group box visible so the user can add an item to the list.
            grpAdd.Visible = true;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            //This calls the AddTasks method which adds the new task to the list box.
            AddTasks();
        }

        private void mnuRemoveItem_Click(object sender, EventArgs e)
        {
            //This calls the RemoveTask method which removes the selected task from the list box.
            RemoveTask();          
        }

        private void mnuImportItem_Click(object sender, EventArgs e)
        {
            //This calls the OpenDialog method which opens an Open File dialog so the user can select a file for importing.
            OpenDialog();
        }

        private void mnuExportItem_Click(object sender, EventArgs e)
        {
            //This calls the SaveDialog method which opens a Save File dialog so the user can export the task list to a file.
            SaveDialog();
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
           
            //This calls the ClearTasks method which clears all items from the task list.
            ClearTasks();            
        }
    }
}
