using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VirtualDriver
{
    public partial class Señales : Form
    {
        public Señales()
        {
            InitializeComponent();
           
        }

        private int panelActual = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIncio_Click(object sender, EventArgs e)
        {
            
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

       
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            List<Panel> pnl = new List<Panel>();
            pnl.Add(panel1);
            pnl.Add(panel2);
            pnl.Add(panel3);
            pnl.Add(panel4);


            if (pnl.Count() > panelActual ) {
                btnAnterior.Enabled = true;
                pnl[panelActual].Visible = false;
                panelActual++;
                pnl[panelActual].Visible = true;
                
                if (panelActual+1 == pnl.Count()) {
                    btnSiguiente.Enabled = false;
                };
            };
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            List<Panel> pnl = new List<Panel>();
            pnl.Add(panel1);
            pnl.Add(panel2);
            pnl.Add(panel3);
            pnl.Add(panel4);

            
            if (panelActual > 0)
            {
                pnl[panelActual].Visible = false;
                panelActual--;
                pnl[panelActual].Visible = true;
                if (panelActual == 0)
                {
                    btnAnterior.Enabled = false;
                };
            };

        }


    }
}
