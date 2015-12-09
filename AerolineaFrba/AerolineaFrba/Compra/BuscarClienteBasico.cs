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
    public partial class BuscarClienteBasico : Form
    {
        public Cliente cliente;

        public BuscarClienteBasico()
        {
            InitializeComponent();
        }



        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(Validation.isFilled(textBoxBusqueda)){
                cliente = DAOCliente.getCliente(int.Parse(textBoxBusqueda.Text));
                if (cliente != null)
                {
                    actualizarComboBoxCliente(cliente);
                    buttonModificarCliente.Enabled = true;
                }
                else {
                    MessageBox.Show("Error", "No se econtro cliente con ese DNI",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void actualizarComboBoxCliente(Cliente cliente)
        {
            textBoxApellidoCliente.Text = cliente.apellido;
            textBoxDni.Text = cliente.dni.ToString();
            textBoxNombreCliente.Text = cliente.nombre;
            textBoxUsuario.Text = cliente.username;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            CrearDatosPasajero pasajeroForm = new CrearDatosPasajero(cliente);
            pasajeroForm.ShowDialog();
            if (pasajeroForm.cliente != null)
            {
                cliente = pasajeroForm.cliente;
                actualizarComboBoxCliente(cliente);
            }
        }

        private void buttonCrearCliente_Click(object sender, EventArgs e)
        {
            CrearDatosPasajero pasajeroForm = new CrearDatosPasajero();
            
            pasajeroForm.ShowDialog();
            if (pasajeroForm.cliente != null) {
                cliente = pasajeroForm.cliente;
                actualizarComboBoxCliente(cliente);
            }
        }

        private void BuscarClienteBasico_Load(object sender, EventArgs e)
        {
            buttonModificarCliente.Enabled = false;
        }

        private void textBoxBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AcceptOnlyNumbers(e);
        }

        private void AcceptOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
