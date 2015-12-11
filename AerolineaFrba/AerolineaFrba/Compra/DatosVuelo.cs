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
        private int butacasDisponibles;

        public DatosVuelo(Pasaje pasaje)
        {
            this.pasaje = pasaje;
            InitializeComponent();

            textBoxAvion.Text = pasaje.vuelo.aeronave.ToString();
            textBoxFechaSalida.Text = pasaje.vuelo.fechaSalida.ToString();
            textBoxFechaLlegada.Text = pasaje.vuelo.fechaLlegada.ToString();

            Ruta ruta = DAORuta.getRuta((int) pasaje.vuelo.ruta);
            textBoxCiudadDestino.Text = ruta.ciudadDestinoNombre;
            textBoxCiudadOrigen.Text = ruta.ciudadOrigenNombre;
            textBoxTipoServicio.Text = ruta.tipoServicioNombre;

            kgDisponibles = DAOVuelo.getKgDisponibles((int)pasaje.vuelo.id);
            textBoxKilogramosDisponibles.Text = kgDisponibles.ToString();
            butacasDisponibles = DAOButaca.getButacasDisponibles((int)pasaje.vuelo.id).Count;
            textBoxPasajesDisponibles.Text = butacasDisponibles.ToString();
            
        }

        private void buttonPasaje_Click(object sender, EventArgs e)
        {
            CrearPasaje pasajeForm = new CrearPasaje(this.pasaje,pasajeList);
            pasajeForm.ShowDialog();
            if (pasajeForm.pasaje != null) {
                pasajeList.Add(pasajeForm.pasaje);
                actualizarDataGridViews();
                butacasDisponibles = butacasDisponibles - 1;
                textBoxPasajesDisponibles.Text = butacasDisponibles.ToString();
                buttonConfirmarCompra.Enabled = true;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosVuelo_Load(object sender, EventArgs e)
        {

            dataGridViewEncomiendas.AutoGenerateColumns = false;
            dataGridViewEncomiendas.Columns.Add(Utils.crearColumna("precioTotal", "Precio", 138, true));
            dataGridViewEncomiendas.Columns.Add(Utils.crearColumna("kg", "Kilos", 138, true));
            dataGridViewEncomiendas.Columns.Add(Utils.crearColumna("dni", "DNI", 138, true));

            dataGridViewPasajes.AutoGenerateColumns = false;
            dataGridViewPasajes.Columns.Add(Utils.crearColumna("precio", "Precio", 138, true));
            dataGridViewPasajes.Columns.Add(Utils.crearColumna("butaca_numero", "Butaca Nro", 138, true));
            dataGridViewPasajes.Columns.Add(Utils.crearColumna("kg", "DNI", 138, true));

            buttonConfirmarCompra.Enabled = false;
        }

        private void actualizarDataGridViews() {
            dataGridViewPasajes.Rows.Clear();
            dataGridViewEncomiendas.Rows.Clear();
            foreach (Pasaje pasaje in pasajeList) {
                string[] row1 = new string[] { pasaje.precio.ToString(), pasaje.butaca.numero.ToString(), pasaje.usuario.dni.ToString() };
                
                dataGridViewPasajes.Rows.Add(row1);
            }

            foreach (Encomienda encomienda in encomiendaList)
            {
                string[] row1 = new string[] { encomienda.precioTotal.ToString(), encomienda.kg.ToString(), ((Int32) encomienda.idCliente).ToString() };
                
                dataGridViewEncomiendas.Rows.Add(row1);
            }
        }

        private void buttonEncomienda_Click(object sender, EventArgs e)
        {
            CrearEncomienda crearEncomienda = new CrearEncomienda(pasaje,kgDisponibles);
            crearEncomienda.ShowDialog();
            if (crearEncomienda.encomienda != null)
            {
                Encomienda encomienda = crearEncomienda.encomienda;
                this.encomiendaList.Add(encomienda);
                actualizarDataGridViews();
                actualizarCantidadKGDisponibles(encomienda);
                buttonConfirmarCompra.Enabled = true;
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

            ConfirmarCompra confirmarCompraForm = new ConfirmarCompra(encomiendaList, pasajeList, this);
            confirmarCompraForm.ShowDialog();
        }
    }
}
