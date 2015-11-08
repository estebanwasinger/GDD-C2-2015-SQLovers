using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AerolineaFrba.Models;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Abm_Rol;

namespace AerolineaFrba
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(Usuario invoker)
        {
            InitializeComponent();
            user = invoker;
        }

        public Usuario user { get; set; }

        private void buttonAeronaves_Click(object sender, EventArgs e)
        {
            FormABMAeronave abmAeronaves = new FormABMAeronave();
            abmAeronaves.ShowDialog();
        }

        private void buttonCiudades_Click(object sender, EventArgs e)
        {
            ABMCiudad abmCiudad = new ABMCiudad();
            abmCiudad.ShowDialog();
        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            ABMRol abmRol = new ABMRol();
            abmRol.ShowDialog();
        }

        private void buttonRutas_Click(object sender, EventArgs e)
        {
            ABMRuta abmRuta = new ABMRuta();
            abmRuta.ShowDialog();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {

        }

        private void buttonMillas_Click(object sender, EventArgs e)
        {

        }

        private void buttonViajes_Click(object sender, EventArgs e)
        {

        }
    }
}
