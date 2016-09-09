namespace Unit6_Project
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnGreet = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGreet = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.cmbFood);
            this.grpInput.Controls.Add(this.txtAge);
            this.grpInput.Controls.Add(this.lblAge);
            this.grpInput.Controls.Add(this.lblFood);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Location = new System.Drawing.Point(25, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(301, 112);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            // 
            // cmbFood
            // 
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Items.AddRange(new object[] {
            "Pizza",
            "Chinese Food",
            "Hamburgers"});
            this.cmbFood.Location = new System.Drawing.Point(112, 71);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(121, 21);
            this.cmbFood.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(112, 45);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(71, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(31, 74);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(75, 13);
            this.lblFood.TabIndex = 3;
            this.lblFood.Text = "Favorite Food:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnGreet
            // 
            this.btnGreet.Location = new System.Drawing.Point(25, 130);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(75, 23);
            this.btnGreet.TabIndex = 4;
            this.btnGreet.Text = "Greet Me";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(124, 130);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(100, 23);
            this.btnPredict.TabIndex = 5;
            this.btnPredict.Text = "Predict My Future";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(251, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGreet
            // 
            this.lblGreet.AutoSize = true;
            this.lblGreet.Location = new System.Drawing.Point(22, 177);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(28, 13);
            this.lblGreet.TabIndex = 7;
            this.lblGreet.Text = "Test";
            this.lblGreet.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 215);
            this.Controls.Add(this.lblGreet);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.btnPredict);
            this.Name = "frmMain";
            this.Text = "Greetings";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGreet;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.ComboBox cmbFood;
    }
}

