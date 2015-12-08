using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
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
        private bool create;

        public CrearDatosPasajero()
        {
            create = true;
            InitializeComponent();
        }

        public CrearDatosPasajero(Cliente cliente)
        {
            create = false;
            this.cliente = cliente;
            
            InitializeComponent();

            textBoxApellidoPasajero.Text = cliente.apellido;
            textBoxDireccionpasajero.Text = cliente.direccion;
            textBoxDNI.Text = cliente.dni.ToString();
            textBoxNombrePasajero.Text = cliente.nombre;
            textBoxMailPasajero.Text = cliente.mail;
            textBoxTelefonoPasajero.Text = cliente.telefono.ToString();
            dateTimePickerFechaNacimiento.Value = cliente.fechaNacimiento;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosPasajero_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (create)
            {
                if (Validation.isFilled(textBoxApellidoPasajero) &&
                    Validation.isFilled(textBoxDireccionpasajero) &&
                    Validation.isFilled(textBoxDNI) &&
                    Validation.isFilled(textBoxNombrePasajero) &&
                    Validation.isFilled(textBoxMailPasajero) &&
                    Validation.isFilled(textBoxTelefonoPasajero))
                {

                    Cliente cliente = new Cliente();
                    cliente.apellido = textBoxApellidoPasajero.Text;
                    cliente.nombre = textBoxNombrePasajero.Text;
                    cliente.dni = Int32.Parse(textBoxDNI.Text);
                    cliente.mail = textBoxMailPasajero.Text;
                    cliente.direccion = textBoxDireccionpasajero.Text;
                    cliente.telefono = int.Parse(textBoxTelefonoPasajero.Text);
                    cliente.fechaNacimiento = dateTimePickerFechaNacimiento.Value;

                    this.cliente = cliente;
                    this.Close();
                    DAOCliente.create(cliente);
                }
                else
                {
                    MessageBox.Show("Error", "No todos los datos se han ingresado", MessageBoxButtons.OK);
                }
            }
            else {

                cliente.apellido = textBoxApellidoPasajero.Text;
                cliente.nombre = textBoxNombrePasajero.Text;
                cliente.dni = Int32.Parse(textBoxDNI.Text);
                cliente.mail = textBoxMailPasajero.Text;
                cliente.direccion = textBoxDireccionpasajero.Text;
                cliente.telefono = int.Parse(textBoxTelefonoPasajero.Text);
                cliente.fechaNacimiento = dateTimePickerFechaNacimiento.Value;

                this.cliente = cliente;
                DAOCliente.update(cliente);
                this.Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
