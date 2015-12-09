using AerolineaFrba.Abm_Ruta.filter;
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
            loadFilterComboBox();
            fillDataGridView((RutaFilter) comboBoxFiltros.SelectedItem);
            
        }

        private void fillDataGridView(RutaFilter rutaFilter)
        {
            rutaList = daoRuta.retrieveAll();
            List<Ruta> filteredRutaList = new List<Ruta>();
            foreach ( Ruta ruta in rutaList){
                if (rutaFilter.accept(ruta)){
                    filteredRutaList.Add(ruta);
                }
            }

            dataGridViewRuta.DataSource = filteredRutaList;
        }

        private void loadFilterComboBox()
        {
            List<RutaFilter> filterList = new List<RutaFilter>();
            filterList.Add(new NoneFilter());
            filterList.Add(new OnlyActiveFilter());
            filterList.Add(new OnlyInactiveFilter());
            comboBoxFiltros.Items.AddRange(filterList.ToArray());
            comboBoxFiltros.DisplayMember = "nombre";
            comboBoxFiltros.SelectedIndex = 0;
        }

        private void createColumns()
        {

            DataGridViewCheckBoxColumn colEstado = new DataGridViewCheckBoxColumn();
            colEstado.DataPropertyName = "estado";
            colEstado.HeaderText = "Activo";
            colEstado.Width = 60;
            colEstado.ReadOnly = true;

            dataGridViewRuta.Columns.Add(crearColumna("id", "Id", 40, true));
            dataGridViewRuta.Columns.Add(crearColumna("tipoServicioNombre", "Tipo Servicio", 100, true));
            dataGridViewRuta.Columns.Add(crearColumna("ciudadOrigenNombre", "Ciudad origen", 100, true));
            dataGridViewRuta.Columns.Add(crearColumna("ciudadDestinoNombre", "Ciudad Destino", 100, true));
            dataGridViewRuta.Columns.Add(crearColumna("precioBasePasaje", "Precio Base Pasaje", 40, true));
            dataGridViewRuta.Columns.Add(crearColumna("precioBaseKg", "Precio Base KG", 40, true));
            dataGridViewRuta.Columns.Add(colEstado);
            dataGridViewRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private static DataGridViewTextBoxColumn crearColumna(String dataPropertyName, String headerText, int width, bool readOnly)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.DataPropertyName = dataPropertyName;
            columna.HeaderText = headerText;
            columna.Width = width;
            columna.ReadOnly = readOnly;
            return columna;
        }

        private void fillDataGridView()
        {
            rutaList = daoRuta.retrieveAll();

            dataGridViewRuta.DataSource = rutaList;
        }

        private void CrearButtonRuta_Click(object sender, EventArgs e)
        {
            CrearOModificarRuta view = new CrearOModificarRuta();
            view.ShowDialog();
            fillDataGridView();
        }

        private void BajaButtonRuta_Click(object sender, EventArgs e)
        {
            Ruta ruta = (Ruta)dataGridViewRuta.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Todos los pasajes y encomiendas de la ruta seleccionada se daran de baja, esta de acuerdo?","Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult.Equals(DialogResult.OK)) {
                DAORuta.baja(ruta);
                updateDataGridView();
            }
        }

        private void dataGridViewRuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BajaButtonRuta.Enabled = true;
            ModificarButtonRuta.Enabled = true;
        }

        private void ModificarButtonRuta_Click(object sender, EventArgs e)
        {
            CrearOModificarRuta form = new CrearOModificarRuta((Ruta)dataGridViewRuta.CurrentRow.DataBoundItem);
            form.ShowDialog();
            updateDataGridView();
        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridView((RutaFilter)comboBoxFiltros.SelectedItem);
        }

        private void updateDataGridView()
        {
            int pos = dataGridViewRuta.CurrentRow.Index;
            Cursor cursor = dataGridViewRuta.Cursor;
            fillDataGridView((RutaFilter)comboBoxFiltros.SelectedItem);
            if (dataGridViewRuta.Rows.Count != 0)
            {
                dataGridViewRuta.CurrentCell = dataGridViewRuta.Rows[pos].Cells[0];
                dataGridViewRuta.Rows[pos].Selected = true;

            }
        }
    }
}
