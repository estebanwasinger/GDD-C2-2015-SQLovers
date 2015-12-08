using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
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
    public partial class CrearEncomienda : Form
    {
        private Models.BO.Pasaje pasaje;
        private int kgDisponibles = 0;
        private int precioBaseKg;
        private Int32 kgSeleccionados = 0;
        private Int32 precioTotal;
        public Cliente cliente;
        public Encomienda encomienda;

        public CrearEncomienda()
        {
            InitializeComponent();
        }

        public CrearEncomienda(Models.BO.Pasaje pasaje, int kgDisponibles)
        {
            this.pasaje = pasaje;
            this.kgDisponibles = kgDisponibles;
            this.precioBaseKg = DAORuta.getRuta((int)pasaje.vuelo.ruta).precioBaseKg;
            InitializeComponent();
        }

        private void numericUpDownPeso_ValueChanged(object sender, EventArgs e)
        {
            kgSeleccionados = (Int32) numericUpDownPeso.Value;
            precioTotal = kgSeleccionados * precioBaseKg;

            textBoxPrecioTotal.Text = (precioTotal).ToString();
            habilitarBotonAceptar();
        }

        private void CrearEncomienda_Load(object sender, EventArgs e)
        {
            buttonComprar.Enabled = false;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            encomienda = new Encomienda();
            encomienda.dniCliente = this.cliente.dni;
            encomienda.kg = this.kgSeleccionados;
            encomienda.precioTotal = this.precioTotal;
            encomienda.vueloId = (int) pasaje.vuelo.id;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClienteBasico clienteForm = new BuscarClienteBasico();
            clienteForm.ShowDialog();
            this.cliente = clienteForm.cliente;
            if (cliente != null)
            {
                textBoxApellidoCliente.Text = cliente.apellido;
                textBoxDni.Text = cliente.dni.ToString();
                textBoxNombreCliente.Text = cliente.nombre;
                textBoxUsuario.Text = cliente.username;
            }
            habilitarBotonAceptar();
        }

        private void habilitarBotonAceptar()
        {
            buttonComprar.Enabled = cliente != null && kgSeleccionados <= kgDisponibles;
        }
    }
}
