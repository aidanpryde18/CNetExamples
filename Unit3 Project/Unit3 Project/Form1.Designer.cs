namespace Unit3_Project
{
    partial class frmBaseball
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
            this.grpBaseball = new System.Windows.Forms.GroupBox();
            this.lblAverageOutput = new System.Windows.Forms.Label();
            this.lblSalaryOutput = new System.Windows.Forms.Label();
            this.lblRankingOutput = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblAtBats = new System.Windows.Forms.Label();
            this.lblHomers = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.txtHomers = new System.Windows.Forms.TextBox();
            this.txtAtBats = new System.Windows.Forms.TextBox();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBaseball.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBaseball
            // 
            this.grpBaseball.Controls.Add(this.lblAverageOutput);
            this.grpBaseball.Controls.Add(this.lblSalaryOutput);
            this.grpBaseball.Controls.Add(this.lblRankingOutput);
            this.grpBaseball.Controls.Add(this.lblRanking);
            this.grpBaseball.Controls.Add(this.lblSalary);
            this.grpBaseball.Controls.Add(this.lblAverage);
            this.grpBaseball.Controls.Add(this.lblAtBats);
            this.grpBaseball.Controls.Add(this.lblHomers);
            this.grpBaseball.Controls.Add(this.lblHits);
            this.grpBaseball.Controls.Add(this.txtHomers);
            this.grpBaseball.Controls.Add(this.txtAtBats);
            this.grpBaseball.Controls.Add(this.txtHits);
            this.grpBaseball.Location = new System.Drawing.Point(73, 12);
            this.grpBaseball.Name = "grpBaseball";
            this.grpBaseball.Size = new System.Drawing.Size(269, 194);
            this.grpBaseball.TabIndex = 0;
            this.grpBaseball.TabStop = false;
            // 
            // lblAverageOutput
            // 
            this.lblAverageOutput.AutoSize = true;
            this.lblAverageOutput.Location = new System.Drawing.Point(122, 106);
            this.lblAverageOutput.Name = "lblAverageOutput";
            this.lblAverageOutput.Size = new System.Drawing.Size(35, 13);
            this.lblAverageOutput.TabIndex = 9;
            this.lblAverageOutput.Text = "label4";
            this.lblAverageOutput.Visible = false;
            // 
            // lblSalaryOutput
            // 
            this.lblSalaryOutput.AutoSize = true;
            this.lblSalaryOutput.Location = new System.Drawing.Point(122, 156);
            this.lblSalaryOutput.Name = "lblSalaryOutput";
            this.lblSalaryOutput.Size = new System.Drawing.Size(35, 13);
            this.lblSalaryOutput.TabIndex = 8;
            this.lblSalaryOutput.Text = "label3";
            this.lblSalaryOutput.Visible = false;
            // 
            // lblRankingOutput
            // 
            this.lblRankingOutput.AutoSize = true;
            this.lblRankingOutput.Location = new System.Drawing.Point(122, 132);
            this.lblRankingOutput.Name = "lblRankingOutput";
            this.lblRankingOutput.Size = new System.Drawing.Size(35, 13);
            this.lblRankingOutput.TabIndex = 6;
            this.lblRankingOutput.Text = "label1";
            this.lblRankingOutput.Visible = false;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(66, 132);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(50, 13);
            this.lblRanking.TabIndex = 3;
            this.lblRanking.Text = "Ranking:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(29, 156);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(87, 13);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Expected Salary:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(30, 106);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(86, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Batting Average:";
            // 
            // lblAtBats
            // 
            this.lblAtBats.AutoSize = true;
            this.lblAtBats.Location = new System.Drawing.Point(53, 30);
            this.lblAtBats.Name = "lblAtBats";
            this.lblAtBats.Size = new System.Drawing.Size(63, 13);
            this.lblAtBats.TabIndex = 5;
            this.lblAtBats.Text = "# of At Bats";
            // 
            // lblHomers
            // 
            this.lblHomers.AutoSize = true;
            this.lblHomers.Location = new System.Drawing.Point(31, 82);
            this.lblHomers.Name = "lblHomers";
            this.lblHomers.Size = new System.Drawing.Size(85, 13);
            this.lblHomers.TabIndex = 4;
            this.lblHomers.Text = "# of Home Runs";
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Location = new System.Drawing.Point(69, 56);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(47, 13);
            this.lblHits.TabIndex = 3;
            this.lblHits.Text = "# of Hits";
            // 
            // txtHomers
            // 
            this.txtHomers.Location = new System.Drawing.Point(122, 79);
            this.txtHomers.Name = "txtHomers";
            this.txtHomers.Size = new System.Drawing.Size(100, 20);
            this.txtHomers.TabIndex = 2;
            // 
            // txtAtBats
            // 
            this.txtAtBats.Location = new System.Drawing.Point(122, 27);
            this.txtAtBats.Name = "txtAtBats";
            this.txtAtBats.Size = new System.Drawing.Size(100, 20);
            this.txtAtBats.TabIndex = 0;
            // 
            // txtHits
            // 
            this.txtHits.Location = new System.Drawing.Point(122, 53);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(100, 20);
            this.txtHits.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(87, 212);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 43);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Get My Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmBaseball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 267);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpBaseball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBaseball";
            this.Text = "Baseball Averages";
            this.grpBaseball.ResumeLayout(false);
            this.grpBaseball.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBaseball;
        private System.Windows.Forms.Label lblAtBats;
        private System.Windows.Forms.Label lblHomers;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.TextBox txtHomers;
        private System.Windows.Forms.TextBox txtAtBats;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAverageOutput;
        private System.Windows.Forms.Label lblSalaryOutput;
        private System.Windows.Forms.Label lblRankingOutput;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnClear;
    }
}

