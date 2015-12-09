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

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistrarLlegada : Form
    {
        Aeronave aer = new Aeronave();
        DAOCiudad daoCiudad = new DAOCiudad();
        DAOAeronave daoAeronave = new DAOAeronave();

        public RegistrarLlegada()
        {
            InitializeComponent();
        }

        private void FormRegistrarLlegada_Load(object sender, EventArgs e)
        {

            cargarCombos();

        }

        private void cargarDatos_click(object sender, EventArgs e)
        {

            //txtMatricula.Text = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            txtFabricante.Text = ((Aeronave)cmbMatricula.SelectedItem).fabricante;
            txtModelo.Text = ((Aeronave)cmbMatricula.SelectedItem).modelo;
            txtCarga.Text = Convert.ToString(((Aeronave)cmbMatricula.SelectedItem).peso_disponible);
            txtServicio.Text = ((Aeronave)cmbMatricula.SelectedItem).get_service();
            txtButacasPasillo.Text = Convert.ToString(((Aeronave)cmbMatricula.SelectedItem).getCantidadButacasPasillo());
            txtButacasVent.Text = Convert.ToString(((Aeronave)cmbMatricula.SelectedItem).getCantidadButacasVentanilla());



            txtButacasVent.Enabled = false;
            txtFabricante.Enabled = false;
            txtModelo.Enabled = false;
            txtButacasPasillo.Enabled = false;
            txtServicio.Enabled = false;
            txtCarga.Enabled = false;
        }

        public void cargarCombos()
        {

            cmbAOrigen.Items.AddRange(daoCiudad.retrieveBase().ToArray());
            cmbASalia.Items.AddRange(daoCiudad.retrieveBase().ToArray());
            cmbMatricula.Items.AddRange(daoAeronave.retrieveBase().ToArray());


            cmbAOrigen.DisplayMember = "nombre";
            cmbASalia.DisplayMember = "nombre";
            cmbMatricula.DisplayMember = "matricula";

        }

        public bool validarMatricula()
        {

            // matricula, hora de llegada y ruta 

            string matricula = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            bool existe = false;

            DAOVuelo daoVuelo = new DAOVuelo();
            List<Vuelo> LsVuelos = new List<Vuelo>();

            LsVuelos = daoVuelo.search(matricula);

            if (LsVuelos.Count > 0) { existe = true; }


            // else { MessageBox.Show("¡La Aeronave no tenia vuelo Planificado, Call 911!", "Error", MessageBoxButtons.OK); }
            return existe;

        }

        public bool validarFechadeArribo()
        {

            string matricula = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            bool arribo_correcto = false;
            DAOVuelo daoVuelo = new DAOVuelo();
            List<Vuelo> LsVuelos = new List<Vuelo>();
            LsVuelos = daoVuelo.search(matricula);

            DateTime fecha_llegada_form = new DateTime(dateLlegada.Value.Year, dateLlegada.Value.Month, dateLlegada.Value.Day, horaLlegada.Value.Hour, horaLlegada.Value.Minute, horaLlegada.Value.Second);

            foreach (Vuelo velo in LsVuelos)
            {
                TimeSpan dif_horas = new TimeSpan();
                dif_horas = fecha_llegada_form - velo.fechaSalida;
                
                if(DateTime.Compare(fecha_llegada_form,velo.fechaSalida)>0)
                {
                    if(dif_horas.TotalHours < 24){
                        Console.WriteLine(velo.id);
                    //System.Console.WriteLine("la fecha de la tabla vuelo es:" + velo.fecha_Llegada);
                    //System.Console.WriteLine("la fecha de la tabla vuelo es:" + fecha_llegada_form);
                    arribo_correcto = true;}
                }
                // else { MessageBox.Show("¡La Aeronave no tenia vuelo Planificado a esa HORA, Call 911!", "Error", MessageBoxButtons.OK); }
            }

            return arribo_correcto;
        }

        public int obtener_vueloID() {
            string matricula = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            //bool arribo_correcto = false;
            DAOVuelo daoVuelo = new DAOVuelo();
            List<Vuelo> LsVuelos = new List<Vuelo>();
            LsVuelos = daoVuelo.search(matricula);
            int vuelo_id =0;

            DateTime fecha_llegada_form = new DateTime(dateLlegada.Value.Year, dateLlegada.Value.Month, dateLlegada.Value.Day, horaLlegada.Value.Hour, horaLlegada.Value.Minute, horaLlegada.Value.Second);

            foreach (Vuelo velo in LsVuelos)
            {
                TimeSpan dif_horas = new TimeSpan();
                dif_horas = fecha_llegada_form - velo.fechaSalida;
                

                if(DateTime.Compare(fecha_llegada_form,velo.fechaSalida)>0)
                {
                    if(dif_horas.TotalHours < 24){
                        vuelo_id = (int)velo.id;
                        //Console.WriteLine(velo.id);
                       // arribo_correcto = true;
                    }
                }
                // else { MessageBox.Show("¡La Aeronave no tenia vuelo Planificado a esa HORA, Call 911!", "Error", MessageBoxButtons.OK); }
            }

            return vuelo_id;
        }


        public bool validarRuta()
        {

            string matricula = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            bool ruta_correcta = false;
            DAOVuelo daoVuelo = new DAOVuelo();
            List<Vuelo> LsVuelos = new List<Vuelo>();
            Ruta ruta = new Ruta();
            string origen = ((Ciudad)cmbAOrigen.SelectedItem).nombre;
            string destino = ((Ciudad)cmbASalia.SelectedItem).nombre;


            LsVuelos = daoVuelo.search(matricula);

            int ruta_elex = ruta.getRuta(origen, destino);


            foreach (Vuelo velo in LsVuelos)
            {
                if (velo.ruta.Equals(ruta_elex)) { ruta_correcta = true; }

            }

            return ruta_correcta;

        }

        private void ValidarLLegada_click(object sender, EventArgs e)
        {

            if (!validarMatricula()) { MessageBox.Show("¡La Aeronave no tenia vuelo planificado, Call 911!", "Error", MessageBoxButtons.OK);
            //btnRegist.Enabled = false;
            }
            else
            {

                if (!validarRuta()) { MessageBox.Show("¡La Aeronave no tenia esta Ruta planificada!", "Error", MessageBoxButtons.OK);
             //   btnRegist.Enabled = false;
                }
                else
                {
                    if (!validarFechadeArribo()) { MessageBox.Show("¡La fecha de Llegada tiene que ser mayor a la fecha de Salida!", "Error", MessageBoxButtons.OK);
               //     btnRegist.Enabled = false;
                    }

                    else { MessageBox.Show("¡La Aeronave llego al destino y en el horario correcto, presione Registrar", "Notificacion", MessageBoxButtons.OK);
                                                                                                                                              };
                }


            }

        }

        public void insertarLLegada(object sender, EventArgs e)
        {

            LlegadaDestino llegada = new LlegadaDestino();
            DAOLlegadaDestino daoll = new DAOLlegadaDestino();

            llegada.matricula = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            llegada.fecha_arribo = new DateTime(dateLlegada.Value.Year, dateLlegada.Value.Month, dateLlegada.Value.Day, horaLlegada.Value.Hour, horaLlegada.Value.Minute, horaLlegada.Value.Second);
            llegada.origen_id = ((Ciudad)cmbAOrigen.SelectedItem).id;
            llegada.destino_id = ((Ciudad)cmbASalia.SelectedItem).id;
            llegada.vuelo_id = this.obtener_vueloID();

            if (daoll.create(llegada))
            {
                List<Pasaje> pasajeList = DAOPasaje.getFromVuelo(llegada.vuelo_id);

                foreach( Pasaje pasaje in pasajeList) {
                    Millas millas = new Millas();
                    millas.cantidad = pasaje.precio / 10;
                    millas.cliente = pasaje.usuario.dni;
                    millas.pasaje = pasaje.codigo;
                    millas.fecha = DateTime.Now;
                    DAOMillas.create(millas);
                }

                List<Encomienda> encomiendaList = DAOEncomienda.getFromVuelo(llegada.vuelo_id);

                foreach (Encomienda encomienda in encomiendaList)
                {
                    Millas millas = new Millas();
                    millas.cantidad = encomienda.precioTotal / 10;
                    millas.cliente = encomienda.dniCliente;
                    millas.encomienda = encomienda.id;
                    millas.fecha = DateTime.Now;
                    DAOMillas.create(millas);
                }

                MessageBox.Show("Llegada de Aeronave Registrada", "Notificacion", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Error al Registrar llegada", "Notificacion", MessageBoxButtons.OK); }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
