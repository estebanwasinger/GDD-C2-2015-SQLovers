using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Abm_Rol
{
    public partial class FormRol : Form
    {
        private int _rol_id;
        private Rol rol;
        private DAORol daoRol;
        private ABMRol _abmRol;
        private List<Funcionalidad> funcList;
        private DAOFuncionalidad funcDAO;

        public FormRol(ABMRol abmRol, int rol_id)
        {
            InitializeComponent();
            this._abmRol = abmRol;
            funcList = new List<Funcionalidad>();
            funcDAO = new DAOFuncionalidad();
            daoRol = new DAORol();
            this._rol_id = rol_id;
            if (_rol_id != 0)
            {
                this.Text = "Modificar Rol";
                lblTitulo.Text = "Modificar Rol";
                rol = daoRol.getRolById(_rol_id);
                txtNombreRol.Text = rol.name;
                if ((bool)rol.activo)
                    RbActivo.Checked = true;
                if (!(bool)rol.activo)
                    RbNoActivo.Checked = true;
            }
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            setDgvFuncionalidades();
            fillDgvFuncionalidades();
        }

        private void fillDgvFuncionalidades()
        {
            funcList = funcDAO.retrieveAll();
            dgvFuncionalidades.DataSource = funcList;
        }

        private void setDgvFuncionalidades()
        {
            dgvFuncionalidades.ColumnCount = 2;
            dgvFuncionalidades.AllowUserToAddRows = false;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "chkFunc";
            checkColumn.HeaderText = "Seleccionar";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10;
            dgvFuncionalidades.Columns.Insert(0, checkColumn);

            dgvFuncionalidades.Columns[1].Name = "ID";
            dgvFuncionalidades.Columns[1].DataPropertyName = "id";
            dgvFuncionalidades.Columns[1].Visible = false;

            dgvFuncionalidades.Columns[2].Name = "Nombre";
            dgvFuncionalidades.Columns[2].DataPropertyName = "name";
            dgvFuncionalidades.Columns[2].ReadOnly = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rol = new Rol();
            rol.name = txtNombreRol.Text;
            if (RbActivo.Checked)
                rol.activo = true;
            else if (RbNoActivo.Checked)
                rol.activo = false;
            else
                rol.activo = false;
            if (this._rol_id != 0) //Es modificacion
            {
                rol.id = this._rol_id;
                daoRol.update(rol);
            }
            else
                daoRol.create(rol);
            _abmRol.fillDataGridView();
            this.Hide();
        }
    }
}
