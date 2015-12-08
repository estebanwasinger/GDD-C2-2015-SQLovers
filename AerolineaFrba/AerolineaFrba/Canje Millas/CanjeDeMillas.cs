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



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.producto = (Producto)comboBoxProducto.SelectedItem;
            this.millasproducto = this.producto.millas;
        }

        private void CanjeDeMillas_Load(object sender, EventArgs e)
        {
            List<Producto> productoList = DAOProducto.retrieveAll();
            comboBoxProducto.Text = "(Seleccionar producto)";
            comboBoxProducto.Items.AddRange(productoList.ToArray());
            comboBoxProducto.DisplayMember = "nombre";
            buttonCanjear.Enabled = validarDatosCargados();
            //buttonCanjear.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cantidad = (Int32)numericUpDown_cant.Value;
            if (cantidad>0)
            {
                cantidadTotal = cantidad * millasproducto;
                if (cantidadTotal < cliente.millas)
                { buttonCanjear.Enabled = validarDatosCargados(); }
                else
                {
                    MessageBox.Show("No se puede realizar la operación, no cuenta con la cantidad de millas suficiente", "Error!", MessageBoxButtons.OK);
                }
            }

        }

        private void buttonCanjear_Click(object sender, EventArgs e)
        {
            producto.stock = producto.stock - 1;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            cliente = DAOCliente.getCliente(int.Parse(textBoxDNI.Text));

            if (cliente == null)
            {
                //MessageBox.Show("El cliente no existe", "Error!", MessageBoxButtons.OK);
               // textBoxDNI.Text = "";
            }

            buttonCanjear.Enabled = validarDatosCargados();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //public bool Validarcliente { get; set; }

      /*  private void buttonValidar_Click(object sender, EventArgs e)
        {
            cliente = DAOCliente.getCliente(int.Parse(textBoxDNI.Text));
            
            if (cliente == null)
            {
                MessageBox.Show("El cliente no existe", "Error!", MessageBoxButtons.OK);
                textBoxDNI.Text = "";
            }

            buttonCanjear.Enabled = validarDatosCargados();
        }*/

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
    }
}
