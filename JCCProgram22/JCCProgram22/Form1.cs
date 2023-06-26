/***************************************************************
 * Jason Cox
 * CIS 251: BAP
 * Dr. McKeown
 * Events
 * Phoentic Alphabet Graphics * 
 * Displays image, letter and word associted with letter input
 * ************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCProgram22
{
    public partial class frmEvent : Form
    {
        public frmEvent()
        {
            InitializeComponent();
        }

        private void frmEvent_KeyDown(object sender, KeyEventArgs e)
        {
            int ascii = Convert.ToInt32(e.KeyValue);
            char typed = Convert.ToChar(ascii);
          //  bool results = false;
            string letter = typed.ToString();

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
           // while (results == true)
            {
                if (e.KeyCode == Keys.A)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Alpha";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.B)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Bravo";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.C)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Charlie";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.D)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Delta";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.E)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Echo";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.F)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Foxtrot";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.G)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Golf";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.H)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Hotel";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.I)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "India";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.J)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Juliett";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.K)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Kilo";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.L)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Lima";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.M)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Mike";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.N)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "November";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.O)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Oscar";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.P)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Papa";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.Q)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Quebec";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.R)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Romeo";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.S)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Sierra";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.T)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Tango";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.U)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Uniform";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.V)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Victor";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.W)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Whiskey";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.X)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "X-Ray";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.Y)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Yankee";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
                if (e.KeyCode == Keys.Z)
                {
                    lblLetter.Text = letter;
                    lblWord.Text = "Zulu";
                    picSignals.Image = imgSignals.Images[letter + ".png"];
                }
            }
                        
        }

        private void frmEvent_MouseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEvent_MouseMove(object sender, MouseEventArgs e)
        {
            lblLetter.Text = "";
            lblWord.Text = "";
            picSignals.Image = null;
            picSignals.InitialImage = null;
            
        }
    }
}
