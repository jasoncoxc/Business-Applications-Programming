/****************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Control Break
 * MadisonMetroplexTickets.dat file
 * File Structure: month, day, early, late, midnight
 * Processes a control break based on month
 * *************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCPRogram15
{
    public partial class frmMadisonMetroplex : Form
    {
        public frmMadisonMetroplex()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Declarations
            double monthlyTotal = 0;
            double total = 0;
            double grandTotal = 0;
            double earlyTotal = 0;
            double lateTotal = 0;
            double midnightTotal = 0;

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                         Madison Metroplex" + "\n");
            rtbOut.AppendText("                        Ticket Sales Report" + "\n\n");
            rtbOut.AppendText("Month       " + "Day             " + "Early      " + "Late   " + "Midnight   " + "Total" + "\n");

            //IO Initialization
            string path = @"MadisonMetroplexTickets.dat";
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //Prime the pump
            string row = textIn.ReadLine();
            string[] record = row.Split(',');
            string month = record[0];
            string day = record[1];
            double early = Convert.ToDouble(record[2]);
            double late = Convert.ToDouble(record[3]);
            double midnight = Convert.ToDouble(record[4]);

            //Key field
            string key = month;

            //Processing Loop
            while (textIn.Peek() != -1)
            {
                //Check for control break
                if (key != month)
                {
                    //Process control break
                    rtbOut.AppendText("Total for " + key.PadRight(15) +
                        earlyTotal.ToString("n0").PadLeft(8) +
                        lateTotal.ToString("n0").PadLeft(10) +
                        midnightTotal.ToString("n0").PadLeft(11) +
                        monthlyTotal.ToString("n0").PadLeft(8) + "\n\n");

                    //Update variables
                    grandTotal += monthlyTotal;
                    monthlyTotal = 0;
                    earlyTotal = 0;
                    lateTotal = 0;
                    midnightTotal = 0;
                    key = month;
                }

                //Accumulate tickets
                total = early + late + midnight;
                monthlyTotal += total;
                earlyTotal += early;
                lateTotal += late;
                midnightTotal += midnight;

                //Display record
                rtbOut.AppendText(month.PadRight(12) +
                                  day.PadRight(10) +
                                  early.ToString("n0").PadLeft(11) +
                                  late.ToString("n0").PadLeft(10) +
                                  midnight.ToString("n0").PadLeft(11) +
                                  total.ToString("n0").PadLeft(8) + "\n");

                //Input
                row = textIn.ReadLine();
                record = row.Split(',');
                month = record[0];
                day = record[1];
                early = Convert.ToDouble(record[2]);
                late = Convert.ToDouble(record[3]);
                midnight = Convert.ToDouble(record[4]);
            }
            //Close file
            textIn.Close();

            total = early + late + midnight;
            monthlyTotal += total;
            earlyTotal += early;
            lateTotal += late;
            midnightTotal += midnight;

            //Display record
            rtbOut.AppendText(month.PadRight(12) +
                              day.PadRight(10) +
                              early.ToString("n0").PadLeft(11) +
                              late.ToString("n0").PadLeft(10) +
                              midnight.ToString("n0").PadLeft(11) +
                              total.ToString("n0").PadLeft(8) + "\n");

            //Process last control break            
            rtbOut.AppendText("Total for " + key.PadRight(15) +
                earlyTotal.ToString("n0").PadLeft(8) +
                lateTotal.ToString("n0").PadLeft(10) +
                midnightTotal.ToString("n0").PadLeft(11) +
                monthlyTotal.ToString("n0").PadLeft(8) + "\n\n");

            //Update grand total
            grandTotal += monthlyTotal;


            //Display grand total
            rtbOut.AppendText("Grand Total" + grandTotal.ToString("n0").PadLeft(51) + "\n");
        }
    }
}
