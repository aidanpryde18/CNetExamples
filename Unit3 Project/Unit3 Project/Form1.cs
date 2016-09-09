using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit3_Project
{
    public partial class frmBaseball : Form
    {
        public frmBaseball()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //Closes the program
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Local Variables

            double hits; //Number of Hits
            double atBats; //Number of At Bats
            double homeRuns;//Number of home runs
            double battingAverage; //Variable to store calculated batting average
            double salary; //Variable to store calculated salary
           
            //Verifies proper input type for the Hits text box
            if (double.TryParse(txtHits.Text, out hits))
            {
                //Verifies proper input type for the At Bats text box
                if (double.TryParse(txtAtBats.Text, out atBats))
                {
                    //Calculates batting average from input
                    battingAverage = hits / atBats;
                    
                    //Rounds batting average to three decimal places
                    battingAverage = Math.Round(battingAverage, 3);
                    
                    //Sets the output format for the batting average. This removes the leading zero and ensures that 3 decimal places are used
                    string fmt = ".000";

                    //Outputs batting average to the label on the form. Uses the fmt format
                    lblAverageOutput.Text = battingAverage.ToString(fmt);

                    //Verifies proper input type for the Home Runs text box
                    if (double.TryParse(txtHomers.Text, out homeRuns))
                    {

                        //Calculates salary now that the homeRuns variable has a number assigned to it
                        salary = (battingAverage * 30000000) + (homeRuns * 100000);

                        //Outputs salary to the label on the form. Uses the dollar formatting
                        lblSalaryOutput.Text = salary.ToString("C");
                        
                        //Following lines make the output labels on the form visible so user can see the results
                        lblAverageOutput.Visible = true;
                        lblRankingOutput.Visible = true;
                        lblSalaryOutput.Visible = true;

                        /*Beginning of  Player Quality Algorithm. 
                        It first finds the level based on batting average and then it checks their home run count to see if
                        their home run count will drop them to a lower level. Depending on the level of their batting average
                        it stops analyzing home run count once the home run count meets their batting average level. I did this
                        because the schema showed that batting average was the primary determinant of their level. Excess home runs
                        past that level do not increase their ranking, so I saved the processing time by ending the analysis once the
                        minimum number of home runs was reached.
                        */ 


                    if (battingAverage >= .350 && homeRuns >= 30)
                        {
                            lblRankingOutput.Text = "Superstar";
                        }
                    else if (battingAverage >= .300 && homeRuns >= 20)
                        {
                            lblRankingOutput.Text = "Great Hitter";
                        }
                    else if (battingAverage >= .250 && homeRuns >= 10)
                        {
                            lblRankingOutput.Text = "Good Hitter";
                        }
                    else if (battingAverage >= .200 && homeRuns >= 5)
                        {
                            lblRankingOutput.Text = "Average Hitter";
                        }
                    else
                        {
                            lblRankingOutput.Text = "Minor Leaguer";
                        }
                        /*
                        //Checks for Sub-.200 Batting average
                        if (battingAverage <= .200)
                        {
                            //Sets the player ranking to Minor Leaguer. Home run numbers aren't analyzed since it is unimportant at this level
                            lblRankingOutput.Text = "Minor Leaguer";
                        }

                        //Once past .200 check to see if player is at .250 or less
                        else if (battingAverage <= .250)
                        {
                            if (homeRuns < 5)
                            {
                                //Sets player at Minor leaguer if they did not hit at least 5 home runs.
                                lblRankingOutput.Text = "Minor Leaguer";
                            }
                            else
                            {
                                //Sets their ranking to Average Hitter since they hit at least 5 home runs.
                                lblRankingOutput.Text = "Average Hitter";
                            }
                        }

                        //Once past .250 check to see if player is at .300 or less
                        else if (battingAverage <= .300)
                        {
                            if (homeRuns < 5)
                            {
                                //Sets player at Minor leaguer if they did not hit at least 5 home runs.
                                lblRankingOutput.Text = "Minor Leaguer";
                            }
                            else if (homeRuns < 10)
                            {
                                //Sets their ranking to Average Hitter since they didn't hit 10 home runs to match their batting average
                                lblRankingOutput.Text = "Average Hitter";
                            }
                            else
                            {
                                //Sets their ranking to Good Hitter since they hit at least 10 home runs.
                                lblRankingOutput.Text = "Good Hitter";
                            }
                        }
                        //Once past .300 check to see if player is at .350 or less
                        else if (battingAverage <= .350)
                        {
                            if (homeRuns < 5)
                            {
                                //Sets player at Minor leaguer if they did not hit at least 5 home runs.
                                lblRankingOutput.Text = "Minor Leaguer";
                            }
                            else if (homeRuns < 10)
                            {
                                //Sets their ranking to Average Hitter since they didn't hit 20 home runs to match their batting average
                                lblRankingOutput.Text = "Average Hitter";
                            }
                            else if (homeRuns < 20)
                            {
                                //Sets their ranking to Good Hitter since they didn't hit 20 home runs to match their batting average
                                lblRankingOutput.Text = "Good Hitter";
                            }
                            else
                            {
                                //Sets their ranking to Good Hitter since they hit at least 20 home runs.
                                lblRankingOutput.Text = "Great Hitter";
                            }
                        }
                        //This section is for hitters over .350 since there is no upper bound at this level. No comparison necessary
                        else
                        {
                            if (homeRuns < 5)
                            {
                                //Sets player at Minor leaguer if they did not hit at least 5 home runs.
                                lblRankingOutput.Text = "Minor Leaguer";
                            }
                            else if (homeRuns < 10)
                            {
                                //Sets their ranking to Average Hitter since they didn't hit 30 home runs to match their batting average
                                lblRankingOutput.Text = "Average Hitter";
                            }
                            else if (homeRuns < 20)
                            {
                                //Sets their ranking to Good Hitter since they didn't hit 30 home runs to match their batting average
                                lblRankingOutput.Text = "Good Hitter";
                            }
                            else if (homeRuns < 30)
                            {
                                //Sets their ranking to Good Hitter since they didn't hit 30 home runs to match their batting average
                                lblRankingOutput.Text = "Great Hitter";
                            }
                            else
                            {
                                //Sets their ranking to Good Hitter since they hit at least 30 home runs.
                                lblRankingOutput.Text = "Superstar";
                            }
                        }
                        */
                    }
                    else
                    {
                        //Displays an error message if the input of the home run text box can't be parsed
                        MessageBox.Show("Invalid Input for Home Runs");
                    }
                }
                else
                {
                    //Displays an error message if the input of the at bats text box can't be parsed
                    MessageBox.Show("Invalid Input for At Bats");
                }

            }
            else
            {
                //Displays an error message if the input of the Hits text box can't be parsed
                MessageBox.Show("Invalid Input for Hits");
            }            
        }

        //This class clears out all previous input and resets the form for the user so they can run a new set of numbers.
        private void btnClear_Click(object sender, EventArgs e)
        {

            txtAtBats.Text = ""; //Clears the At Bats text box

            txtHits.Text = ""; //Clears the Hits text box

            txtHomers.Text = ""; //clears the Home Runs text box

            lblAverageOutput.Visible = false; //Hides the batting average output label

            lblRankingOutput.Visible = false; //Hides the ranking output label

            lblSalaryOutput.Visible = false; //Hides the salary output label

            txtAtBats.Focus(); //Resets the focus to the at bats text box to help the user start new input
        }
    }  
}
