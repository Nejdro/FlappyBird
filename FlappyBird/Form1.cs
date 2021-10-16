using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            koniec.Visible = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ruchdrzew(3);
            ruchprzeszkod(3);
            koniecgry();
        }



        int punkciki = 0;
        void ruchdrzew(int speed)  // funkcja ruchu drzew
        {
            if (t1.Left >= 0)
            {
                t1.Left += -speed;
            }
            else
            {
                t1.Left = 1020;
            }
            if (t2.Left >= 0)
            {
                t2.Left += -speed;
            }
            else
            {
                t2.Left = 1020;
            }
            if (t3.Left >= 0)
            {
                t3.Left += -speed;
            }
            else
            {
                t3.Left = 1020;
            }
            if (t4.Left >= 0)
            {
                t4.Left += -speed;
            }
            else
            {
                t4.Left = 1020;
            }
            if (t5.Left >= 0)
            {
                t5.Left += -speed;
            }
            else
            {
                t5.Left = 1020;
            }

        }
        Random r = new Random();
        void ruchprzeszkod(int speed)
        {
            if (h1.Left >= 0)
            {
                h1.Left += -speed;
            }
            else
            {
                h1.Left = 1020;
                h1.Height = r.Next(400, 500);
            }
            if (h2.Left >= 0)
            {
                h2.Left += -speed;
                
            }
            else
            {
                h2.Left = 1020;
                h2.Height = r.Next(100, 150);
            }
            if (h3.Left >= 0)
            {
                h3.Left += -speed;
                
            }
            else
            {
                h3.Left = 1020;
                h3.Height = r.Next(300, 400);
            }
            if (h4.Left >= 0)
            {
                h4.Left += -speed;
            }
            else
            {
                h4.Left = 1020;
                h4.Height = r.Next(100, 200);

            }
            if (h5.Left >= 0)
            {
                h5.Left += -speed;
            }
            else
            {
                h5.Left = 1020;
                h5.Height = r.Next(300, 400); //zmiana wielkosci
            }
            if (h6.Left >= 0)
            {
                h6.Left += -speed;
            }
            else
            {
                h6.Left = 1020;
                h6.Height = r.Next(100, 200);
            }
            
        }

        void koniecgry()
        {
            if((ptaszek.Bounds.IntersectsWith(h1.Bounds)) || ptaszek.Bounds.IntersectsWith(h2.Bounds) || ptaszek.Bounds.IntersectsWith(h3.Bounds) || ptaszek.Bounds.IntersectsWith(h4.Bounds) || ptaszek.Bounds.IntersectsWith(h5.Bounds) || ptaszek.Bounds.IntersectsWith(h6.Bounds))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                koniec.Visible = true;
               

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(ptaszek.Top <= 521)
            {
                ptaszek.Top += 10;
                punkciki++;
                punkty.Text = punkciki.ToString();
            }
            
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Space)
            {
                ptaszek.Top += -40; //skok ptaszka
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();  // wcisnij escape zeby zamknac
            }
            if (e.KeyCode == Keys.F1)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                koniec.Visible = false;
                punkciki = 0;
                
            }
        }
    }
}
