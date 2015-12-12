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
using System.Diagnostics;
using AerolineaFrba.Models.Utils;

namespace AerolineaFrba.Compra
{
    public partial class CompraForm : Form
    {
        List<Cliente> originalList;
        private Dictionary<int, Ruta> dictionary = new Dictionary<int, Ruta>();
        List<Vuelo> vueloList;

        public CompraForm()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = checkRequiredValues();
        }

        private void comboBoxCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = checkRequiredValues();
        }

        private bool checkRequiredValues()
        {
            if (comboBoxCiudadDestino.SelectedItem == null)
            {
                return false;
            }

            if (comboBoxCiudadOrigen.SelectedItem == null)
            {
                return false;
            }

            return true;
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = false;

            List<Ciudad> ciudadList = DAOCiudad.retrieveAll();
            comboBoxCiudadDestino.Text = "(Seleccionar ciudad)";
            comboBoxCiudadDestino.Items.AddRange(ciudadList.ToArray());
            comboBoxCiudadDestino.DisplayMember = "nombre";

            comboBoxCiudadOrigen.Text = "(Seleccionar ciudad)";
            comboBoxCiudadOrigen.Items.AddRange(ciudadList.ToArray());
            comboBoxCiudadOrigen.DisplayMember = "nombre";

            dataGridViewVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVuelos.Columns.Add(Utils.crearColumna("", "Id", 15, true));
            dataGridViewVuelos.Columns.Add(Utils.crearColumna("", "Fecha Salida", 150, true));
            dataGridViewVuelos.Columns.Add(Utils.crearColumna("", "Fecha Llegada", 150, true));
            dataGridViewVuelos.Columns.Add(Utils.crearColumna("", "Ciudad Origen", 110, true));
            dataGridViewVuelos.Columns.Add(Utils.crearColumna("", "Ciudad Destino", 110, true));
            dataGridViewVuelos.Columns.Add(Utils.crearColumna("", "Tipo Servicio", 110, true));

            vueloList = DAOVuelo.retrieveAll();

            fillDataGridView(vueloList);

            buttonContinuar.Enabled = false;
        }

        private void fillDataGridView(List<Vuelo> vueloList)
        {
            dataGridViewVuelos.Rows.Clear();
            foreach (Vuelo vuelo in vueloList)
            {
                Ruta ruta = getRuta((int)vuelo.ruta);
                string[] row1 = new string[] { vuelo.id.ToString(), vuelo.fechaSalida.ToString(), vuelo.fechaLlegadaEstimada.ToString(), ruta.ciudadOrigenNombre, ruta.ciudadDestinoNombre, ruta.tipoServicioNombre };

                dataGridViewVuelos.Rows.Add(row1);
            }
        }

        private Ruta getRuta(int rutaId) {
            if (dictionary.ContainsKey(rutaId))
            {
                return dictionary[rutaId];
            }
            else
            {
                Ruta ruta = DAORuta.getRuta(rutaId);
                dictionary.Add(rutaId, ruta);
                return ruta;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            vueloList = DAOVuelo.retrieveWithOriginDestinyAndDate((Ciudad) comboBoxCiudadOrigen.SelectedItem, (Ciudad) comboBoxCiudadDestino.SelectedItem, dateTimePickerCompra.Value);
            fillDataGridView(vueloList);
            if (vueloList.Count == 0) {
                buttonContinuar.Enabled = false;
            }

        }

        private void dataGridViewVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vueloList.Count == 0)
            {
                buttonContinuar.Enabled = false;
            }
            else { buttonContinuar.Enabled = true; }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            Pasaje nuevoPasaje = new Pasaje();
            nuevoPasaje.vuelo = selectedVuelo();
            DatosVuelo datosVuelo = new DatosVuelo(nuevoPasaje);
            datosVuelo.ShowDialog();
        }

        private Vuelo selectedVuelo()
        {
            return DAOVuelo.getVuelo(int.Parse((String) dataGridViewVuelos.CurrentRow.Cells[0].Value));
        }

        private void dataGridViewVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pasaje nuevoPasaje = new Pasaje();
            nuevoPasaje.vuelo = selectedVuelo();
            DatosVuelo datosVuelo = new DatosVuelo(nuevoPasaje);
            datosVuelo.ShowDialog();
        }
    }
}
