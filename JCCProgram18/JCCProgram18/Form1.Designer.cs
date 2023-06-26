namespace JCCProgram18
{
    partial class frmNFL
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTeam = new System.Windows.Forms.ListBox();
            this.nudWeek = new System.Windows.Forms.NumericUpDown();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.lblGames = new System.Windows.Forms.Label();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstTeam
            // 
            this.lstTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTeam.FormattingEnabled = true;
            this.lstTeam.ItemHeight = 20;
            this.lstTeam.Location = new System.Drawing.Point(285, 12);
            this.lstTeam.Name = "lstTeam";
            this.lstTeam.Size = new System.Drawing.Size(144, 124);
            this.lstTeam.Sorted = true;
            this.lstTeam.TabIndex = 3;
            this.lstTeam.SelectedIndexChanged += new System.EventHandler(this.lstTeam_SelectedIndexChanged);
            // 
            // nudWeek
            // 
            this.nudWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeek.Location = new System.Drawing.Point(538, 12);
            this.nudWeek.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudWeek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeek.Name = "nudWeek";
            this.nudWeek.Size = new System.Drawing.Size(55, 27);
            this.nudWeek.TabIndex = 4;
            this.nudWeek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeek.ValueChanged += new System.EventHandler(this.nudWeek_ValueChanged);
            // 
            // txtAttendance
            // 
            this.txtAttendance.AcceptsReturn = true;
            this.txtAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttendance.Location = new System.Drawing.Point(457, 96);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(225, 22);
            this.txtAttendance.TabIndex = 5;
            this.txtAttendance.Text = "0";
            // 
            // lblGames
            // 
            this.lblGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(713, 11);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(75, 23);
            this.lblGames.TabIndex = 6;
            this.lblGames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbOut
            // 
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOut.Location = new System.Drawing.Point(0, 124);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(851, 485);
            this.rtbOut.TabIndex = 7;
            this.rtbOut.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Week";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Games";
            // 
            // frmNFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.nudWeek);
            this.Controls.Add(this.lstTeam);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNFL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Football League";
            this.Load += new System.EventHandler(this.frmNFL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstTeam;
        private System.Windows.Forms.NumericUpDown nudWeek;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

