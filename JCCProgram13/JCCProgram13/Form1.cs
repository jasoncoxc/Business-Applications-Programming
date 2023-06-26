/***********************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * South Dakota Counties
 * Reads SDCounties.dat file
 * File Structure: county, 2020 population, kids, area, 2010 population
 * Displays county info, children, and density.
 * ********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram13
{
    public partial class frmCounties : Form
    {
        public frmCounties()
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
            double difference = 0;
            double density = 0;
            double kidsPercent = 0;
            double totalPop = 0;
            double totalPop2010 = 0;
            double totalDifference = 0;
            double totalKids = 0;
            double totalArea = 0;
            double counties = 0;
            double totalDensity = 0;
            double densityAvg = 0;
            double totalKidsPercent = 0;
            double kidsAvg = 0;

            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("                              South Dakota Counties" + "\n");
            rtbOut.AppendText("                                2020 Census Data" + "\n\n");
            rtbOut.AppendText("County       " + "Population  " + "2010 Pop.  " + "Pop +/-     " + "Kids     " + "Area  " + "Density   "  + "%Kids" + "\n");

            //IO Initialization
            string path = @"SDCounties.dat";
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //Processing Loop
            while (textIn.Peek() != -1)
            {
                //Input
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                double pop = double.Parse(record[1]);
                double pop2010 = double.Parse(record[4]);
                double kids = double.Parse(record[2]);
                double area = double.Parse(record[3]);

                //Processing
                difference = pop - pop2010;
                density = pop / area;
                kidsPercent = kids / pop;
                totalPop += pop;
                totalPop2010 += pop2010;
                totalDifference += difference;
                totalKids += kids;
                totalArea += area;                
                totalDensity += density;
                densityAvg = totalPop / totalArea;               
                kidsAvg = totalKids / totalPop;
                if (pop > 0)
                {
                    counties++;
                }


                //Output
                rtbOut.AppendText(record[0].PadRight(13) +
                    pop.ToString("n0").PadLeft(10) +
                    pop2010.ToString("n0").PadLeft(11) +
                    difference.ToString("n0").PadLeft(9) +
                    kids.ToString("n0").PadLeft(9) +
                    area.ToString("n0").PadLeft(9) +
                    density.ToString("n1").PadLeft(9) +
                    kidsPercent.ToString("p1").PadLeft(8) + "\n");
            }

            //Postprocessing
            textIn.Close();

            rtbOut.AppendText("Total:" + totalPop.ToString("n0").PadLeft(17) + totalPop2010.ToString("n0").PadLeft(11) + totalDifference.ToString("n0").PadLeft(9) + totalKids.ToString("n0").PadLeft(9) + totalArea.ToString("n0").PadLeft(9) + "\n");
            rtbOut.AppendText("Overall:" + densityAvg.ToString("n1").PadLeft(62) + kidsAvg.ToString("p2").PadLeft(8) + "\n");
            rtbOut.AppendText("Counties:  " + counties.ToString() + "\n");
        }
    }
}
