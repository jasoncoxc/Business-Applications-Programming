/****************************************************************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * 2d Array
 * DamNames.dat and Mainstem.dat files
 * File Structure: dam, date, CFS, gallons
 * Loads data files, populates list box with names, puts Mainstem.dat into 2d array, and calculates gallons/CFS
 * *************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public static int[,] discharge = new int[365, 6];
        
        private void Form1_Load(object sender, EventArgs e)
        {                  
            int num = 0;

            //Preprocessing
            rtbOut.AppendText("                        Mainstem Dams Daily Discharge Rate" + "\n");
            rtbOut.AppendText("                            Cubic Feet Per Second (CFS)" + "\n\n");
            rtbOut.AppendText("   Fort Peck     Garrison         Oahe     Big Bend Fort Randall Gavins Point" + "\n");

            //Open file
            //IO initializations
            string path = @"Mainstem.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));            

            while (textIn.Peek() != -1)
            {                
                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');               
                discharge[num, 0] = Convert.ToInt32(record[0]);
                discharge[num, 1] = Convert.ToInt32(record[1]);
                discharge[num, 2] = Convert.ToInt32(record[2]);
                discharge[num, 3] = Convert.ToInt32(record[3]);
                discharge[num, 4] = Convert.ToInt32(record[4]);
                discharge[num, 5] = Convert.ToInt32(record[5]);

                //Display Record
                rtbOut.AppendText(discharge[num, 0].ToString("n0").PadLeft(12) +
                discharge[num, 1].ToString("n0").PadLeft(13) +
                discharge[num, 2].ToString("n0").PadLeft(13) +
                discharge[num, 3].ToString("n0").PadLeft(13) +
                discharge[num, 4].ToString("n0").PadLeft(13) +
                discharge[num, 5].ToString("n0").PadLeft(13) + "\n");
                num++;
            }

            //Close file
            textIn.Close();           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Declarations
            int day = Convert.ToInt32(nudDate.Value);
            int month = Convert.ToInt32(lstMonth.SelectedIndex + 1);
            int name = Convert.ToInt32(lstDam.SelectedIndex);
            int year = 2021;
            DateTime date = new DateTime(year, month, day);
            int doy = Convert.ToInt32(date.DayOfYear - 1);                   
          
            //Processing
            int CFS = discharge[doy,name];
            double gallons = 7.48051948 * CFS;

            //Output
            lblGallons.Text = gallons.ToString("n0");
            lblCFS.Text = CFS.ToString("n0");
            lblDate.Text = date.ToString();
        }
    }
}
