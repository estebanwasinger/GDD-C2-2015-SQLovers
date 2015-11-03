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

namespace AerolineaFrba.Abm_Rol
{
    public partial class ABMRol : Form
    {
        private List<Rol> rolList;
        private DAORol daoRol;
        private Rol selectedRol;

        public ABMRol()
        {
            InitializeComponent();
            rolList = new List<Rol>();
            daoRol = new DAORol();
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {
            dataGridViewRol.AutoGenerateColumns = false;
            dataGridViewRol.MultiSelect = false;
            modificarButton.Enabled = false;
            borrarButton.Enabled = false;
            createColumns();
            fillDataGridView();
        }

        private void fillDataGridView()
        {
            rolList = daoRol.retrieveAll();

            dataGridViewRol.DataSource = rolList;
        }

        private void createColumns()
        {
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "id";
            colId.HeaderText = "Id";
            colId.Width = 70;
            colId.ReadOnly = true;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "name";
            colNombre.HeaderText = "Nombre";
            colNombre.Width = 120;
            colNombre.ReadOnly = true;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.DataPropertyName = "activo";
            colEstado.HeaderText = "Estado";
            colEstado.Width = 50;
            colEstado.ReadOnly = true;

            dataGridViewRol.Columns.Add(colId);
            dataGridViewRol.Columns.Add(colNombre);
            dataGridViewRol.Columns.Add(colEstado);
            dataGridViewRol.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            borrarButton.Enabled = true;
            modificarButton.Enabled = true;
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            selectedRol = (Rol)dataGridViewRol.CurrentRow.DataBoundItem;
            System.Windows.Forms.MessageBox.Show("Rol Nombre: " + selectedRol.name + " Rol Id: " + selectedRol.id);
            daoRol.deleteRol((int) selectedRol.id);
            fillDataGridView();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            selectedRol = (Rol)dataGridViewRol.CurrentRow.DataBoundItem;
            UpdateOrCreateView view = new UpdateOrCreateView(selectedRol, daoRol, false);
            view.ShowDialog();
            fillDataGridView();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            Rol newRol = new Rol();
            UpdateOrCreateView view = new UpdateOrCreateView(newRol, daoRol, true);
            view.ShowDialog();
            fillDataGridView();
        }

    }
}
