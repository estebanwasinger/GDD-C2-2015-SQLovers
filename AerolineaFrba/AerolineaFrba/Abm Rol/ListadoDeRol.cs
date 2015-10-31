using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AerolineaFrba.Abm_Rol
{
    public partial class Listado : Form

    {
        private SqlConnection con = new SqlConnection(@"Server=MARISA\SQLSERVER2012;Database=GD2C2015;User Id=gd;Password=gd2015;");
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            setDgv();
            fillDgv();
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            showFrmAlta();

        }

        private void showFrmAlta(int rol_id = 0)

        {
            AltaRol frmAltaRol = new AltaRol(this, rol_id);
            frmAltaRol.ShowDialog();
        }

        public void fillDgv(string filtro="", int traerActivos=3) {
           
            string query = "SELECT rol_id,rol_name, CASE WHEN rol_activo =1 THEN 'Activo' ELSE 'No Activo' END AS Activo FROM SQLOVERS.ROL WHERE 1=1";
            if (filtro != "")
            query += " AND rol_name LIKE '%" +filtro +"%'";
            if (traerActivos ==1)
                query +=" AND rol_activo=1";
            else if (traerActivos ==2)
                query +=" AND rol_activo=0";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable("roles");
            da.Fill(dt);
            DGVListado.DataSource = dt;
        }

        private void setDgv(){
            DGVListado.ColumnCount = 3;
            DGVListado.AllowUserToAddRows = false;

            DGVListado.Columns[0].Name="ID";
            DGVListado.Columns[0].DataPropertyName="rol_id";
            DGVListado.Columns[0].Visible=false;

            DGVListado.Columns[1].Name = "Nombre";
            DGVListado.Columns[1].DataPropertyName = "rol_name";
            DGVListado.Columns[1].Visible = true;

            DGVListado.Columns[2].Name = "Activo";
            DGVListado.Columns[2].DataPropertyName = "Activo";
            DGVListado.Columns[2].Visible = true;
            DGVListado.Columns[2].Width= 40;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DGVListado.Columns.Add(btn);
            btn.HeaderText = "Modificar";
            btn.Text = "Modificar";
            btn.Name = "btnModificar";
            btn.UseColumnTextForButtonValue = true;

            btn = new DataGridViewButtonColumn();
            DGVListado.Columns.Add(btn);
            btn.HeaderText = "Eliminar";
            btn.Text = "Eliminar";
            btn.Name = "btnEliminar";
            btn.UseColumnTextForButtonValue = true;


        }

        private void LBLFiltro_Click(object sender, EventArgs e)
        {

        }

        private void Filtro_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int traerActivos;
            if(rbActivo.Checked)
            traerActivos=1;
            else if(rbNoActivo.Checked)
            traerActivos = 2; 
            else
            traerActivos = 3;

            this.fillDgv(Filtro.Text, traerActivos);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtro.Text = "";
            rbActivo.Checked = false;
            rbNoActivo.Checked = false;
            this.fillDgv();
        }

        private void DGVListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGVListado.CurrentCell.OwningRow;
            int rol_id= Convert.ToInt32 (row.Cells["ID"].Value.ToString());
            
            if(e.ColumnIndex==0)
             showFrmAlta(rol_id);
            else if (e.ColumnIndex==1)
             DeleteRol(rol_id);   
        }

        private void DeleteRol(int rol_id = 0) {
            if (rol_id == 0)
                return;
            con.Open();
            string query = "@DELETE FROM SQLOVERS.ROL WHERE rol_id=@rol_id";
            SqlCommand cmd = new SqlCommand(query, con);            
            cmd.Parameters.Add(new SqlParameter("@rol_id", rol_id));
            cmd.ExecuteNonQuery();
            con.Close();
            this.fillDgv();

        
        }
    }

}
