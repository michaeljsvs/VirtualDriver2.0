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
        //VARIABLES
        int gamespeed = 0;
        Random r = new Random();
        int x, y;
        bool desacelerar = false;
        bool up = false;
        int contTime2 = 0;
        int t3 = 0;
        bool b3 = false;
        bool red = false;
        int puntaje = 0;

        public GameDistancia()
        {
            InitializeComponent();
            over.Visible = false;
            semaforo.Visible = false;
            senda.Visible = false;

            timer3.Stop();
        }

        
        //TIMERS
        //generan eventos definidos por el usuario,
        //cada cierto tiempo (10 milisegundos) definido por este
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            velocidad();
            if (b3)
                sendSema(gamespeed);
            if (red)
                gosemaforo();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            puntaje++;
            label1.Text = "Puntaje = " + puntaje.ToString();
            desacelerarcar();
            if (contTime2 < 3)
            {
                contTime2++;
                //label1.Text = contTime2.ToString();
                if (contTime2 == 3)
                {
                    timer3.Start();
                }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            t3++;
            if (t3 == 1)
            {
                semaforo.Visible = true;
                senda.Visible = true;
                b3 = true;
            }
            if (t3 == 2)
                semaforo.Image = Image.FromFile("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\yellowsf.png");

            if (t3 == 3)
            {
                red = true;
                semaforo.Image = Image.FromFile("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\redsf.png");
            }
            
            if (t3 == 5)
            {
                red = false;
                semaforo.Image = Image.FromFile("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\greensf.png");
            }
            if (t3 == 6)
            {
                contTime2 = 0;
                semaforo.Visible = false;
                senda.Visible = false;
                t3 = 0;
                timer3.Stop();
            }
            


        }

        //MOVELINE (Mueve las posiciones de los pictureBox)
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

        //ENEMY
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
                x = r.Next(0, 347);
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

        void sendSema(int speed)
        {
            if (semaforo.Top >= 500)
            { semaforo.Top = 0; }
            else { semaforo.Top += speed; }

            if (senda.Top >= 500)
            {senda.Top = 0; }
            else { senda.Top += speed; }
        }


        //GAMEOVER
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

        void gosemaforo()
        {
            if (car.Bounds.IntersectsWith(senda.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

            //VELOCIDAD
            void velocidad()
        {
            label2.Text = "Velocidad = " + gamespeed.ToString();
        }

        //DESACELERAR
        void desacelerarcar()
        {
            if (desacelerar == true && gamespeed > 0)
            {
                gamespeed--;
            }
        }

        //KEYUP
        private void GameDistancia_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                desacelerar = true;
                up = false;
            }
        }

        //KEYDOWN
        private void GameDistancia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (car.Left < 380)
                {
                    car.Left -= 20;
                    if (up)
                    {
                        desacelerar = false;
                    }
                }
            }
            
            if (e.KeyCode == Keys.D)
            {
                if (car.Right < 380)
                {
                    car.Left += 20;
                    if (up)
                    {
                        desacelerar = false;
                    }
                } 
            }
            
            if (e.KeyCode == Keys.W)
            {
                if (gamespeed < 6)
                {
                    gamespeed++;
                    up = true;
                }
            }

            if (e.KeyCode == Keys.S)
            {
                if (gamespeed > -4)
                    gamespeed --;
            }
        }

        //RESET
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameDistancia ventana = new GameDistancia();
            ventana.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }


        //CLOSE
        private void GameDistancia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }


}
