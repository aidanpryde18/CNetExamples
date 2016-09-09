namespace Unit4_Project
{
    partial class frmPurchases
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
            this.lstValues = new System.Windows.Forms.ListBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCarValue = new System.Windows.Forms.Label();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstValues
            // 
            this.lstValues.FormattingEnabled = true;
            this.lstValues.Location = new System.Drawing.Point(41, 12);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(224, 160);
            this.lstValues.TabIndex = 0;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnExit);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.lblCarValue);
            this.grpInput.Controls.Add(this.txtInputValue);
            this.grpInput.Location = new System.Drawing.Point(41, 200);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(224, 73);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(141, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCarValue
            // 
            this.lblCarValue.AutoSize = true;
            this.lblCarValue.Location = new System.Drawing.Point(6, 16);
            this.lblCarValue.Name = "lblCarValue";
            this.lblCarValue.Size = new System.Drawing.Size(104, 13);
            this.lblCarValue.TabIndex = 4;
            this.lblCarValue.Text = "Car Value (0-39999):";
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(116, 13);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(100, 20);
            this.txtInputValue.TabIndex = 0;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(38, 184);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(64, 13);
            this.lblTotalValue.TabIndex = 5;
            this.lblTotalValue.Text = "Total Value:";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Location = new System.Drawing.Point(108, 184);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayTotal.TabIndex = 6;
            // 
            // frmPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 305);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lstValues);
            this.Name = "frmPurchases";
            this.Text = "Car Purchases";
            this.Load += new System.EventHandler(this.frmPurchases_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstValues;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCarValue;
        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblDisplayTotal;
    }
}

