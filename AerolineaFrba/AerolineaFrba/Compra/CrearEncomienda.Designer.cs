namespace AerolineaFrba.Compra
{
    partial class CrearEncomienda
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
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.labelKgs = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecioTotal = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxApellidoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Location = new System.Drawing.Point(115, 20);
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.ReadOnly = true;
            this.numericUpDownPeso.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownPeso.TabIndex = 0;
            this.numericUpDownPeso.ValueChanged += new System.EventHandler(this.numericUpDownPeso_ValueChanged);
            // 
            // labelKgs
            // 
            this.labelKgs.AutoSize = true;
            this.labelKgs.Location = new System.Drawing.Point(16, 22);
            this.labelKgs.Name = "labelKgs";
            this.labelKgs.Size = new System.Drawing.Size(93, 13);
            this.labelKgs.TabIndex = 1;
            this.labelKgs.Text = "Peso Encomienda";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(16, 53);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(64, 13);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio Total";
            // 
            // textBoxPrecioTotal
            // 
            this.textBoxPrecioTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrecioTotal.Enabled = false;
            this.textBoxPrecioTotal.Location = new System.Drawing.Point(115, 50);
            this.textBoxPrecioTotal.Name = "textBoxPrecioTotal";
            this.textBoxPrecioTotal.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrecioTotal.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(6, 142);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(129, 35);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(141, 142);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(129, 35);
            this.buttonComprar.TabIndex = 5;
            this.buttonComprar.Text = "Agregar Compra";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonBuscarCliente);
            this.groupBox3.Controls.Add(this.textBoxDni);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxUsuario);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxApellidoCliente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxNombreCliente);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(276, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 165);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Cliente";
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(18, 125);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(260, 32);
            this.buttonBuscarCliente.TabIndex = 6;
            this.buttonBuscarCliente.Text = "Seleccionar Cliente";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(98, 99);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.ReadOnly = true;
            this.textBoxDni.Size = new System.Drawing.Size(180, 20);
            this.textBoxDni.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "DNI:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(98, 73);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(180, 20);
            this.textBoxUsuario.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Usuario:";
            // 
            // textBoxApellidoCliente
            // 
            this.textBoxApellidoCliente.Location = new System.Drawing.Point(98, 47);
            this.textBoxApellidoCliente.Name = "textBoxApellidoCliente";
            this.textBoxApellidoCliente.ReadOnly = true;
            this.textBoxApellidoCliente.Size = new System.Drawing.Size(180, 20);
            this.textBoxApellidoCliente.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Apellido:";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(98, 19);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(180, 20);
            this.textBoxNombreCliente.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPeso);
            this.groupBox1.Controls.Add(this.labelKgs);
            this.groupBox1.Controls.Add(this.labelPrecio);
            this.groupBox1.Controls.Add(this.textBoxPrecioTotal);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encomienda";
            // 
            // CrearEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 184);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "CrearEncomienda";
            this.Text = "Nueva Encomienda";
            this.Load += new System.EventHandler(this.CrearEncomienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.Label labelKgs;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxPrecioTotal;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxApellidoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}