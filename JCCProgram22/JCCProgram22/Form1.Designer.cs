namespace JCCProgram22
{
    partial class frmEvent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvent));
            this.imgSignals = new System.Windows.Forms.ImageList(this.components);
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.picSignals = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSignals)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSignals
            // 
            this.imgSignals.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSignals.ImageStream")));
            this.imgSignals.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSignals.Images.SetKeyName(0, "A.png");
            this.imgSignals.Images.SetKeyName(1, "B.png");
            this.imgSignals.Images.SetKeyName(2, "C.png");
            this.imgSignals.Images.SetKeyName(3, "D.png");
            this.imgSignals.Images.SetKeyName(4, "E.png");
            this.imgSignals.Images.SetKeyName(5, "F.png");
            this.imgSignals.Images.SetKeyName(6, "G.png");
            this.imgSignals.Images.SetKeyName(7, "H.png");
            this.imgSignals.Images.SetKeyName(8, "I.png");
            this.imgSignals.Images.SetKeyName(9, "J.png");
            this.imgSignals.Images.SetKeyName(10, "K.png");
            this.imgSignals.Images.SetKeyName(11, "L.png");
            this.imgSignals.Images.SetKeyName(12, "M.png");
            this.imgSignals.Images.SetKeyName(13, "N.png");
            this.imgSignals.Images.SetKeyName(14, "O.png");
            this.imgSignals.Images.SetKeyName(15, "P.png");
            this.imgSignals.Images.SetKeyName(16, "Q.png");
            this.imgSignals.Images.SetKeyName(17, "R.png");
            this.imgSignals.Images.SetKeyName(18, "S.png");
            this.imgSignals.Images.SetKeyName(19, "T.png");
            this.imgSignals.Images.SetKeyName(20, "U.png");
            this.imgSignals.Images.SetKeyName(21, "V.png");
            this.imgSignals.Images.SetKeyName(22, "W.png");
            this.imgSignals.Images.SetKeyName(23, "X.png");
            this.imgSignals.Images.SetKeyName(24, "Y.png");
            this.imgSignals.Images.SetKeyName(25, "Z.png");
            // 
            // lblLetter
            // 
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter.Location = new System.Drawing.Point(39, 172);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(100, 23);
            this.lblLetter.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(39, 215);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(100, 23);
            this.lblWord.TabIndex = 2;
            // 
            // picSignals
            // 
            this.picSignals.Location = new System.Drawing.Point(43, 12);
            this.picSignals.Name = "picSignals";
            this.picSignals.Size = new System.Drawing.Size(128, 157);
            this.picSignals.TabIndex = 0;
            this.picSignals.TabStop = false;
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 261);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.picSignals);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A - Z";
            this.Click += new System.EventHandler(this.frmEvent_MouseClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEvent_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEvent_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picSignals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgSignals;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.PictureBox picSignals;
    }
}

