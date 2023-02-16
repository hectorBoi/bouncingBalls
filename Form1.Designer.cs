namespace BallPit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BallPitPCTBX = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.newBallButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BallPitPCTBX)).BeginInit();
            this.SuspendLayout();
            // 
            // BallPitPCTBX
            // 
            this.BallPitPCTBX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BallPitPCTBX.Location = new System.Drawing.Point(12, 12);
            this.BallPitPCTBX.Name = "BallPitPCTBX";
            this.BallPitPCTBX.Size = new System.Drawing.Size(776, 384);
            this.BallPitPCTBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BallPitPCTBX.TabIndex = 0;
            this.BallPitPCTBX.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // newBallButton
            // 
            this.newBallButton.Location = new System.Drawing.Point(338, 402);
            this.newBallButton.Name = "newBallButton";
            this.newBallButton.Size = new System.Drawing.Size(94, 29);
            this.newBallButton.TabIndex = 1;
            this.newBallButton.Text = "New Ball";
            this.newBallButton.UseVisualStyleBackColor = true;
            this.newBallButton.Click += new System.EventHandler(this.newBallButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newBallButton);
            this.Controls.Add(this.BallPitPCTBX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BallPitPCTBX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox BallPitPCTBX;
        private System.Windows.Forms.Timer timer1;
        private Button newBallButton;
    }
}