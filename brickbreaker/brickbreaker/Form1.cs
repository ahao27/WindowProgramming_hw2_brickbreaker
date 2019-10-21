using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickbreaker
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        Label[] bricks = new Label[170];
        
        private void form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    bricks[index] = Brick(60 * i+30 , 40 * j);
                    this.Controls.Add(bricks[index]);
                    index++;
                }
            } 
        }

        private void reset()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--) //動態刪除
                if (this.Controls[i] is Label)
                    if(this.Controls[i].Width ==60 )
                    this.Controls[i].Dispose();
            B.Top = 300;
            B.Left = 0;
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    bricks[index] = Brick(60 * i+30 , 40 * j);
                    this.Controls.Add(bricks[index]);
                    index++;
                }
            }
            score = 0;
            cheat = 0;
            scoree.Text = "Score:" + score;
            timer1.Stop();
        }
        int vx = 5;
        int vy = 5;
        int level = 1;
        Random rng = new Random();
        int rngv=0;
        int score=0;
        int cheat = 0;
        int bleft, bright, btop, bbotton;
        private void timer1_Tick(object sender, EventArgs e)
        {
            bleft = B.Left;
            bright = B.Right;
            btop = B.Top;
            bbotton = B.Bottom;

            if (level > 0)
            {
                for (int i = 0; i < level; i++)
                {
                    B.Left += vx;
                    B.Top += vy;
                }
            }

            if (B.Left < 0) { vx = Math.Abs(vx); }
            if(B.Right > 600) { vx = -Math.Abs(vx); }
            if(B.Top < 0) { vy = Math.Abs(vy); }
            if(cheat==1)if (B.Bottom > this.ClientSize.Height) { vy = -Math.Abs(vy); }
            if (B.Bottom > P.Top)
            {
                int sweatpoint = (B.Left + B.Right) / 2;
                if (sweatpoint >= P.Left && sweatpoint <= P.Right)
                {
                    vy = -Math.Abs(vy);
                }
                else if( B.Top >this.ClientSize.Height)
                {
                    timer1.Stop();
                    MessageBox.Show("lose","遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.None);
                }                
            }

            for (int i = this.Controls.Count - 1; i >= 0; i--) 
                if (this.Controls[i] is Label)
                    {
                        if (this.Controls[i].Visible)
                        {
                        Label brick = (Label)this.Controls[i];
                        if (Onhit(brick)) { break; }
                        }
                    }

          //  foreach (var c in this.Controls)
          //  {
          //      if(c is Label)
           //     {
            //        Label brick = (Label)c;
          //          if (brick.Visible)
           //         {
         //               if (Onhit(brick)){ score++; break; }
        //            }
          //      }
        //   }

            if (rngv == 1)
            {
                level = rng.Next(-1, 5);
            }

            if (score == 63)
            {
                timer1.Stop();
                MessageBox.Show("win", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.None);
                score = 0;
            }

            scoree.Text = "Score:"+score;
        }

        int mdx;
        private void P_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
        }

        private void P_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               int x = P.Left + e.X - mdx;
                if (x < 0) { x = 0; }
                if(x>this.ClientSize.Width-P.Width)
                { x = this.ClientSize.Width - P.Width; }
                P.Left = x;
            }
        }

        private void speed1_Click(object sender, EventArgs e)
        {
            rngv = 0;
            level = 1;
        }

        private void speed2_Click(object sender, EventArgs e)
        {
            rngv = 0;
            level = 2;
        }

        private void speed3_Click(object sender, EventArgs e)
        {
            rngv = 0;
            level = 4;
        }

        private void speed4_Click(object sender, EventArgs e)
        {
            rngv = 1;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.SendToBack();
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cheat = 1;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            reset();
        }

        private Label Brick(int x,int y)
        {
            Label brick = new Label();
            brick.Width = 60;
            brick.Height = 40;
            brick.Image = Image.FromFile(@"..\..\GD2.png");
            //brick.BackColor = Color.DarkRed;
            brick.BorderStyle = BorderStyle.FixedSingle;
            brick.Left = x;
            brick.Top = y;
            brick.BringToFront();
            return brick;
        }
        private Boolean Onhit(Label brick)
        {
            if (B.Top > brick.Bottom) { return false; }
            if (B.Right < brick.Left) { return false; }
            if (B.Left > brick.Right) { return false; }
            if (B.Bottom < brick.Top) { return false; }
            brick.Dispose();
            score++;
            if (B.Top <= brick.Bottom && btop > brick.Bottom)
            {
                vy = Math.Abs(vy);
                return true;
            }
            if (B.Right >= brick.Left && bright < brick.Left)
            {
                vx = -Math.Abs(vx);
                return true;
            }
            if (B.Left <= brick.Right && bleft < brick.Right)
            {
                vx = Math.Abs(vx);
                return true;
            }
            if (B.Bottom >= brick.Top && bbotton < brick.Top)
            {
                vy = -Math.Abs(vy);
                return true;
            }
            return false;

        }

    }
}
