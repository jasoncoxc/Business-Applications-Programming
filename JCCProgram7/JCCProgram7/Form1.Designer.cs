namespace JCCProgram7
{
    partial class frmSux
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
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.grpPackage = new System.Windows.Forms.GroupBox();
            this.radHardcore = new System.Windows.Forms.RadioButton();
            this.radFearless = new System.Windows.Forms.RadioButton();
            this.radNewbie = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRock = new System.Windows.Forms.CheckBox();
            this.chkBungee = new System.Windows.Forms.CheckBox();
            this.chkScuba = new System.Windows.Forms.CheckBox();
            this.chkSky = new System.Windows.Forms.CheckBox();
            this.chkHang = new System.Windows.Forms.CheckBox();
            this.chkZip = new System.Windows.Forms.CheckBox();
            this.chkBallon = new System.Windows.Forms.CheckBox();
            this.grpPackage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbOut
            // 
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 10F);
            this.rtbOut.Location = new System.Drawing.Point(0, 254);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(477, 278);
            this.rtbOut.TabIndex = 1;
            this.rtbOut.Text = "";
            // 
            // grpPackage
            // 
            this.grpPackage.Controls.Add(this.radHardcore);
            this.grpPackage.Controls.Add(this.radFearless);
            this.grpPackage.Controls.Add(this.radNewbie);
            this.grpPackage.Location = new System.Drawing.Point(22, 12);
            this.grpPackage.Name = "grpPackage";
            this.grpPackage.Size = new System.Drawing.Size(150, 149);
            this.grpPackage.TabIndex = 2;
            this.grpPackage.TabStop = false;
            this.grpPackage.Text = "Package";
            // 
            // radHardcore
            // 
            this.radHardcore.AutoSize = true;
            this.radHardcore.Location = new System.Drawing.Point(7, 102);
            this.radHardcore.Name = "radHardcore";
            this.radHardcore.Size = new System.Drawing.Size(124, 21);
            this.radHardcore.TabIndex = 2;
            this.radHardcore.TabStop = true;
            this.radHardcore.Text = "Hardcore $499";
            this.radHardcore.UseVisualStyleBackColor = true;
            this.radHardcore.CheckedChanged += new System.EventHandler(this.radHardcore_CheckedChanged);
            // 
            // radFearless
            // 
            this.radFearless.AutoSize = true;
            this.radFearless.Location = new System.Drawing.Point(7, 60);
            this.radFearless.Name = "radFearless";
            this.radFearless.Size = new System.Drawing.Size(119, 21);
            this.radFearless.TabIndex = 1;
            this.radFearless.TabStop = true;
            this.radFearless.Text = "Fearless $349";
            this.radFearless.UseVisualStyleBackColor = true;
            this.radFearless.CheckedChanged += new System.EventHandler(this.radFearless_CheckedChanged);
            // 
            // radNewbie
            // 
            this.radNewbie.AutoSize = true;
            this.radNewbie.Checked = true;
            this.radNewbie.Location = new System.Drawing.Point(6, 21);
            this.radNewbie.Name = "radNewbie";
            this.radNewbie.Size = new System.Drawing.Size(111, 21);
            this.radNewbie.TabIndex = 0;
            this.radNewbie.TabStop = true;
            this.radNewbie.Text = "Newbie $249";
            this.radNewbie.UseVisualStyleBackColor = true;
            this.radNewbie.CheckedChanged += new System.EventHandler(this.radNewbie_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRock);
            this.groupBox1.Controls.Add(this.chkBungee);
            this.groupBox1.Controls.Add(this.chkScuba);
            this.groupBox1.Controls.Add(this.chkSky);
            this.groupBox1.Controls.Add(this.chkHang);
            this.groupBox1.Controls.Add(this.chkZip);
            this.groupBox1.Controls.Add(this.chkBallon);
            this.groupBox1.Location = new System.Drawing.Point(193, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Side Trips";
            // 
            // chkRock
            // 
            this.chkRock.AutoSize = true;
            this.chkRock.Location = new System.Drawing.Point(15, 183);
            this.chkRock.Name = "chkRock";
            this.chkRock.Size = new System.Drawing.Size(155, 21);
            this.chkRock.TabIndex = 11;
            this.chkRock.Text = "Rock Climbing $129";
            this.chkRock.UseVisualStyleBackColor = true;
            this.chkRock.CheckedChanged += new System.EventHandler(this.chkRock_CheckedChanged);
            // 
            // chkBungee
            // 
            this.chkBungee.AutoSize = true;
            this.chkBungee.Location = new System.Drawing.Point(15, 156);
            this.chkBungee.Name = "chkBungee";
            this.chkBungee.Size = new System.Drawing.Size(172, 21);
            this.chkBungee.TabIndex = 10;
            this.chkBungee.Text = "Bungee Jumping $199";
            this.chkBungee.UseVisualStyleBackColor = true;
            this.chkBungee.CheckedChanged += new System.EventHandler(this.chkBungee_CheckedChanged);
            // 
            // chkScuba
            // 
            this.chkScuba.AutoSize = true;
            this.chkScuba.Location = new System.Drawing.Point(15, 129);
            this.chkScuba.Name = "chkScuba";
            this.chkScuba.Size = new System.Drawing.Size(149, 21);
            this.chkScuba.TabIndex = 9;
            this.chkScuba.Text = "Scuba Diving $169";
            this.chkScuba.UseVisualStyleBackColor = true;
            this.chkScuba.CheckedChanged += new System.EventHandler(this.chkScuba_CheckedChanged);
            // 
            // chkSky
            // 
            this.chkSky.AutoSize = true;
            this.chkSky.Location = new System.Drawing.Point(15, 102);
            this.chkSky.Name = "chkSky";
            this.chkSky.Size = new System.Drawing.Size(126, 21);
            this.chkSky.TabIndex = 8;
            this.chkSky.Text = "Skydiving $189";
            this.chkSky.UseVisualStyleBackColor = true;
            this.chkSky.CheckedChanged += new System.EventHandler(this.chkSky_CheckedChanged);
            // 
            // chkHang
            // 
            this.chkHang.AutoSize = true;
            this.chkHang.Location = new System.Drawing.Point(15, 75);
            this.chkHang.Name = "chkHang";
            this.chkHang.Size = new System.Drawing.Size(129, 21);
            this.chkHang.TabIndex = 7;
            this.chkHang.Text = "Hang Glide $59";
            this.chkHang.UseVisualStyleBackColor = true;
            this.chkHang.CheckedChanged += new System.EventHandler(this.chkHang_CheckedChanged);
            // 
            // chkZip
            // 
            this.chkZip.AutoSize = true;
            this.chkZip.Location = new System.Drawing.Point(15, 48);
            this.chkZip.Name = "chkZip";
            this.chkZip.Size = new System.Drawing.Size(109, 21);
            this.chkZip.TabIndex = 6;
            this.chkZip.Text = "Zip Line $49";
            this.chkZip.UseVisualStyleBackColor = true;
            this.chkZip.CheckedChanged += new System.EventHandler(this.chkZip_CheckedChanged);
            // 
            // chkBallon
            // 
            this.chkBallon.AutoSize = true;
            this.chkBallon.Location = new System.Drawing.Point(15, 21);
            this.chkBallon.Name = "chkBallon";
            this.chkBallon.Size = new System.Drawing.Size(138, 21);
            this.chkBallon.TabIndex = 5;
            this.chkBallon.Text = "Ballon Ride $159";
            this.chkBallon.UseVisualStyleBackColor = true;
            this.chkBallon.CheckedChanged += new System.EventHandler(this.chkBallon_CheckedChanged);
            // 
            // frmSux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPackage);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSux_Load);
            this.grpPackage.ResumeLayout(false);
            this.grpPackage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.GroupBox grpPackage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radHardcore;
        private System.Windows.Forms.RadioButton radFearless;
        private System.Windows.Forms.RadioButton radNewbie;
        private System.Windows.Forms.CheckBox chkRock;
        private System.Windows.Forms.CheckBox chkBungee;
        private System.Windows.Forms.CheckBox chkScuba;
        private System.Windows.Forms.CheckBox chkSky;
        private System.Windows.Forms.CheckBox chkHang;
        private System.Windows.Forms.CheckBox chkZip;
        private System.Windows.Forms.CheckBox chkBallon;
    }
}

