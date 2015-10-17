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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaAeronave : Form
    {
        private Aeronave aeronave{ get; set; }       
        private DAOAeronave daoaeronave = new DAOAeronave(); 
        private bool update;
       

        public AltaAeronave(Aeronave aero)
        {
            aeronave = aero;
            InitializeComponent();
            cargarCombos();
            
        }

        private void cargarDatosClientes()
        {
            txtMatricula.Text = aeronave.matricula;
            txtModelo.Text = aeronave.modelo;
            txtCarga.Text = aeronave.peso_disponible.ToString();
            txtFabricante.Text = aeronave.fabricante;
            txtButacas.Text = aeronave.cant_butacas.ToString();
            dateTimeFA.Value = (DateTime)aeronave.fecha_alta;



               /* txtNombre.Text = cliente.nombre;
                txtApellido.Text = cliente.apellido;
                txtCalle.Text = cliente.dom_calle;
                txtDepto.Text = cliente.dom_dpto.ToString();
                txtPiso.Text = cliente.dom_piso.ToString();
                txtMail.Text = cliente.mail;
                txtNumero.Text = cliente.dom_nro.ToString();
                txtNumID.Text = cliente.documento.ToString();                
                dateNacimiento.Value = (DateTime)cliente.fecha_nac;
                string pa = (string)cliente.get_pais().Substring(1);            
                cbNacionalidad.SelectedIndex = cbNacionalidad.FindStringExact(pa); 
                string tip = ((TipoDocumento)daoTipoDoc.retrieveBy_id(cliente.tipo_documento)).descripcion;
                cmbTipo.SelectedIndex = cmbTipo.FindStringExact(tip);
                checkActivo.Checked = (bool)cliente.activo;*/
        }


        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.isCaracterInvalido(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validateCamps()
        {
            if (txtMatricula.Text == "" || txtModelo.Text == "" || txtCarga.Text == "" || txtFabricante.Text == "" || txtButacas.Text == "")
                
            {
                MessageBox.Show("Hay campos vacios");
                return false;
            }
            return true;
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            if (validateCamps())
            {
               
                aeronave.matricula = txtMatricula.Text;
                aeronave.modelo = txtModelo.Text;
                aeronave.peso_disponible = (int?)Convert.ToInt32(txtCarga.Text);
                aeronave.fabricante = txtFabricante.Text;
                aeronave.cant_butacas = (int?)Convert.ToInt32(txtButacas.Text);
                aeronave.fecha_alta = dateTimeFA.Value.Date;
                aeronave.aeronave_tipo_servicio = ((Servicio)cmbServicio.SelectedItem).tipo_servicio_id;
                


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
             
        }
        
        /*private void cargarGrilla()
        {

            DataGridViewTextBoxColumn colNumero = new DataGridViewTextBoxColumn();
            colNumero.DataPropertyName = "numeroMostrable";
            colNumero.HeaderText = "Numero";
            colNumero.Width = 120;
            DataGridViewTextBoxColumn colEmision = new DataGridViewTextBoxColumn();
            colEmision.DataPropertyName = "fecha_emision";
            colEmision.HeaderText = "Fecha Emision";
            colEmision.Width = 120;
            DataGridViewTextBoxColumn colVencimiento = new DataGridViewTextBoxColumn();
            colVencimiento.DataPropertyName = "fecha_vencimiento";
            colVencimiento.HeaderText = "Fecha de Vencimiento";
            colVencimiento.Width = 120;
            DataGridViewTextBoxColumn colSeguridad = new DataGridViewTextBoxColumn();
            colSeguridad.DataPropertyName = "cod_seguridad";
            colSeguridad.HeaderText = "Codigo de Seguridad";
            colSeguridad.Width = 120;

            dtgTarjetas.Columns.Add(colNumero);
            dtgTarjetas.Columns.Add(colEmision);
            dtgTarjetas.Columns.Add(colVencimiento);
            dtgTarjetas.Columns.Add(colSeguridad);
        }*/


        /*public void actualizarGrilla()
        {
            if (txtNombre.Text != "")
                lstTarjetas = cliente.get_tarjetas();
            if (lstTarjetas.Count == 0)
            {
            }
            else {
                Tarjeta tarjeta = new Tarjeta();
                tarjeta = lstTarjetas[0];
            }

            dtgTarjetas.DataSource = lstTarjetas;

        }*/

        /*private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            actualizarGrilla();
        }*/

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCombos()
        {
            cmbServicio.Items.AddRange(new DAOServicio().retrieveBase().ToArray());
        }

       /* private void FormAltaCliente_Load(object sender, EventArgs e)
        {                       
            cargarCombos();
            if (cliente.id != null)
            {
                txtUsuario.Enabled = false;
                update = true;
                cargarDatosClientes();
                dtgTarjetas.AutoGenerateColumns = false;
                dtgTarjetas.MultiSelect = false;
                cargarGrilla();
                actualizarGrilla();
                btnCrear.Text = "Modificar";
                this.Text = "FormModifCliente";
            }
        }*/

      /*  private void btnDesvinc_Click(object sender, EventArgs e)
        {
            if (dtgTarjetas.CurrentRow != null) {
                Tarjeta delete = (Tarjeta)dtgTarjetas.CurrentRow.DataBoundItem;
                daoTarjeta.delete((long)(decimal)delete.numero);
            } 
            
            actualizarGrilla();
        }*/

      /*  private void btnMod_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = (Tarjeta)dtgTarjetas.CurrentRow.DataBoundItem;
            FormModifTarjet fmt = new FormModifTarjet(tarjeta);
            fmt.Show();
        }*/

     /*   private void btnAlta_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = new Tarjeta();
            if (cliente.id == null) { MessageBox.Show("El cliente al que quiere vincular tarjetas no existe"); return; }
            else tarjeta.cli_cod = cliente.id;
            FormModifTarjet fmt = new FormModifTarjet(tarjeta);
            fmt.Show();
        }*/

       /* public AltaAeronave()
        {
            InitializeComponent();
        }*/

        private void AltaAeronave_Load(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }

    
}
