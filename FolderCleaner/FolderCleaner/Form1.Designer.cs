namespace FolderCleaner
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPicker = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnPicker = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.chkFileTypes = new System.Windows.Forms.CheckedListBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.dlgDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPicker
            // 
            this.lblPicker.AutoSize = true;
            this.lblPicker.Location = new System.Drawing.Point(26, 36);
            this.lblPicker.Name = "lblPicker";
            this.lblPicker.Size = new System.Drawing.Size(103, 13);
            this.lblPicker.TabIndex = 0;
            this.lblPicker.Text = "Choose a Directory: ";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(136, 28);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(196, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // btnPicker
            // 
            this.btnPicker.Location = new System.Drawing.Point(338, 28);
            this.btnPicker.Name = "btnPicker";
            this.btnPicker.Size = new System.Drawing.Size(75, 23);
            this.btnPicker.TabIndex = 2;
            this.btnPicker.Text = "Browse";
            this.btnPicker.UseVisualStyleBackColor = true;
            this.btnPicker.Click += new System.EventHandler(this.btnPicker_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(338, 74);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // chkFileTypes
            // 
            this.chkFileTypes.FormattingEnabled = true;
            this.chkFileTypes.Location = new System.Drawing.Point(29, 74);
            this.chkFileTypes.Name = "chkFileTypes";
            this.chkFileTypes.Size = new System.Drawing.Size(193, 169);
            this.chkFileTypes.TabIndex = 4;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(338, 359);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(29, 250);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(71, 17);
            this.chkAll.TabIndex = 6;
            this.chkAll.Text = "Delete All";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 465);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.chkFileTypes);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnPicker);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lblPicker);
            this.Name = "frmMain";
            this.Text = "Folder Cleaner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPicker;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnPicker;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.CheckedListBox chkFileTypes;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.FolderBrowserDialog dlgDestination;
        private System.Windows.Forms.CheckBox chkAll;
    }
}

