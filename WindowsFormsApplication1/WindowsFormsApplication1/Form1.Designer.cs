namespace Unit5Project
{
    partial class frmTask
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(284, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFileItem
            // 
            this.mnuFileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddItem,
            this.mnuRemoveItem,
            this.mnuClear,
            this.toolStripMenuItem1,
            this.mnuImportItem,
            this.mnuExportItem,
            this.toolStripMenuItem2,
            this.mnuCloseItem});
            this.mnuFileItem.Name = "mnuFileItem";
            this.mnuFileItem.Size = new System.Drawing.Size(37, 20);
            this.mnuFileItem.Text = "File";
            // 
            // mnuAddItem
            // 
            this.mnuAddItem.Name = "mnuAddItem";
            this.mnuAddItem.Size = new System.Drawing.Size(152, 22);
            this.mnuAddItem.Text = "Add";
            this.mnuAddItem.Click += new System.EventHandler(this.mnuAddItem_Click);
            // 
            // mnuRemoveItem
            // 
            this.mnuRemoveItem.Name = "mnuRemoveItem";
            this.mnuRemoveItem.Size = new System.Drawing.Size(152, 22);
            this.mnuRemoveItem.Text = "Remove Item";
            this.mnuRemoveItem.Click += new System.EventHandler(this.mnuRemoveItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuImportItem
            // 
            this.mnuImportItem.Name = "mnuImportItem";
            this.mnuImportItem.Size = new System.Drawing.Size(152, 22);
            this.mnuImportItem.Text = "Import";
            this.mnuImportItem.Click += new System.EventHandler(this.mnuImportItem_Click);
            // 
            // mnuExportItem
            // 
            this.mnuExportItem.Name = "mnuExportItem";
            this.mnuExportItem.Size = new System.Drawing.Size(152, 22);
            this.mnuExportItem.Text = "Export";
            this.mnuExportItem.Click += new System.EventHandler(this.mnuExportItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuCloseItem
            // 
            this.mnuCloseItem.Name = "mnuCloseItem";
            this.mnuCloseItem.Size = new System.Drawing.Size(152, 22);
            this.mnuCloseItem.Text = "Close";
            this.mnuCloseItem.Click += new System.EventHandler(this.mnuCloseItem_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(58, 27);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(151, 121);
            this.lstTasks.TabIndex = 1;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnAddTask);
            this.grpAdd.Controls.Add(this.lblTask);
            this.grpAdd.Controls.Add(this.txtTask);
            this.grpAdd.Location = new System.Drawing.Point(58, 154);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(151, 82);
            this.grpAdd.TabIndex = 2;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Task";
            this.grpAdd.Visible = false;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(46, 48);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(6, 25);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(34, 13);
            this.lblTask.TabIndex = 1;
            this.lblTask.Text = "Task:";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(46, 22);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(100, 20);
            this.txtTask.TabIndex = 0;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Text Files|*.txt";
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.FileName = "*.txt";
            this.dlgSaveFile.Filter = "Text Documents (*.txt)|*.txt";
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(152, 22);
            this.mnuClear.Text = "Clear Tasks";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmTask";
            this.Text = "Task List";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFileItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuImportItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExportItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseItem;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
    }
}

