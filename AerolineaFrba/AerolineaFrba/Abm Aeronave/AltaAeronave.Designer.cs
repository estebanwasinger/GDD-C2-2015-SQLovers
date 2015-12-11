namespace AerolineaFrba.Abm_Aeronave
{
    partial class AltaAeronave
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeFA = new System.Windows.Forms.DateTimePicker();
            this.BAlta = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.comboBoxFabricante = new System.Windows.Forms.ComboBox();
            this.numericUpDownPasillo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVentana = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKg = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kg de Carga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fabricante";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(128, 22);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(115, 20);
            this.txtMatricula.TabIndex = 5;
            this.txtMatricula.TextChanged += new System.EventHandler(this.validar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Butacas Ventanilla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Alta";
            // 
            // dateTimeFA
            // 
            this.dateTimeFA.Location = new System.Drawing.Point(129, 207);
            this.dateTimeFA.Name = "dateTimeFA";
            this.dateTimeFA.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFA.TabIndex = 13;
            // 
            // BAlta
            // 
            this.BAlta.Location = new System.Drawing.Point(198, 297);
            this.BAlta.Name = "BAlta";
            this.BAlta.Size = new System.Drawing.Size(157, 50);
            this.BAlta.TabIndex = 14;
            this.BAlta.Text = "Crear";
            this.BAlta.UseVisualStyleBackColor = true;
            this.BAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(12, 297);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(163, 50);
            this.BCancelar.TabIndex = 15;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo Servicio";
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(129, 180);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 17;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.validar);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Butacas Pasillo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxModelo);
            this.groupBox1.Controls.Add(this.comboBoxFabricante);
            this.groupBox1.Controls.Add(this.numericUpDownPasillo);
            this.groupBox1.Controls.Add(this.numericUpDownVentana);
            this.groupBox1.Controls.Add(this.numericUpDownKg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbServicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.dateTimeFA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 241);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModelo.FormattingEnabled = true;
            this.comboBoxModelo.Location = new System.Drawing.Point(128, 75);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModelo.TabIndex = 24;
            this.comboBoxModelo.SelectedIndexChanged += new System.EventHandler(this.validar);
            // 
            // comboBoxFabricante
            // 
            this.comboBoxFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFabricante.FormattingEnabled = true;
            this.comboBoxFabricante.Location = new System.Drawing.Point(128, 48);
            this.comboBoxFabricante.Name = "comboBoxFabricante";
            this.comboBoxFabricante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFabricante.TabIndex = 23;
            this.comboBoxFabricante.SelectedIndexChanged += new System.EventHandler(this.comboBoxFabricante_SelectedIndexChanged);
            // 
            // numericUpDownPasillo
            // 
            this.numericUpDownPasillo.Location = new System.Drawing.Point(129, 154);
            this.numericUpDownPasillo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPasillo.Name = "numericUpDownPasillo";
            this.numericUpDownPasillo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPasillo.TabIndex = 22;
            this.numericUpDownPasillo.ValueChanged += new System.EventHandler(this.validar);
            // 
            // numericUpDownVentana
            // 
            this.numericUpDownVentana.Location = new System.Drawing.Point(129, 128);
            this.numericUpDownVentana.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVentana.Name = "numericUpDownVentana";
            this.numericUpDownVentana.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownVentana.TabIndex = 21;
            this.numericUpDownVentana.ValueChanged += new System.EventHandler(this.validar);
            // 
            // numericUpDownKg
            // 
            this.numericUpDownKg.Location = new System.Drawing.Point(129, 102);
            this.numericUpDownKg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKg.Name = "numericUpDownKg";
            this.numericUpDownKg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKg.TabIndex = 20;
            this.numericUpDownKg.ValueChanged += new System.EventHandler(this.validar);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(112, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Datos Aeronave";
            // 
            // AltaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 361);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAlta);
            this.Name = "AltaAeronave";
            this.Text = "AltaAeronave";
            this.Load += new System.EventHandler(this.AltaAeronave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeFA;
        private System.Windows.Forms.Button BAlta;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxFabricante;
        private System.Windows.Forms.NumericUpDown numericUpDownPasillo;
        private System.Windows.Forms.NumericUpDown numericUpDownVentana;
        private System.Windows.Forms.NumericUpDown numericUpDownKg;
        private System.Windows.Forms.Label label9;
    }
}