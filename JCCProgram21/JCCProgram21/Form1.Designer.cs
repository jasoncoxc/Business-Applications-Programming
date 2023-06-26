namespace JCCProgram21
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDam = new System.Windows.Forms.ListBox();
            this.lstMonth = new System.Windows.Forms.ListBox();
            this.nudDate = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCFS = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dam";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gallons";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "CFS";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Month";
            // 
            // lstDam
            // 
            this.lstDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDam.FormattingEnabled = true;
            this.lstDam.ItemHeight = 18;
            this.lstDam.Items.AddRange(new object[] {
            "Fort Peck",
            "Garrison",
            "Oahe",
            "Big Bend",
            "Fort Randall",
            "Gavins Point"});
            this.lstDam.Location = new System.Drawing.Point(27, 38);
            this.lstDam.Name = "lstDam";
            this.lstDam.Size = new System.Drawing.Size(137, 94);
            this.lstDam.TabIndex = 6;
            // 
            // lstMonth
            // 
            this.lstMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonth.FormattingEnabled = true;
            this.lstMonth.ItemHeight = 18;
            this.lstMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.lstMonth.Location = new System.Drawing.Point(191, 38);
            this.lstMonth.Name = "lstMonth";
            this.lstMonth.Size = new System.Drawing.Size(140, 94);
            this.lstMonth.TabIndex = 7;
            // 
            // nudDate
            // 
            this.nudDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDate.Location = new System.Drawing.Point(347, 35);
            this.nudDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDate.Name = "nudDate";
            this.nudDate.Size = new System.Drawing.Size(73, 27);
            this.nudDate.TabIndex = 8;
            this.nudDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(443, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 23);
            this.lblDate.TabIndex = 9;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCFS
            // 
            this.lblCFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFS.Location = new System.Drawing.Point(443, 67);
            this.lblCFS.Name = "lblCFS";
            this.lblCFS.Size = new System.Drawing.Size(116, 23);
            this.lblCFS.TabIndex = 10;
            this.lblCFS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGallons
            // 
            this.lblGallons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGallons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGallons.Location = new System.Drawing.Point(443, 99);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(116, 23);
            this.lblGallons.TabIndex = 11;
            this.lblGallons.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbOut
            // 
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.Location = new System.Drawing.Point(0, 128);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(779, 322);
            this.rtbOut.TabIndex = 12;
            this.rtbOut.Text = "";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(663, 12);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(84, 34);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(663, 57);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblCFS);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.nudDate);
            this.Controls.Add(this.lstMonth);
            this.Controls.Add(this.lstDam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2021 Daily Discharge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstDam;
        private System.Windows.Forms.ListBox lstMonth;
        private System.Windows.Forms.NumericUpDown nudDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCFS;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
    }
}

