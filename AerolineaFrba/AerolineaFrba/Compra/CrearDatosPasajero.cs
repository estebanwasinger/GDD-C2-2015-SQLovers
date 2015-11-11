using AerolineaFrba.Models.BO;
using AerolineaFrba.ValildationUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class CrearDatosPasajero : Form
    {

        public Cliente cliente { get; set; }

        public CrearDatosPasajero()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosPasajero_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (Validation.isFilled(textBoxApellidoPasajero) && 
                Validation.isFilled(textBoxDireccionpasajero) &&
                Validation.isFilled(textBoxDNI) &&
                Validation.isFilled(textBoxNombrePasajero) &&
                Validation.isFilled(textBoxMailPasajero)) {

                    Cliente cliente = new Cliente();
                    cliente.apellido = textBoxApellidoPasajero.Text;
                    cliente.nombre = textBoxNombrePasajero.Text;
                    cliente.dni = Int32.Parse(textBoxDNI.Text);
                    cliente.mail = textBoxMailPasajero.Text;
                    cliente.direccion = textBoxDireccionpasajero.Text;
                    cliente.fechaNacimiento = dateTimePickerFechaNacimiento.Value;

                    this.cliente = cliente;
                    this.Close();
                    // DAOClie
            }
        }
    }
}
