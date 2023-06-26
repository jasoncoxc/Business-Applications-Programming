/****************************************************************************************************
 * Jason Cox
 * Dr. McKeown
 * Summer Class
 * Programming Assignment Five
 * 07/05/2022
 * JCCProgram5
 * Creates formatted currency string, finds middle of 3 numbers, displays generataion based on year.
 * *************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCProgram5
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

        private double CalcMiddle(double num1, double num2, double num3)
        {
            double middle = 0;

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    middle = num2;
                }
                else if (num1 > num3)
                {
                    middle = num3;
                }
                else
                    middle = num1;
            }
            else if (num1 > num3)
            {
                if (num1 > num2)
                {
                    middle = num1;
                }
                else if (num2 > num3)
                {
                    middle = num3;
                }
                else
                    middle = num2;
            }          

            return middle;
        }

        private string CalcGen(double year)
        {
            string gen = "";

            if (year >= 1900 && year <= 1926)
            {
                gen = "GI Generation";
            }               
            else if (year >= 1927 && year < 1946)
            {
                gen = "Silent Generation";
            }               
            else if (year >= 1946 && year < 1965)
            {
                gen = "Boomer Generation";
            }                
            else if (year >= 1965 && year < 1981)
            {
                gen = "Generation X";
            }                
            else if (year >= 1981 && year < 2001)
            {
                gen = "Millennial Generation";
            }              
            else
            {
                gen = "Generation Z";
            }
            return gen;
        }        

        private void btnStart_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();           

            //Input
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int num3 = Convert.ToInt32(txtNum3.Text);

            //Processing
            double grade = CalcMiddle(num1, num2, num3);

            //Output
            rtbOut.AppendText("The Middle Number is:".PadLeft(43) + "\n" + "\n" + grade.ToString().PadLeft(38));

        }      

        private void btnStart2_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();          

            //Input
            double year = Convert.ToDouble(txtYear.Text);

            //Processing
            string gen = CalcGen(year);

            //Output
            rtbOut.AppendText("           Your Generation is:" + "\n" + "\n" + gen.ToString().PadLeft(42));

        }
        

        private void btnStart3_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            rtbOut.AppendText("         The Currency is:" + "\n" + "\n");

            //Input
            double money = Convert.ToDouble(txtDollar.Text);
            int length = Convert.ToInt16(txtLength.Text);

            //Processing
            string all = CalcLength(money, length);

            //Output
            rtbOut.AppendText(all);

        }

        private string CalcLength(double money, int length)
        {
            string stars = "";
            string all = money.ToString("c");
           
            for (int i = all.Length; i < length; i++)
            {
                stars = stars + "*";
            }
            return stars + all;
        }
        
    }
}