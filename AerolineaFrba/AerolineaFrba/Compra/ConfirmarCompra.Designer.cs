namespace AerolineaFrba.Compra
{
    partial class ConfirmarCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEncomiendas = new System.Windows.Forms.TextBox();
            this.textBoxCantPasajes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCostoTotal = new System.Windows.Forms.TextBox();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.radioButtonTC = new System.Windows.Forms.RadioButton();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumeroTC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxCodSeguridad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxCuotas = new System.Windows.Forms.ComboBox();
            this.groupBoTC = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEncomiendas);
            this.groupBox1.Controls.Add(this.textBoxCantPasajes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Compra";
            // 
            // textBoxEncomiendas
            // 
            this.textBoxEncomiendas.Location = new System.Drawing.Point(282, 23);
            this.textBoxEncomiendas.Name = "textBoxEncomiendas";
            this.textBoxEncomiendas.ReadOnly = true;
            this.textBoxEncomiendas.Size = new System.Drawing.Size(100, 20);
            this.textBoxEncomiendas.TabIndex = 9;
            // 
            // textBoxCantPasajes
            // 
            this.textBoxCantPasajes.Location = new System.Drawing.Point(73, 23);
            this.textBoxCantPasajes.Name = "textBoxCantPasajes";
            this.textBoxCantPasajes.ReadOnly = true;
            this.textBoxCantPasajes.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantPasajes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encomiendas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pasajes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDNI);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonBuscarCliente);
            this.groupBox2.Location = new System.Drawing.Point(14, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Pago";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(62, 23);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DNI:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(250, 23);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(113, 20);
            this.textBoxNombre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre:";
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(6, 49);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(376, 27);
            this.buttonBuscarCliente.TabIndex = 11;
            this.buttonBuscarCliente.Text = "Buscar Cliente";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(20, 449);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(188, 28);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo total:";
            // 
            // textBoxCostoTotal
            // 
            this.textBoxCostoTotal.Location = new System.Drawing.Point(295, 103);
            this.textBoxCostoTotal.Name = "textBoxCostoTotal";
            this.textBoxCostoTotal.ReadOnly = true;
            this.textBoxCostoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCostoTotal.TabIndex = 10;
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(219, 449);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(189, 28);
            this.buttonComprar.TabIndex = 11;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // radioButtonTC
            // 
            this.radioButtonTC.AutoSize = true;
            this.radioButtonTC.Location = new System.Drawing.Point(20, 228);
            this.radioButtonTC.Name = "radioButtonTC";
            this.radioButtonTC.Size = new System.Drawing.Size(111, 17);
            this.radioButtonTC.TabIndex = 12;
            this.radioButtonTC.TabStop = true;
            this.radioButtonTC.Text = "Tarjeta De Credito";
            this.radioButtonTC.UseVisualStyleBackColor = true;
            this.radioButtonTC.CheckedChanged += new System.EventHandler(this.radioButtonTC_CheckedChanged);
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Location = new System.Drawing.Point(20, 416);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(64, 17);
            this.radioButtonEfectivo.TabIndex = 13;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            this.radioButtonEfectivo.CheckedChanged += new System.EventHandler(this.validar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero Tarjeta";
            // 
            // textBoxNumeroTC
            // 
            this.textBoxNumeroTC.Location = new System.Drawing.Point(89, 17);
            this.textBoxNumeroTC.Name = "textBoxNumeroTC";
            this.textBoxNumeroTC.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroTC.TabIndex = 15;
            this.textBoxNumeroTC.TextChanged += new System.EventHandler(this.validar);
            this.textBoxNumeroTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroTC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vencimiento";
            // 
            // comboBoxTipos
            // 
            this.comboBoxTipos.FormattingEnabled = true;
            this.comboBoxTipos.Location = new System.Drawing.Point(89, 96);
            this.comboBoxTipos.Name = "comboBoxTipos";
            this.comboBoxTipos.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipos.TabIndex = 18;
            this.comboBoxTipos.SelectedIndexChanged += new System.EventHandler(this.validar);
            this.comboBoxTipos.TextChanged += new System.EventHandler(this.validar);
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(89, 43);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVencimiento.TabIndex = 19;
            // 
            // textBoxCodSeguridad
            // 
            this.textBoxCodSeguridad.Location = new System.Drawing.Point(89, 70);
            this.textBoxCodSeguridad.Name = "textBoxCodSeguridad";
            this.textBoxCodSeguridad.Size = new System.Drawing.Size(64, 20);
            this.textBoxCodSeguridad.TabIndex = 20;
            this.textBoxCodSeguridad.TextChanged += new System.EventHandler(this.validar);
            this.textBoxCodSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodSeguridad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cod Seguridad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tipo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cuotas";
            // 
            // comboBoxCuotas
            // 
            this.comboBoxCuotas.FormattingEnabled = true;
            this.comboBoxCuotas.Location = new System.Drawing.Point(89, 123);
            this.comboBoxCuotas.Name = "comboBoxCuotas";
            this.comboBoxCuotas.Size = new System.Drawing.Size(64, 21);
            this.comboBoxCuotas.TabIndex = 23;
            this.comboBoxCuotas.SelectedIndexChanged += new System.EventHandler(this.validar);
            // 
            // groupBoTC
            // 
            this.groupBoTC.Controls.Add(this.label7);
            this.groupBoTC.Controls.Add(this.label11);
            this.groupBoTC.Controls.Add(this.textBoxNumeroTC);
            this.groupBoTC.Controls.Add(this.comboBoxCuotas);
            this.groupBoTC.Controls.Add(this.label8);
            this.groupBoTC.Controls.Add(this.label10);
            this.groupBoTC.Controls.Add(this.comboBoxTipos);
            this.groupBoTC.Controls.Add(this.label9);
            this.groupBoTC.Controls.Add(this.dateTimePickerVencimiento);
            this.groupBoTC.Controls.Add(this.textBoxCodSeguridad);
            this.groupBoTC.Location = new System.Drawing.Point(23, 251);
            this.groupBoTC.Name = "groupBoTC";
            this.groupBoTC.Size = new System.Drawing.Size(385, 159);
            this.groupBoTC.TabIndex = 25;
            this.groupBoTC.TabStop = false;
            // 
            // ConfirmarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 489);
            this.Controls.Add(this.groupBoTC);
            this.Controls.Add(this.radioButtonEfectivo);
            this.Controls.Add(this.radioButtonTC);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.textBoxCostoTotal);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmarCompra";
            this.Text = "ConfirmarCompra";
            this.Load += new System.EventHandler(this.ConfirmarCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoTC.ResumeLayout(false);
            this.groupBoTC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEncomiendas;
        private System.Windows.Forms.TextBox textBoxCantPasajes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCostoTotal;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.RadioButton radioButtonTC;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumeroTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTipos;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.TextBox textBoxCodSeguridad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxCuotas;
        private System.Windows.Forms.GroupBox groupBoTC;
    }
}