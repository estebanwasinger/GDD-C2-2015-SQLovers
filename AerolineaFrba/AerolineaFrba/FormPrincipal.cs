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
using AerolineaFrba.Compra;
using AerolineaFrba.Listado_Estadistico;
using AerolineaFrba.Canje_Millas;
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Registro_Llegada_Destino;
using AerolineaFrba.Consulta_Millas;
using AerolineaFrba.Devolucion;


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
            CompraForm comp = new CompraForm();
            comp.ShowDialog();
        }

        private void buttonMillas_Click(object sender, EventArgs e)
        {
            CanjeDeMillas canjeForm = new CanjeDeMillas();
            canjeForm.ShowDialog();
        }

        private void buttonViajes_Click(object sender, EventArgs e)
        {
            GenerarViaje viajeForm = new GenerarViaje();
            viajeForm.ShowDialog();
        } 
        
        private void btnListadoEstadistico_Click(object sender, EventArgs e)
        {
            ListadoEstadistico frm = new ListadoEstadistico();
            frm.ShowDialog();
        }

        private void buttonRegistroDeLlegada_Click(object sender, EventArgs e)
        {
            RegistrarLlegada registroForm = new RegistrarLlegada();
            registroForm.ShowDialog();
        }

        private void buttonConsultaMillas_Click(object sender, EventArgs e)
        {
            ConsultaMillas millas = new ConsultaMillas();
            millas.ShowDialog();
        }

        private void buttonDevolucion_Click(object sender, EventArgs e)
        {
            FormDevolucion devolucion = new FormDevolucion();
            devolucion.ShowDialog();
        }

    }
}
