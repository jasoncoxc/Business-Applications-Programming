/**************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. MaKeown
 * Program 2 Grading
 * Calculates the average and grade for a student
 * ************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCProgram2
{
    public partial class frmJasonCox : Form
    {
        public frmJasonCox()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            //Input
            int test1 = short.Parse(txtTestOne.Text);
            int test2 = short.Parse(txtTestTwo.Text);
            int test3 = short.Parse(txtTestThree.Text);
            int test4 = short.Parse(txtTestFour.Text);
            int final = short.Parse(txtFinal.Text);

            //Processing
            float total = test1 + test2 + test3 + test4 + (final * 2);
            float average = (float)total / 6;

            //Output
            lblAverage.Text = average.ToString("f1");

            if (average > 90)
                lblGrade.Text = average.ToString("'A'");
            else if (average >= 80 && average <= 89.9999)
                lblGrade.Text = average.ToString("'B'");
            else if (average >= 70 && average <= 79.9999)
                lblGrade.Text = average.ToString("'C'");
            else if (average >= 60 && average <= 69.9999)
                lblGrade.Text = average.ToString("'D'");
            else if (average <= 59.9999)
                lblGrade.Text = average.ToString("'F'");
        }
    }
}
