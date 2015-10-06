using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using AerolineaFrba.Models;

namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "" && txtPassword.Text != "")
                {
                    // Armo usuario
                    Usuario user = new Usuario(txtUserName.Text);
                    if (txtUserName.Text == "admin")
                    {
                        // Pass hashing
                        UTF8Encoding encoderHash = new UTF8Encoding();
                        SHA256Managed hasher = new SHA256Managed();
                        byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(txtPassword.Text));
                        string pass = bytesDeHasheoToString(bytesDeHasheo);

                        if (!user.Password.Equals(pass))
                        {
                            // llamar a VIDA_ESTATICA.updateIntentos
                            user.ActualizarFallidos();
                            
                            MessageBox.Show("Usuario y contraseña no validos", "Error!", MessageBoxButtons.OK);
                            txtPassword.Text = "";
                        }
                        else
                        {
                            // Está activo?
                            if (!user.Activo)
                                MessageBox.Show("Usuario inactivo para acceder al sistema", "Error!", MessageBoxButtons.OK);
                            else
                            {
                                user.ReiniciarFallidos();

                                // Paso al form Principal (requiere user siempre)
                                FormPrincipal formPrincipal = new FormPrincipal(user);
                                this.Hide();
                                formPrincipal.Show();
                            }
                        }
                    }
                    else
                    {
                        
                        MessageBox.Show("Usuario y contraseña no validos", "Error!", MessageBoxButtons.OK);
                        txtPassword.Text = "";
                    }

                }
                else MessageBox.Show("Complete todos los campos", "Error!", MessageBoxButtons.OK);
            } catch {

                
                MessageBox.Show("Usuario y contraseña no validos", "Error!", MessageBoxButtons.OK);
                txtPassword.Text = "";
            }
        }

        // Transformar lo hasheado a string
        private string bytesDeHasheoToString(byte[] array) {
            StringBuilder salida = new StringBuilder("");
            for (int i = 0; i < array.Length; i++)
                salida.Append(array[i].ToString("X2"));
            return salida.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
