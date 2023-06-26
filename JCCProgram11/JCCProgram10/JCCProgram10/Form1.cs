/*****************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Program 10 MSU Soccer
 * Reads MSUSoccer.dat file
 * File Structure: Team, Score, Opp. Date, Site, Result, and Type
 * Displays game summary and record of Madion State Soccer.
 * **************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram10
{
    public partial class frmSoccer : Form
    {
        public frmSoccer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Declarations
            string result = null;
            int overW = 0;
            int overL = 0;
            int homeW = 0;
            int homeL = 0;
            int conW = 0;
            int conL = 0;

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                             Madison State Soccer" + "\n");
            rtbOut.AppendText("                                 2021 Scores" + "\n\n");
            rtbOut.AppendText("Team                     " + "Score  " + "Opp.     " + "Date     " + "Site   " + "Result    " + " Type" + "\n");

            //IO Initialization
            string path = @"MSUSoccer.dat";
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //Processing Loop
            while (textIn.Peek() != -1)
            {
                //Input
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                DateTime datDate = Convert.ToDateTime(record[1]);
                short score = Convert.ToInt16(record[3]);
                short opp = Convert.ToInt16(record[4]);
               // bool OT = Convert.ToBoolean(record[5]);
               if (score > opp)
                {
                    result = "W";
                }
               else
                {
                    result = "L";
                }

               //Processing
               if (record[2] == "H")
                {
                    if (result == "W")
                    {
                        homeW++;
                    }
                    else
                    {
                        homeL++;
                    }
                }
               if (record[6] == "C")
                {
                    if(result == "W")
                    {
                        conW++;
                    }
                    else
                    {
                        conL++;
                    }
                }
               if (result == "W")
                {
                    overW++;
                }
               else
                {
                    overL++;
                }             

                //Output
                rtbOut.AppendText(record[0].PadRight(25) +
                    record[3].PadLeft(5) +
                    record[4].PadLeft(6) +
                    datDate.ToShortDateString().PadLeft(12) +
                    record[2].PadLeft(6) +
                    result.ToString().PadLeft(9) + 
                    record[6].PadLeft(9) + "\n");
            }

            //Postprocessing
            textIn.Close();

            rtbOut.AppendText("Home Record: " + homeW.ToString("n0") + " - " + homeL.ToString("n0") + "\n");
            rtbOut.AppendText("Conference Record: " + conW.ToString("n0") + " - " + conL.ToString("n0") + "\n");
            rtbOut.AppendText("Overall Record: " + overW.ToString("n0") + " - " + overL.ToString("n0"));             
        }
    }
}
