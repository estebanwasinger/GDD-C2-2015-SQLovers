using AerolineaFrba.Compra;
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

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillas : Form
    {
        private Cliente cliente;

        public ConsultaMillas()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClienteBasico buscarCliente = new BuscarClienteBasico();
            buscarCliente.ShowDialog();
            if (buscarCliente.cliente != null) {
                this.cliente = buscarCliente.cliente;
                textBoxDni.Text = this.cliente.dni.ToString();
                textBoxMillas.Text = (DAOMillas.getMillasTotalesDeCliente(this.cliente.dni) - DAOCanje.getMillasGastadas(this.cliente.dni)).ToString();
                List<Canje> canjeList = DAOCanje.getCanjes(this.cliente.dni);
                List<Millas> millasList = DAOMillas.getMillasDeCliente(this.cliente.dni);

                foreach (Canje canje in canjeList)
                {
                    string[] row1 = new string[] { canje.cantidad.ToString(), canje.precio.ToString(), canje.producto.ToString() };

                    dataGridViewCanjes.Rows.Add(row1);
                }

                foreach (Millas millas in millasList)
                {
                    string[] row1 = new string[] { millas.cantidad.ToString(), millas.fecha.ToString() , millas.encomienda == 0 ? "Pasaje" : "Encomienda" };

                    dataGridViewMillas.Rows.Add(row1);
                }
            }
        }

        private void ConsultaMillas_Load(object sender, EventArgs e)
        {
            dataGridViewCanjes.Columns.Add(Utils.crearColumna("", "Cantidad", 100, true));
            dataGridViewCanjes.Columns.Add(Utils.crearColumna("", "Precio", 100, true));
            dataGridViewCanjes.Columns.Add(Utils.crearColumna("", "Producto", 100, true));

            dataGridViewMillas.Columns.Add(Utils.crearColumna("", "Cantidad", 100, true));
            dataGridViewMillas.Columns.Add(Utils.crearColumna("", "Fecha", 100, true));
            dataGridViewMillas.Columns.Add(Utils.crearColumna("", "Tipo", 100, true));
        }
    }
}
