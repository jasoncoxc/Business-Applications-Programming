/**************************************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Program 4 Student Status
 * Calculates grade year, dorm, and loan amount based on GPA and credits taken so far.
 * ************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCProgram4
{
    public partial class frmStudentStatus : Form
    {
        public frmStudentStatus()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentStatus()
        {
            //Input
            double GPA = Convert.ToDouble(nudGPA.Value);
            int credits = Convert.ToInt32(trbCredits.Value);

            //Processing


            //Output
            double loan1 = 8500;
            double loan2 = 12000;

            lblCredits.Text = credits.ToString("n0");

            if (credits < 30)
                lblStatus.Text = credits.ToString("Freshman");
            else if (credits >= 30 && credits < 60)
                lblStatus.Text = credits.ToString("Sophmore");
            else if (credits >= 60 && credits < 90)
                lblStatus.Text = credits.ToString("Junior");
            else if (credits >= 90)
                lblStatus.Text = credits.ToString("Senior");

             if (GPA < 2.00)
                lblStanding.Text = GPA.ToString("Probation");
            else if (GPA >= 2.00 && GPA < 3.00)
                lblStanding.Text = GPA.ToString("Good Standing");
            else if (GPA >= 3.00 && GPA < 3.50)
                lblStanding.Text = GPA.ToString("Scholarship");
            else if (GPA >= 3.50)
                lblStanding.Text = GPA.ToString("Dean's List");

            if (GPA < 2.00)
                lblLoan.Text = GPA.ToString("'$0'");
            else if (GPA >= 2.00 && credits < 60)
                lblLoan.Text = loan1.ToString("c");
            else if (GPA >= 2.00 && credits >= 60)
                lblLoan.Text = loan2.ToString("c");

            if (GPA < 2.00 || credits < 60)
                lblHousing.Text = "Dorm";
            else if (GPA >= 2.00 && credits >= 60)
                lblHousing.Text = "Off Campus";         

        }

        private void nudGPA_ValueChanged(object sender, EventArgs e)
        {
            this.StudentStatus();
        }

        
        private void trbCredits_Scroll(object sender, EventArgs e)
        {
            this.StudentStatus();
        }
    }
}
