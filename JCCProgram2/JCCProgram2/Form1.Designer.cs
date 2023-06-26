namespace JCCProgram2
{
    partial class frmJasonCox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJasonCox));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTestOne = new System.Windows.Forms.TextBox();
            this.txtTestTwo = new System.Windows.Forms.TextBox();
            this.txtTestThree = new System.Windows.Forms.TextBox();
            this.txtTestFour = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test Three";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test Four";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Average";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grade";
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(58, 352);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 7;
            this.btnGrade.Text = "&Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(151, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTestOne
            // 
            this.txtTestOne.Location = new System.Drawing.Point(138, 23);
            this.txtTestOne.Name = "txtTestOne";
            this.txtTestOne.Size = new System.Drawing.Size(100, 22);
            this.txtTestOne.TabIndex = 10;
            this.txtTestOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTestTwo
            // 
            this.txtTestTwo.Location = new System.Drawing.Point(138, 69);
            this.txtTestTwo.Name = "txtTestTwo";
            this.txtTestTwo.Size = new System.Drawing.Size(100, 22);
            this.txtTestTwo.TabIndex = 11;
            this.txtTestTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTestThree
            // 
            this.txtTestThree.Location = new System.Drawing.Point(138, 116);
            this.txtTestThree.Name = "txtTestThree";
            this.txtTestThree.Size = new System.Drawing.Size(100, 22);
            this.txtTestThree.TabIndex = 12;
            this.txtTestThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTestFour
            // 
            this.txtTestFour.Location = new System.Drawing.Point(138, 163);
            this.txtTestFour.Name = "txtTestFour";
            this.txtTestFour.Size = new System.Drawing.Size(100, 22);
            this.txtTestFour.TabIndex = 13;
            this.txtTestFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(138, 209);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 22);
            this.txtFinal.TabIndex = 14;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverage.Location = new System.Drawing.Point(138, 255);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(100, 23);
            this.lblAverage.TabIndex = 15;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrade
            // 
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrade.Location = new System.Drawing.Point(138, 304);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(100, 23);
            this.lblGrade.TabIndex = 16;
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmJasonCox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 387);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtTestFour);
            this.Controls.Add(this.txtTestThree);
            this.Controls.Add(this.txtTestTwo);
            this.Controls.Add(this.txtTestOne);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJasonCox";
            this.Text = "Jason Cox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTestOne;
        private System.Windows.Forms.TextBox txtTestTwo;
        private System.Windows.Forms.TextBox txtTestThree;
        private System.Windows.Forms.TextBox txtTestFour;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblGrade;
    }
}

