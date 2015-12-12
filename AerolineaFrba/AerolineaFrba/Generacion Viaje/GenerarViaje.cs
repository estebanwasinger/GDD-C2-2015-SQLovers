using AerolineaFrba.Abm_Ruta;
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

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class GenerarViaje : Form
    {

        private DAOCiudad daoCiudad = new DAOCiudad();
        private DAOVuelo daoVuelo = new DAOVuelo();
        private Vuelo vuelo = new Vuelo();

        private DAOAeronave daoAeronave = new DAOAeronave();
        private List<Aeronave> lstAeronaves { get; set; }

        public GenerarViaje()
        {
            InitializeComponent();
            lstAeronaves = new List<Aeronave>();
        }

        private void FormGenerarViaje_Load(object sender, EventArgs e)
        {

            cargarCombos();

            dtgAeronavesPosibles.AutoGenerateColumns = false;
            dtgAeronavesPosibles.MultiSelect = false;
            cargarGrilla();
            actualizarGrilla();
        }

        public void cargarDatosVueloAGuardar()
        {

            vuelo.fechaSalida = getFechaSalida();
            vuelo.fechaLlegadaEstimada = getFechaLlegada();

            Aeronave aer_seleccionada = (Aeronave)dtgAeronavesPosibles.CurrentRow.DataBoundItem;
            vuelo.aeronave = aer_seleccionada.id;

            string origen = ((Ciudad)cmbOrigen.SelectedItem).nombre;
            string destino = ((Ciudad)cmbDestino.SelectedItem).nombre;

            Ruta ruta = new Ruta();
            vuelo.ruta = ruta.getRuta(origen, destino);
        }

        private DateTime getFechaSalida()
        {
            return new DateTime(dateSalida.Value.Year, dateSalida.Value.Month, dateSalida.Value.Day, horaSalida.Value.Hour, horaSalida.Value.Minute, horaSalida.Value.Second);
        }

        private DateTime getFechaLlegada()
        {
            return new DateTime(dateLlegada.Value.Year, dateLlegada.Value.Month, dateLlegada.Value.Day, horaLlegada.Value.Hour, horaLlegada.Value.Minute, horaLlegada.Value.Second);
        }

        private void cargarCombos()
        {
            DAOServicio daoServ = new DAOServicio();
            DAOAeronave daoAer = new DAOAeronave();

            cmbOrigen.Items.AddRange(daoCiudad.retrieveBase().ToArray());
            cmbDestino.Items.AddRange(daoCiudad.retrieveBase().ToArray());
            cmbTipoServ.Items.AddRange(daoServ.retrieveBase().ToArray());

            cmbOrigen.DisplayMember = "nombre";
            cmbDestino.DisplayMember = "nombre";
            cmbTipoServ.DisplayMember = "tipo_servicio_nombre";

        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colMatricula = new DataGridViewTextBoxColumn();
            colMatricula.DataPropertyName = "matricula";
            colMatricula.HeaderText = "Matricula";
            colMatricula.Width = 120;
            DataGridViewTextBoxColumn Colservicio = new DataGridViewTextBoxColumn();
            Colservicio.DataPropertyName = "descripcion_tipoServicio";
            Colservicio.HeaderText = "Servicio";
            Colservicio.Width = 120;

            dtgAeronavesPosibles.Columns.Add(colMatricula);
            dtgAeronavesPosibles.Columns.Add(Colservicio);


        }

        public void actualizarGrilla()
        {

            lstAeronaves = daoAeronave.aeronave_servicio();
            dtgAeronavesPosibles.DataSource = lstAeronaves;

        }

        public int validar_fecha_salida()
        {


            DateTime fechaSalida = getFechaSalida();

            int result = DateTime.Compare(fechaSalida, DateTime.Now);

            return result;

        }

        public double getHorasDeViaje()
        {
            //new DateTime(1192,12,13,1,2,1)
            DateTime fechaSalida = getFechaSalida();
            DateTime fechaLlegada = getFechaLlegada();

            TimeSpan fechadiff = fechaLlegada.Subtract(fechaSalida);
            double diff = fechadiff.TotalHours;
            System.Console.WriteLine(diff);

            return diff;

        }

        public bool validar_mismoServicio()
        {

            string seleccionado = cmbTipoServ.Text;
            Aeronave aer = (Aeronave)dtgAeronavesPosibles.CurrentRow.DataBoundItem;

            if (aer.descripcion_tipoServicio == seleccionado) { return true; }
            else { return false; }

        }


        public bool validarDisponibiladad()
        {

            Aeronave aer_seleccionada = (Aeronave)dtgAeronavesPosibles.CurrentRow.DataBoundItem;
            DateTime fecha_salida = getFechaSalida();
            bool disponible = aer_seleccionada.estaDisponible(fecha_salida);
            System.Console.WriteLine("la fecha elejida es:" + fecha_salida);

            return disponible;

        }

        private void btnGuardarVuelo_click(object sender, EventArgs e)
        {
            if (validar_fecha_salida() == 1)
            {
                double horasDeViaje = getHorasDeViaje();
                if (horasDeViaje <= 24 && horasDeViaje > 0)
                {
                    if (validar_mismoServicio())
                    {
                        if (validarDisponibiladad())
                        {

                            cargarDatosVueloAGuardar();
                            if (vuelo.ruta == 0)
                            {

                                MessageBox.Show("¡La Ruta no Existe, Necesita crearla!", "Error", MessageBoxButtons.OK);
                                CrearOModificarRuta nuevaRuta = new CrearOModificarRuta();
                                nuevaRuta.Show();
                            }
                            else
                            {
                                if (!daoVuelo.existe_vuelo(vuelo))
                                {
                                    daoVuelo.create(vuelo);
                                    MessageBox.Show("¡Se Creo el Viaje correctamente", "Error", MessageBoxButtons.OK);
                                }
                                else { MessageBox.Show("¡La Aeronave tiene un vuelo a esa hora", "Error", MessageBoxButtons.OK); }
                            }

                        }
                        else
                        {

                            MessageBox.Show("¡el avion No esta disponible esa fecha!", "Error", MessageBoxButtons.OK);
                        }

                    }
                    else { MessageBox.Show("¡El Servicio del Avion y el Recorrido no coinciden!", "Error", MessageBoxButtons.OK); }

                }
                else { MessageBox.Show("¡verificar Fecha de viaje!", "Error", MessageBoxButtons.OK); }


            }
            else
            {
                MessageBox.Show("¡La fecha de salida tiene que ser mayor a la actual!", "Error", MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
