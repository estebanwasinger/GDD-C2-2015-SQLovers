using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class AltaRol : Form
    {
        private SqlConnection con = new SqlConnection(@"Server=MARISA\SQLSERVER2012;Database=GD2C2015;User Id=gd;Password=gd2015;");
        private Listado frm;
        private int rol_id;

        public AltaRol(Listado frm, int rol_id= 0)
        {
            InitializeComponent();
            this.frm = frm;
            this.rol_id = rol_id;
            if(rol_id!=0)
            setFieldForm();
        }

        private void setFieldForm()
        {  
            string query= "SELECT rol_id, rol_name,  CASE WHEN rol_activo=1 THEN 'SI' ELSE 'NO' END AS activo FROM SQLOVERS.ROL WHERE rol_id=" +this.rol_id;
           // SqlDataAdapter da = new SqlDataAdapter(query, con);
           // DataTable dt= new DataTable ( @"rol");
            con.Open();
       
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            Titulo.Text = @"EDICIÓN ROL";
            if (dr.Read()) {
                TxtNombre.Text = dr["rol_name"].ToString();
                Activo.Checked=dr["activo"].ToString()=="SI";
                NoActivo.Checked = dr["activo"].ToString() == "NO";
            
            }
            con.Close();
                

            


            //TxtNombre.Text = dt.Rows[0].ItemArray[1].ToString();
            //Activo.Checked = dt.Rows[0].ItemArray[2].ToString()=="SI";
            //NoActivo.Checked = dt.Rows[0].ItemArray[2].ToString()=="NO";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateForm())
                return;
            if (this.rol_id == 0)
                createRol();
            else
                updateRol();

            this.Hide();
            frm.fillDgv();
        }

        private void createRol()
        {
            con.Open();
            string query = "INSERT INTO  SQLOVERS.ROL(rol_name, rol_activo) VALUES (@rol_name,@rol_activo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@rol_name", TxtNombre.Text));
            cmd.Parameters.Add(new SqlParameter("@rol_activo", Activo.Checked));
            cmd.ExecuteNonQuery();
            con.Close();
          
        }

        private void updateRol()
        {
            con.Open();
            string query = @"UPDATE SQLOVERS.ROL SET rol_name= @rol_name, rol_activo = @rol_activo WHERE rol_id=" + this.rol_id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@rol_name", TxtNombre.Text));
            cmd.Parameters.Add(new SqlParameter("@rol_activo", Activo.Checked));
            cmd.ExecuteNonQuery();
            con.Close();

        }



        private bool validateForm()
        {
            if (String.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del rol", 
                                "Nombre Rol", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
               
                TxtNombre.Focus();
                return false;
            }
            if (!Activo.Checked && !NoActivo.Checked)
            {
                MessageBox.Show("Por favor establezca si el rol eactivo o no", 
                    "Rol Activo/No Ativo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            
                return false;
            }
            return true;
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AltaRol_Load(object sender, EventArgs e)
        {

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {

        }
    }
}
