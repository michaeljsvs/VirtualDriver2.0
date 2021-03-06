﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace VirtualDriver
{
    public partial class TestManejo : Form
    {
        public TestManejo()
        {
            InitializeComponent();
        }       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        Panel panelActual = new Panel();
        int preguntaActual = 1;
        int respuestasCorrectas = 0;

        //INICIO
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
        //MAXIMIZAR
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        //MINIMIZAR
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //RESTAURAR
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

        }
        //CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //MOVER VENTANA
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //PREGUNTAS
        public string[,] Preguntas = new string[15,3] {
            {"¿Que es lo primero que debe hacer" + "\r\n" + "al subirse al vehiculo?","No usado" ,"0" },
            {"¿Que debe hacer al consmir bebidas alcoholicas?", "No Usado", "1" },
            {"¿Como procede si una ambulancia/pratulla/autobomba " + "\r\n" + "viene detras suyo con las sirenas encendidas?", "No Usado", "2" },
            {"Siempre los sobrepasos se realizan por el carril...", "No Usado", "3" },
            {"¿Qué significa el término “culposo”" + "\r\n" + "en materia de accidentes de tránsito?", "No Usado", "4" },
            {"Estás llegando a un cruce de calles y una" + "\r\n" + "persona está cruzando por la senda, Ud.debe:", "No Usado", "5" },
            {"¿Cuándo se pierde la prioridad de paso de mano derecha?", "No Usado", "6" },
            {"¿En qué casos la autoridad de control puede retener su licencia de conducir?", "No Usado", "7" },
            {"¿Todo vehículo debe estar cubierto por un seguro?", "No Usado", "8" },
            {"¿Cuál es el objetivo de la Inspección Técnica Vehicular?", "No Usado", "9" },
            {"¿Qué consecuencias tiene conducir habiendo" + "\r\n" + "dormido pocas horas previamente?", "No Usado", "10" },
            {"Si un conductor necesita realizar una" + "\r\n" + "llamada de urgencia, ¿quédebe hacer", "No Usado", "11" },
            {"¿Que funcion cumplen las señales de prevencion?", "No Usado", "12" },
            {"¿Está permitido conducir en la vía pública con auriculares puestos?", "No Usado", "13" },
            {"La “Senda peatonal” está destinada:", "No Usado", "14" },
        };

        private void button1_Click(object sender, EventArgs e)
        {
            panelActual.Visible = false;
            panelCorrecto.Visible = true;
            respuestasCorrectas ++;
        }

        //PANEL BOTON INCORRECTO
        private void button2_Click(object sender, EventArgs e)
        {
            switch (preguntaActual)
            {
                case 1:
                    lblRespuesta.Text = btn0Correcto.Text;
                    break;
                case 2:
                    lblRespuesta.Text = btn1Correcto.Text;
                    break;
                case 3:
                    lblRespuesta.Text = btn2Correcto.Text;
                    break;
                case 4:
                    lblRespuesta.Text = btn3Correcto.Text;
                    break;
                case 5:
                    lblRespuesta.Text = btn4Correcto.Text;
                    break;
                case 6:
                    lblRespuesta.Text = btn5Correcto.Text;
                    break;
                case 7:
                    lblRespuesta.Text = btn6Correcto.Text;
                    break;
                case 8:
                    lblRespuesta.Text = btn7Correcto.Text;
                    break;
                case 9:
                    lblRespuesta.Text = btn8Correcto.Text;
                    break;
                case 10:
                    lblRespuesta.Text = btn9Correcto.Text;
                    break;
                case 11:
                    lblRespuesta.Text = btn10Correcto.Text;
                    break;
                case 12:
                    lblRespuesta.Text = btn11Correcto.Text;
                    break;
                case 13:
                    lblRespuesta.Text = btn12Correcto.Text;
                    break;
                case 14:
                    lblRespuesta.Text = btn13Correcto.Text;
                    break;
                case 15:
                    lblRespuesta.Text = btn14Correcto.Text;
                    break;
            }

            lblRetro.Text += preguntaActual.ToString();

            if (preguntaActual != 15)
            {
                lblRetro.Text += ",";
            }
            else
            {
                lblRetro.Text += ".";
            };

            lblRetro.Visible = true;
            lblRetro1.Visible = true;
            panelActual.Visible = false;
            panelError.Visible = true;
        }

        private void btnCorrecto_Click(object sender, EventArgs e)
        {
            panelCorrecto.Visible = false;
            SiguientePregunta();
        }

        private void btnIncorrecto_Click(object sender, EventArgs e)
        {
            panelError.Visible = false;
            SiguientePregunta();
        }

        private void SiguientePregunta()
        {
            List<Panel> pnl = new List<Panel>();
            pnl.Add(panelPreg0);
            pnl.Add(panelPreg1);
            pnl.Add(panelPreg2);
            pnl.Add(panelPreg3);
            pnl.Add(panelPreg4);
            pnl.Add(panelPreg5);
            pnl.Add(panelPreg6);
            pnl.Add(panelPreg7);
            pnl.Add(panelPreg8);
            pnl.Add(panelPreg9);
            pnl.Add(panelPreg10);
            pnl.Add(panelPreg11);
            pnl.Add(panelPreg12);
            pnl.Add(panelPreg13);
            pnl.Add(panelPreg14);

            if (pnl.Count > preguntaActual)
            {
                panelActual = pnl[preguntaActual];
                panelCorrecto.Visible = false;
                panelError.Visible = false;
                panelActual.Visible = true;
                /*
                 * randdomm panel siguiente
                 * 
                 */
                preguntaActual++;
            }
            else {
                panelFinal.Visible = true;
                double resultado = (double)respuestasCorrectas/pnl.Count;
                lblResultados.Text = respuestasCorrectas.ToString() + " respuestas correctas de " + pnl.Count.ToString() + " posibles.";
                if (resultado >= 0.7){
                    lblTest.ForeColor = Color.Green;
                    lblTest.Text = "Aprobado";
                    imgAprobado.Visible = true;
                    lblCondicion.Text = "Felicitaciones";
                }
                else{
                    lblTest.ForeColor = Color.Red;
                    lblTest.Text = "Reprobado";
                    imgDesaprobado.Visible = true;
                    lblCondicion.Text = "Vuelve a intentarlo";
                }
                
                /* panelFinal.visible = true*/
            }
           
        }


    }
}
