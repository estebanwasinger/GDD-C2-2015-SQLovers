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
    public partial class Reemplazar : Form
    {

        private Vuelo vuelo { get; set; }
        private DAOAeronave daoAeronave = new DAOAeronave();
        private List<Aeronave> lstAer { get; set; }
        private bool update;

        public Reemplazar(Vuelo vuelo)
        {
            this.vuelo = vuelo;
            InitializeComponent();
            lstAer = new List<Aeronave>();

        }

        public Reemplazar()
        {
            InitializeComponent();
        }

        private void FormReemplazar_Load(object sender, EventArgs e) {

            cargarCombos();
            if (vuelo.id != null)
            {
                txtVuelo.Enabled = false;
                txtAeron.Enabled = false;
                update = true;
                cargarDatosVuelo();

            }

            dtgAeronaves.AutoGenerateColumns = false;
            dtgAeronaves.MultiSelect = false;
            cargarGrilla();
            actualizarGrilla();
        }

        private void cargarCombos()
        {
            //cmbServicio.Items.AddRange(daoPais.retrieveBase().ToArray());

        }

        private void cargarDatosVuelo()
        {

            txtVuelo.Text = vuelo.id.ToString();

            txtAeron.Text = vuelo.aeronave;

            /*txtModelo.Text = aeronave.modelo;

            txtFabri.Text = aeronave.fabricante;

            txtPeso.Text = aeronave.peso_disponible.ToString();

            string serv = (string)aeronave.get_service();
            cmbServicio.SelectedIndex = cmbServicio.FindStringExact(serv);*/
            
        }

        //del mismo modelo y fabricante y mismo tipo de servicio)

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn colModelo = new DataGridViewTextBoxColumn();
            colModelo.DataPropertyName = "modelo";
            colModelo.HeaderText = "Modelo";
            colModelo.Width = 120;
            DataGridViewTextBoxColumn colFabri = new DataGridViewTextBoxColumn();
            colFabri.DataPropertyName = "fabricante";
            colFabri.HeaderText = "Fabricante";
            colFabri.Width = 120;

            DataGridViewTextBoxColumn colTipoServ = new DataGridViewTextBoxColumn();
            colTipoServ.DataPropertyName = "aeronave_tipo_servicio";
            colTipoServ.HeaderText = "Tipo Servicio";
            colTipoServ.Width = 120;

            DataGridViewTextBoxColumn colMatricula = new DataGridViewTextBoxColumn();
            colMatricula.DataPropertyName = "matricula";
            colMatricula.HeaderText = "Matricula";
            colMatricula.Width = 120;

            dtgAeronaves.Columns.Add(colMatricula);
            dtgAeronaves.Columns.Add(colTipoServ);
            dtgAeronaves.Columns.Add(colModelo);
            dtgAeronaves.Columns.Add(colFabri);

        }

        public void actualizarGrilla()
        {
            if (txtVuelo.Text != "")
                lstAer = daoAeronave.listaAero(txtAeron.Text);
            // else
            //    lstAeronaves = dao.retrieveAll();
            //Vuelo vuelo = new Vuelo();
            //vuelo = lstVuelo[0];

            if (lstAer.Count == 0) {

                MessageBox.Show("no hay aeronaves para reemplazo", "Notificacion", MessageBoxButtons.OK);
                btnReemp.Enabled = false;
            }

            dtgAeronaves.DataSource = lstAer;
            
        }

        public void btnReemp_click(object sender, EventArgs e)
        {
            Aeronave aer = (Aeronave)dtgAeronaves.CurrentRow.DataBoundItem;
            daoAeronave.reemplazoAeronave(aer.matricula, (int)vuelo.id);
            MessageBox.Show("Aeronave asignada", "Notificacion", MessageBoxButtons.OK);

        }

        public void btnNvaAero_click(object sender, EventArgs e) {

            AltaAeronave aa = new AltaAeronave(new Aeronave());
            aa.Show();
        }

    }
}