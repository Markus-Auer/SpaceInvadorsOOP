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
                if (e.KeyCode == Keys.Right)
                {
                    pBplayer.Left += player1.move(player1.speed_ = 4);
                }
            }
            if (!leftout)
            {
                if (e.KeyCode == Keys.Left)
                {
                    pBplayer.Left -= player1.move(player1.speed_ = 4);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pBplayer.Bounds.IntersectsWith(this.Bounds))
            {
             

            }

           /* int x = pBplayer.Location.X;
            int y = pBplayer.Location.Y;

            if (x <= 0 )
            {
                leftout = true;
            }else
            {
                leftout = false;
            }
            if(x >= this.Width)
            {
                rightout = true;
            }
            else
            {
                rightout = false;
            }
            */ 

        }
    }
}
