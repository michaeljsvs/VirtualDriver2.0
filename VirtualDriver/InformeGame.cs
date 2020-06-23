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
    public partial class Estadísticas : Form
    {
        public Estadísticas(string total_infrac,  string contramano, string nrpoliciaTransito, string cruzar_rojo, string nomin30, string nomax60, string nomax90, string puntaje, string rpoliciaTransito, string cruzar_verde, string simin30, string simax60, string simax90)
        {
            InitializeComponent();
            txtPuntaje.Text = puntaje;
            txtrpolicia_transito.Text = rpoliciaTransito;
            txtcruza_verde.Text = cruzar_verde;
            txtrvelmin30.Text = simin30;
            txtrvelmax60.Text = simax60;
            txtrvelmax90.Text = simax90;

            txtTotalInf.Text = total_infrac;
            txtcontramano.Text = contramano;
            txtnrpolicia_transito.Text = nrpoliciaTransito;
            txtcruza_rojo.Text = cruzar_rojo;
            txtnrvelocidad_minima30.Text = nomin30;
            txtnrvelocidad_maxima60.Text = nomax60;
            txtnrvelocidad_maximo90.Text = nomax90;
        }

        private void InformeGame_Load(object sender, EventArgs e)
        {

        }
    }
}
