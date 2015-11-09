using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
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
    public partial class DatosVuelo : Form
    {
        public DatosVuelo(Vuelo vuelo)
        {
            InitializeComponent();
            textBoxAvion.Text = vuelo.aeronave;
            textBoxFechaSalida.Text = vuelo.fechaSalida.ToString();
            textBoxFechaLlegada.Text = vuelo.fechaLlegada.ToString();
            Ruta ruta = DAORuta.getRuta((int) vuelo.ruta);
            textBoxCiudadDestino.Text = ruta.ciudadDestinoNombre;
            textBoxCiudadOrigen.Text = ruta.ciudadOrigenNombre;
        }
    }
}
