using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AerolineaFrba.Models;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Compra;

namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class PantallaCliente : Form
    {
        public PantallaCliente(Usuario invoker)
        {
            InitializeComponent();
            user = invoker;
        }

        public Usuario user { get; set; }


        private void buttonCompra_Click(object sender, EventArgs e)
        {
            CompraForm comp = new CompraForm();
            comp.ShowDialog();
        }

        private void buttonCanjeMillas_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsultarMillas_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
  
    }
}
