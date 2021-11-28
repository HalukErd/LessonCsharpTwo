namespace LessonCsharpTwo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mousePos = new System.Windows.Forms.Label();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.whichKeyDown = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // mousePos
            // 
            this.mousePos.AutoSize = true;
            this.mousePos.Location = new System.Drawing.Point(13, 13);
            this.mousePos.Name = "mousePos";
            this.mousePos.Size = new System.Drawing.Size(72, 16);
            this.mousePos.TabIndex = 1;
            this.mousePos.Text = "MousePos";
            this.mousePos.Click += new System.EventHandler(this.mousePos_Click);
            // 
            // flappy
            // 
            this.flappy.Image = ((System.Drawing.Image)(resources.GetObject("flappy.Image")));
            this.flappy.Location = new System.Drawing.Point(182, 234);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(91, 86);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 2;
            this.flappy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // whichKeyDown
            // 
            this.whichKeyDown.AutoSize = true;
            this.whichKeyDown.Location = new System.Drawing.Point(777, 13);
            this.whichKeyDown.Name = "whichKeyDown";
            this.whichKeyDown.Size = new System.Drawing.Size(44, 16);
            this.whichKeyDown.TabIndex = 3;
            this.whichKeyDown.Text = "label1";
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-47, 528);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1087, 54);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1020, 573);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.whichKeyDown);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.mousePos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mousePos;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label whichKeyDown;
        private System.Windows.Forms.PictureBox ground;
    }
}

