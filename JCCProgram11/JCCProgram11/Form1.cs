/**************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Program 11 Write Moving Expenses
 * Writes MovingExpenses.dat file
 * File Structure: Date, Amount, Method, Category, Description
 * Tracks moving expenses
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

namespace JCCProgram11
{
    public partial class frmTrack : Form
    {
        public frmTrack()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Preprocessing
            //IO initializations
            string path = @"MovingExpenses.dat";
            StreamWriter textOut = new StreamWriter(
                new FileStream(path, FileMode.Append, FileAccess.Write));

            //Input
            int date = Convert.ToInt32(nudDate.Value);
            int month = Convert.ToInt32(nudMonth.Value);
            int year = Convert.ToInt32(nudYear.Value);
            double amount = Convert.ToDouble(txtAmount.Text);
            string description = txtDescription.Text;
            string method = Convert.ToString(lstMethod.SelectedItem);
            string category = Convert.ToString(lstCategory.SelectedItem);


            //Processing
            string dateString = Convert.ToString(month) + "/" + Convert.ToString(date) + "/" + Convert.ToString(year);
            string outputline = dateString + "," + amount + "," + method + "," + category + "," + description;

            //Output
            textOut.WriteLine(outputline);
            rtbOut.AppendText(outputline + "\n");

            //Postprocessing
            textOut.Close();

        }
    }
}
