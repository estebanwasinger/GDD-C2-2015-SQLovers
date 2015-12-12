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
        DAORuta daoRuta = new DAORuta();

        public RegistrarLlegada()
        {
            InitializeComponent();
        }

        private void FormRegistrarLlegada_Load(object sender, EventArgs e)
        {

            cargarCombos();
            btnRegist.Enabled = false;

        }

        private void cargarDatos_click(object sender, EventArgs e)
        {

            //txtMatricula.Text = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            //txtFabricante.Text = ((Aeronave)cmbMatricula.SelectedItem).fabricante;

            if ((Aeronave)cmbMatricula.SelectedItem != null)
            {
                int modelo_id = (int)((Aeronave)cmbMatricula.SelectedItem).modelo;


                txtModelo.Text = DAOAeronave.getNombreModelo(modelo_id).nombre;

                int fabricante_id = DAOAeronave.getNombreModelo(modelo_id).fabricante;
                txtFabricante.Text = DAOAeronave.getNombreFabricante(fabricante_id).nombre;


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
            else { MessageBox.Show("¡Elija una Aeronave para cargar datos!", "Atencion", MessageBoxButtons.OK); }

        }

        public void cargarCombos()
        {

            //cmbAOrigen.Items.AddRange(daoCiudad.retrieveBase().ToArray());
            /*Aeronave aer = new Aeronave();
            aer = ((Aeronave)cmbMatricula.SelectedItem);
            string matricula = aer.matricula;
            cmbAOrigen.Items.AddRange(daoCiudad.getOrigenes(matricula).ToArray());*/

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

            LsVuelos = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(matricula).id);

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
            LsVuelos = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(matricula).id);

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
            LsVuelos = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(matricula).id);
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


            LsVuelos = daoVuelo.search(DAOAeronave.getAeronaveFromMatricula(matricula).id);

            int ruta_elex = ruta.getRuta(origen, destino);


            foreach (Vuelo velo in LsVuelos)
            {
                if (velo.ruta.Equals(ruta_elex)) { ruta_correcta = true; }

            }

            return ruta_correcta;

        }

        private void elegirMa_click(object sender, EventArgs e)
        {
            Aeronave aer = new Aeronave();
                aer = ((Aeronave)cmbMatricula.SelectedItem);
                int id = (int)aer.id;
                
                cmbAOrigen.Items.Clear();
                cmbAOrigen.Items.AddRange(daoCiudad.getOrigenes(id).ToArray());
        }

        private void ValidarLLegada_click(object sender, EventArgs e)
        {
            if ((Aeronave)cmbMatricula.SelectedItem != null && (Ciudad)cmbAOrigen.SelectedItem != null && (Ciudad)cmbASalia.SelectedItem != null)
            {

                if (!validarMatricula())
                {
                    MessageBox.Show("¡La Aeronave no tenia vuelo planificado!", "Error", MessageBoxButtons.OK);

                }
                else
                {

                    if (!validarRuta())
                    {
                        MessageBox.Show("¡EL vuelo no registra ese Destino, No se puede registrar!", "Atencion", MessageBoxButtons.OK);
                        //MessageBox.Show("¡Presione Registrar", "Notificacion", MessageBoxButtons.OK);
                        //btnRegist.Enabled = true;
                    }
                    else
                    {
                        if (!validarFechadeArribo())
                        {
                            MessageBox.Show("¡La fecha de Llegada tiene que ser mayor a la fecha de Salida!", "Error", MessageBoxButtons.OK);

                        }

                        else
                        {
                            MessageBox.Show("¡Presione Registrar", "Notificacion", MessageBoxButtons.OK);
                            btnRegist.Enabled = true;
                        };
                    }


                }
            }
        else{ MessageBox.Show("¡No debe haber campos vacios", "Notificacion", MessageBoxButtons.OK);}

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

            if (daoll.registrarLlegada(llegada)<0)
            {
                List<Pasaje> pasajeList = DAOPasaje.getFromVuelo(llegada.vuelo_id);

                foreach( Pasaje pasaje in pasajeList) {
                    Millas millas = new Millas();
                    millas.cantidad = (int) pasaje.precio / 10;
                    millas.cliente = pasaje.usuario.dni;
                    millas.pasaje = pasaje.codigo;
                    millas.fecha = DateTime.Now;
                    DAOMillas.create(millas);
                }

                List<Encomienda> encomiendaList = DAOEncomienda.getFromVuelo(llegada.vuelo_id);

                foreach (Encomienda encomienda in encomiendaList)
                {
                    Millas millas = new Millas();
                    millas.cantidad = (int) encomienda.precioTotal / 10;
                    millas.cliente = encomienda.idCliente;
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
