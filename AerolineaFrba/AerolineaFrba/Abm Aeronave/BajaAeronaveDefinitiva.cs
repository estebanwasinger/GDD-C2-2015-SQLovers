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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaAeronaveD : Form
    {

        private DAOServicio daoPais = new DAOServicio();
        private DAOVuelo daoVuelo = new DAOVuelo();



        private Aeronave aeronave { get; set; }
        private bool update;
        private List<Vuelo> lstVuelo { get; set; }
        private Vuelo vuelo { get; set; }



        public BajaAeronaveD(Aeronave aer)
        {
            aeronave = aer;
            InitializeComponent();
            lstVuelo = new List<Vuelo>();

        }


        private void FormBajaDefinitiva_Load(object sender, EventArgs e)
        {


            int NO_tiene_vuelos;
            cargarCombos();
            if (aeronave.matricula != null)
            {
                txtmatricula.Enabled = false;

                update = true;
                cargarDatosAeronave();
            }

            cargarGrilla();
            NO_tiene_vuelos = actualizarGrilla();
            if (dtgVuelos.RowCount > 0) { btnBaja.Enabled = false; }
            if (NO_tiene_vuelos == 1)
            {

                txtFabri.Enabled = false;
                txtModelo.Enabled = false;
                txtPeso.Enabled = false;
                btnReempV.Enabled = false;
                btnCancelarV.Enabled = false;
                cmbServicio.Enabled = false;

            }

        }

        private void cargarDatosAeronave()
        {
            txtmatricula.Text = aeronave.matricula;
            txtModelo.Text = aeronave.modelo.ToString();
            txtFabri.Text = aeronave.fabricante.ToString();
            txtPeso.Text = aeronave.peso_disponible.ToString();

            string serv = (string)aeronave.get_service();
            cmbServicio.SelectedIndex = cmbServicio.FindStringExact(serv);

            txtmatricula.Enabled = false;
            txtModelo.Enabled = false;
            txtPeso.Enabled = false;
            txtFabri.Enabled = false;
            cmbServicio.Enabled = false;


        }

        private void cargarCombos()
        {
            cmbServicio.Items.AddRange(daoPais.retrieveBase().ToArray());

        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colAeronave = new DataGridViewTextBoxColumn();
            colAeronave.DataPropertyName = "aeronave";
            colAeronave.HeaderText = "Aeronave";
            colAeronave.Width = 120;
            DataGridViewTextBoxColumn colRuta = new DataGridViewTextBoxColumn();
            colRuta.DataPropertyName = "ruta";
            colRuta.HeaderText = "Ruta";
            colRuta.Width = 120;

            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.DataPropertyName = "id";
            colID.HeaderText = "Vuelo ID";
            colID.Width = 120;

            dtgVuelos.Columns.Add(colID);
            dtgVuelos.Columns.Add(colAeronave);
            dtgVuelos.Columns.Add(colRuta);

        }

        public int actualizarGrilla()
        {

            int var = 0;
            if (txtmatricula.Text != "")
                lstVuelo = DAOVuelo.getVuelosDesdeFecha((int)DAOAeronave.getAeronaveFromMatricula(txtmatricula.Text).id, getFechaBaja());
            dtgVuelos.DataSource = lstVuelo;

            if (lstVuelo.Count == 0) { var = 1; }
            return var;

        }

        public void actualizarGrilla_X_vueloCancelado()
        {

            lstVuelo = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(txtmatricula.Text).id);
            dtgVuelos.DataSource = lstVuelo;
        }


        private void btn_Reemplazar_Click(object sender, EventArgs e)
        {

            Vuelo vue = (Vuelo)dtgVuelos.CurrentRow.DataBoundItem;
            Reemplazar rem = new Reemplazar(vue, this);
            rem.ShowDialog();
            actualizarGrilla();
        }

        private void btn_Cancelar_Vuelo(object sender, EventArgs e)
        {

            Vuelo vuelo = (Vuelo)dtgVuelos.CurrentRow.DataBoundItem;
            DAOVuelo.darBaja((int)vuelo.id);
            actualizarGrilla();
            actualizarEstadoBotonBaja();
            MessageBox.Show("Vuelo Cancelado", "Notificacion", MessageBoxButtons.OK);

        }

        private void actualizarEstadoBotonBaja()
        {
            if (dtgVuelos.RowCount == 0)
            {
                btnBaja.Enabled = true;
                btnCancelarV.Enabled = false;
                btnReempV.Enabled = false;
            }
            else
            {
                btnBaja.Enabled = false;
                btnCancelarV.Enabled = true;
                btnReempV.Enabled = true;
            }
        }

        private void btn_darBajaDefinitiva(object sender, EventArgs e)
        {

            DAOAeronave daoA = new DAOAeronave();
            DateTime fecha_bajaDef = getFechaBaja();

            if (DateTime.Compare(fecha_bajaDef, DateTime.Today) >= 0)
            {

                if (dtgVuelos.RowCount > 0)
                {
                    MessageBox.Show("La Aeronave tiene Vuelos asignados", "Notificacion", MessageBoxButtons.OK);
                }
                else
                {
                    daoA.bajaDef((int)aeronave.id, fecha_bajaDef);
                    MessageBox.Show("Baja Definitiva completa", "Notificacion", MessageBoxButtons.OK);
                }
                this.Close();
            }
            else { MessageBox.Show("Verifique la fecha/hora", "Notificacion", MessageBoxButtons.OK); }

        }

        private DateTime getFechaBaja()
        {
            return new DateTime(dateBaja.Value.Year, dateBaja.Value.Month, dateBaja.Value.Day, horaBD.Value.Hour, horaBD.Value.Minute, horaBD.Value.Second);
        }

        public bool tieneVuelos(string matricula)
        {

            bool tieneVuelos = false;
            lstVuelo = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(matricula).id);
            if (lstVuelo.Count > 0) { tieneVuelos = true; }

            return tieneVuelos;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void dateBaja_ValueChanged(object sender, EventArgs e)
        {
            actualizarGrilla();
            actualizarEstadoBotonBaja();
        }

    }
}
