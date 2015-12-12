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
        private float precioTotal;
        public Cliente cliente;
        public Encomienda encomienda;
        private Servicio tipoServicio;

        public CrearEncomienda()
        {
            InitializeComponent();
        }

        public CrearEncomienda(Models.BO.Pasaje pasaje, int kgDisponibles)
        {
            this.pasaje = pasaje;
            this.kgDisponibles = kgDisponibles;
            this.precioBaseKg = DAORuta.getRuta((int)pasaje.vuelo.ruta).precioBaseKg;
            int precioBase = DAORuta.getRuta((int)this.pasaje.vuelo.ruta).precioBasePasaje;
            DAOServicio servicio = new DAOServicio();
            tipoServicio = servicio.retrieveBy_id_serv((int)DAORuta.getRuta((int)this.pasaje.vuelo.ruta).tipoServicioId);
            InitializeComponent();
        }

        private void numericUpDownPeso_ValueChanged(object sender, EventArgs e)
        {
            kgSeleccionados = (Int32) numericUpDownPeso.Value;
            precioTotal = ((kgSeleccionados * precioBaseKg) + (kgSeleccionados * precioBaseKg) * tipoServicio.tipo_servicio_recargo);

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
            encomienda.idCliente = this.cliente.dni;



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
            }
            habilitarBotonAceptar();
        }

        private void habilitarBotonAceptar()
        {
            buttonComprar.Enabled = cliente != null && kgSeleccionados <= kgDisponibles && kgSeleccionados > 0;
        }
    }
}
