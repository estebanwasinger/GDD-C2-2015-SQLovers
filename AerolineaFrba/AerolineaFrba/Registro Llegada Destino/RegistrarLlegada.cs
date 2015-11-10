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

            txtMatricula.Text = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            txtFabricante.Text = ((Aeronave)cmbMatricula.SelectedItem).fabricante;
            txtModelo.Text = ((Aeronave)cmbMatricula.SelectedItem).modelo;
            txtCarga.Text = Convert.ToString(((Aeronave)cmbMatricula.SelectedItem).peso_disponible);
            txtServicio.Text = ((Aeronave)cmbMatricula.SelectedItem).get_service();
            txtButacas.Text = Convert.ToString(((Aeronave)cmbMatricula.SelectedItem).getCantidadButacas());

            txtMatricula.Enabled = false;
            txtFabricante.Enabled = false;
            txtModelo.Enabled = false;
            txtButacas.Enabled = false;
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
                if (velo.fecha_Llegada.Equals(fecha_llegada_form))
                {
                    //System.Console.WriteLine("la fecha de la tabla vuelo es:" + velo.fecha_Llegada);
                    //System.Console.WriteLine("la fecha de la tabla vuelo es:" + fecha_llegada_form);
                    arribo_correcto = true;
                }
                // else { MessageBox.Show("¡La Aeronave no tenia vuelo Planificado a esa HORA, Call 911!", "Error", MessageBoxButtons.OK); }
            }

            return arribo_correcto;
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
            btnRegist.Enabled = false;
            }
            else
            {

                if (!validarFechadeArribo()) { MessageBox.Show("¡La Aeronave no tenia vuelo Planificado a esa HORA, Call 911!", "Error", MessageBoxButtons.OK);
                btnRegist.Enabled = false;
                }
                else
                {
                    if (!validarRuta()) { MessageBox.Show("¡La Aeronave no tenia este destino, Call 911!", "Error", MessageBoxButtons.OK);
                    btnRegist.Enabled = false;
                    }

                    else { MessageBox.Show("¡La Aeronave llego al destino y en el horario correcto", "Notificacion", MessageBoxButtons.OK);
                                                                                                                                              };
                }


            }

        }

        public void insertarLLegada(object sender, EventArgs e)
        {

            LlegadaDestino llegada = new LlegadaDestino();
            DAOLlegadaDestino daoll= new DAOLlegadaDestino();

            llegada.matricula = ((Aeronave)cmbMatricula.SelectedItem).matricula;
            llegada.fecha_arribo = new DateTime(dateLlegada.Value.Year, dateLlegada.Value.Month, dateLlegada.Value.Day, horaLlegada.Value.Hour, horaLlegada.Value.Minute, horaLlegada.Value.Second);
            llegada.origen_id = ((Ciudad)cmbAOrigen.SelectedItem).id;
            llegada.destino_id=((Ciudad)cmbASalia.SelectedItem).id;

            daoll.create(llegada);
            MessageBox.Show("Llegada de Aeronave Registrada", "Notificacion", MessageBoxButtons.OK);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
