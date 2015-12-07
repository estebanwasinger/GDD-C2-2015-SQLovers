﻿using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.DAO;
using AerolineaFrba.Models.Utils;
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
    public partial class CrearPasaje : Form
    {
        public Butaca butaca;
        public Cliente cliente;
        private Pasaje pasajePrivate;
        public Pasaje pasaje;
        private List<Pasaje> pasajeList;

        public CrearPasaje(Pasaje pasaje, List<Pasaje> pasajeList)
        {
            this.pasajeList = pasajeList;
            this.pasajePrivate = pasaje;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearPasaje_Load(object sender, EventArgs e)
        {
            buttonAgregar.Enabled = false;
            dataGridViewButacas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewButacas.AutoGenerateColumns = false;
            dataGridViewButacas.Columns.Add(Utils.crearColumna("numero","Numero", 70,true));
            dataGridViewButacas.Columns.Add(Utils.crearColumna("tipo", "Tipo", 70, true));
            dataGridViewButacas.Columns.Add(Utils.crearColumna("piso", "Piso", 70, true));
            List<Butaca> butacaList = DAOButaca.getButacasDisponibles((int) pasajePrivate.vuelo.id);
            butacaList = filtrarButacasReservadas(pasajeList, butacaList);
            dataGridViewButacas.DataSource = butacaList;
        }

        private void dataGridViewButacas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotonAceptar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.butaca = (Butaca)dataGridViewButacas.CurrentRow.DataBoundItem;
            Pasaje pasaje = new Pasaje();
            pasaje.vuelo = this.pasajePrivate.vuelo;
            pasaje.usuario = this.cliente;
            pasaje.precio = DAORuta.getRuta((int)this.pasajePrivate.vuelo.ruta).precioBasePasaje;
            pasaje.butaca = this.butaca;
            pasaje.fechaCompra = System.DateTime.Now;
            this.pasaje = pasaje;
            this.Close();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente clienteForm = new BuscarCliente();
            clienteForm.ShowDialog();
            this.cliente = clienteForm.cliente;
            if (cliente != null) {
                textBoxApellidoCliente.Text = cliente.apellido;
                textBoxDni.Text = cliente.dni.ToString();
                textBoxNombreCliente.Text = cliente.nombre;
                textBoxUsuario.Text = cliente.username;
            }
            habilitarBotonAceptar();
        }

        private void habilitarBotonAceptar()
        {
            if (cliente != null && dataGridViewButacas.SelectedCells.Count != 0)
            {
                buttonAgregar.Enabled = true;
            }
        }

        private List<Butaca> filtrarButacasReservadas(List<Pasaje> pasajeList, List<Butaca> butacaList)
        {
                foreach (Pasaje pasaje in pasajeList)
                {
                    butacaList.Remove(pasaje.butaca);
                }
                return butacaList;
        }

    }
}