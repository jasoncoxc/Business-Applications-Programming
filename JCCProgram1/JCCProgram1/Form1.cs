/*********************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Program 1 Carpet Estimate
 * Calculates cost to carpet a room
 * *******************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCProgram1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Input
            double length = double.Parse(txtLength.Text);
            double width = double.Parse(txtWidth.Text);

            //Processing
            double area = length * width;
            double backing = area * 1.59;
            double carpet = area * 3.25;
            double total = backing + carpet;

            //Output
            lblArea.Text = area.ToString("n1");
            lblBacking.Text = backing.ToString("c2");
            lblCarpet.Text = carpet.ToString("c2");
            lblTotal.Text = total.ToString("c2");
        }
    }
}
