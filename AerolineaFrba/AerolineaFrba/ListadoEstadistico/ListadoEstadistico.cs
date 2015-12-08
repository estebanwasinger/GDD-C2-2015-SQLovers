
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AerolineaFrba.Models.DAO;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            fillCmbSemestre();
            fillCmbAnio();
            fillCmbListado();
        }

        private void fillCmbSemestre()
        {
            Dictionary<int, string> semestres = new Dictionary<int, string>();
            semestres.Add(1, "1er. Semestre");
            semestres.Add(2, "2do. Semestre");
            cmbSemestre.DataSource = new BindingSource(semestres, null);
            cmbSemestre.DisplayMember = "Value";
            cmbSemestre.ValueMember = "Key";
        }

        private void fillCmbAnio()
        {
            for (int i = 2000; i < 2020; i++)
                cmbAnio.Items.Add(i);
        }

        private void fillCmbListado()
        {
            Dictionary<int, string> listados = new Dictionary<int, string>();
            listados.Add(1, "Destinos con más pasajes comprados");
            listados.Add(2, "Destinos con aeronaves más vacías");
            listados.Add(3, "Clientes con más puntos acumulados a la fecha");
            listados.Add(4, "Destinos con más pasajes cancelados");
            listados.Add(5, "Aeronaves con mayor cantidad de días fuera de servicio");
            cmbListado.DataSource = new BindingSource(listados, null);
            cmbListado.DisplayMember = "Value";
            cmbListado.ValueMember = "Key";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string fechaIni, fechaFin;
            DAOListadoEstadistico daoListadoEstadistico = new DAOListadoEstadistico();

            if (Convert.ToInt32(cmbSemestre.SelectedValue) == 1)
            {
                fechaIni = cmbAnio.Text + "/01/01 00:00:00";
                fechaFin = cmbAnio.Text + "/06/30 23:59:59";
            }
            else
            {
                fechaIni = cmbAnio.Text + "/07/01 00:00:00";
                fechaFin = cmbAnio.Text + "/12/31 23:59:59";
            }

            switch (Convert.ToInt32(cmbListado.SelectedValue))
            {
                case 1:
                    dgvListado.DataSource = daoListadoEstadistico.DestMasPasajComp(fechaIni, fechaFin);
                    break;
                case 2:
                    dgvListado.DataSource = daoListadoEstadistico.DestAeroMasVacias(fechaIni, fechaFin);
                    break;
                case 3:
                    dgvListado.DataSource = daoListadoEstadistico.CliMasPtosAcum(fechaIni, fechaFin);
                    break;
                case 4:
                   dgvListado.DataSource = daoListadoEstadistico.DestPasCancel(fechaIni, fechaFin);
                    break;
                case 5:
                    dgvListado.DataSource = daoListadoEstadistico.AeroMasCantDiaFueraServ(fechaIni, fechaFin);
                    break;
            }
        }
    }
}
