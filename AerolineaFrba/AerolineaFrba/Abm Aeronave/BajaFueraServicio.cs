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
    public partial class BajaFueraServicio : Form
    {

        private DAOServicio daoServicio = new DAOServicio();
        private DAOVuelo daoVuelo = new DAOVuelo();
        private Aeronave aeronave { get; set; }
        private bool update;
        private List<Vuelo> lstVuelo { get; set; }
        private Vuelo vuelo { get; set; }



        public BajaFueraServicio(Aeronave aer)
        {
            aeronave = aer;
            InitializeComponent();
            lstVuelo = new List<Vuelo>();

        }


        private void FormBajaFservicio_Load(object sender, EventArgs e)
        {
            int NO_tiene_vuelos;
            cargarCombos();
            if (aeronave.matricula != null)
            {
                txtmatricula.Enabled = false;
                txtModelo.Enabled = false;
                txtPeso.Enabled = false;
                txtFabri.Enabled = false;
                cmbServicio.Enabled = false;
                //dateBaja.Enabled = false;

                update = true;
                cargarDatosAeronave();
            }

            cargarGrilla();
            NO_tiene_vuelos = actualizarGrilla();

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
        }

        private void cargarCombos()
        {
            cmbServicio.Items.AddRange(daoServicio.retrieveBase().ToArray());

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

            DataGridViewTextBoxColumn colFSalida = new DataGridViewTextBoxColumn();
            colFSalida.DataPropertyName = "fechaSalida";
            colFSalida.HeaderText = "Fecha de Salida";
            colFSalida.Width = 120;

            DataGridViewTextBoxColumn colFLlegada = new DataGridViewTextBoxColumn();
            colFLlegada.DataPropertyName = "fechaLlegada";
            colFLlegada.HeaderText = "Fecha de Llegada";
            colFLlegada.Width = 120;

            dtgVuelos.Columns.Add(colID);
            dtgVuelos.Columns.Add(colAeronave);
            dtgVuelos.Columns.Add(colRuta);
            dtgVuelos.Columns.Add(colFSalida);
            dtgVuelos.Columns.Add(colFLlegada);

        }

        public int actualizarGrilla()
        {

            int var = 0;
            if (txtmatricula.Text != "")
                lstVuelo = DAOVuelo.getVuelosEntreDosFechas((int)DAOAeronave.getAeronaveFromMatricula(txtmatricula.Text).id, getFechaBaja(), getFechaVueltaServicio());
            dtgVuelos.DataSource = lstVuelo;

            if (lstVuelo.Count == 0) { var = 1; }
            return var;

        }

        private void btn_Reemplazar_Click(object sender, EventArgs e)
        {

            Vuelo vue = (Vuelo)dtgVuelos.CurrentRow.DataBoundItem;
            Reemplazar rem = new Reemplazar(vue, this);
            rem.ShowDialog();
            actualizarGrilla();
            actualizarEstadoBotonBaja();
        }

        private void btn_Cancelar_Vuelo(object sender, EventArgs e)
        {

            Vuelo vuelo = (Vuelo)dtgVuelos.CurrentRow.DataBoundItem;
            int cancelo = daoVuelo.cancelarVuelo((int)vuelo.id);

            actualizarGrilla();
            actualizarEstadoBotonBaja();
            MessageBox.Show("Vuelo Cancelado", "Notificacion", MessageBoxButtons.OK);

        }

        private void btn_darBajaFueraDeServicio(object sender, EventArgs e)
        {

            DAOAeronave daoA = new DAOAeronave();
            DateTime fecha_bfs = getFechaBaja();

            if (DateTime.Compare(fecha_bfs, DateTime.Now) >= 0)
            {

                DateTime fecha_vueltaS = getFechaVueltaServicio();

                if (DateTime.Compare(fecha_vueltaS, DateTime.Today) > 0)
                {
                    DateTime fechaV = new DateTime(fecha_vueltaS.Year, fecha_vueltaS.Month, fecha_vueltaS.Day);
                    daoA.bajaFueraServicio((int) aeronave.id, fecha_vueltaS, fecha_bfs);
                    MessageBox.Show("Baja por Fuera de Servicio hasta: " + fechaV, "Notificacion", MessageBoxButtons.OK);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Ingrese una fecha superior para la vuelta de Servicio", "Notificacion", MessageBoxButtons.OK);
                }

            }
            else
            {
                { MessageBox.Show("Verifique fecha/hora de baja", "Notificacion", MessageBoxButtons.OK); }

            }
        }

        private DateTime getFechaVueltaServicio()
        {
            return new DateTime(dateFVS.Value.Year, dateFVS.Value.Month, dateFVS.Value.Day, dateFVS.Value.Hour, dateFVS.Value.Minute, dateFVS.Value.Second);
        }

        private DateTime getFechaBaja()
        {
            return new DateTime(dateBaja.Value.Year, dateBaja.Value.Month, dateBaja.Value.Day, horaBFS.Value.Hour, horaBFS.Value.Minute, horaBFS.Value.Second);
        }

        public bool tieneVuelos(string matricula)
        {

            bool tieneVuelos = false;
            lstVuelo = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(txtmatricula.Text).id);
            if (lstVuelo.Count > 0) { tieneVuelos = true; }

            return tieneVuelos;
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

        public void actualizarGrilla_X_vueloCancelado()
        {

            lstVuelo = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(txtmatricula.Text).id);
            dtgVuelos.DataSource = lstVuelo;
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateBaja_ValueChanged(object sender, EventArgs e)
        {
            dateBaja.MaxDate = dateFVS.Value;
            dateFVS.MinDate = dateBaja.Value;
            actualizarGrilla();
            actualizarEstadoBotonBaja();
        }



    }
}
