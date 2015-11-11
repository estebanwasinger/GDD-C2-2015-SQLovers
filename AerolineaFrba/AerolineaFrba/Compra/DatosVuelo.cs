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
        }

        private void buttonPasaje_Click(object sender, EventArgs e)
        {
            
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
            }
        }
    }
}
