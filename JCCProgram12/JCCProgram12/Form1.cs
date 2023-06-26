/***********************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Program 12 Insurance Sales Figures
 * Reads QuarterlySales.dat file
 * File Structure: ID, Qtr 1, Qtr 2, Qtr 3, Qtr 4
 * Calculates totals, averages, performance, finds high and low averages
 * *********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram12
{
    public partial class frmPolicy : Form
    {
        public frmPolicy()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //Declarations
            string goal = null;
            double highAverage = 0;
            double lowAverage = 999999;
            double highID = 0;
            double lowID = 999999;
            double overPerform = 0;
            double underPerform = 0;
            double perform = 0;            
            double allPolicies = 0;
            double records = 0;

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                Bilk, Soke, and Cheatum Insurance Company" + "\n");
            rtbOut.AppendText("                     " + "\"" + "Selling Policies is Our Policy" + "\"" + "\n\n");
            rtbOut.AppendText("            1" + "       2" + "       3" + "       4" + "                       Over/Under" + "\n");
            rtbOut.AppendText(" ID        " + "Qtr     " + "Qtr     " + "Qtr     " + "Qtr     " + "Total  " + "Average   " + "Met Goals" +"\n");

            //IO Initialization
            string path = @"QuarterlySales.dat";
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //Processing Loop
            while (textIn.Peek() != -1)
            {

                //Input
                string row = textIn.ReadLine();
                string[] record = row.Split('\t');
                double ID = double.Parse(record[0]);
                double Q1 = double.Parse(record[1]);
                double Q2 = double.Parse(record[2]);
                double Q3 = double.Parse(record[3]);
                double Q4 = double.Parse(record[4]);
                double total = Q1 + Q2 + Q3 + Q4;
                double average = total / 4;

                //Processing               
                allPolicies = allPolicies + total;
                if (average > 70)
                {
                    goal = "Over";
                    overPerform++;
                    records++;
                }
                else if (average < 55)
                {
                    goal = "Under";
                    underPerform++;
                    records++;
                }
                else
                {
                    goal = "Met";
                    perform++;
                    records++;
                }
                if (average > highAverage)
                {
                    highAverage = average;
                    highID = ID; 
                }
                if (average < lowAverage)
                {
                    lowAverage = average;
                    lowID = ID;
                }

                //Output                 
                rtbOut.AppendText(record[0] +
                    record[1].PadLeft(8) +
                    record[2].PadLeft(8) +
                    record[3].PadLeft(8) +
                    record[4].PadLeft(8) + 
                    total.ToString("n0").PadLeft(9) + 
                    average.ToString("n1").PadLeft(10).PadRight(13) +
                    goal.ToString() + "\n");             

            }

            //Postprocessing
            textIn.Close();

            rtbOut.AppendText("No. of Records:  " + records.ToString() + "\n");
            rtbOut.AppendText("No. of Policies:  " + allPolicies.ToString("n0") + "\n");
            rtbOut.AppendText("High Average:  " + highID.ToString() + " " + highAverage.ToString("n1") + "\n");
            rtbOut.AppendText("Low Average:  " + lowID.ToString() + " " + lowAverage.ToString("n1") + "\n");
            rtbOut.AppendText("Number Overperforming:  " + overPerform.ToString("n0") + "\n");
            rtbOut.AppendText("Number Underperforming:  " + underPerform.ToString("n0") + "\n");
            rtbOut.AppendText("Number Performing:  " + perform.ToString("n0") + "\n");
            
        }
    }
}
