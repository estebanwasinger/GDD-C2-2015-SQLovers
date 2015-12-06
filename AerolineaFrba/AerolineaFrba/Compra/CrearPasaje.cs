using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class CrearPasaje : Form
    {
        private Vuelo vuelo;
        public Butaca butaca;

        public CrearPasaje(Vuelo vuelo)
        {
            this.vuelo = vuelo;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearPasaje_Load(object sender, EventArgs e)
        {
            buttonAgregar.Enabled = false;
            dataGridViewButacas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewButacas.AutoGenerateColumns = false;
            dataGridViewButacas.Columns.Add(Utils.crearColumna("numero","Numero", 70,true));
            dataGridViewButacas.Columns.Add(Utils.crearColumna("tipo", "Tipo", 70, true));
            dataGridViewButacas.Columns.Add(Utils.crearColumna("piso", "Piso", 70, true));
            dataGridViewButacas.DataSource = DAOButaca.getButacasDisponibles((int) vuelo.id);
        }

        private void dataGridViewButacas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAgregar.Enabled = true;
        }

        private void dataGridViewButacas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.butaca = (Butaca)dataGridViewButacas.CurrentRow.DataBoundItem;
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.butaca = (Butaca)dataGridViewButacas.CurrentRow.DataBoundItem;
            this.Close();
        }
    }
}
