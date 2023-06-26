/********************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Program 7 Suxdontit Adventures
 * Takes package and side trip input and calculates total.
 * ******************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCProgram7
{
    public partial class frmSux : Form
    {
        public frmSux()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoWork()
        {
            //Declarations
            const double NEWBIE = 249;
            const double FEARLESS = 349;
            const double HARDCORE = 499;
            const double BALLONRIDE = 159;
            const double ZIPLINE = 49;
            const double HANGGLIDING = 59;
            const double SKYDIVING = 189;
            const double SCUBADIVING = 169;
            const double BUNGEEJUMPING = 199;
            const double ROCKCLIMBING = 129;
            const double SURCHARGE = .12;
            double subtotal = 0;
            


            //Preprocessing
            DisplayHeader();

            //Input
            if (radNewbie.Checked == true)
            {
                subtotal = NEWBIE;
                rtbOut.AppendText("Newbie Package".PadRight(20) + NEWBIE.ToString("c").PadLeft(12) + "\n");
            }
            else if (radFearless.Checked == true)
            {
                subtotal = FEARLESS;
                rtbOut.AppendText("Fearless Package".PadRight(20) + FEARLESS.ToString("c").PadLeft(12) + "\n");
            }
            else
            {
                subtotal = HARDCORE;
                rtbOut.AppendText("Hardcore Package".PadRight(20) + HARDCORE.ToString("c").PadLeft(12) + "\n");
            }
            if (chkBallon.Checked == true)
            {
                subtotal += BALLONRIDE;
                rtbOut.AppendText("Ballon Ride".PadRight(20) + BALLONRIDE.ToString("c").PadLeft(12) + "\n");
            }
            if (chkZip.Checked == true)
            {
                subtotal += ZIPLINE;
                rtbOut.AppendText("Zip Line".PadRight(20) + ZIPLINE.ToString("c").PadLeft(12) + "\n");
            }
            if (chkHang.Checked == true)
            {
                subtotal += HANGGLIDING;
                rtbOut.AppendText("Hang Gliding".PadRight(20) + HANGGLIDING.ToString("c").PadLeft(12) + "\n");
            }
            if (chkSky.Checked == true)
            {
                subtotal += SKYDIVING;
                rtbOut.AppendText("Skydiving".PadRight(20) + SKYDIVING.ToString("c").PadLeft(12) + "\n");
            }
            if (chkScuba.Checked == true)
            {
                subtotal += SCUBADIVING;
                rtbOut.AppendText("Scuba Diving".PadRight(20) + SCUBADIVING.ToString("c").PadLeft(12) + "\n");
            }
            if (chkBungee.Checked == true)
            {
                subtotal += BUNGEEJUMPING;
                rtbOut.AppendText("Bungee Jumping".PadRight(20) + BUNGEEJUMPING.ToString("c").PadLeft(12) + "\n");
            }
            if (chkRock.Checked == true)
            {
                subtotal += ROCKCLIMBING;
                rtbOut.AppendText("Rock Climbing".PadRight(20) + ROCKCLIMBING.ToString("c").PadLeft(12) + "\n");
            }
            

            //Postprocessing

            double liability = subtotal * SURCHARGE;
            double total = subtotal + liability;
            double liabilitycharge = total - subtotal;
            rtbOut.AppendText("Subtotal".PadRight(20) + subtotal.ToString("c").PadLeft(12) + "\n");
            rtbOut.AppendText("Liability Surcharge".PadRight(20) + liabilitycharge.ToString("c").PadLeft(12) + "\n");
            rtbOut.AppendText("Total".PadRight(20) + total.ToString("c").PadLeft(12));

        }

        private void DisplayHeader()
        {
            rtbOut.Clear();
            DateTime currentDate = DateTime.Today;
            this.Text = currentDate.ToShortDateString();

            rtbOut.AppendText("            Suxdontit Adventures" + "\n");
            rtbOut.AppendText("            Rental Fee Schedule" + "\n\n");
        }
        private void frmSux_Load(object sender, EventArgs e)
        {
            DisplayHeader();
            DoWork();
        }

        private void radNewbie_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void radFearless_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void radHardcore_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void chkBallon_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void chkZip_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void chkHang_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void chkSky_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void chkScuba_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void chkBungee_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }

        private void chkRock_CheckedChanged(object sender, EventArgs e)
        {
            DoWork();
        }
    }
}
