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

namespace AerolineaFrba.Compra
{
    public partial class BuscarCliente : Form
    {

        public Cliente cliente { get; set; }

        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonSeleccionar.Enabled = true;
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.Columns.Add(crearColumna("dni", "DNI", 50, true));
            dataGridViewClientes.Columns.Add(crearColumna("nombre", "Nombre", 100, true));
            dataGridViewClientes.Columns.Add(crearColumna("apellido", "Apellido", 100, true));
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.DataSource = DAOCliente.retrieveAll();
            buttonSeleccionar.Enabled = false;
        }

        private static DataGridViewTextBoxColumn crearColumna(String dataPropertyName, String headerText, int width, bool readOnly)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.DataPropertyName = dataPropertyName;
            columna.HeaderText = headerText;
            columna.Width = width;
            columna.ReadOnly = readOnly;
            return columna;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            this.cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;
            this.Close();
        }

    }
}
