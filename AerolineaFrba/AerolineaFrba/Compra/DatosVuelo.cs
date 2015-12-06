using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class DatosVuelo : Form
    {
        private Pasaje pasaje;
        private Int32 kgDisponibles;

        public DatosVuelo(Pasaje pasaje)
        {
            this.pasaje = pasaje;
            InitializeComponent();
            textBoxAvion.Text = pasaje.vuelo.aeronave;
            textBoxFechaSalida.Text = pasaje.vuelo.fechaSalida.ToString();
            textBoxFechaLlegada.Text = pasaje.vuelo.fechaLlegada.ToString();
            Ruta ruta = DAORuta.getRuta((int) pasaje.vuelo.ruta);
            textBoxCiudadDestino.Text = ruta.ciudadDestinoNombre;
            textBoxCiudadOrigen.Text = ruta.ciudadOrigenNombre;
            kgDisponibles = DAOVuelo.getKgDisponibles((int)pasaje.vuelo.id);
            textBoxKilogramosDisponibles.Text = kgDisponibles.ToString();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarClienteForm = new BuscarCliente();
            buscarClienteForm.ShowDialog();
            if (buscarClienteForm.cliente != null)
            {
                textBoxApellidoCliente.Text = buscarClienteForm.cliente.apellido;
                textBoxNombreCliente.Text = buscarClienteForm.cliente.nombre;
                textBoxDni.Text = buscarClienteForm.cliente.dni.ToString() ;
                textBoxUsuario.Text = buscarClienteForm.cliente.username;
                pasaje.usuario = buscarClienteForm.cliente;

                buttonPasaje.Enabled = true;
                buttonEncomienda.Enabled = true;
            }
        }

        private void buttonPasaje_Click(object sender, EventArgs e)
        {
            if (!DAOPasaje.create(this.pasaje)) {
                throw new Exception("ERROR");
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosVuelo_Load(object sender, EventArgs e)
        {
            buttonEncomienda.Enabled = false;
            buttonPasaje.Enabled = false;
        }

        private void buttonEncomienda_Click(object sender, EventArgs e)
        {
            CrearEncomienda crearEncomienda = new CrearEncomienda(pasaje,kgDisponibles);
            crearEncomienda.ShowDialog();
            kgDisponibles = DAOVuelo.getKgDisponibles((int)pasaje.vuelo.id);
            textBoxKilogramosDisponibles.Text = kgDisponibles.ToString();
        }
    }
}
