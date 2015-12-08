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
    public partial class NumeroCompra : Form
    {
        private int numeroCompra;

        public NumeroCompra(int numeroCompra)
        {
            this.numeroCompra = numeroCompra;
            InitializeComponent();
        }

        private void NumeroCompra_Load(object sender, EventArgs e)
        {
            labelPNR.Text = numeroCompra.ToString();
        }
    }
}
