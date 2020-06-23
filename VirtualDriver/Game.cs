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
    public partial class Game : Form
    {
        //Variables de Informe
        int contramano,
            nrpoliciaTransito,
            cruzar_rojo,
            nomin30,
            nomax60,
            nomax90,
            
            cruzar_verde,
            rpoliciaTransito,
            simin30,
            simax60,
            simax90;

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
        bool b3 = false;
        bool red = false;
        int puntaje = 0;
        int inf = 0;

        int contAparicionCop = 0;
        bool aparececop = false;
        bool desactivarcartel = false;

        bool hb = false;
        bool siga = false;
        bool pare = false;

        bool mn30 = false;
        bool mx60 = false;
        bool mx90 = false;

        //Inicializacion
        public Game()
        {
            InitializeComponent();
            cop.Visible = false;
            cartelcop.Visible = false;
            semaforo.Visible = false;
            senda.Visible = false;
            lblchoque.Visible = false;

            timer3.Stop();

            min30.Visible = false;
        }


        //TIMERS -----------------------------------------------------------------------------
        //generan eventos definidos por el usuario,
        //cada cierto tiempo (10 milisegundos) definido por este

        //TIMER 1
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cartelmin30();
            cartelmax60();
            cartelmax90();

            aprccop();
            moveline(gamespeed); //Lineas Blancas

            movenemy1(ve1 + gamespeed);
            movenemy2(ve2 + gamespeed);
            movenemy3(ve3 - gamespeed);

            gameover();
            velocidad();
            if (b3)
                sendSema(gamespeed);

            if (red)
            {
                gosemaforo();
            }
            else
            {
                putinf();
            }
        }

        //TIMER 2
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            ipmin30();
            ipmax60();
            ipmax90();

            if (contTime2 < 5)
            {
                contTime2++;
                //label1.Text = contTime2.ToString();
                if (contTime2 == 5)
                {
                    timer3.Start();
                    t3 = 0;
                }

            }
        }

        //TIMER 3 (Semaforo, senda)
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            t3++;
            if (t3 == 1)
            {
                contAparicionCop++;
                if (contAparicionCop == 2 || contAparicionCop == 4)
                {
                    aparececop = true;
                }
                semaforo.Visible = true;
                senda.Visible = true;
                b3 = true;

            }

            if (t3 == 2)
            {
                semaforo.Image = Properties.Resources.yellowsf;
            }


            if (t3 == 3)
            {
                red = true;
                semaforo.Image = Properties.Resources.redsfc;
            }

            if (t3 == 4)
            {
                if (contAparicionCop == 2 || contAparicionCop == 4)
                    desactivarcartel = true;

                
            }

            if (t3 == 5)
            {
                red = false;
                semaforo.Image = Properties.Resources.greensf;
            }
            if (t3 == 6)
            {
                contTime2 = 0;
                timer3.Stop();
            }
        }

        //METODOS ----------------------------------------------------------------------------

        //CARTELES
        void cartelmin30()
        {
            if (t3 == 5)
            {
                min30.Visible = true;
                mn30 = true;
            }
            if (contTime2 == 2)
            {
                min30.Visible = false;
                mn30 = false;
            }
        }
        
        void cartelmax60()
        {
            if (contTime2 == 2)
            {
                max60.Visible = true;
                mx60 = true;
            }
            if (t3 == 5)
            {
                max60.Visible = false;
                mx60 = false;
            }
        }

        void cartelmax90()
        {
            if (t3 == 5)
            {
                max90.Visible = true;
                mx90 = true;
            }
            if (contTime2 == 2)
            {
                max90.Visible = false;
                mx90 = false;
            }
        }

        //CARTELES - INFRACCIONES Y PUNTAJE
        void ipmin30()
        {
            if (mn30)
            {
                if (gamespeed <= 6 && gamespeed >= 2)
                {
                    puntaj();
                    simin30++;
                }
                else
                {
                    infrac();
                    nomin30++;
                }
            }
        }

        void ipmax60()
        {
            if (mx60)
            {
                if (gamespeed <= 4)
                {
                    puntaj();
                    simax60++;
                }
                else
                {
                    infrac();
                    nomax60 ++;
                }
            }
        }

        void ipmax90()
        {
            if (mx90)
            {
                if (gamespeed <= 6 && gamespeed >= 2)
                {
                    puntaj();
                    simax90++;
                }
                else
                {
                    infrac();
                    nomax90 ++;
                }
            }
        }

        //OPTIMIZACION
        void aprccop()
        {
            if (aparececop)
            {
                cartelcop.Text = "PARE!";
                cartelcop.ForeColor = Color.Red;
                pare = true;
                ///////////////
                cartelcop.Top = semaforo.Top + 57; //Esto tambien hace mover al Picture en cada ciclo del time
                cop.Top = cartelcop.Top + 19;
                ///////////////
                cop.Visible = true;
                cartelcop.Visible = true;
                if (t3 == 4 && desactivarcartel)
                {
                    cartelcop.Text = "SIGA";
                    cartelcop.ForeColor = Color.Green;
                    siga = true;
                    pare = false;
                }

                if (cop.Top >= 500)
                {
                    cop.Visible = false;
                    aparececop = false;
                    cartelcop.Visible = false;
                    desactivarcartel = false;
                    siga = false;
                    pare = false;
                }
            }
        }

        void puntaj()
        {
            puntaje++;
            label1.Text = "Puntaje = " + puntaje.ToString();
            hb = true;
        }

        void infrac()
        {
            inf++;
            Infracciones.Text = "Infracciones = " + inf.ToString();
            hb = true;
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
                        if (pare == false)
                        {
                            puntaj();
                            cruzar_verde++;
                        }
                        else
                        {
                            infrac();
                            nrpoliciaTransito++;
                        }
                    }
                }
                else
                {
                    if (hb == false)
                    {
                        infrac();
                        contramano++;
                    }

                }
            }
            else
            {
                hb = false;
            }
        }

        void gosemaforo()
        {
            if (car.Bounds.IntersectsWith(senda.Bounds))
            {
                if (hb == false)
                {
                    if (siga == false)
                    {
                        infrac();
                        cruzar_rojo++;
                    }
                    else
                    {
                        puntaj();
                        rpoliciaTransito++;
                    }
                }
            }
            else
            {
                hb = false;
            }
        }

        void movimiento(PictureBox picture, int velocidad)
        {
            //TOP: obtiene o establece la distancia en pixeles
            //desde el borde superior del control (picture box)
            //y el borde superior del contenedor (el Form en nuesto caso)
            if (picture.Top >= 460)
            { picture.Top = 0; }
            else { picture.Top += velocidad; }
        }

        //LINEAS BLANCAS (Mueve las posiciones de los pictureBox)
        void moveline(int speed)
        {
            movimiento(pictureBox1, speed);
            movimiento(pictureBox2, speed);
            movimiento(pictureBox3, speed);
            movimiento(pictureBox4, speed);
            movimiento(pictureBox7, speed);
            movimiento(pictureBox8, speed);
            movimiento(pictureBox9, speed);
            movimiento(pictureBox10, speed);
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            desacelerarcar();
        }

        void sendSema(int speed)
        {
            if (semaforo.Top >= 460)
            {
                semaforo.Top = 0;
                if (t3 == 6)
                {
                    semaforo.Visible = false;
                    b3 = false;
                }
            }
            else { semaforo.Top += speed; }

            if (senda.Top >= 460)
            {
                senda.Top = 0;
                if (t3 == 6)
                {
                    senda.Visible = false;
                }
            }
            else { senda.Top += speed; }
        }

        //GAMEOVER
        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                final();
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                final();
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                final();
            }

        }

        void final()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            lblchoque.Visible = true;
            Form infrac = new Estadísticas(inf.ToString(), contramano.ToString(), nrpoliciaTransito.ToString(), cruzar_rojo.ToString(), nomin30.ToString(), nomax60.ToString(), nomax90.ToString(),
                puntaje.ToString(), rpoliciaTransito.ToString(), cruzar_verde.ToString(), simin30.ToString(), simax60.ToString(), simax90.ToString());
            infrac.ShowDialog();
        }

        //VELOCIDAD
        void velocidad()
        {
            label2.Left = car.Left - 37;
            int vel = gamespeed * 15;
            label2.Text = "Vel = " + vel.ToString() + " km/h";
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
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                desacelerar = true;
                up = false;
            }
        }

        //KEYDOWN
        private void Game_KeyDown(object sender, KeyEventArgs e)
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
                if (gamespeed < 7)
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
        private void rESETToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Game ventana = new Game();
            ventana.Show();
            this.Hide();
        }

        //INICIO
        private void iNICIOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        //CLOSE
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
