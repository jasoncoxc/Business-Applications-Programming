/**********************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Search data file
 * NFLScores.dat file
 * File Structure: team, week, attendance, games
 * Loads data file, searches, and displays them in report
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram18
{
    public partial class frmNFL : Form
    {
        public frmNFL()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayHeader()
        {
            rtbOut.Clear();
            rtbOut.AppendText("                           National Football League" + "\n");
            rtbOut.AppendText("                                  2021 scores" + "\n\n");
            rtbOut.AppendText("                      Home             Visitor" + "\n");
            rtbOut.AppendText("Week       Date Team         Score Team        Score Winner       Attendance" + "\n");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Declarations
            string[] homeTeam = new string[0];
            string[] awayTeam = new string[0];
            int[] week = new int[0];
            string[] date = new string[0];
            int[] homeScore = new int[0];
            int[] awayScore = new int[0];
            int[] attendance = new int[0];
            string[] winner = new string[0];
            int num = 0;
            int numR = 0;
            double att = double.Parse(txtAttendance.Text);
            int findWeek = Convert.ToInt32(nudWeek.Value);
            string selected = Convert.ToString(lstTeam.SelectedItem);

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"NFLScores.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref homeTeam, homeTeam.Length + 1);
                Array.Resize<string>(ref awayTeam, awayTeam.Length + 1);
                Array.Resize<int>(ref week, week.Length + 1);
                Array.Resize<string>(ref date, date.Length + 1);
                Array.Resize<int>(ref homeScore, homeScore.Length + 1);
                Array.Resize<int>(ref awayScore, awayScore.Length + 1);
                Array.Resize<int>(ref attendance, attendance.Length + 1);
                Array.Resize<string>(ref winner, winner.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                homeTeam[num] = record[2];
                awayTeam[num] = record[3];
                week[num] = Convert.ToInt32(record[0]);
                date[num] = (record[1]);
                homeScore[num] = Convert.ToInt32(record[4]);
                awayScore[num] = Convert.ToInt32(record[5]);
                attendance[num] = Convert.ToInt32(record[6]);

                //Populate ListBox
                int found = lstTeam.FindString(homeTeam[num]);
                if (found < 0)
                {
                    lstTeam.Items.Add(homeTeam[num]);
                }

                //Input
                if (homeScore[num] > awayScore[num])
                {
                    winner[num] = homeTeam[num];
                }
                else if (awayScore[num] > homeScore[num])
                {
                    winner[num] = awayTeam[num];
                }
                else
                {
                    winner[num] = "-";
                }

                if (att < attendance[num])
                {
                    rtbOut.AppendText(week[num].ToString("n0").PadLeft(3) + date[num].ToString().PadLeft(12) + " " +
                                        homeTeam[num].ToString().PadRight(15) + homeScore[num].ToString("n0").PadLeft(3) + " " + awayTeam[num].ToString().PadRight(14) +
                                        awayScore[num].ToString("n0").PadLeft(3) + " " + winner[num].ToString().PadRight(17) + attendance[num].ToString("n0") + "\n");
                    numR++;
                }

                lblGames.Text = numR.ToString("n0");
            }
            //Close file
            textIn.Close();
        }

        private void frmNFL_Load(object sender, EventArgs e)
        {
            //Declarations
            string[] homeTeam = new string[0];
            string[] awayTeam = new string[0];
            int[] week = new int[0];
            string[] date = new string[0];
            int[] homeScore = new int[0];
            int[] awayScore = new int[0];
            int[] attendance = new int[0];
            string[] winner = new string[0];
            int num = 0;
            int numR = 0;
            double att = double.Parse(txtAttendance.Text);
            int findWeek = Convert.ToInt32(nudWeek.Value);
            string selected = Convert.ToString(lstTeam.SelectedItem);

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"NFLScores.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref homeTeam, homeTeam.Length + 1);
                Array.Resize<string>(ref awayTeam, awayTeam.Length + 1);
                Array.Resize<int>(ref week, week.Length + 1);
                Array.Resize<string>(ref date, date.Length + 1);
                Array.Resize<int>(ref homeScore, homeScore.Length + 1);
                Array.Resize<int>(ref awayScore, awayScore.Length + 1);
                Array.Resize<int>(ref attendance, attendance.Length + 1);
                Array.Resize<string>(ref winner, winner.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                homeTeam[num] = record[2];
                awayTeam[num] = record[3];
                week[num] = Convert.ToInt32(record[0]);
                date[num] = (record[1]);
                homeScore[num] = Convert.ToInt32(record[4]);
                awayScore[num] = Convert.ToInt32(record[5]);
                attendance[num] = Convert.ToInt32(record[6]);

                //Populate ListBox
                int found = lstTeam.FindString(homeTeam[num]);
                if (found < 0)
                {
                    lstTeam.Items.Add(homeTeam[num]);
                }

                //Input
                if (homeScore[num] > awayScore[num])
                {
                    winner[num] = homeTeam[num];
                }
                else if (awayScore[num] > homeScore[num])
                {
                    winner[num] = awayTeam[num];
                }
                else
                {
                    winner[num] = "-";
                }

                numR++;

                rtbOut.AppendText(week[num].ToString("n0").PadLeft(3) + date[num].ToString().PadLeft(12) + " " +
                 homeTeam[num].ToString().PadRight(15) + homeScore[num].ToString("n0").PadLeft(3) + " " + awayTeam[num].ToString().PadRight(14) +
                  awayScore[num].ToString("n0").PadLeft(3) + " " + winner[num].ToString().PadRight(17) + attendance[num].ToString("n0") + "\n");

                lblGames.Text = numR.ToString("n0");
            }
            //Close file
            textIn.Close();
        }

        private void nudWeek_ValueChanged(object sender, EventArgs e)
        {
            //Declarations
            string[] homeTeam = new string[0];
            string[] awayTeam = new string[0];
            int[] week = new int[0];
            string[] date = new string[0];
            int[] homeScore = new int[0];
            int[] awayScore = new int[0];
            int[] attendance = new int[0];
            string[] winner = new string[0];
            int num = 0;
            int numR = 0;
            double att = double.Parse(txtAttendance.Text);
            int findWeek = Convert.ToInt32(nudWeek.Value);
            string selected = Convert.ToString(lstTeam.SelectedItem);

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"NFLScores.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref homeTeam, homeTeam.Length + 1);
                Array.Resize<string>(ref awayTeam, awayTeam.Length + 1);
                Array.Resize<int>(ref week, week.Length + 1);
                Array.Resize<string>(ref date, date.Length + 1);
                Array.Resize<int>(ref homeScore, homeScore.Length + 1);
                Array.Resize<int>(ref awayScore, awayScore.Length + 1);
                Array.Resize<int>(ref attendance, attendance.Length + 1);
                Array.Resize<string>(ref winner, winner.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                homeTeam[num] = record[2];
                awayTeam[num] = record[3];
                week[num] = Convert.ToInt32(record[0]);
                date[num] = (record[1]);
                homeScore[num] = Convert.ToInt32(record[4]);
                awayScore[num] = Convert.ToInt32(record[5]);
                attendance[num] = Convert.ToInt32(record[6]);

                //Populate ListBox
                int found = lstTeam.FindString(homeTeam[num]);
                if (found < 0)
                {
                    lstTeam.Items.Add(homeTeam[num]);
                }

                //Input
                if (homeScore[num] > awayScore[num])
                {
                    winner[num] = homeTeam[num];
                }
                else if (awayScore[num] > homeScore[num])
                {
                    winner[num] = awayTeam[num];
                }
                else
                {
                    winner[num] = "-";
                }
                if (findWeek == week[num])
                {
                    rtbOut.AppendText(week[num].ToString("n0").PadLeft(3) + date[num].ToString().PadLeft(12) + " " +
                    homeTeam[num].ToString().PadRight(15) + homeScore[num].ToString("n0").PadLeft(3) + " " + awayTeam[num].ToString().PadRight(14) +
                    awayScore[num].ToString("n0").PadLeft(3) + " " + winner[num].ToString().PadRight(17) + attendance[num].ToString("n0") + "\n");
                    numR++;

                }

                lblGames.Text = numR.ToString("n0");
            }
            //Close file
            textIn.Close();
        }

        private void lstTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Declarations
            string[] homeTeam = new string[0];
            string[] awayTeam = new string[0];
            int[] week = new int[0];
            string[] date = new string[0];
            int[] homeScore = new int[0];
            int[] awayScore = new int[0];
            int[] attendance = new int[0];
            string[] winner = new string[0];
            int num = 0;
            int numR = 0;
            double att = double.Parse(txtAttendance.Text);
            int findWeek = Convert.ToInt32(nudWeek.Value);
            string selected = Convert.ToString(lstTeam.SelectedItem);

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"NFLScores.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref homeTeam, homeTeam.Length + 1);
                Array.Resize<string>(ref awayTeam, awayTeam.Length + 1);
                Array.Resize<int>(ref week, week.Length + 1);
                Array.Resize<string>(ref date, date.Length + 1);
                Array.Resize<int>(ref homeScore, homeScore.Length + 1);
                Array.Resize<int>(ref awayScore, awayScore.Length + 1);
                Array.Resize<int>(ref attendance, attendance.Length + 1);
                Array.Resize<string>(ref winner, winner.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                homeTeam[num] = record[2];
                awayTeam[num] = record[3];
                week[num] = Convert.ToInt32(record[0]);
                date[num] = (record[1]);
                homeScore[num] = Convert.ToInt32(record[4]);
                awayScore[num] = Convert.ToInt32(record[5]);
                attendance[num] = Convert.ToInt32(record[6]);

                //Populate ListBox
                int found = lstTeam.FindString(homeTeam[num]);
                if (found < 0)
                {
                    lstTeam.Items.Add(homeTeam[num]);
                }

                //Input
                if (homeScore[num] > awayScore[num])
                {
                    winner[num] = homeTeam[num];
                }
                else if (awayScore[num] > homeScore[num])
                {
                    winner[num] = awayTeam[num];
                }
                else
                {
                    winner[num] = "-";
                }

                if (selected == homeTeam[num])
                {
                    rtbOut.AppendText(week[num].ToString("n0").PadLeft(3) + date[num].ToString().PadLeft(12) + " " +
                 homeTeam[num].ToString().PadRight(15) + homeScore[num].ToString("n0").PadLeft(3) + " " + awayTeam[num].ToString().PadRight(14) +
                 awayScore[num].ToString("n0").PadLeft(3) + " " + winner[num].ToString().PadRight(17) + attendance[num].ToString("n0") + "\n");
                    numR++;
                }
                if (selected == awayTeam[num])
                {
                    rtbOut.AppendText(week[num].ToString("n0").PadLeft(3) + date[num].ToString().PadLeft(12) + " " +
                 homeTeam[num].ToString().PadRight(15) + homeScore[num].ToString("n0").PadLeft(3) + " " + awayTeam[num].ToString().PadRight(14) +
                 awayScore[num].ToString("n0").PadLeft(3) + " " + winner[num].ToString().PadRight(17) + attendance[num].ToString("n0") + "\n");
                    numR++;
                }

                lblGames.Text = numR.ToString("n0");
            }
            //Close file
            textIn.Close();
        }
    }
}
