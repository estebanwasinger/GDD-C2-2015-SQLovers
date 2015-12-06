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
    public partial class DatosVuelo : Form
    {
        private Pasaje pasaje;
        private Int32 kgDisponibles;
        private List<Encomienda> encomiendaList = new List<Encomienda>();
        private List<Pasaje> pasajeList = new List<Pasaje>();

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
            textBoxPasajesDisponibles.Text = DAOButaca.getButacasDisponibles((int)pasaje.vuelo.id).Count.ToString();
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
            CrearPasaje pasajeForm = new CrearPasaje(this.pasaje.vuelo);
            pasajeForm.ShowDialog();
            if (pasajeForm.butaca != null) { 
                Pasaje pasaje = new Pasaje();
                pasaje.vuelo = this.pasaje.vuelo;
                pasaje.usuario = this.pasaje.usuario;
                pasaje.precio = DAORuta.getRuta((int) this.pasaje.vuelo.ruta).precioBasePasaje;
                pasaje.butaca = pasajeForm.butaca;
                pasaje.fechaCompra = System.DateTime.Now;
                pasajeList.Add(pasaje);
                dataGridViewPasajes.DataSource = getPasajeList();
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

            dataGridViewEncomiendas.AutoGenerateColumns = false;
            dataGridViewEncomiendas.Columns.Add(Utils.crearColumna("precioTotal","Precio",140,true));
            dataGridViewEncomiendas.Columns.Add(Utils.crearColumna("kg", "Kilos", 140, true));
            dataGridViewEncomiendas.DataSource = encomiendaList;

            dataGridViewPasajes.AutoGenerateColumns = false;
            dataGridViewPasajes.Columns.Add(Utils.crearColumna("precio", "Precio", 140, true));
            dataGridViewPasajes.Columns.Add(Utils.crearColumna("butaca.numero", "Butaca Nro", 140, true));
            dataGridViewPasajes.DataSource = pasajeList;
            
        }

        private void buttonEncomienda_Click(object sender, EventArgs e)
        {
            CrearEncomienda crearEncomienda = new CrearEncomienda(pasaje,kgDisponibles);
            crearEncomienda.ShowDialog();
            if (crearEncomienda.encomienda != null)
            {
                Encomienda encomienda = crearEncomienda.encomienda;
                this.encomiendaList.Add(encomienda);
                dataGridViewEncomiendas.DataSource = getEncomiendaList();
                actualizarCantidadKGDisponibles(encomienda);
            }
        }

        private void actualizarCantidadKGDisponibles(Encomienda encomienda)
        {
            this.kgDisponibles = this.kgDisponibles - encomienda.kg;
            this.textBoxKilogramosDisponibles.Text = this.kgDisponibles.ToString();
        }

        private List<Encomienda> getEncomiendaList()
        {
            List<Encomienda> comparableList = new List<Encomienda>();
            foreach (Encomienda compra in this.encomiendaList)
            {
                comparableList.Add(compra);
            }
            return comparableList;
        }

        private List<Pasaje> getPasajeList()
        {
            List<Pasaje> comparableList = new List<Pasaje>();
            foreach (Pasaje compra in this.pasajeList)
            {
                comparableList.Add(compra);
            }
            return comparableList;
        }

        private void buttonConfirmarCompra_Click(object sender, EventArgs e)
        {
            foreach (Comprable comprable in this.pasajeList)
            {
                comprable.comprar();
            }

            foreach (Comprable comprable in this.encomiendaList)
            {
                comprable.comprar();
            }
            this.Close();
        }
    }
}
