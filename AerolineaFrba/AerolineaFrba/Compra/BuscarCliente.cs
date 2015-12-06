using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
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
    public partial class BuscarCliente : Form
    {

        public Cliente cliente { get; set; }

        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonSeleccionar.Enabled = true;
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.Columns.Add(Utils.crearColumna("dni", "DNI", 50, true));
            dataGridViewClientes.Columns.Add(Utils.crearColumna("nombre", "Nombre", 100, true));
            dataGridViewClientes.Columns.Add(Utils.crearColumna("apellido", "Apellido", 100, true));
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.DataSource = DAOCliente.retrieveAll();
            buttonSeleccionar.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            this.cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text != null)
            {
                List<Cliente> clienteList = DAOCliente.retrieveAll();
                List<Cliente> filteredClienteList = new List<Cliente>();
                foreach (Cliente cliente in clienteList)
                {
                    if (cliente.dni.ToString().StartsWith(textBoxBusqueda.Text))
                    {
                        filteredClienteList.Add(cliente);
                    }
                }

                dataGridViewClientes.DataSource = filteredClienteList;
            }
            
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearDatosPasajero form = new CrearDatosPasajero();
            form.ShowDialog();
            form.Close();
            this.cliente = form.cliente;
            this.Close();
        }

        private void dataGridViewClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;
            this.Close();
        }

    }
}
