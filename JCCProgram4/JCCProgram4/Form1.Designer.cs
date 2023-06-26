namespace JCCProgram4
{
    partial class frmStudentStatus
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
            this.btnExit = new System.Windows.Forms.Button();
            this.nudGPA = new System.Windows.Forms.NumericUpDown();
            this.trbCredits = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStanding = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblHousing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(465, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nudGPA
            // 
            this.nudGPA.DecimalPlaces = 2;
            this.nudGPA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudGPA.Location = new System.Drawing.Point(118, 154);
            this.nudGPA.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudGPA.Name = "nudGPA";
            this.nudGPA.Size = new System.Drawing.Size(67, 22);
            this.nudGPA.TabIndex = 1;
            this.nudGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGPA.ValueChanged += new System.EventHandler(this.nudGPA_ValueChanged);
            // 
            // trbCredits
            // 
            this.trbCredits.Location = new System.Drawing.Point(12, 95);
            this.trbCredits.Maximum = 250;
            this.trbCredits.Name = "trbCredits";
            this.trbCredits.Size = new System.Drawing.Size(547, 56);
            this.trbCredits.TabIndex = 2;
            this.trbCredits.Scroll += new System.EventHandler(this.trbCredits_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Status Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dismal State University";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Credits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Standing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Loan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Housing";
            // 
            // lblCredits
            // 
            this.lblCredits.Location = new System.Drawing.Point(218, 156);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(100, 23);
            this.lblCredits.TabIndex = 21;
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(218, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStanding
            // 
            this.lblStanding.Location = new System.Drawing.Point(218, 228);
            this.lblStanding.Name = "lblStanding";
            this.lblStanding.Size = new System.Drawing.Size(100, 23);
            this.lblStanding.TabIndex = 23;
            this.lblStanding.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLoan
            // 
            this.lblLoan.Location = new System.Drawing.Point(218, 263);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(100, 23);
            this.lblLoan.TabIndex = 24;
            this.lblLoan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHousing
            // 
            this.lblHousing.Location = new System.Drawing.Point(218, 300);
            this.lblHousing.Name = "lblHousing";
            this.lblHousing.Size = new System.Drawing.Size(100, 23);
            this.lblHousing.TabIndex = 25;
            this.lblHousing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "GPA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmStudentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHousing);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.lblStanding);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbCredits);
            this.Controls.Add(this.nudGPA);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jason Cox";
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudGPA;
        private System.Windows.Forms.TrackBar trbCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStanding;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblHousing;
        private System.Windows.Forms.Label label3;
    }
}

