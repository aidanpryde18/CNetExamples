using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int remaining = 20, setting;
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.prine);
       

        public Form1()
        {
            InitializeComponent();
            cmbCounter.SelectedIndex = 0;
        }

        private void updateCounter()
        {
            int minutes, seconds;

            minutes = remaining / 60;
            seconds = remaining % 60;

            lblTimer.Text = String.Format("{0}:{1:00}", minutes, seconds);
        }

        private void checkCombo()
        {
            setting = cmbCounter.SelectedIndex;

            if (setting <= 0)
            {
                remaining = 20;
                updateCounter();
            }
            else if (setting == 1)
            {
                remaining = 60;
                updateCounter();
            }
            else
            {
                remaining = 180;
                updateCounter();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            checkCombo();
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            remaining = 0;
            updateCounter();
        }

        private void cmbCounter_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkCombo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            remaining -= 1;

            if (remaining == 0)
            {
                updateCounter();
                timer.Stop();
                simpleSound.Play();
            }
            else
            {
                updateCounter();
            }
        }
    }
}
