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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ABMRuta : Form
    {
        private List<Ruta> rutaList;
        private DAORuta daoRuta;
        private Ruta selectedRuta;

        public ABMRuta()
        {
            InitializeComponent();
            rutaList = new List<Ruta>();
            daoRuta = new DAORuta();
            
        }

        private void ABMRuta_Load(object sender, EventArgs e)
        {
            dataGridViewRuta.AutoGenerateColumns = false;
            dataGridViewRuta.MultiSelect = false;
            ModificarButtonRuta.Enabled = false;
            BajaButtonRuta.Enabled = false;
            createColumns();
            fillDataGridView();
        }

        private void createColumns()
        {
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "id";
            colId.HeaderText = "Id";
            colId.Width = 40;
            colId.ReadOnly = true;

            DataGridViewTextBoxColumn colTipoServicio = new DataGridViewTextBoxColumn();
            colTipoServicio.DataPropertyName = "tipoServicio";
            colTipoServicio.HeaderText = "Tipo Servicio";
            colTipoServicio.Width = 100;
            colTipoServicio.ReadOnly = true;

            DataGridViewTextBoxColumn colCiudadOrigen = new DataGridViewTextBoxColumn();
            colCiudadOrigen.DataPropertyName = "ciudadOrigen";
            colCiudadOrigen.HeaderText = "Ciudad origen";
            colCiudadOrigen.Width = 100;
            colCiudadOrigen.ReadOnly = true;

            DataGridViewTextBoxColumn colCiudadDestino = new DataGridViewTextBoxColumn();
            colCiudadDestino.DataPropertyName = "ciudadDestino";
            colCiudadDestino.HeaderText = "Ciudad Destino";
            colCiudadDestino.Width = 100;
            colCiudadDestino.ReadOnly = true;

            DataGridViewTextBoxColumn colPrecio_BasePasaje = new DataGridViewTextBoxColumn();
            colPrecio_BasePasaje.DataPropertyName = "precioBasePasaje";
            colPrecio_BasePasaje.HeaderText = "Precio Base Pasaje";
            colPrecio_BasePasaje.Width = 40;
            colPrecio_BasePasaje.ReadOnly = true;

            DataGridViewTextBoxColumn colPrecio_BaseKg = new DataGridViewTextBoxColumn();
            colPrecio_BaseKg.DataPropertyName = "precioBaseKg";
            colPrecio_BaseKg.HeaderText = "Precio Base KG";
            colPrecio_BaseKg.Width = 40;
            colPrecio_BaseKg.ReadOnly = true;

            dataGridViewRuta.Columns.Add(colId);
            dataGridViewRuta.Columns.Add(colTipoServicio);
            dataGridViewRuta.Columns.Add(colCiudadOrigen);
            dataGridViewRuta.Columns.Add(colCiudadDestino);
            dataGridViewRuta.Columns.Add(colPrecio_BasePasaje);
            dataGridViewRuta.Columns.Add(colPrecio_BaseKg);
            dataGridViewRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void fillDataGridView()
        {
            rutaList = daoRuta.retrieveAll();

            dataGridViewRuta.DataSource = rutaList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
