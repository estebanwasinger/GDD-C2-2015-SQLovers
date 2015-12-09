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

namespace AerolineaFrba.Devolucion
{
    public partial class FormDevolucion : Form
    {
        public List<Pasaje> lstPasajes = new List<Pasaje>();
        public List<Encomienda> lstEncom = new List<Encomienda>();

        public Devolver devolucion = new Devolver(); 

        public FormDevolucion()
        {
            InitializeComponent();
        }



        private void btnPasaje_Click(object sender, EventArgs e)
        {
            DevolucionPasaje devPas = new DevolucionPasaje(this);
            devPas.ShowDialog();
        }

        private void btnEncomienda_Click(object sender, EventArgs e)
        {
            DevolucionEncomienda devEnc = new DevolucionEncomienda(this);
            devEnc.ShowDialog();
        }

        private void Datos_Load(object sender, EventArgs e) {
            dtgPasajes.AutoGenerateColumns = false;
            dtgPasajes.MultiSelect = false;

            cargarGrilla();
        }

        private void cargarGrilla()
        {

            DataGridViewTextBoxColumn colPasaje = new DataGridViewTextBoxColumn();
            colPasaje.DataPropertyName = "codigo";
            colPasaje.HeaderText = "Pasaje";
            colPasaje.Width = 100;
            DataGridViewTextBoxColumn colCompraID = new DataGridViewTextBoxColumn();
            colCompraID.DataPropertyName = "compra_id";
            colCompraID.HeaderText = "Compra";
            colCompraID.Width = 100;

            DataGridViewTextBoxColumn colEncomienda = new DataGridViewTextBoxColumn();
            colEncomienda.DataPropertyName = "id";
            colEncomienda.HeaderText = "Encomienda";
            colEncomienda.Width = 100;
            DataGridViewTextBoxColumn colCompraID_E = new DataGridViewTextBoxColumn();
            colCompraID_E.DataPropertyName = "compra_id";
            colCompraID_E.HeaderText = "Compra";
            colCompraID_E.Width = 100;


            dtgPasajes.Columns.Add(colPasaje);
            dtgPasajes.Columns.Add(colCompraID);
            dtgEncomiendas.Columns.Add(colEncomienda);
            dtgEncomiendas.Columns.Add(colCompraID_E);

        }


        public void agregarPasaje(Pasaje pasaje) {

            if (pasajeNoElegido(pasaje))
            {
                string[] row1 = new string[] { ((Int32)pasaje.codigo).ToString(), ((Int32)pasaje.compraId).ToString() };
                dtgPasajes.Rows.Add(row1);
                lstPasajes.Add(pasaje);
                
            }
            else { MessageBox.Show("El pasaje ya fue seleccionado", "Error", MessageBoxButtons.OK); }
                   
        }

        public void agregarEncomienda(Encomienda encomienda)
        {

            if (encomiendaNoElegido(encomienda))
            {
                string[] row1 = new string[] { ((Int32)encomienda.id).ToString(), ((Int32)encomienda.compraId).ToString() };
                dtgEncomiendas.Rows.Add(row1);
                lstEncom.Add(encomienda);
            }
            else { MessageBox.Show("La encomienda ya fue seleccionado", "Error", MessageBoxButtons.OK); }

        }


        public bool encomiendaNoElegido(Encomienda encomienda)
        {
            bool retorno = true;

            foreach (Encomienda enco in lstEncom)
            {

                if (enco.id == encomienda.id) { retorno = false; }
            }

            return retorno;
        }

        public bool pasajeNoElegido(Pasaje pasaje)
        {
            bool retorno= true;

            foreach (Pasaje pas in lstPasajes) {

                if (pas.codigo == pasaje.codigo) { retorno = false; }
            }

            return retorno;
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {

            DAODevolucion daoDev = new DAODevolucion();
            DateTime fechaDev = DateTime.Now;
                //new DateTime(DateTime.Now.Value.Year, dateDev.Value.Month, dateDev.Value.Day, dateDev.Value.Hour, dateDev.Value.Minute, dateDev.Value.Second);
            string detalle = txtDetalle.Text;

            if (detalle != "" )
            {
                if (lstEncom.Count > 0 || lstPasajes.Count > 0)
                {
                int dinero = daoDev.guardar(fechaDev, detalle, lstPasajes, lstEncom);
                MessageBox.Show("Se Devolvio en $: " + dinero, "Error", MessageBoxButtons.OK);
                this.Close();
                }
                else { MessageBox.Show("Elija algun Item a Cancelar ", "Error", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("Ingrese el Detalle ", "Error", MessageBoxButtons.OK); }

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
