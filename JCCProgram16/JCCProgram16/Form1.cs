/***********************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Load Arrays
 * Snacks.dat file
 * File Structure: candy, sold
 * Loads parallel arrays from a data file and displays them
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            string[] candy = new string[0];
            int[] sold = new int[0];
            int num = 0;            

            //Open file
            //IO initializations
            string path = @"Snacks.dat";
            StreamReader textIn = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("    East Hall Vending Machine" + "\n");
            rtbOut.AppendText("          Weekly Sales" + "\n\n");           

            //Processing loop
            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref candy, candy.Length + 1);
                Array.Resize<int>(ref sold, candy.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                candy[num] = record[0];
                sold[num] = Convert.ToInt32(record[1]);
                num++;

            }

            //Close file
            textIn.Close();

            //Loop to display records
            for (int i = 0; i < candy.GetUpperBound(0); i++)
            {               
                rtbOut.AppendText(candy[i].PadRight(20) + sold[i].ToString("n0").PadLeft(5) + "\n");
            }
            rtbOut.AppendText(candy[19].PadRight(20) + sold[19].ToString("n0").PadLeft(5) + "\n");
            //Display the number of records


            rtbOut.AppendText("Number of items: " + num.ToString("n0") + "\n");
           

        }
    }
}
