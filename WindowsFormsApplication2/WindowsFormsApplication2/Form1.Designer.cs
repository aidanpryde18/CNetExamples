namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblImg = new System.Windows.Forms.PictureBox();
            this.cmbCounter = new System.Windows.Forms.ComboBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lblImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImg
            // 
            this.lblImg.Image = ((System.Drawing.Image)(resources.GetObject("lblImg.Image")));
            this.lblImg.Location = new System.Drawing.Point(12, 12);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(227, 226);
            this.lblImg.TabIndex = 0;
            this.lblImg.TabStop = false;
            // 
            // cmbCounter
            // 
            this.cmbCounter.FormattingEnabled = true;
            this.cmbCounter.Items.AddRange(new object[] {
            "20 Seconds",
            "1 Minute",
            "3 Minutes"});
            this.cmbCounter.Location = new System.Drawing.Point(118, 263);
            this.cmbCounter.Name = "cmbCounter";
            this.cmbCounter.Size = new System.Drawing.Size(121, 21);
            this.cmbCounter.TabIndex = 1;
            this.cmbCounter.SelectedIndexChanged += new System.EventHandler(this.cmbCounter_SelectedIndexChanged);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(12, 266);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(100, 13);
            this.lblCounter.TabIndex = 2;
            this.lblCounter.Text = "Countdown Length:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(48, 320);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(147, 72);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "0:20";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 437);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(96, 437);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(178, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 478);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.cmbCounter);
            this.Controls.Add(this.lblImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lblImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblImg;
        private System.Windows.Forms.ComboBox cmbCounter;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnExit;
    }
}

