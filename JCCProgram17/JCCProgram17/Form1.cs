/**********************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Load Arrays
 * SDJobOpenings.dat file
 * File Structure: county, openings, population
 * Loads parallel arrays from a data file and displays them in reports
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declarations
            string[] county = new string[0];
            int[] openings = new int[0];
            int[] pop = new int[0];
            int num = 0;
            int totalOpenings = 0;
            int totalPop = 0;

            //Open file
            //IO initializations
            string path = @"SDJobOpenings.dat";
            StreamReader textIn = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                          South Dakota Job Openings" + "\n");
            rtbOut.AppendText("                           County-by-County Report" + "\n\n");
            rtbOut.AppendText("County           Openings    Population" + "\n");

            //Processing loop
            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref county, county.Length + 1);
                Array.Resize<int>(ref openings, openings.Length + 1);
                Array.Resize<int>(ref pop, pop.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                county[num] = record[0];
                openings[num] = Convert.ToInt32(record[1]);
                pop[num] = Convert.ToInt32(record[2]);                

                //Processing               
                    totalOpenings += openings[0];
                    totalPop += pop[0];
                    rtbOut.AppendText(county[num].PadRight(20) + openings[num].ToString("n0").PadLeft(5) + pop[num].ToString("n0").PadLeft(14) + "\n");
            }

            //Close file
            textIn.Close();
            
            //Postprocessing
            rtbOut.AppendText("Total:" + totalOpenings.ToString("n0").PadLeft(19) + totalPop.ToString("n0").PadLeft(14));
        
        }

        private void countyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declarations
            string[] county = new string[0];
            // int[] openings = new int[0];
            // int[] pop = new int[0];
            decimal openings = 0;
            decimal pop = 0;
            int num = 0;
            decimal openThousands = 0;

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                          South Dakota Job Openings" + "\n");
            rtbOut.AppendText("                           County-by-County Report" + "\n\n");
            rtbOut.AppendText("                                          Openings" + "\n");
            rtbOut.AppendText("County           Openings    Population  /Thousand" + "\n");

            //Open file
            //IO initializations
            string path = @"SDJobOpenings.dat";
            StreamReader textIn = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));

            //Processing loop
            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref county, county.Length + 1);
               // Array.Resize<int>(ref openings, openings.Length + 1);
               // Array.Resize<int>(ref pop, pop.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                county[num] = record[0];
                openings = decimal.Parse(record[1]);
                pop = decimal.Parse(record[2]);

                //Processing                
                openThousands = (openings / pop) * 1000;
                rtbOut.AppendText(county[num].PadRight(20) + openings.ToString("n0").PadLeft(5) + pop.ToString("n0").PadLeft(14) + openThousands.ToString("n1").PadLeft(11) + "\n");

            }
            //Close file
            textIn.Close();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declarations
            string[] county = new string[0];
            //int[] openings = new int[0];
            //int[] pop = new int[0];
            decimal openings = 0;
            decimal pop = 0;
            int num = 0;
            decimal openPercent = 0;           
            decimal popPercent = 0;
            decimal totalOpen = 0;
            decimal totalPop = 0;

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                          South Dakota Job Openings" + "\n");
            rtbOut.AppendText("                           County-by-County Report" + "\n\n");
            rtbOut.AppendText("                                           Percent      Percent" + "\n");
            rtbOut.AppendText("County           Openings    Population   Openings   Population" + "\n");

            //Open file
            //IO initializations
            string path = @"SDJobOpenings.dat";
            StreamReader textIn = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));

            //Processing loop
            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref county, county.Length + 1);
               // Array.Resize<int>(ref openings, openings.Length + 1);
                //Array.Resize<int>(ref pop, pop.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                county[num] = record[0];
                openings = decimal.Parse(record[1]);
                pop = decimal.Parse(record[2]);
                
                //Processing                
                 totalOpen += openings;
                 totalPop += pop;
                 openPercent = openings / totalOpen;
                 popPercent = pop / totalPop;
                 rtbOut.AppendText(county[num].PadRight(20) + openings.ToString("n0").PadLeft(5) + pop.ToString("n0").PadLeft(14) + openPercent.ToString("p1").PadLeft(11) + popPercent.ToString("p2").PadLeft(13) + "\n");

            }
            
            //Close file
            textIn.Close();
          
        }
    }
}
