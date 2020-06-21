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
        int x;
        int ve1 = 1;
        int ve2 = 1;
        int ve3 = 1;
        bool desacelerar = false;
        bool up = false;
        int contTime2 = 0;
        int t3 = 0;
        bool b3, c1, c2, c3 = false;
        bool red = false;
        int puntaje = 0;
        int inf = 0;

        int contAparicionCop = 0;
        bool aparececop = false;
        bool desactivarcartel = false;

        bool hb = false;

        //Inicializacion
        public GameDistancia()
        {
            InitializeComponent();
            cop.Visible = false;
            cartelcop.Visible = false;
            semaforo.Visible = false;
            senda.Visible = false;

            timer3.Stop();
        }


        //TIMERS
        //generan eventos definidos por el usuario,
        //cada cierto tiempo (10 milisegundos) definido por este
        //TIMER 1
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aparececop)
            {
                cartelcop.Top = semaforo.Top + 57;
                cop.Top = cartelcop.Top + 19;

                cop.Visible = true;
                if (cop.Top >= 500)
                { 
                    cop.Visible = false;
                    aparececop = false;
                }
                else { cop.Top += gamespeed; }

                cartelcop.Visible = true;
                if (cartelcop.Top >= 500)
                { cartelcop.Visible = false; }
                else { cartelcop.Top += gamespeed; }
                
                //contAparicionCop++;
            }

            if (desactivarcartel)
            {
                cartelcop.Text = "SIGA";
                cartelcop.ForeColor = Color.Green;
            }

            putinf();
            moveline(gamespeed); //Lineas Blancas

            movenemy1(ve1 + gamespeed);
            movenemy2(ve2 + gamespeed);
            movenemy3(ve3 - gamespeed);
            
            gameover();
            velocidad();
            if (b3)
                sendSema(gamespeed);
            if (red)
                gosemaforo();
        }

        void putinf()
        {
            //label1.Text = contAparicionCop.ToString();
            if (car.Bounds.IntersectsWith(senda.Bounds))
            {
                if (car.Location.X > 210)
                {
                    if (hb == false)
                    {
                        puntaje++;
                        label1.Text = "Puntaje = " + puntaje.ToString();
                        hb = true;
                    }
                }
                else
                {
                    if (hb == false)
                    {
                        inf++;
                        Infracciones.Text = "Infracciones = " + inf.ToString();
                        hb = true;
                    }

                }
            }
            else
            {
                hb = false;
            }
        }

        //TIMER 2
        private void timer2_Tick(object sender, EventArgs e)
        {
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

        //TIMER 3 (Semaforo, senda)
        private void timer3_Tick(object sender, EventArgs e)
        {
            
            t3++;
            if (t3 == 1)
            {
                contAparicionCop++;
                if (contAparicionCop == 2)
                    aparececop = true;
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

            if (t3 == 4)
            {
                if (contAparicionCop == 2)
                    desactivarcartel = true;
            }

            if (t3 == 5)
            {
                
                red = false;
                semaforo.Image = Image.FromFile("C:\\Users\\Villanueva.MICHAEL-PC\\Downloads\\TP3 TED\\greensf.png");
            }
            if (t3 == 6)
            {
                contTime2 = 0;
                t3 = 0;
                timer3.Stop();
            }
        }



        //LINEAS BLANCAS (Mueve las posiciones de los pictureBox)
        void moveline(int speed)
        {
            //TOP: obtiene o establece la distancia en pixeles
            //desde el borde superior del control (picture box)
            //y el borde superior del contenedor (el Form en nuesto caso)
            if (pictureBox1.Top >= 460)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 460)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 460)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 460)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox7.Top >= 460)
            { pictureBox7.Top = 0; }
            else { pictureBox7.Top += speed; }

            if (pictureBox8.Top >= 460)
            { pictureBox8.Top = 0; }
            else { pictureBox8.Top += speed; }

            if (pictureBox9.Top >= 460)
            { pictureBox9.Top = 0; }
            else { pictureBox9.Top += speed; }

            if (pictureBox10.Top >= 460)
            { pictureBox10.Top = 0; }
            else { pictureBox10.Top += speed; }

        }

        //ENEMY
        void movenemy1(int speed)
        {
            if (enemy1.Top >= 460)
            {
                //x = r.Next(0, 286);
                ve1 = r.Next(1, 5);
                enemy1.Location = new Point(36, 0);
            }
            else { enemy1.Top += speed; }
        }

        void movenemy2(int speed)
        {
            if (enemy2.Top >= 460)
            {
                //x = r.Next(0, 286);
                ve2 = r.Next(1, 5);
                enemy2.Location = new Point(136, 0);
            }
            else { enemy2.Top += speed; }
        }

        void movenemy3(int speed)
        {
            if (enemy3.Top <= 0)
            {
                //x = r.Next(20, 286);
                ve3 = r.Next(1, 5);
                enemy3.Location = new Point(228, 460);
            }
            else { enemy3.Top -= speed; }

            if (enemy3.Top >= 501)
            {
                ve3 = r.Next(1, 5);
                enemy3.Location = new Point(228, 460);
            }
            else { enemy3.Top -= speed; }
        }


        void sendSema(int speed)
        {
            if (semaforo.Top >= 460)
            { semaforo.Top = 0; }
            else { semaforo.Top += speed; }

            if (senda.Top >= 460)
            { senda.Top = 0; }
            else { senda.Top += speed; }
        }


        //GAMEOVER
        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                cop.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                cop.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                cop.Visible = true;
            }

        }

        void gosemaforo()
        {
            if (car.Bounds.IntersectsWith(senda.Bounds))
            {
                if (hb == false)
                {
                    inf ++;
                    Infracciones.Text = "Infracciones = " + inf.ToString();
                    hb = true;
                }
            }
            else
            {
                hb = false;
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
            if (e.KeyCode == Keys.Up)
            {
                desacelerar = true;
                up = false;
            }
        }

        //KEYDOWN
        private void GameDistancia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
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

            if (e.KeyCode == Keys.Right)
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

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 3)
                {
                    gamespeed++;
                    up = true;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                    gamespeed--;
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
