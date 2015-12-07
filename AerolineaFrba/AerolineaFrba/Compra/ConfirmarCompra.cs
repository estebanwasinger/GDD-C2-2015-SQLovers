using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.Utils;
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
    public partial class ConfirmarCompra : Form
    {
        private Cliente cliente;
        private List<Encomienda> encomiendaList;
        private List<Pasaje> pasajeList;
        private DatosVuelo datosVuelo;

        public ConfirmarCompra(List<Encomienda> encomiendaList, List<Pasaje> pasajeList, DatosVuelo datosVuelo)
        {
            // TODO: Complete member initialization
            this.encomiendaList = encomiendaList;
            this.pasajeList = pasajeList;
            this.datosVuelo = datosVuelo;
            InitializeComponent();
            this.datosVuelo.Hide();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente clienteForm = new BuscarCliente();
            clienteForm.ShowDialog();
            if (clienteForm.cliente != null)
            {
                cliente = clienteForm.cliente;
                textBoxNombre.Text = cliente.dni.ToString();
                textBoxDNI.Text = cliente.nombre + " " + cliente.apellido;
                this.validar(null, null);
            };
        }

        private bool validarDatosCargados() {
            if (cliente == null) {
                return false;
            }

            if (radioButtonTC.Checked) {
                if (!Validation.isFilled(comboBoxTipos) ||
                    !Validation.isFilled(comboBoxCuotas) ||
                    !Validation.isFilled(textBoxCodSeguridad) ||
                    !Validation.isFilled(textBoxNumeroTC))
                {
                        return false;
                }
            }
            
            return true;
        }

        private void ConfirmarCompra_Load(object sender, EventArgs e)
        {
            comboBoxCuotas.Items.AddRange(new object[] { 1,2,3,6,12,18,24,36,48 });
            comboBoxCuotas.Text = "(Cuotas)";

            comboBoxTipos.Items.AddRange(new object[] { "VISA", "MASTERCARD", "AMEX"});
            comboBoxTipos.Text = "(Tipo)";

            dateTimePickerVencimiento.CustomFormat = "MM/yyyy";
            dateTimePickerVencimiento.MinDate = DateTime.Today;
            dateTimePickerVencimiento.MaxDate = DateTime.Today.AddYears(4);

            textBoxCantPasajes.Text = pasajeList.Count.ToString();
            textBoxEncomiendas.Text = encomiendaList.Count.ToString();
            Int32 costoTotal = getCostoTotal();
            textBoxCostoTotal.Text = costoTotal.ToString();

            groupBoTC.Enabled = false;

            buttonComprar.Enabled = false;
        }

        private int getCostoTotal()
        {
            Int32 costoTotal = 0;
            foreach (Comprable comprable in encomiendaList)
            {
                costoTotal = costoTotal + comprable.precioTotal;
            }
            foreach (Comprable comprable in pasajeList)
            {
                costoTotal = costoTotal + comprable.precioTotal;
            }
            return costoTotal;
        }

        private void radioButtonTC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTC.Checked)
            {
                groupBoTC.Enabled = true;
            }
            else {
                groupBoTC.Enabled = false;
            }

            buttonComprar.Enabled = this.validarDatosCargados();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.datosVuelo.Show();
        }

        private void validar(object sender, EventArgs e)
        {
            buttonComprar.Enabled = this.validarDatosCargados();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            foreach (Comprable compra in pasajeList)
            {
                compra.comprar();
            }

            foreach (Comprable compra in encomiendaList)
            {
                compra.comprar();
            }
            this.Close();
            this.datosVuelo.Close();
        }

        private void textBoxNumeroTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumbers(e);
        }

        private void textBoxCodSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumbers(e);
        }

        private static void AcceptOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
