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
        public CompraForm()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonContinuar.Enabled = checkRequiredValues();
        }

        private void comboBoxCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonContinuar.Enabled = checkRequiredValues();
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
            buttonContinuar.Enabled = false;

            List<Ciudad> ciudadList = DAOCiudad.retrieveAll();
            comboBoxCiudadDestino.Text = "(Seleccionar ciudad)";
            comboBoxCiudadDestino.Items.AddRange(ciudadList.ToArray());
            comboBoxCiudadDestino.DisplayMember = "nombre";

            comboBoxCiudadOrigen.Text = "(Seleccionar ciudad)";
            comboBoxCiudadOrigen.Items.AddRange(ciudadList.ToArray());
            comboBoxCiudadOrigen.DisplayMember = "nombre";
        }
    }
}
