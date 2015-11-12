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
            //modificarButton.Enabled = false;
            //borrarButton.Enabled = false;
            //createColumns();
            SetDgv();
            fillDataGridView();
        }

        public void fillDataGridView()
        {
            rolList = daoRol.retrieveAll();

            dataGridViewRol.DataSource = rolList;
        }
        
               private void SetDgv()
        {
            dataGridViewRol.ColumnCount = 3;
            dataGridViewRol.AllowUserToAddRows = false;

            dataGridViewRol.Columns[0].Name = "ID";
            dataGridViewRol.Columns[0].DataPropertyName = "id";
            dataGridViewRol.Columns[0].Visible = false;

            dataGridViewRol.Columns[1].Name = "Nombre";
            dataGridViewRol.Columns[1].DataPropertyName = "name";
            dataGridViewRol.Columns[1].ReadOnly = true;

            dataGridViewRol.Columns[2].Name = "Activo";
            dataGridViewRol.Columns[2].DataPropertyName = "activo";
            dataGridViewRol.Columns[2].ReadOnly = true;
            dataGridViewRol.Columns[2].Width = 40;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridViewRol.Columns.Add(btn);
            btn.HeaderText = "Modificar";
            btn.Text = "Modificar";
            btn.Name = "btnModificar";
            btn.UseColumnTextForButtonValue = true;

            btn = new DataGridViewButtonColumn();
            dataGridViewRol.Columns.Add(btn);
            btn.HeaderText = "Eliminar";
            btn.Text = "Eliminar";
            btn.Name = "btnEliminar";
            btn.UseColumnTextForButtonValue = true;
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
          //  borrarButton.Enabled = true;
          //  modificarButton.Enabled = true;
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
            CrearOModificarRol view = new CrearOModificarRol(selectedRol, daoRol, false);
            view.ShowDialog();
            fillDataGridView();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            Rol newRol = new Rol();
            CrearOModificarRol view = new CrearOModificarRol(newRol, daoRol, true);
            view.ShowDialog();
            fillDataGridView();
        }

        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            showFormRol();
        }

        private void showFormRol(int rol_id = 0)
        {
            FormRol formRol = new FormRol(this, rol_id);
            formRol.ShowDialog();
        }

        private void dataGridViewRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewRol.CurrentCell.OwningRow;
            int rol_id = Convert.ToInt32(row.Cells["ID"].Value.ToString());

            if (e.ColumnIndex == 3)
                showFormRol(rol_id);
            else if (e.ColumnIndex == 4)
                DeleteRol(rol_id);
        }

        private void DeleteRol(int rol_id)
        {
            daoRol.deleteRol(rol_id);
            this.fillDataGridView();
        }

    }
}
