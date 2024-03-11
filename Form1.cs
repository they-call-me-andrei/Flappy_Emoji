using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace game2
{
    public partial class Form1 : Form
    {
        private static int x = 500, y = 360,x1 = -10,y1 = 300, count = 0;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Top = y;
            pictureBox1.Left = x;
            pictureBox4.BringToFront();
            pictureBox3.BringToFront();
            pictureBox2.BringToFront();
            pictureBox1.BringToFront();
            button2.BringToFront();

            //pictureBox8.BringToFront();    player2

            pictureBox5.BringToFront();
            pictureBox5.Left = -10;
            pictureBox5.Top = r.Next(170, 300);
            pictureBox6.BringToFront();
            pictureBox6.Left = -150;
            pictureBox6.Top = r.Next(170, 300);
            pictureBox7.BringToFront();
            pictureBox7.Left = -300;
            pictureBox7.Top = r.Next(170, 300);
        }

        private static Boolean startgame = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(startgame == true)
            {
                if (jump == true)
                {
                    pictureBox1.Left -= 2;
                    pictureBox1.Top = (pictureBox1.Left - duplicate + 5) * (pictureBox1.Left - duplicate + 5) + 5 * (pictureBox1.Left - duplicate + 5) + 80;
                }
                if (pictureBox1.Top > 310)
                {
                    jump = false;
                }
                if (pictureBox1.Left < -20)
                {
                    pictureBox1.Left = x + 70;
                }

                //player2

                /*
                if (jump1 == true)
                {
                    pictureBox8.Left -= 2;
                    pictureBox8.Top = (pictureBox8.Left - duplicate1 + 5) * (pictureBox8.Left - duplicate1 + 5) + 5 * (pictureBox8.Left - duplicate1 + 5) + 80;
                }
                if (pictureBox8.Top > 310)
                {
                    jump1 = false;
                }
                if (pictureBox8.Left < -70)
                {
                    pictureBox8.Left = x + 200;
                }
                */
            }
           
            
        }

        private static int duplicate,duplicate1;

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            startgame = true;
        }

        private static int pause = 0;

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(pause %2 == 0)
            {
                startgame = false;
                button2.Text = "Unpause";
            }
            else
            {
                startgame = true;
                button2.Text = "Pause";
            }
            pause++;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {/*
            button2.Width += 10;
            button2.Height += 10;
            button2.Location = new Point(button2.Left - 10, button2.Top - 10);*/
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {/*
            button2.Width -= 10;
            button2.Height -= 10;
            button2.Location = new Point(button2.Left + 10, button2.Top + 10);
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                startgame = false;
                button2.Text = "Unpause";
            }
            else
            {
                startgame = true;
                button2.Text = "Pause";
            }
            x++;
        }

        private static Boolean hit = false;


        private static Boolean jump = false, jump1 = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(startgame == true)
            {
                pictureBox5.Left += 2;
                pictureBox6.Left += 2;
                pictureBox7.Left += 2;
                if (pictureBox5.Left > 610)
                {
                    pictureBox5.Left = -150;
                    pictureBox5.Top = r.Next(170, 300);
                }
                if (pictureBox6.Left > 610)
                {
                    pictureBox6.Left = -250;
                    pictureBox6.Top = r.Next(170, 300);
                }
                if (pictureBox7.Left > 610)
                {
                    pictureBox7.Left = -400;
                    pictureBox7.Top = r.Next(170, 300);
                }
                if ((pictureBox1.Left + 72>pictureBox5.Left)&&(pictureBox1.Left<pictureBox5.Left + 42))
                {
                    if((pictureBox1.Top + 68>pictureBox5.Top)&&(pictureBox1.Top<pictureBox5.Top + 44))
                    {
                        hit = true;
                        pictureBox5.Left = -150;
                        pictureBox5.Top = r.Next(170, 300);
                    }
                }
                if ((pictureBox1.Left + 72 > pictureBox6.Left) && (pictureBox1.Left < pictureBox6.Left + 42))
                {
                    if ((pictureBox1.Top + 68 > pictureBox6.Top) && (pictureBox1.Top < pictureBox6.Top + 44))
                    {
                        hit = true;
                        pictureBox6.Left = -250;
                        pictureBox6.Top = r.Next(170, 300);
                    }
                }
                if ((pictureBox1.Left + 72 > pictureBox7.Left) && (pictureBox1.Left < pictureBox7.Left + 42))
                {
                    if ((pictureBox1.Top + 68 > pictureBox7.Top) && (pictureBox1.Top < pictureBox7.Top + 44))
                    {
                        hit = true;
                        pictureBox7.Left = -400;
                        pictureBox7.Top = r.Next(170, 300);
                    }
                }

                //player2
                /*
                if ((pictureBox8.Left + 72 > pictureBox5.Left) && (pictureBox8.Left < pictureBox5.Left + 42))
                {
                    if ((pictureBox8.Top + 68 > pictureBox5.Top) && (pictureBox8.Top < pictureBox5.Top + 44))
                    {
                        hit = true;
                        pictureBox5.Left = -150;
                        pictureBox5.Top = r.Next(170, 300);
                    }
                }
                if ((pictureBox8.Left + 72 > pictureBox6.Left) && (pictureBox8.Left < pictureBox6.Left + 42))
                {
                    if ((pictureBox8.Top + 68 > pictureBox6.Top) && (pictureBox8.Top < pictureBox6.Top + 44))
                    {
                        hit = true;
                        pictureBox6.Left = -250;
                        pictureBox6.Top = r.Next(170, 300);
                    }
                }
                if ((pictureBox8.Left + 72 > pictureBox7.Left) && (pictureBox8.Left < pictureBox7.Left + 42))
                {
                    if ((pictureBox8.Top + 68 > pictureBox7.Top) && (pictureBox8.Top < pictureBox7.Top + 44))
                    {
                        hit = true;
                        pictureBox7.Left = -400;
                        pictureBox7.Top = r.Next(170, 300);
                    }
                }*/
                if (hit == true)
                {
                    count++;
                    label6.Text = "Score : " + count;
                    hit = false;

                }
            }
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if((keyData == Keys.Up)&&(startgame == true))
            {
                duplicate = pictureBox1.Left;
                jump = true;
            }
            return base.ProcessCmdKey(ref msg, keyData) ;
        }
        
     }
}

