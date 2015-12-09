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
    public partial class CrearPasaje : Form
    {
        public Butaca butaca;
        public Cliente cliente;
        private Pasaje pasajePrivate;
        public Pasaje pasaje;
        private List<Pasaje> pasajeList;

        public CrearPasaje(Pasaje pasaje, List<Pasaje> pasajeList)
        {
            this.pasajeList = pasajeList;
            this.pasajePrivate = pasaje;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearPasaje_Load(object sender, EventArgs e)
        {
            buttonAgregar.Enabled = false;
            dataGridViewButacas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewButacas.AutoGenerateColumns = false;
            dataGridViewButacas.Columns.Add(Utils.crearColumna("numero","Numero", 70,true));
            dataGridViewButacas.Columns.Add(Utils.crearColumna("tipo", "Tipo", 70, true));
            dataGridViewButacas.Columns.Add(Utils.crearColumna("piso", "Piso", 70, true));
            List<Butaca> butacaList = DAOButaca.getButacasDisponibles((int) pasajePrivate.vuelo.id);
            butacaList = filtrarButacasReservadas(pasajeList, butacaList);
            dataGridViewButacas.DataSource = butacaList;
        }

        private void dataGridViewButacas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotonAceptar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.butaca = (Butaca)dataGridViewButacas.CurrentRow.DataBoundItem;
            Pasaje pasaje = new Pasaje();
            pasaje.vuelo = this.pasajePrivate.vuelo;
            pasaje.usuario = this.cliente;
            int precioBase = DAORuta.getRuta((int)this.pasajePrivate.vuelo.ruta).precioBasePasaje;
            DAOServicio servicio = new DAOServicio();
            Servicio serv = servicio.retrieveBy_id_serv((int) DAORuta.getRuta((int) this.pasajePrivate.vuelo.ruta).tipoServicioId);
            pasaje.precio = precioBase + precioBase * serv.tipo_servicio_recargo;
            pasaje.butaca = this.butaca;
            pasaje.fechaCompra = System.DateTime.Now;
            this.pasaje = pasaje;
            this.Close();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClienteBasico clienteForm = new BuscarClienteBasico();
            clienteForm.ShowDialog();
            this.cliente = clienteForm.cliente;
            if (cliente != null) {
                if (!DAOVuelo.tieneVueloEntre(cliente.dni, this.pasajePrivate.vuelo.fechaSalida, this.pasajePrivate.vuelo.fechaLlegadaEstimada) && !pasajeroYaEstaEnList(cliente.dni))
                {
                    textBoxApellidoCliente.Text = cliente.apellido;
                    textBoxDni.Text = cliente.dni.ToString();
                    textBoxNombreCliente.Text = cliente.nombre;
                    textBoxUsuario.Text = cliente.username;
                }
                else {
                    cliente = null;
                    MessageBox.Show("El pasajero seleccionado ya tiene un vuelo incompatible con el selccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            habilitarBotonAceptar();
        }

        private bool pasajeroYaEstaEnList(int dni)
        {
            foreach (Pasaje pasaje in pasajeList) { 
                if(pasaje.usuario.dni.Equals(dni)){
                return true;
                }
            }
            return false;
        }

        private void habilitarBotonAceptar()
        {
            if (cliente != null && dataGridViewButacas.SelectedCells.Count != 0)
            {
                buttonAgregar.Enabled = true;
            }
        }

        private List<Butaca> filtrarButacasReservadas(List<Pasaje> pasajeList, List<Butaca> butacaList)
        {
                foreach (Pasaje pasaje in pasajeList)
                {
                    butacaList.Remove(pasaje.butaca);
                }
                return butacaList;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
