namespace AerolineaFrba.Compra
{
    partial class DatosVuelo
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonEncomienda = new System.Windows.Forms.Button();
            this.buttonPasaje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAvion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFechaLlegada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxKilogramosDisponibles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPasajesDisponibles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCiudadDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCiudadOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEncomiendas = new System.Windows.Forms.DataGridView();
            this.groupBoxEncomiendas = new System.Windows.Forms.GroupBox();
            this.groupBoxPasajes = new System.Windows.Forms.GroupBox();
            this.dataGridViewPasajes = new System.Windows.Forms.DataGridView();
            this.buttonConfirmarCompra = new System.Windows.Forms.Button();
            this.textBoxTipoServicio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEncomiendas)).BeginInit();
            this.groupBoxEncomiendas.SuspendLayout();
            this.groupBoxPasajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasajes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(13, 305);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 41);
            this.buttonVolver.TabIndex = 0;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonEncomienda
            // 
            this.buttonEncomienda.Location = new System.Drawing.Point(474, 19);
            this.buttonEncomienda.Name = "buttonEncomienda";
            this.buttonEncomienda.Size = new System.Drawing.Size(83, 138);
            this.buttonEncomienda.TabIndex = 1;
            this.buttonEncomienda.Text = "Agregar Encomienda";
            this.buttonEncomienda.UseVisualStyleBackColor = true;
            this.buttonEncomienda.Click += new System.EventHandler(this.buttonEncomienda_Click);
            // 
            // buttonPasaje
            // 
            this.buttonPasaje.Location = new System.Drawing.Point(474, 19);
            this.buttonPasaje.Name = "buttonPasaje";
            this.buttonPasaje.Size = new System.Drawing.Size(83, 137);
            this.buttonPasaje.TabIndex = 2;
            this.buttonPasaje.Text = "Agregar Pasaje";
            this.buttonPasaje.UseVisualStyleBackColor = true;
            this.buttonPasaje.Click += new System.EventHandler(this.buttonPasaje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTipoServicio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxAvion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxFechaLlegada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFechaSalida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCiudadDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCiudadOrigen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vuelo";
            // 
            // textBoxAvion
            // 
            this.textBoxAvion.Location = new System.Drawing.Point(98, 79);
            this.textBoxAvion.Name = "textBoxAvion";
            this.textBoxAvion.Size = new System.Drawing.Size(124, 20);
            this.textBoxAvion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Avion:";
            // 
            // textBoxFechaLlegada
            // 
            this.textBoxFechaLlegada.Location = new System.Drawing.Point(98, 131);
            this.textBoxFechaLlegada.Name = "textBoxFechaLlegada";
            this.textBoxFechaLlegada.Size = new System.Drawing.Size(124, 20);
            this.textBoxFechaLlegada.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxKilogramosDisponibles);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPasajesDisponibles);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disponibilidad";
            // 
            // textBoxKilogramosDisponibles
            // 
            this.textBoxKilogramosDisponibles.Location = new System.Drawing.Point(139, 50);
            this.textBoxKilogramosDisponibles.Name = "textBoxKilogramosDisponibles";
            this.textBoxKilogramosDisponibles.Size = new System.Drawing.Size(57, 20);
            this.textBoxKilogramosDisponibles.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kilogramos Disponibles:";
            // 
            // textBoxPasajesDisponibles
            // 
            this.textBoxPasajesDisponibles.Location = new System.Drawing.Point(139, 19);
            this.textBoxPasajesDisponibles.Name = "textBoxPasajesDisponibles";
            this.textBoxPasajesDisponibles.Size = new System.Drawing.Size(57, 20);
            this.textBoxPasajesDisponibles.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Butacas Disponibles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Llegada:";
            // 
            // textBoxFechaSalida
            // 
            this.textBoxFechaSalida.Location = new System.Drawing.Point(98, 53);
            this.textBoxFechaSalida.Name = "textBoxFechaSalida";
            this.textBoxFechaSalida.Size = new System.Drawing.Size(124, 20);
            this.textBoxFechaSalida.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Salida:";
            // 
            // textBoxCiudadDestino
            // 
            this.textBoxCiudadDestino.Location = new System.Drawing.Point(98, 105);
            this.textBoxCiudadDestino.Name = "textBoxCiudadDestino";
            this.textBoxCiudadDestino.Size = new System.Drawing.Size(124, 20);
            this.textBoxCiudadDestino.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad Destino:";
            // 
            // textBoxCiudadOrigen
            // 
            this.textBoxCiudadOrigen.Location = new System.Drawing.Point(98, 27);
            this.textBoxCiudadOrigen.Name = "textBoxCiudadOrigen";
            this.textBoxCiudadOrigen.Size = new System.Drawing.Size(124, 20);
            this.textBoxCiudadOrigen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad Origen:";
            // 
            // dataGridViewEncomiendas
            // 
            this.dataGridViewEncomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEncomiendas.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewEncomiendas.Name = "dataGridViewEncomiendas";
            this.dataGridViewEncomiendas.Size = new System.Drawing.Size(462, 138);
            this.dataGridViewEncomiendas.TabIndex = 6;
            // 
            // groupBoxEncomiendas
            // 
            this.groupBoxEncomiendas.Controls.Add(this.dataGridViewEncomiendas);
            this.groupBoxEncomiendas.Controls.Add(this.buttonEncomienda);
            this.groupBoxEncomiendas.Location = new System.Drawing.Point(258, 182);
            this.groupBoxEncomiendas.Name = "groupBoxEncomiendas";
            this.groupBoxEncomiendas.Size = new System.Drawing.Size(563, 164);
            this.groupBoxEncomiendas.TabIndex = 7;
            this.groupBoxEncomiendas.TabStop = false;
            this.groupBoxEncomiendas.Text = "Encomiendas";
            // 
            // groupBoxPasajes
            // 
            this.groupBoxPasajes.Controls.Add(this.dataGridViewPasajes);
            this.groupBoxPasajes.Controls.Add(this.buttonPasaje);
            this.groupBoxPasajes.Location = new System.Drawing.Point(258, 13);
            this.groupBoxPasajes.Name = "groupBoxPasajes";
            this.groupBoxPasajes.Size = new System.Drawing.Size(563, 163);
            this.groupBoxPasajes.TabIndex = 8;
            this.groupBoxPasajes.TabStop = false;
            this.groupBoxPasajes.Text = "Pasajes";
            // 
            // dataGridViewPasajes
            // 
            this.dataGridViewPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasajes.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPasajes.Name = "dataGridViewPasajes";
            this.dataGridViewPasajes.Size = new System.Drawing.Size(462, 138);
            this.dataGridViewPasajes.TabIndex = 3;
            // 
            // buttonConfirmarCompra
            // 
            this.buttonConfirmarCompra.Location = new System.Drawing.Point(116, 305);
            this.buttonConfirmarCompra.Name = "buttonConfirmarCompra";
            this.buttonConfirmarCompra.Size = new System.Drawing.Size(136, 41);
            this.buttonConfirmarCompra.TabIndex = 9;
            this.buttonConfirmarCompra.Text = "Comprar";
            this.buttonConfirmarCompra.UseVisualStyleBackColor = true;
            this.buttonConfirmarCompra.Click += new System.EventHandler(this.buttonConfirmarCompra_Click);
            // 
            // textBoxTipoServicio
            // 
            this.textBoxTipoServicio.Location = new System.Drawing.Point(98, 157);
            this.textBoxTipoServicio.Name = "textBoxTipoServicio";
            this.textBoxTipoServicio.Size = new System.Drawing.Size(124, 20);
            this.textBoxTipoServicio.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo Servicio:";
            // 
            // DatosVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 358);
            this.Controls.Add(this.buttonConfirmarCompra);
            this.Controls.Add(this.groupBoxPasajes);
            this.Controls.Add(this.groupBoxEncomiendas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBox2);
            this.Name = "DatosVuelo";
            this.Text = "DatosVuelo";
            this.Load += new System.EventHandler(this.DatosVuelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEncomiendas)).EndInit();
            this.groupBoxEncomiendas.ResumeLayout(false);
            this.groupBoxPasajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonEncomienda;
        private System.Windows.Forms.Button buttonPasaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAvion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFechaLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFechaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCiudadDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCiudadOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxKilogramosDisponibles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPasajesDisponibles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewEncomiendas;
        private System.Windows.Forms.GroupBox groupBoxEncomiendas;
        private System.Windows.Forms.GroupBox groupBoxPasajes;
        private System.Windows.Forms.DataGridView dataGridViewPasajes;
        private System.Windows.Forms.Button buttonConfirmarCompra;
        private System.Windows.Forms.TextBox textBoxTipoServicio;
        private System.Windows.Forms.Label label8;
    }
}