using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LessonCsharpTwo
{
    public partial class Form1 : Form
    {
        private static int gravitySpeed = 3;
        private int gravity = gravitySpeed;
        private PictureBox flappyTemplate;
        private List<PictureBox> bullets = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Text = Form1.DefaultBackColor.ToArgb().ToString();
            //timer1.Interval = 20;
            //timer1.Enabled = true;
            flappyTemplate = flappy;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            handleMouseTextAndLocation();
            handleGravity();
            handleHitBoxEvents();
        }

        private void mousePos_Click(object sender, EventArgs e)
        {
            
        }

        private void handleMouseTextAndLocation()
        {
            mousePos.Text = MousePosition.X + ", " + MousePosition.Y;
            mousePos.Location = MousePosition;
        }

        private void handleGravity()
        {
            //flappy.Location = new Point(flappy.Location.X, flappy.Location.Y + gravity);
            flappy.Top += gravity;
            foreach(Control xControl in this.Controls)
            {
                if(xControl is PictureBox && xControl.Tag == "bullet")
                {
                    xControl.Top += gravity;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            whichKeyDown.Text = e.KeyCode.ToString();
            if(e.KeyCode == Keys.Space )
            {
                gravity = -1 * gravitySpeed;
            }
            if(e.KeyCode == Keys.Q)
            {
                flappy = flappyTemplate;
                flappy.Top -= 100;
                this.Controls.Add(flappy);
            }
            if(e.KeyCode == Keys.W)
            {
                PictureBox bullet = new PictureBox();
                bullet.Image = flappyTemplate.Image;
                bullet.Size = flappyTemplate.Size;
                bullet.Tag = "bullet";

                bullet.Left = flappyTemplate.Left;

                bullet.Top = flappy.Top - 100;

                this.Controls.Add(bullet);
                bullet.BringToFront();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            whichKeyDown.Text = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Space)
            {
                gravity = gravitySpeed;
            }
        }

        private void form1_SizeChanged(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(Width / 2, Height);
            ground.Size = new Size(Width, 40);
            whichKeyDown.Text =
                ground.Location.X + " "
                + ground.Location.Y + " "
                + Width.ToString() + " "
                + Height.ToString();
        }

        private void handleHitBoxEvents()
        {
            foreach(Control xControl in this.Controls)
            {
                if(xControl is PictureBox 
                    && xControl.Tag == "bullet" 
                    && ((PictureBox)xControl).Bounds.IntersectsWith(ground.Bounds))
                {
                    gravity = 0;
                    Thread.Sleep(200);
                    this.Controls.Remove(xControl);
                    //Application.Exit();
                    whichKeyDown.Text = "GameOver";
                }
            }
            if(this.Controls.Contains(flappy) && flappy.Bounds.IntersectsWith(ground.Bounds))
            {
                gravity = 0;
                Thread.Sleep(200);
                this.Controls.Remove(flappy);
                //Application.Exit();
                whichKeyDown.Text = "GameOver";
            }
        }
    }
}
