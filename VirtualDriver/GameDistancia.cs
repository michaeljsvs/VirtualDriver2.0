using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualDriver
{
    public partial class GameDistancia : Form
    {
        public GameDistancia()
        {
            InitializeComponent();
            over.Visible = false;
            person1.Image = Image.FromFile
                ("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\niños.png");
            person2.Image = Image.FromFile
                ("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\abuela.png");
        }

        int gamespeed = 0;
        Random r = new Random();
        int x, y;
        int collectedcoins = 0;

        //TIMER
        //genera eventos definidos por el usuario,
        //cada cierto tiempo (10 milisegundos) definido por este
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            person(gamespeed);
            carperson();
            coins(gamespeed);
            coinscollection();
        }

        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            { 
                x = r.Next(0, 200);
                //y = r.Next(0, 350);
                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }
        }

        void person(int speed)
        {
            if (person1.Top >= 500)
            {
                x = r.Next(0, 200);
                person1.Location = new Point(x, 0);
                person1.Image = Image.FromFile
                ("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\niños.png");
            }
            else { person1.Top += speed; }
        }

        void coins(int speed)
        {
            if (person2.Top >= 500)
            {
                x = r.Next(0, 200);
                person2.Location = new Point(x, 0);
                person2.Image = Image.FromFile
                ("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\abuela.png");
            }
            else { person2.Top += speed; }
            //Hacer para cada coin
        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void carperson()
        {
            if (car.Bounds.IntersectsWith(person1.Bounds))
            {
                collectedcoins++;
                label1.Text = "Kill = " + collectedcoins.ToString();
                //person1.Image = Image.FromFile
                //("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\sangre.png");
                x = r.Next(50, 300);
                person1.Location = new Point(x, 0);
            }
        }

        //MOVELINE
        //Mueve las posiciones de los pictureBox
        void moveline(int speed)
        {
            //TOP: obtiene o establece la distancia en pixeles
            //desde el bode superior del control (picture box)
            //y el borde superior del contenedor (el Form en nuesto caso)
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(person2.Bounds))
            {
                collectedcoins++;
                label1.Text = "Kill = " + collectedcoins.ToString();
                //person2.Image = Image.FromFile
                //("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\sangre.png");
                x = r.Next(50, 300);
                person2.Location = new Point(x, 0);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int u = r.Next(20, 200);
            int d = r.Next(20, 200);
            int t = r.Next(20, 200);
            timer1.Enabled = true;
            over.Visible = false;
            car.Location = new Point(70, 362);
            enemy1.Location = new Point(u, u);
            enemy2.Location = new Point(d, d);
            enemy3.Location = new Point(t, t);
            gamespeed = 0;
        }

        private void GameDistancia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -8;
            }
            
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                    car.Left += 8;
            }
            
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                    gamespeed++;
            }
            
            if (e.KeyCode == Keys.Left)
            {
                if (gamespeed > 0)
                    gamespeed--;
            }
        }
    }


}
