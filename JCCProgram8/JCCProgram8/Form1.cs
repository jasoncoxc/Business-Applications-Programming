
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCProgram8
{
    public partial class frmTheater : Form
    {
        public frmTheater()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Preprocessing
            rtbOut.Clear();
            rtbOut.AppendText("           Madison Metroplex" + "\n");
            rtbOut.AppendText("          Weekly Ticket Sales" + "\n\n");
            rtbOut.AppendText("Day        " + "Early       " + "Late   " + "Midnight" + "\n");

            //IO Initialization
            string path = @"TheaterSeats.dat";
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //Processing Loop
            while (textIn.Peek() != -1)
            {
                //Input
                string row = textIn.ReadLine();
                string[] record = row.Split(',');

                //Output
                rtbOut.AppendText(record[0].PadRight(13) +
                    record[1].PadRight(11) +
                    record[2].PadRight(8) +
                    record[3].PadLeft(6) + "\n");
            }
            
            //Postprocessing
            textIn.Close();
        }
    }
}
