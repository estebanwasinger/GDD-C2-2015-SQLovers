﻿using AerolineaFrba.Models.BO;
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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class FormABMAeronave : Form
    {
        public FormABMAeronave()
        {
            InitializeComponent();
            lstAeronaves = new List<Aeronave>();
            dao = new DAOAeronave();
            //lstTipos = new List<TipoDocumento>();

        }

        private DAOAeronave dao;
        private List<Aeronave> lstAeronaves { get; set; }
        DateTime fechaVS;
        //private List<TipoDocumento> lstTipos;


        private void frmABMAeronave_Load(object sender, EventArgs e)
        {

            dtgAeoronave.AutoGenerateColumns = false;
            dtgAeoronave.MultiSelect = false;

            cargarGrilla();
            actualizarGrilla();
        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colMatricula = new DataGridViewTextBoxColumn();
            colMatricula.DataPropertyName = "Matricula";
            colMatricula.HeaderText = "Matricula";
            colMatricula.Width = 120;
            DataGridViewTextBoxColumn colModelo = new DataGridViewTextBoxColumn();
            colModelo.DataPropertyName = "modeloNombre";
            colModelo.HeaderText = "Modelo";
            colModelo.Width = 120;
            DataGridViewTextBoxColumn colKGDisp = new DataGridViewTextBoxColumn();
            colKGDisp.DataPropertyName = "peso_disponible";
            colKGDisp.HeaderText = "KG Disponibles";
            colKGDisp.Width = 120;
            DataGridViewTextBoxColumn colFabricante = new DataGridViewTextBoxColumn();
            colFabricante.DataPropertyName = "fabricanteNombre";
            colFabricante.HeaderText = "Fabricante";
            colFabricante.Width = 120;

            dtgAeoronave.Columns.Add(colMatricula);
            dtgAeoronave.Columns.Add(colModelo);
            dtgAeoronave.Columns.Add(colKGDisp);
            dtgAeoronave.Columns.Add(colFabricante);
        }

        public void actualizarGrilla()
        {
            if (txtmatricula.Text != "" || txtfabri.Text != "" || txtmodelo.Text != "" || txtPeso.Text != "")
                lstAeronaves = dao.search(txtmatricula.Text, txtfabri.Text, txtmodelo.Text, txtPeso.Text);
            else
                lstAeronaves = dao.retrieveAll();
            Aeronave client = new Aeronave();
            client = lstAeronaves[0];
            dtgAeoronave.DataSource = lstAeronaves;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaAeronave aa = new AltaAeronave(new Aeronave());
            aa.ShowDialog();
            actualizarGrilla();
        }

        private void btn_bTecnica_Click(object sender, EventArgs e)
        {

                Aeronave aer = (Aeronave)dtgAeoronave.CurrentRow.DataBoundItem;

                if (aer.fecha_vueltaFS != null)
                {
                    fechaVS = (DateTime)aer.fecha_vueltaFS;
                }

                BajaFueraServicio bafs = new BajaFueraServicio(aer);
                bafs.Show();

        }
        
        private void btn_bDef_Click(object sender, EventArgs e)
        {
                 Aeronave aer = (Aeronave)dtgAeoronave.CurrentRow.DataBoundItem;

                 if (aer.fecha_vueltaFS != null)
                 {
                      fechaVS = (DateTime)aer.fecha_vueltaFS;
                 }
                
                    if (dao.estaDisponible(aer.matricula) == 3)
                {
                    BajaAeronaveD bad = new BajaAeronaveD(aer);
                    bad.Show();
                }
                else {
                    if (dao.estaDisponible(aer.matricula) == 2) { MessageBox.Show("Aeronave fue dada de baja Definitivamente", "Error!", MessageBoxButtons.OK); } else { MessageBox.Show("Aeronave Fuera de Servicio hasta: " + fechaVS.ToString("dd/MM/yyyy"), "Error!", MessageBoxButtons.OK); }
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          //  try { 
                actualizarGrilla();
          //  }
//catch { MessageBox.Show("No existe Aeronave con esas caracteristicas", "Error!", MessageBoxButtons.OK); }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtmatricula.Clear();
            txtfabri.Clear();
            txtmodelo.Clear();
            txtPeso.Clear();
        }

        private void dtgAeoronave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dao.estaDisponible(((Aeronave)dtgAeoronave.CurrentRow.DataBoundItem).matricula) == 2)
            {
                btn_bdef.Enabled = false;
                btn_fueraServ.Enabled = false;
            }
            else {
                btn_bdef.Enabled = true;
                btn_fueraServ.Enabled = true;
            }
        }
    }
}
