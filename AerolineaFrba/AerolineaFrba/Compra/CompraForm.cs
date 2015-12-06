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

namespace AerolineaFrba.Compra
{
    public partial class CompraForm : Form
    {
        List<Cliente> originalList;

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
            dataGridViewVuelos.DataSource = DAOVuelo.retrieveAll();
            buttonContinuar.Enabled = false;
        }

        private void comboBoxUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (comboBoxUsuarios.Text.Length > 3)
            {
                List<Cliente> filteredList = new List<Cliente>();
                foreach (Cliente cliente in originalList)
                {
                    if(cliente.dni.ToString().StartsWith(comboBoxUsuarios.Text)){
                        filteredList.Add(cliente);
                    }
                }
                comboBoxUsuarios.Items.Clear();
                comboBoxUsuarios.Items.AddRange(filteredList.ToArray());
            }*/
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Vuelo> vueloList = DAOVuelo.retrieveWithOriginDestinyAndDate((Ciudad) comboBoxCiudadOrigen.SelectedItem, (Ciudad) comboBoxCiudadDestino.SelectedItem, dateTimePickerCompra.Value);
            dataGridViewVuelos.DataSource = vueloList;
        }

        private void dataGridViewVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonContinuar.Enabled = true;
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
            return (Vuelo) dataGridViewVuelos.CurrentRow.DataBoundItem;
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
