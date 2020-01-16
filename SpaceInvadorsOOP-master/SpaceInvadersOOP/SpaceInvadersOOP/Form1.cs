using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersOOP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        GameElements player1 = new GameElements();
        bool leftout = false;
        bool rightout;

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (!rightout)
            {
                if (e.KeyCode == Keys.D)
                {
                    pBplayer.Left += player1.move(player1.speed_ = 4);
                    positionXplayer.Text = pBplayer.Location.X.ToString();
                }
            }
            if (!leftout)
            {
                if (e.KeyCode == Keys.A)
                {
                    pBplayer.Left -= player1.move(player1.speed_ = 4);
                    positionXplayer.Text = pBplayer.Location.X.ToString();
                }
            }
                if(e.KeyCode == Keys.Space)
            {
                draw();
            }
            
            positionXplayer2.Text = this.Width.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void draw()
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new System.Drawing.Point(pBplayer.Location.X, pBplayer.Location.Y);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 50);
            pictureBox1.BackColor = Color.Black;
            this.Controls.Add(pictureBox1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pBplayer.Bounds.IntersectsWith(this.Bounds))
            {
             

            }

            int x = pBplayer.Location.X;
            int y = pBplayer.Location.Y;

            if (x <= 0 + pBplayer.Width/2 )
            {
                leftout = true;
            }else
            {
                leftout = false;
            }
            if(x >= this.Width - 2 * pBplayer.Width)
            {
                rightout = true;
            }
            else
            {
                rightout = false;
            }
             

        }
    }
}
