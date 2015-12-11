using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
using AerolineaFrba.ValildationUtils;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaAeronave : Form
    {
        private Aeronave aeronave { get; set; }
        private DAOAeronave daoaeronave = new DAOAeronave();
        private bool update = false;
        private List<FabricanteAeronave> fabricanteList;
        private List<ModeloAeronave> modeloList;


        public AltaAeronave(Aeronave aero)
        {
            aeronave = aero;
            InitializeComponent();
            cargarCombos();

        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.isCaracterInvalido(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            aeronave.matricula = txtMatricula.Text;
            aeronave.modelo = ((ModeloAeronave)comboBoxModelo.SelectedItem).id;

            aeronave.peso_disponible = (int?)numericUpDownKg.Value;
            aeronave.cant_butacas_vent = (int?)numericUpDownVentana.Value;
            aeronave.cant_butacas_pas = (int?)numericUpDownPasillo.Value;

            aeronave.aeronave_tipo_servicio = ((Servicio)cmbServicio.SelectedItem).tipo_servicio_id;
            DateTime fecha_alta = new DateTime(dateTimeFA.Value.Year, dateTimeFA.Value.Month, dateTimeFA.Value.Day, dateTimeFA.Value.Hour, dateTimeFA.Value.Minute, dateTimeFA.Value.Second);

            if (validar_fecha_Alta() >= 0)
            {
                aeronave.fecha_alta = fecha_alta;
            }
            else { MessageBox.Show("fecha de Alta invalida"); }

            if (update)
            {
                if (daoaeronave.create(aeronave))
                {
                    MessageBox.Show("Aeronave actualizado correctamente");
                    this.Close();
                    return;
                }
                else
                {
                    throw new Exception("Datos no se cargaron correctamente");
                }
            }
            else
            {
                if (daoaeronave.create(aeronave))
                {
                    aeronave = DAOAeronave.getAeronaveFromMatricula(aeronave.matricula);
                    DAOButaca.createButacas(aeronave.cant_butacas_pas, aeronave.cant_butacas_vent, aeronave.id);
                    MessageBox.Show("Aeronave creada correctamente");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Datos no se cargaron correctamente");
                    return;
                }
            }


        }

        public int validar_fecha_Alta()
        {
            int result = 1;

            return result;

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCombos()
        {
            cmbServicio.Items.AddRange(new DAOServicio().retrieveBase().ToArray());
        }

        private void AltaAeronave_Load(object sender, EventArgs e)
        {
            BAlta.Enabled = false;
            comboBoxModelo.Enabled = false;
            fabricanteList = DAOFabricanteAeronave.retrieveAll();
            comboBoxFabricante.DataSource = fabricanteList;
            comboBoxFabricante.DisplayMember = "nombre";

        }

        private bool validarDatosCargados()
        {

            if (!Validation.isFilled(comboBoxFabricante) || !Validation.isFilled(comboBoxModelo) || !Validation.isFilled(cmbServicio))
            {
                return false;
            }

            if (!Validation.isFilled(txtMatricula))
            {
                return false;
            }

            if (!(numericUpDownKg.Value > 0) || !(numericUpDownPasillo.Value > 0) || !(numericUpDownVentana.Value > 0))
            {
                return false;
            }

            return true;
        }



        private void validar(object sender, EventArgs e)
        {
            BAlta.Enabled = validarDatosCargados();
        }

        private void comboBoxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            validar(sender, e);
            modeloList = DAOModeloAeronave.getFromFabricante(((FabricanteAeronave)comboBoxFabricante.SelectedItem).id);
            comboBoxModelo.DataSource = modeloList;
            comboBoxModelo.DisplayMember = "nombre";
            comboBoxModelo.Enabled = true;
        }

    }


}
