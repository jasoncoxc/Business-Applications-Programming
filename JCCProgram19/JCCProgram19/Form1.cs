/**********************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Bubble Sort
 * StateMinimumWages.dat file
 * File Structure: state, wage
 * Loads data file, orders data, and displays them in report
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

namespace JCCProgram19
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

        private void DisplayHeader()
        {
            rtbOut.Clear();
            rtbOut.AppendText("            Minimum Wage" + "\n");
            rtbOut.AppendText("              by State" + "\n\n");
            rtbOut.AppendText("State                      Wage" + "\n");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //Declarations
            string[] state = new string[0];
            double[] wage = new double[0];
            int num = 0;

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"StateMinimumWages.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref state, state.Length + 1);
                Array.Resize<double>(ref wage, wage.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                state[num] = record[0];
                wage[num] = Convert.ToDouble(record[1]);

                //Display Record
                rtbOut.AppendText(state[num].ToString().PadRight(20) + wage[num].ToString("c2").PadLeft(11) + "\n");
            }

            //Close file
            textIn.Close();
            this.loadToolStripMenuItem.Enabled = false;
            this.stateToolStripMenuItem.Enabled = true;
            this.minimumWageToolStripMenuItem.Enabled = true;
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declarations
            string[] state = new string[0];
            double[] wage = new double[0];
            int num = 0;          

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"StateMinimumWages.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref state, state.Length + 1);
                Array.Resize<double>(ref wage, wage.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                state[num] = record[0];
                wage[num] = Convert.ToDouble(record[1]);
                num++;
               
            }

            //Close file
            textIn.Close();

            //Sort by State                
            for (int i = 0; i < state.GetUpperBound(0) - 1; i++)
            {
                for (int j = 0; j < (state.GetUpperBound(0) - i); j++)
                {
                    int k = j + 1;
                    if (string.Compare(state[j], state[k]) >=0)
                    {
                        string tempState = state[j];
                        state[j] = state[k];
                        state[k] = tempState;
                        double tempWage = wage[j];
                        wage[j] = wage[k];
                        wage[k] = tempWage;
                    }
                }
            }
            //Display Record
            for (int i = 0; i < state.Length; i++)
            {
                rtbOut.AppendText(state[i].ToString().PadRight(20) + wage[i].ToString("c2").PadLeft(11) + "\n");

            }
        }

        private void minimumWageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declarations
            string[] state = new string[0];
            double[] wage = new double[0];
            int num = 0;

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"StateMinimumWages.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref state, state.Length + 1);
                Array.Resize<double>(ref wage, wage.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                state[num] = record[0];
                wage[num] = Convert.ToDouble(record[1]);
                num++;

            }

            //Close file
            textIn.Close();

            //Sort by Wage                
            for (int i = 0; i < wage.GetUpperBound(0) - 1; i++)
            {
                for (int j = 0; j < (wage.GetUpperBound(0) - i); j++)
                {
                    int k = j + 1;
                    if (wage[j] < wage[k])
                    {
                        double tempWage = wage[j];
                        wage[j] = wage[k];
                        wage[k] = tempWage;
                        string tempState = state[j];
                        state[j] = state[k];
                        state[k] = tempState;
                        
                    }
                }
            }
            //Display Record
            for (int i = 0; i < wage.Length; i++)
            {
                rtbOut.AppendText(state[i].ToString().PadRight(20) + wage[i].ToString("c2").PadLeft(11) + "\n");
            }
        }
    }
}
