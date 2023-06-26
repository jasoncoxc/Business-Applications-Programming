/**********************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Control Break
 * BaitShopSales.dat file
 * File Structure: Location, Day, Dept, Amount
 * Processes a control break based on location
 * *******************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCPRogram14
{
    public partial class frmControlBreak : Form
    {
        public frmControlBreak()
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
            double total = 0;
            double grandTotal = 0;
            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                      Bait Shop Sales" + "\n");
            rtbOut.AppendText("                    Control Break Report" + "\n\n");
            rtbOut.AppendText("Location                   " + "Day       " + "Dept.      " + "Amount" + "\n");

            //IO Initialization
            string path = @"BaitShopSales.dat";
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //Prime the pump
            string row = textIn.ReadLine();
            string[] record = row.Split(',');            
            string location = record[0];
            string day = record[1];
            string dept = record[2];
            double amount = double.Parse(record[3]);

            //Key Field
            string key = location;

            //Processing Loop
            while (textIn.Peek() != -1)
            {
                //Check for control break
                if (key != location)
                {
                    //Process control break
                    rtbOut.AppendText("Total for " + key.PadRight(20) +
                        total.ToString("c2").PadLeft(24) + "\n\n");

                    //Update variables
                    grandTotal += total;
                    total = 0;
                    key = location;
                }

                total += amount;

                //Display record
                rtbOut.AppendText(location.PadRight(20) +
                                  day.PadLeft(10) +
                                  dept.PadLeft(12) +
                                  amount.ToString("c2").PadLeft(12) + "\n");

                //Input
                row = textIn.ReadLine();
                record = row.Split(',');
                location = record[0];
                day = record[1];
                dept = record[2];
                amount = double.Parse(record[3]);
            }
            //Close file
            textIn.Close();

            total += amount;

            //Display record
            rtbOut.AppendText(location.PadRight(20) +
                              day.PadLeft(10) +
                              dept.PadLeft(12) +
                              amount.ToString("c2").PadLeft(12) + "\n");

            //Process last control break
            rtbOut.AppendText("Total for " + key.PadRight(20) +
                        total.ToString("c2").PadLeft(24) + "\n\n");

            //Add last location to total
            grandTotal += total;

            //Display grand total
            rtbOut.AppendText("Grand Total" + grandTotal.ToString("c2").PadLeft(43) + "\n");
        }
    }
}
