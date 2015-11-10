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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class CrearOModificarRuta : Form
    {
        private bool crear;
        private Ruta ruta;

        public CrearOModificarRuta()
        {
            this.crear = true;
            InitializeComponent();
        }

        public CrearOModificarRuta(Ruta ruta)
        {
            this.crear = false;
            this.ruta = ruta;
            
            InitializeComponent();

        }

        private void NuevaRuta_Load(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;

            List<Ciudad> ciudadList = DAOCiudad.retrieveAll();
            comboBoxCiudadDestino.Text = "(Seleccionar ciudad)";
            comboBoxCiudadDestino.Items.AddRange(ciudadList.ToArray());
            comboBoxCiudadDestino.DisplayMember = "nombre";

            comboBoxCiudadOrigen.Text = "(Seleccionar ciudad)";
            comboBoxCiudadOrigen.Items.AddRange(ciudadList.ToArray());
            comboBoxCiudadOrigen.DisplayMember = "nombre";

            List<Servicio> servicioList = DAOServicio.retrieveAll();
            comboBoxTipoDeServicio.Text = "(Seleccionar tipo de servicio)";
            comboBoxTipoDeServicio.Items.AddRange(servicioList.ToArray());
            comboBoxTipoDeServicio.DisplayMember = "tipo_servicio_nomre";

            if (!crear)
            {
                checkBoxActivo.Checked = ruta.estado;
                textBoxPrecioBaseKG.Text = (ruta.precioBaseKg.ToString());
                textBoxPrecioBasePasaje.Text = ruta.precioBasePasaje.ToString();
                comboBoxCiudadDestino.SelectedIndex = getIndexOfCity(comboBoxCiudadDestino.Items, ruta.ciudadDestinoId);
                comboBoxCiudadOrigen.SelectedIndex = getIndexOfCity(comboBoxCiudadOrigen.Items, ruta.ciudadOrigenId);
                comboBoxTipoDeServicio.SelectedIndex = getIndexOfTipoServicio(comboBoxTipoDeServicio.Items, ruta.tipoServicioId);
            }
        }

        private int getIndexOfTipoServicio(ComboBox.ObjectCollection objectCollection, int p)
        {

            foreach (Servicio servicio in objectCollection)
            {
                if (servicio.tipo_servicio_id.Equals(p))
                {
                    return objectCollection.IndexOf(servicio);
                }
            }
            return 0;
        }

        private int getIndexOfCity(ComboBox.ObjectCollection objectCollection, int p)
        {

           foreach (Ciudad ciudad in objectCollection)
           {
               if (ciudad.id.Equals(p))
               {
                   return objectCollection.IndexOf(ciudad);
               }
           }
            return 0;
        }

        private void labelTipoDeServicio_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            Ciudad selectedCiudadDestino = (Ciudad) comboBoxCiudadDestino.SelectedItem;
            Ciudad selectedCiudadOrigen = (Ciudad) comboBoxCiudadOrigen.SelectedItem;
            Servicio selectedServicio = (Servicio)comboBoxTipoDeServicio.SelectedItem;

            Ruta ruta = new Ruta();
          
            ruta.ciudadDestinoId = selectedCiudadDestino.id;
            ruta.ciudadOrigenId = selectedCiudadOrigen.id;
            ruta.tipoServicioId = (int)selectedServicio.tipo_servicio_id;
            ruta.precioBaseKg = Convert.ToInt32(textBoxPrecioBaseKG.Text);
            ruta.precioBasePasaje = Convert.ToInt32(textBoxPrecioBasePasaje.Text);
            ruta.estado = checkBoxActivo.Checked;

            if (crear)
            {
                DAORuta.create(ruta);
            }
            else
            {
                ruta.id = this.ruta.id;
                DAORuta.update(ruta);
            }
            
            this.Close();
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

            if (comboBoxTipoDeServicio.SelectedItem == null)
            {
                return false;
            }

            if (String.IsNullOrWhiteSpace(textBoxPrecioBaseKG.Text)) {
                return false;
            }

            if (String.IsNullOrWhiteSpace(textBoxPrecioBasePasaje.Text))
            {
                return false;
            }
            EventLog.WriteEntry("Algo", "text");

            if (((Ciudad)comboBoxCiudadDestino.SelectedItem).id.Equals(((Ciudad)comboBoxCiudadOrigen.SelectedItem).id))
            {
                return false;
            }
            return true;

        }

        private static void AcceptOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrecioBaseKG_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumbers(e);
            buttonAceptar.Enabled = checkRequiredValues();
        }

        private void textBoxPrecioBasePasaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumbers(e);
            buttonAceptar.Enabled = checkRequiredValues();
        }

        private void comboBoxCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = checkRequiredValues();
        }

        private void comboBoxCiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = checkRequiredValues();
        }

        private void comboBoxTipoDeServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = checkRequiredValues();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecioBasePasaje_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
