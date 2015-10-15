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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class FormABMAeronave : Form
    {
        public FormABMAeronave()
        {
            InitializeComponent();
            lstAeronaves = new List<Aeronave>();
            dao = new DAOAeronave();
            //lstTipos = new List<TipoDocumento>();

        }

        private DAOAeronave dao;
        private List<Aeronave> lstAeronaves { get; set; }
        //private List<TipoDocumento> lstTipos;


        private void frmABMAeronave_Load(object sender, EventArgs e)
        {
            //lstTipos = TipoDocumento.ObtenerTiposDocumento();

            /*if (lstTipos.Count > 0)
            {
                cmbTipoID.Visible = true;
                cmbTipoID.DataSource = lstTipos;
                cmbTipoID.DisplayMember = "descripcion";
                cmbTipoID.ValueMember = "id";
                cmbTipoID.SelectedIndex = -1;

            }*/

            dtgAeoronave.AutoGenerateColumns = false;
            dtgAeoronave.MultiSelect = false;

            cargarGrilla();
            actualizarGrilla();
        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colMatricula = new DataGridViewTextBoxColumn();
            colMatricula.DataPropertyName = "Matricula";
            colMatricula.HeaderText = "Matricula";
            colMatricula.Width = 120;
            DataGridViewTextBoxColumn colModelo = new DataGridViewTextBoxColumn();
            colModelo.DataPropertyName = "Modelo";
            colModelo.HeaderText = "Modelo";
            colModelo.Width = 120;
            DataGridViewTextBoxColumn colKGDisp = new DataGridViewTextBoxColumn();
            colKGDisp.DataPropertyName = "KG Disponibles";
            colKGDisp.HeaderText = "KG Disponibles";
            colKGDisp.Width = 120;
            DataGridViewTextBoxColumn colFabricante = new DataGridViewTextBoxColumn();
            colFabricante.DataPropertyName = "Fabricante";
            colFabricante.HeaderText = "Fabricante";
            colFabricante.Width = 120;

            dtgAeoronave.Columns.Add(colMatricula);
            dtgAeoronave.Columns.Add(colModelo);
            dtgAeoronave.Columns.Add(colKGDisp);
            dtgAeoronave.Columns.Add(colFabricante);
        }

        public void actualizarGrilla()
        {
            if (txtmatricula.Text != "" || txtfabri.Text != "" || txtmodelo.Text != "" || txtPeso.Text != "")
                lstAeronaves = dao.search(txtmatricula.Text, txtfabri.Text, txtmodelo.SelectedText, txtPeso.SelectedText);
            else
                lstAeronaves = dao.retrieveAll();
            Aeronave client = new Aeronave();
            client = lstAeronaves[0];
            dtgAeoronave.DataSource = lstAeronaves;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
