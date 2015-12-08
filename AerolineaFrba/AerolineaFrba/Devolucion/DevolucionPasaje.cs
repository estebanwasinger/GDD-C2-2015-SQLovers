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

namespace AerolineaFrba.Devolucion
{
    public partial class DevolucionPasaje : Form
    {
        private List<Pasaje> lstPasajes { get; set; }
        private DAOPasaje daoPasaje = new DAOPasaje();
        public FormDevolucion fdev;

        public DevolucionPasaje(FormDevolucion _fdev)
        {
            InitializeComponent();
            this.fdev = _fdev;
        }

        private void DevolucionPasaje_Load(object sender, EventArgs e)
        {

            dtgPasaje.AutoGenerateColumns = false;
            dtgPasaje.MultiSelect = false;

            cargarGrilla();
            actualizarGrilla();

        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn ColCodPasaje = new DataGridViewTextBoxColumn();
            ColCodPasaje.DataPropertyName = "codigo";
            ColCodPasaje.HeaderText = "Pasaje";
            ColCodPasaje.Width = 120;
            DataGridViewTextBoxColumn ColCliente = new DataGridViewTextBoxColumn();
            ColCliente.DataPropertyName = "CliDNI";
            ColCliente.HeaderText = "Cliente";
            ColCliente.Width = 120;

            dtgPasaje.Columns.Add(ColCodPasaje);
            dtgPasaje.Columns.Add(ColCliente);

        }

        public void actualizarGrilla()
        {
            lstPasajes = daoPasaje.getPasajes();
            dtgPasaje.DataSource = lstPasajes;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodPasa.Text != "")
            {
                lstPasajes = daoPasaje.buscarPasaje(txtCodPasa.Text);
                dtgPasaje.DataSource = lstPasajes;
            }
            else { MessageBox.Show("Ingrese el codigo de un Pasaje y presione buscar", "Error", MessageBoxButtons.OK); }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FormDevolucion fdevolucion = new FormDevolucion();

            Pasaje aer = (Pasaje)dtgPasaje.CurrentRow.DataBoundItem;
            fdev.agregarPasaje(aer);
            this.Close();
        }




    }
}
