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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class NuevaRuta : Form
    {
        public NuevaRuta()
        {
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
            ruta.tipoServicioId = selectedServicio.tipo_servicio_id;
            ruta.precioBaseKg = Convert.ToInt32(textBoxPrecioBaseKG.Text);
            ruta.precioBasePasaje = Convert.ToInt32(textBoxPrecioBasePasaje.Text);

            DAORuta.create(ruta);

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

    }
}
