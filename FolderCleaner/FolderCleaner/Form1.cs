using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCleaner
{
    public partial class frmMain : Form
    {
        FolderAnalyzer analyze = new FolderAnalyzer();
        CleanFolder clean = new CleanFolder();
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPicker_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtDirectory.Text = dlgFolder.SelectedPath;
            }
            
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (dlgFolder.SelectedPath != null)
            {
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlgFolder.SelectedPath);
                analyze.WalkDirectoryTree(dir);

                foreach (string type in analyze.fileTypes)
                {
                    chkFileTypes.Items.Add(type);
                }
                
            }
           
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (chkFileTypes.CheckedItems.Count > 0 || chkAll.Checked)
            {
                foreach (string type in chkFileTypes.CheckedItems)
                {
                    clean.fileTypeToKeep.Add(type);
                }
                DialogResult result = dlgDestination.ShowDialog();

                if (result == DialogResult.OK)
                {
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlgFolder.SelectedPath);
                    dlgFolder.Dispose();
                    clean.destPath = new System.IO.DirectoryInfo(dlgDestination.SelectedPath);
                    dlgDestination.Dispose();
                    clean.CleanDirectoryTree(dir);
                    MessageBox.Show("Complete");
                }
                
            }
            else
            {
                MessageBox.Show("Please select one or more file types");
            }
            
        }
    }
}
