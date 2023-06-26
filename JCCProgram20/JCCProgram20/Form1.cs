/**********************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Binary Search
 * COVIDStats.dat file
 * File Structure: county, cases, deaths
 * Loads data file, orders data, searches through data
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

namespace JCCProgram20
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
        
        private void DisplayHeader()
        {
            rtbOut.Clear();
            rtbOut.AppendText("         South Dakota COVID Cases" + "\n");
            rtbOut.AppendText("             Latest Updates" + "\n\n");
            rtbOut.AppendText("County                 Cases   Deaths" + "\n");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Declarations
            string[] county = new string[] { "Aurora", "Beadle", "Bennett", "Bon Homme", "Brookings", "Brown", "Brule", "Buffalo", "Butte", "Campbell", "Charles Mix", "Clark", "Clay", "Codington", "Corson", "Custer", "Davison", "Day", "Deuel", "Dewey", "Douglas", "Edmunds", "Fall River", "Faulk", "Grant", "Gregory", "Haakon", "Hamlin", "Hand", "Hanson", "Harding", "Hughes", "Hutchinson", "Hyde", "Jackson", "Jerauld", "Jones", "Kingsbury", "Lake", "Lawrence", "Lincoln", "Lyman", "Marshall", "McCook", "McPherson", "Meade", "Mellette", "Miner", "Minnehaha", "Moody", "Oglala Lakota", "Pennington", "Perkins", "Potter", "Roberts", "Sanborn", "Spink", "Stanley", "Sully", "Todd", "Tripp", "Turner", "Union", "Walworth", "Yankton", "Ziebach"};
            int[] cases = new int[0];
            int[] deaths = new int[0];
            int num = 0;
            string detail = "Not Found";
            int low = 0;
            int high = county.GetUpperBound(0);
            int middle = 0;
            bool done = false;        

            //Input
            string searchCode = txtSearch.Text;
            
            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"COVIDStats.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref county, county.Length + 1);
                Array.Resize<int>(ref cases, cases.Length + 1);
                Array.Resize<int>(ref deaths, deaths.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                county[num] = record[0];
                cases[num] = Convert.ToInt32(record[1]);
                deaths[num] = Convert.ToInt32(record[2]);
                num++;
            }
            //Close file
            textIn.Close();

            while (low <= high && !done)
            {
                middle = ((low + high) / 2);
                if (searchCode == county[middle])
                {
                    detail = county[middle].PadRight(16) + cases[middle].ToString("n0").PadLeft(12) + deaths[middle].ToString("n0").PadLeft(9);
                    done = true;

                }
                else
                {
                    if (String.Compare(searchCode, county[middle], true) < 0)
                    {
                        high = middle - 1;
                    }
                    else
                    {
                        low = middle + 1;
                    }
                }
            }
            rtbOut.AppendText(detail + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Declarations
            string[] county = new string[0];
            int[] cases = new int[0];
            int[] deaths = new int[0];
            int num = 0;

            //Preprocessing
            DisplayHeader();

            //Open file
            //IO initializations
            string path = @"COVIDStats.dat";
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                //Resize arrays to make room for new record
                Array.Resize<string>(ref county, county.Length + 1);
                Array.Resize<int>(ref cases, cases.Length + 1);
                Array.Resize<int>(ref deaths, deaths.Length + 1);

                //Read record and add to array
                string row = textIn.ReadLine();
                string[] record = row.Split(',');
                county[num] = record[0];
                cases[num] = Convert.ToInt32(record[1]);
                deaths[num] = Convert.ToInt32(record[2]);

                rtbOut.AppendText(county[num].ToString().PadRight(15) + cases[num].ToString("n0").PadLeft(13) +
                    deaths[num].ToString("n0").PadLeft(9) + "\n");
            }
            //Close file
            textIn.Close();
        }
    }
}
