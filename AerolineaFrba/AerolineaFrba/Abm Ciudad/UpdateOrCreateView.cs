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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class UpdateOrCreateView : Form
    {
        private Ciudad ciudad;
        private DAOCiudad daoCiudad;
        private Boolean create;

        private UpdateOrCreateView()
        {
            InitializeComponent();
        }

        public UpdateOrCreateView(Ciudad ciudad, DAOCiudad dao, Boolean create) : this()
        { 
            this.ciudad = ciudad;
            this.daoCiudad = dao;
            this.create = create;
            nombreCiudadTextBox.Text = ciudad.nombre;
            estadoCiudadCheckBox.Checked = ciudad.estado;
        }

        private void UpdateOrCreateView_Load(object sender, EventArgs e)
        {

        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            ciudad.nombre = nombreCiudadTextBox.Text;
            ciudad.estado = estadoCiudadCheckBox.Checked;
            if (create)
            {
                daoCiudad.create(ciudad);
            }
            else { daoCiudad.update(ciudad); }
            
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
