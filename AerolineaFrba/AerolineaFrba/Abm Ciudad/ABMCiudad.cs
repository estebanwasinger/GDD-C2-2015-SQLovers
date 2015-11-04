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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ABMCiudad : Form
    {
        private List<Ciudad> ciudadList;
        private DAOCiudad daoCiudad;
        private Ciudad selectedCiudad;

        public ABMCiudad()
        {
            InitializeComponent();
            ciudadList = new List<Ciudad>();
            daoCiudad = new DAOCiudad();
        }

        private void ABMCiudad_Load(object sender, EventArgs e)
        {
            dataGridViewCiudad.AutoGenerateColumns = false;
            dataGridViewCiudad.MultiSelect = false;
            modificarButton.Enabled = false;
            borrarButton.Enabled = false;
            createColumns();
            fillDataGridView();
        }

        private void fillDataGridView()
        {
            ciudadList = DAOCiudad.retrieveAll();

            dataGridViewCiudad.DataSource = ciudadList;
        }

        private void createColumns()
        {
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "id";
            colId.HeaderText = "Id";
            colId.Width = 70;
            colId.ReadOnly = true;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Width = 120;
            colNombre.ReadOnly = true;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.DataPropertyName = "estado";
            colEstado.HeaderText = "Estado";
            colEstado.Width = 50;
            colEstado.ReadOnly = true;

            dataGridViewCiudad.Columns.Add(colId);
            dataGridViewCiudad.Columns.Add(colNombre);
            dataGridViewCiudad.Columns.Add(colEstado);
            dataGridViewCiudad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewCiudad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            borrarButton.Enabled = true;
            modificarButton.Enabled = true;
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            selectedCiudad = (Ciudad)dataGridViewCiudad.CurrentRow.DataBoundItem;
            System.Windows.Forms.MessageBox.Show("Ciudad Nombre: " + selectedCiudad.nombre + " Ciudad Id: " + selectedCiudad.id);
            daoCiudad.deleteCiudad((int) selectedCiudad.id);
            fillDataGridView();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            selectedCiudad = (Ciudad)dataGridViewCiudad.CurrentRow.DataBoundItem;
            UpdateOrCreateView view = new UpdateOrCreateView(selectedCiudad, daoCiudad, false);
            view.ShowDialog();
            fillDataGridView();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            Ciudad newCiudad = new Ciudad();
            UpdateOrCreateView view = new UpdateOrCreateView(newCiudad, daoCiudad, true);
            view.ShowDialog();
            fillDataGridView();
        }

    }
}
