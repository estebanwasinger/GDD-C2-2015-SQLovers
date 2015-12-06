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
    public partial class CrearEncomienda : Form
    {
        private Models.BO.Pasaje pasaje;
        private int kgDisponibles;
        private int precioBaseKg;
        private Int32 kgSeleccionados;
        private Int32 precioTotal;

        public CrearEncomienda()
        {
            InitializeComponent();
        }

        public CrearEncomienda(Models.BO.Pasaje pasaje, int kgDisponibles)
        {
            this.pasaje = pasaje;
            this.kgDisponibles = kgDisponibles;
            this.precioBaseKg = DAORuta.getRuta((int)pasaje.vuelo.ruta).precioBaseKg;
            InitializeComponent();
        }

        private void numericUpDownPeso_ValueChanged(object sender, EventArgs e)
        {
            kgSeleccionados = (Int32) numericUpDownPeso.Value;
            precioTotal = kgSeleccionados * precioBaseKg;

            textBoxPrecioTotal.Text = (precioTotal).ToString();
            if (kgSeleccionados > kgDisponibles)
            {
                buttonComprar.Enabled = false;
            }
            else {
                buttonComprar.Enabled = true;
            }
        }

        private void CrearEncomienda_Load(object sender, EventArgs e)
        {
            buttonComprar.Enabled = false;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            Encomienda encomienda = new Encomienda();
            encomienda.dniCliente = pasaje.usuario.dni;
            encomienda.kg = this.kgSeleccionados;
            encomienda.precioTotal = this.precioTotal;
            encomienda.vueloId = (int) pasaje.vuelo.id;
            if (DAOEncomienda.create(encomienda)) {
                MessageBox.Show("Encomienda creada correctamente!");
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
