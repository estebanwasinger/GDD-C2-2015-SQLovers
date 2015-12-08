using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
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
            BuscarClienteBasico clienteForm = new BuscarClienteBasico();
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
                    !Validation.isFilled(textBoxNumeroTC) ||
                    textBoxCodSeguridad.Text.Length > 5 ||
                    textBoxNumeroTC.Text.Length > 18)
                {
                        return false;
                }
            }

            if (!radioButtonTC.Checked && !radioButtonEfectivo.Checked) {
                return false;
            }
            
            return true;
        }

        private void ConfirmarCompra_Load(object sender, EventArgs e)
        {
            comboBoxCuotas.Items.AddRange(new object[] { 1, 2, 3, 6, 12, 18, 24, 36, 48 });
            comboBoxCuotas.Text = "(Cuotas)";
            comboBoxCuotas.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxTipos.Items.AddRange(new object[] { "VISA", "MASTERCARD", "AMEX" });
            comboBoxTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipos.Text = "(Tipo)";

            dateTimePickerVencimiento.CustomFormat = "MM/yyyy";
            dateTimePickerVencimiento.MinDate = DateTime.Today;
            dateTimePickerVencimiento.MaxDate = DateTime.Today.AddYears(4);

            textBoxCantPasajes.Text = pasajeList.Count.ToString();
            textBoxEncomiendas.Text = encomiendaList.Count.ToString();
            Int32 costoTotal = getCostoTotal();
            textBoxCostoTotal.Text = costoTotal.ToString();

            if (!Session.Instance().admin)
            {
                radioButtonEfectivo.Enabled = false;
                radioButtonTC.Checked = true;
                groupBoTC.Enabled = true;
            } else {
                groupBoTC.Enabled = false;
            }

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
            CompraAero compraGeneral = new CompraAero();
            compraGeneral.cliente = this.cliente.dni;
            compraGeneral.fecha = DateTime.Now;
            compraGeneral.tipo = radioButtonEfectivo.Checked ? "e" : "t";
            DAOCompra.create(compraGeneral);
            compraGeneral = DAOCompra.getCompra(compraGeneral.cliente, compraGeneral.fecha);
            if (compraGeneral != null)
            {
                foreach (Comprable compra in pasajeList)
                {
                    compra.setCompra(compraGeneral.id);
                    compra.comprar();
                }

                foreach (Comprable compra in encomiendaList)
                {
                    compra.setCompra(compraGeneral.id);
                    compra.comprar();
                }

                if (compraGeneral.tipo.Equals("t")) {
                    TarjetaDeCredito tarjeta = new TarjetaDeCredito();
                    tarjeta.numero = Int64.Parse(textBoxNumeroTC.Text);
                    tarjeta.tipo = comboBoxTipos.Text;
                    tarjeta.cuotas = Int64.Parse(comboBoxCuotas.Text);
                    tarjeta.compraId = (Int64)compraGeneral.id;
                    tarjeta.cod = Int64.Parse(textBoxCodSeguridad.Text);
                    tarjeta.fecha = dateTimePickerVencimiento.Value;
                    DAOTarjetaDeCredito.create(tarjeta);
                }

                NumeroCompra mostrarNumeroForm = new NumeroCompra(compraGeneral.id);
                this.Close();
                this.datosVuelo.Close();
                mostrarNumeroForm.ShowDialog();
            }

            
            
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
