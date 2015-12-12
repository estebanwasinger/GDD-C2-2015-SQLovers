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
using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.BO;


namespace AerolineaFrba
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        public Usuario user { get; set; }
        private Dictionary<Int32, String> dictionary;
        private const int LOGIN_Y_SEGURIDAD = 1;
        private const int REGISTRO_USUARIO = 2;
        private const int ABM_CIUDAD = 3;
        private const int ABM_RUTA = 4;
        private const int ABM_AERONAVE = 5;
        private const int GENERAR_VIAJE = 6;
        private const int REGISTRO_LLEGADA = 7;
        private const int COMPRA = 8;
        private const int CANCELACION_DEVOLUCION = 9;
        private const int CONSULTA_MILLAS = 10;
        private const int CANJE_MILLAS = 11;
        private const int LISTADO_ESTADISTICO = 12;

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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            user.Name = "admin";
            dictionary = DAOFuncionalidad.getFuncionalidadFromUsuarioAsMap(user.Name);

            if (!dictionary.ContainsKey(ABM_CIUDAD)) {
                buttonCiudades.Enabled = false;
            }

        }

    }
}
