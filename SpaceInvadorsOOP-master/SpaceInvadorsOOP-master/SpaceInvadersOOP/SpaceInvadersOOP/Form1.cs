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
        int state = 0;

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
                if (e.KeyCode == Keys.Right)
                {
                    state = 1;
                    //pBplayer.Left += player1.move(player1.speed_ = 4);
                    //positionXplayer.Text = pBplayer.Location.X.ToString();
                }
            }
            if (!leftout)
            {
                if (e.KeyCode == Keys.Left)
                {
                    state = 2;
                    //pBplayer.Left -= player1.move(player1.speed_ = 4);
                    //positionXplayer.Text = pBplayer.Location.X.ToString();
                }
            }
                if(e.KeyCode == Keys.Space)
            {
                //draw();
                state = 3;
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
            pictureBox1.Size = new System.Drawing.Size(10, 15);
            pictureBox1.BackColor = Color.Black;
            this.Controls.Add(pictureBox1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            switch (state)
            {
                case 1:
                    pBplayer.Left += player1.move(player1.speed_ = 4);
                    state = 0;
                    break;
                case 2:
                    pBplayer.Left -= player1.move(player1.speed_ = 4);
                    state = 0;
                    break;
                case 3:
                    draw();
                    //state = 0;
                    break;

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
