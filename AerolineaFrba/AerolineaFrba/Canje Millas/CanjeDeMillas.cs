using AerolineaFrba.Compra;
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

namespace AerolineaFrba.Canje_Millas
{
    public partial class CanjeDeMillas : Form
    {
        private Producto producto;
        private int millasproducto;
        private bool crear;
        private Int32 cantidad = 0;
        private Int32 cantidadTotal;
        private Int32 millasCliente;
        private Int32 millasGastadas;
        public Cliente cliente;
        private Models.Usuario user;

        public CanjeDeMillas()
        {
            this.crear = true;
            InitializeComponent();
        }

        public CanjeDeMillas(Models.Usuario user)
        {
            // TODO: Complete member initialization
            this.user = user;
            this.crear = true;
            InitializeComponent();
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.producto = (Producto)comboBoxProducto.SelectedItem;
            this.millasproducto = this.producto.millas;
            this.numericUpDown_cant.Enabled = true;
            textBoxCostoUnitario.Text = millasproducto.ToString();
            numericUpDown_cant.Value = 0;
            buttonCanjear.Enabled = validarDatosCargados();
        }

        private void CanjeDeMillas_Load(object sender, EventArgs e)
        {
            List<Producto> productoList = DAOProducto.retrieveAll();
            comboBoxProducto.Text = "(Seleccionar producto)";
            comboBoxProducto.Items.AddRange(productoList.ToArray());
            comboBoxProducto.DisplayMember = "nombre";
            buttonCanjear.Enabled = validarDatosCargados();
            numericUpDown_cant.Enabled = false;
            //buttonCanjear.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cantidad = (Int32)numericUpDown_cant.Value;
            cantidadTotal = cantidad * producto.millas;
            if (cantidad > 0)
            {
                if (producto.stock < cantidad)
                {
                    numericUpDown_cant.Value = numericUpDown_cant.Value - 1;
                    MessageBox.Show("No se puede realizar la operación, no cuenta con suficiente stock", "Error!", MessageBoxButtons.OK);
                    return;
                }
                if (cantidadTotal > (millasCliente - millasGastadas))
                {
                    numericUpDown_cant.Value = numericUpDown_cant.Value - 1;
                    MessageBox.Show("No se puede realizar la operación, no cuenta con la cantidad de millas suficiente", "Error!", MessageBoxButtons.OK);
                    return;
                }
            }
            textBoxCostoTotal.Text = cantidadTotal.ToString();
            textBoxBalance.Text = (millasCliente - cantidadTotal - millasGastadas).ToString();
            buttonCanjear.Enabled = validarDatosCargados();
        }

        private void buttonCanjear_Click(object sender, EventArgs e)
        {
            producto.stock = producto.stock - (int) numericUpDown_cant.Value;
            DAOProducto.actualizarStock(producto.id, producto.stock);

            Canje canje = new Canje();
            canje.cantidad = cantidad;
            canje.cliente = cliente.id;
            canje.fecha = DateTime.Now;
            canje.producto = producto.id;
            DAOCanje.create(canje);

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool validarDatosCargados()
        {
            if (cliente == null) {
                return false;
            }

            if (!Validation.isFilled(comboBoxProducto)) {
                return false;
            }

            if (numericUpDown_cant.Value == 0) {
                return false;
            }
            return true;
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClienteBasico buscarForm = new BuscarClienteBasico();
            buscarForm.ShowDialog();

            if (buscarForm.cliente != null) {
                this.cliente = buscarForm.cliente;
                textBoxDNI.Text = this.cliente.dni.ToString();
                millasCliente = DAOMillas.getMillasTotalesDeCliente(this.cliente.id);
                
                millasGastadas = DAOCanje.getMillasGastadas(this.cliente.id);
                textBoxMillasDisponibles.Text = (millasCliente - millasGastadas).ToString();
                validarDatosCargados();
            }

            
        }
    }
}
