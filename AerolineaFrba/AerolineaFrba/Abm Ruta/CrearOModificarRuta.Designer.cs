namespace AerolineaFrba.Abm_Ruta
{
    partial class CrearOModificarRuta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.ciudadOrigenLabel = new System.Windows.Forms.Label();
            this.ciudadDestinoLabel = new System.Windows.Forms.Label();
            this.comboBoxCiudadDestino = new System.Windows.Forms.ComboBox();
            this.labelTipoDeServicio = new System.Windows.Forms.Label();
            this.comboBoxTipoDeServicio = new System.Windows.Forms.ComboBox();
            this.labelPrecioBaseKG = new System.Windows.Forms.Label();
            this.textBoxPrecioBaseKG = new System.Windows.Forms.TextBox();
            this.textBoxPrecioBasePasaje = new System.Windows.Forms.TextBox();
            this.labelPrecioBasePasaje = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxCiudadOrigen
            // 
            this.comboBoxCiudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiudadOrigen.FormattingEnabled = true;
            this.comboBoxCiudadOrigen.Location = new System.Drawing.Point(44, 46);
            this.comboBoxCiudadOrigen.Name = "comboBoxCiudadOrigen";
            this.comboBoxCiudadOrigen.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCiudadOrigen.TabIndex = 0;
            this.comboBoxCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudadOrigen_SelectedIndexChanged);
            // 
            // ciudadOrigenLabel
            // 
            this.ciudadOrigenLabel.AutoSize = true;
            this.ciudadOrigenLabel.Location = new System.Drawing.Point(44, 30);
            this.ciudadOrigenLabel.Name = "ciudadOrigenLabel";
            this.ciudadOrigenLabel.Size = new System.Drawing.Size(74, 13);
            this.ciudadOrigenLabel.TabIndex = 1;
            this.ciudadOrigenLabel.Text = "Ciudad Origen";
            // 
            // ciudadDestinoLabel
            // 
            this.ciudadDestinoLabel.AutoSize = true;
            this.ciudadDestinoLabel.Location = new System.Drawing.Point(266, 30);
            this.ciudadDestinoLabel.Name = "ciudadDestinoLabel";
            this.ciudadDestinoLabel.Size = new System.Drawing.Size(79, 13);
            this.ciudadDestinoLabel.TabIndex = 3;
            this.ciudadDestinoLabel.Text = "Ciudad Destino";
            // 
            // comboBoxCiudadDestino
            // 
            this.comboBoxCiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiudadDestino.FormattingEnabled = true;
            this.comboBoxCiudadDestino.Location = new System.Drawing.Point(269, 46);
            this.comboBoxCiudadDestino.Name = "comboBoxCiudadDestino";
            this.comboBoxCiudadDestino.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCiudadDestino.TabIndex = 2;
            this.comboBoxCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudadDestino_SelectedIndexChanged);
            // 
            // labelTipoDeServicio
            // 
            this.labelTipoDeServicio.AutoSize = true;
            this.labelTipoDeServicio.Location = new System.Drawing.Point(44, 114);
            this.labelTipoDeServicio.Name = "labelTipoDeServicio";
            this.labelTipoDeServicio.Size = new System.Drawing.Size(84, 13);
            this.labelTipoDeServicio.TabIndex = 4;
            this.labelTipoDeServicio.Text = "Tipo de Servicio";
            this.labelTipoDeServicio.Click += new System.EventHandler(this.labelTipoDeServicio_Click);
            // 
            // comboBoxTipoDeServicio
            // 
            this.comboBoxTipoDeServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDeServicio.FormattingEnabled = true;
            this.comboBoxTipoDeServicio.Location = new System.Drawing.Point(44, 130);
            this.comboBoxTipoDeServicio.Name = "comboBoxTipoDeServicio";
            this.comboBoxTipoDeServicio.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipoDeServicio.TabIndex = 5;
            this.comboBoxTipoDeServicio.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDeServicio_SelectedIndexChanged);
            // 
            // labelPrecioBaseKG
            // 
            this.labelPrecioBaseKG.AutoSize = true;
            this.labelPrecioBaseKG.Location = new System.Drawing.Point(41, 185);
            this.labelPrecioBaseKG.Name = "labelPrecioBaseKG";
            this.labelPrecioBaseKG.Size = new System.Drawing.Size(99, 13);
            this.labelPrecioBaseKG.TabIndex = 6;
            this.labelPrecioBaseKG.Text = "Precio base por KG";
            // 
            // textBoxPrecioBaseKG
            // 
            this.textBoxPrecioBaseKG.Location = new System.Drawing.Point(44, 201);
            this.textBoxPrecioBaseKG.Name = "textBoxPrecioBaseKG";
            this.textBoxPrecioBaseKG.Size = new System.Drawing.Size(194, 20);
            this.textBoxPrecioBaseKG.TabIndex = 7;
            this.textBoxPrecioBaseKG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecioBaseKG_KeyPress);
            // 
            // textBoxPrecioBasePasaje
            // 
            this.textBoxPrecioBasePasaje.Location = new System.Drawing.Point(269, 201);
            this.textBoxPrecioBasePasaje.Name = "textBoxPrecioBasePasaje";
            this.textBoxPrecioBasePasaje.Size = new System.Drawing.Size(194, 20);
            this.textBoxPrecioBasePasaje.TabIndex = 9;
            this.textBoxPrecioBasePasaje.TextChanged += new System.EventHandler(this.textBoxPrecioBasePasaje_TextChanged);
            this.textBoxPrecioBasePasaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecioBasePasaje_KeyPress);
            // 
            // labelPrecioBasePasaje
            // 
            this.labelPrecioBasePasaje.AutoSize = true;
            this.labelPrecioBasePasaje.Location = new System.Drawing.Point(266, 185);
            this.labelPrecioBasePasaje.Name = "labelPrecioBasePasaje";
            this.labelPrecioBasePasaje.Size = new System.Drawing.Size(97, 13);
            this.labelPrecioBasePasaje.TabIndex = 8;
            this.labelPrecioBasePasaje.Text = "Precio base pasaje";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(47, 273);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(209, 31);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(269, 273);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(209, 31);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Checked = true;
            this.checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxActivo.Location = new System.Drawing.Point(269, 133);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(54, 17);
            this.checkBoxActivo.TabIndex = 12;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            this.checkBoxActivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CrearOModificarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 319);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxPrecioBasePasaje);
            this.Controls.Add(this.labelPrecioBasePasaje);
            this.Controls.Add(this.textBoxPrecioBaseKG);
            this.Controls.Add(this.labelPrecioBaseKG);
            this.Controls.Add(this.comboBoxTipoDeServicio);
            this.Controls.Add(this.labelTipoDeServicio);
            this.Controls.Add(this.ciudadDestinoLabel);
            this.Controls.Add(this.comboBoxCiudadDestino);
            this.Controls.Add(this.ciudadOrigenLabel);
            this.Controls.Add(this.comboBoxCiudadOrigen);
            this.Name = "CrearOModificarRuta";
            this.Text = "NuevaRuta";
            this.Load += new System.EventHandler(this.NuevaRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCiudadOrigen;
        private System.Windows.Forms.Label ciudadOrigenLabel;
        private System.Windows.Forms.Label ciudadDestinoLabel;
        private System.Windows.Forms.ComboBox comboBoxCiudadDestino;
        private System.Windows.Forms.Label labelTipoDeServicio;
        private System.Windows.Forms.ComboBox comboBoxTipoDeServicio;
        private System.Windows.Forms.Label labelPrecioBaseKG;
        private System.Windows.Forms.TextBox textBoxPrecioBaseKG;
        private System.Windows.Forms.TextBox textBoxPrecioBasePasaje;
        private System.Windows.Forms.Label labelPrecioBasePasaje;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.CheckBox checkBoxActivo;
    }
}