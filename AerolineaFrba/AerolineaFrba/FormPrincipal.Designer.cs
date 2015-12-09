namespace AerolineaFrba
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAeronaves = new System.Windows.Forms.Button();
            this.buttonCiudades = new System.Windows.Forms.Button();
            this.buttonRoles = new System.Windows.Forms.Button();
            this.buttonRutas = new System.Windows.Forms.Button();
            this.buttonCompra = new System.Windows.Forms.Button();
            this.buttonMillas = new System.Windows.Forms.Button();
            this.buttonViajes = new System.Windows.Forms.Button();
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.buttonRegistroDeLlegada = new System.Windows.Forms.Button();
            this.buttonDevolucion = new System.Windows.Forms.Button();
            this.buttonConsultaMillas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAeronaves
            // 
            this.buttonAeronaves.Location = new System.Drawing.Point(27, 27);
            this.buttonAeronaves.Name = "buttonAeronaves";
            this.buttonAeronaves.Size = new System.Drawing.Size(207, 53);
            this.buttonAeronaves.TabIndex = 0;
            this.buttonAeronaves.Text = "Aeronaves";
            this.buttonAeronaves.UseVisualStyleBackColor = true;
            this.buttonAeronaves.Click += new System.EventHandler(this.buttonAeronaves_Click);
            // 
            // buttonCiudades
            // 
            this.buttonCiudades.Location = new System.Drawing.Point(258, 27);
            this.buttonCiudades.Name = "buttonCiudades";
            this.buttonCiudades.Size = new System.Drawing.Size(207, 53);
            this.buttonCiudades.TabIndex = 1;
            this.buttonCiudades.Text = "Ciudades";
            this.buttonCiudades.UseVisualStyleBackColor = true;
            this.buttonCiudades.Click += new System.EventHandler(this.buttonCiudades_Click);
            // 
            // buttonRoles
            // 
            this.buttonRoles.Location = new System.Drawing.Point(27, 99);
            this.buttonRoles.Name = "buttonRoles";
            this.buttonRoles.Size = new System.Drawing.Size(207, 53);
            this.buttonRoles.TabIndex = 2;
            this.buttonRoles.Text = "Roles";
            this.buttonRoles.UseVisualStyleBackColor = true;
            this.buttonRoles.Click += new System.EventHandler(this.buttonRoles_Click);
            // 
            // buttonRutas
            // 
            this.buttonRutas.Location = new System.Drawing.Point(258, 99);
            this.buttonRutas.Name = "buttonRutas";
            this.buttonRutas.Size = new System.Drawing.Size(207, 53);
            this.buttonRutas.TabIndex = 3;
            this.buttonRutas.Text = "Rutas";
            this.buttonRutas.UseVisualStyleBackColor = true;
            this.buttonRutas.Click += new System.EventHandler(this.buttonRutas_Click);
            // 
            // buttonCompra
            // 
            this.buttonCompra.Location = new System.Drawing.Point(27, 170);
            this.buttonCompra.Name = "buttonCompra";
            this.buttonCompra.Size = new System.Drawing.Size(207, 53);
            this.buttonCompra.TabIndex = 4;
            this.buttonCompra.Text = "Compra";
            this.buttonCompra.UseVisualStyleBackColor = true;
            this.buttonCompra.Click += new System.EventHandler(this.buttonCompra_Click);
            // 
            // buttonMillas
            // 
            this.buttonMillas.Location = new System.Drawing.Point(258, 170);
            this.buttonMillas.Name = "buttonMillas";
            this.buttonMillas.Size = new System.Drawing.Size(207, 53);
            this.buttonMillas.TabIndex = 5;
            this.buttonMillas.Text = "Canje Millas";
            this.buttonMillas.UseVisualStyleBackColor = true;
            this.buttonMillas.Click += new System.EventHandler(this.buttonMillas_Click);
            // 
            // buttonViajes
            // 
            this.buttonViajes.Location = new System.Drawing.Point(27, 239);
            this.buttonViajes.Name = "buttonViajes";
            this.buttonViajes.Size = new System.Drawing.Size(207, 53);
            this.buttonViajes.TabIndex = 6;
            this.buttonViajes.Text = "Viajes";
            this.buttonViajes.UseVisualStyleBackColor = true;
            this.buttonViajes.Click += new System.EventHandler(this.buttonViajes_Click);
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Location = new System.Drawing.Point(258, 239);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(207, 53);
            this.btnListadoEstadistico.TabIndex = 7;
            this.btnListadoEstadistico.Text = "Listado Estadístico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // buttonRegistroDeLlegada
            // 
            this.buttonRegistroDeLlegada.Location = new System.Drawing.Point(27, 308);
            this.buttonRegistroDeLlegada.Name = "buttonRegistroDeLlegada";
            this.buttonRegistroDeLlegada.Size = new System.Drawing.Size(207, 53);
            this.buttonRegistroDeLlegada.TabIndex = 8;
            this.buttonRegistroDeLlegada.Text = "Registro de Llegada";
            this.buttonRegistroDeLlegada.UseVisualStyleBackColor = true;
            this.buttonRegistroDeLlegada.Click += new System.EventHandler(this.buttonRegistroDeLlegada_Click);
            // 
            // buttonDevolucion
            // 
            this.buttonDevolucion.Location = new System.Drawing.Point(258, 308);
            this.buttonDevolucion.Name = "buttonDevolucion";
            this.buttonDevolucion.Size = new System.Drawing.Size(207, 53);
            this.buttonDevolucion.TabIndex = 9;
            this.buttonDevolucion.Text = "Devolucion";
            this.buttonDevolucion.UseVisualStyleBackColor = true;
            this.buttonDevolucion.Click += new System.EventHandler(this.buttonDevolucion_Click);
            // 
            // buttonConsultaMillas
            // 
            this.buttonConsultaMillas.Location = new System.Drawing.Point(258, 376);
            this.buttonConsultaMillas.Name = "buttonConsultaMillas";
            this.buttonConsultaMillas.Size = new System.Drawing.Size(207, 53);
            this.buttonConsultaMillas.TabIndex = 10;
            this.buttonConsultaMillas.Text = "Consulta Millas";
            this.buttonConsultaMillas.UseVisualStyleBackColor = true;
            this.buttonConsultaMillas.Click += new System.EventHandler(this.buttonConsultaMillas_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 463);
            this.Controls.Add(this.buttonConsultaMillas);
            this.Controls.Add(this.buttonDevolucion);
            this.Controls.Add(this.buttonRegistroDeLlegada);
            this.Controls.Add(this.buttonViajes);
            this.Controls.Add(this.buttonMillas);
            this.Controls.Add(this.buttonCompra);
            this.Controls.Add(this.buttonRutas);
            this.Controls.Add(this.buttonRoles);
            this.Controls.Add(this.buttonCiudades);
            this.Controls.Add(this.buttonAeronaves);
            this.Controls.Add(this.btnListadoEstadistico);
            this.Name = "FormPrincipal";
            this.Text = "Welcome!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAeronaves;
        private System.Windows.Forms.Button buttonCiudades;
        private System.Windows.Forms.Button buttonRoles;
        private System.Windows.Forms.Button buttonRutas;
        private System.Windows.Forms.Button buttonCompra;
        private System.Windows.Forms.Button buttonMillas;
        private System.Windows.Forms.Button buttonViajes;
        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Button buttonRegistroDeLlegada;
        private System.Windows.Forms.Button buttonDevolucion;
        private System.Windows.Forms.Button buttonConsultaMillas;
    }
}

