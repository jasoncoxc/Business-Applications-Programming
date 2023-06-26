/**************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Program 9 Yields
 * Reads FieldYield.dat file
 * File Structure: Field, Crop, Acres, Bushels, Yield, Revenue
 * Crop yield per field based on acreage. 
 * ***********************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram9
{
    public partial class frmSod : Form
    {
        public frmSod()
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
            DateTime currentDateTime = DateTime.Now;
            this.Text = currentDateTime.ToShortDateString() + "   " + currentDateTime.ToShortTimeString();
        }
        private void frmSod_Load(object sender, EventArgs e)
        {
            this.DisplayHeader();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Declarations           
            double yield = 0;
            double bushels = 0;
            double revenue = 0;
            double totAcres = 0;
            double acres = 0;
            double totRevenue = 0;
            double price = 0;
            
            

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                          Sodbuster Farms" + "\n");
            rtbOut.AppendText("                         2021 Crop Summary" + "\n\n");
            rtbOut.AppendText("Field         " + "Crop      " + "Acres   " + "Bushels    " + "Yield       " + "Revenue" +"\n");

            //IO Initialization
            string path = @"FieldYield.dat";
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //Processing Loop
            while (textIn.Peek() != -1)
            {
               
                //Input
                string row = textIn.ReadLine();                
                string[] record = row.Split(',');
                acres = double.Parse(record[1]);
                bushels = double.Parse(record[3]);                          
                if (record[2] == "corn")
                {
                    price = 4.5;
                }
                if (record[2] == "beans")
                {
                    price = 9.75;
                }
                if (record[2] == "wheat")
                {
                    price = 5.15;
                }

                //Processing                
                totAcres += acres;
                totRevenue += revenue;
                yield = bushels / acres;
                revenue = bushels * price;

                //Output                 
                rtbOut.AppendText(record[0].PadRight(14) +
                    record[2].PadRight(5) +
                    record[1].PadLeft(10) +
                    record[3].PadLeft(10) + 
                    yield.ToString("n1").PadLeft(9) +
                    revenue.ToString("c2").PadLeft(14) + "\n");                
            }
            rtbOut.AppendText("Total:" + totAcres.ToString("n0").PadLeft(23) + totRevenue.ToString("c2").PadLeft(33));

            //Postprocessing
            textIn.Close();
        }
    }
}
