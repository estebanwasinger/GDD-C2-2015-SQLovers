using AerolineaFrba.Models.BO;
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
    public partial class CancelarViaje : Form
    {
        public CancelarViaje()
        {
            InitializeComponent();
        }

        private List<Pasaje> lstPasaje { get; set; }

        private void FormCancelarViaje_Load(object sender, EventArgs e) {

            dtgProdCancelar.AutoGenerateColumns = false;
            dtgProdCancelar.MultiSelect = false;

            cargarGrilla();
            actualizarGrilla();
        }


        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn ColCodigo = new DataGridViewTextBoxColumn();
            ColCodigo.DataPropertyName = "matricula";
            ColCodigo.HeaderText = "Matricula";
            ColCodigo.Width = 120;

            DataGridViewTextBoxColumn ColFechaCompra = new DataGridViewTextBoxColumn();
            ColFechaCompra.DataPropertyName = "descripcion_tipoServicio";
            ColFechaCompra.HeaderText = "Servicio";
            ColFechaCompra.Width = 120;

            dtgProdCancelar.Columns.Add(ColCodigo);
            dtgProdCancelar.Columns.Add(ColFechaCompra);

            
        }


        public void actualizarGrilla()
        {

           // lstPasaje = daoPasaje.aeronave_servicio();
           // dtgAeronavesPosibles.DataSource = lstAeronaves;

        }

    }
}
