using AerolineaFrba.Models;
using AerolineaFrba.Registro_de_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public void btnCliente_Click(object sender, EventArgs e) {

            Usuario user = new Usuario();
            PantallaCliente pantallaCliente = new PantallaCliente(user);
            pantallaCliente.Show();
            //this.Hide();       
        }

        public void btnAdministrador_Click(object sender, EventArgs e) {

            Usuario user = new Usuario();
            FormPrincipal formPrinicipal = new FormPrincipal(user);
            formPrinicipal.Show();
        }
        

    }
}
