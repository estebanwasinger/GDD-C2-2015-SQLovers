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


namespace AerolineaFrba.Abm_Rol
{
    public partial class UpdateOrCreateView : Form
    {
        private Rol rol;
        private DAORol daoRol;
        private Boolean create;

        private UpdateOrCreateView()
        {
            InitializeComponent();
        }

        public UpdateOrCreateView(Rol rol, DAORol dao, Boolean create) : this()
        { 
            this.rol = rol;
            this.daoRol = dao;
            this.create = create;
            nombreRolTextBox.Text = rol.name;
            activoRolCheckBox.Checked = rol.activo == null || !(Boolean)rol.activo ? false : true;
        }
        
        private void UpdateOrCreateView_Load(object sender, EventArgs e)
        {

        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            rol.name = nombreRolTextBox.Text;
            rol.activo = activoRolCheckBox.Checked;
            if (create)
            {
                daoRol.create(rol);
            }
            else { daoRol.update(rol); }
            
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
