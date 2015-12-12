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
    public partial class DevolucionEncomienda : Form
    {
        private List<Encomienda> lstEnco { get; set; }
        private DAOEncomienda daoEnco = new DAOEncomienda();
        public FormDevolucion fdev;

        public DevolucionEncomienda(FormDevolucion _fdev)
        {
            InitializeComponent();
            this.fdev = _fdev;
        }

        private void DevolucionEncomienda_Load(object sender, EventArgs e)
        {

            dtgEncomienda.AutoGenerateColumns = false;
            dtgEncomienda.MultiSelect = false;

            cargarGrilla();
            actualizarGrilla();

        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn ColCodEncomienda = new DataGridViewTextBoxColumn();
            ColCodEncomienda.DataPropertyName = "id";
            ColCodEncomienda.HeaderText = "Codigo";
            ColCodEncomienda.Width = 120;
           /* DataGridViewTextBoxColumn ColCliente = new DataGridViewTextBoxColumn();
            ColCliente.DataPropertyName = "dniCliente";
            ColCliente.HeaderText = "Cliente ";
            ColCliente.Width = 120;*/

            dtgEncomienda.Columns.Add(ColCodEncomienda);
            //dtgEncomienda.Columns.Add(ColCliente);

        }

        public void actualizarGrilla()
        {

            lstEnco = daoEnco.getEncomienda();
            dtgEncomienda.DataSource = lstEnco;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtEnc.Text != "" && Char.IsDigit(txtEnc.Text, 0))
            {
                lstEnco = daoEnco.buscarEncomienda(txtEnc.Text);
                if (lstEnco.Count > 0)
                {
                    dtgEncomienda.DataSource = lstEnco;
                }
                else { MessageBox.Show("No Existe el Codigo de Compra", "Error", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("Ingrese el codigo de una Compra y presione buscar", "Error", MessageBoxButtons.OK); }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FormDevolucion fdevolucion = new FormDevolucion();

            Encomienda enco = (Encomienda)dtgEncomienda.CurrentRow.DataBoundItem;
            fdev.agregarEncomienda(enco);
            this.Close();
        }

    }
}
