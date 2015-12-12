namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaFueraServicio
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
            this.dateFVS = new System.Windows.Forms.DateTimePicker();
            this.fechaAlta = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCancelarV = new System.Windows.Forms.Button();
            this.btnReempV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgVuelos = new System.Windows.Forms.DataGridView();
            this.horaBFS = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBaja = new System.Windows.Forms.DateTimePicker();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtFabri = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateFVS
            // 
            this.dateFVS.Location = new System.Drawing.Point(95, 41);
            this.dateFVS.Name = "dateFVS";
            this.dateFVS.Size = new System.Drawing.Size(200, 20);
            this.dateFVS.TabIndex = 38;
            this.dateFVS.ValueChanged += new System.EventHandler(this.dateBaja_ValueChanged);
            // 
            // fechaAlta
            // 
            this.fechaAlta.AutoSize = true;
            this.fechaAlta.Location = new System.Drawing.Point(6, 44);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(83, 13);
            this.fechaAlta.TabIndex = 37;
            this.fechaAlta.Text = "Fecha Vuelta S.";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(250, 421);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(217, 37);
            this.btnBaja.TabIndex = 36;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btn_darBajaFueraDeServicio);
            // 
            // btnCancelarV
            // 
            this.btnCancelarV.Location = new System.Drawing.Point(6, 252);
            this.btnCancelarV.Name = "btnCancelarV";
            this.btnCancelarV.Size = new System.Drawing.Size(226, 40);
            this.btnCancelarV.TabIndex = 35;
            this.btnCancelarV.Text = "Cancelar Vuelo";
            this.btnCancelarV.UseVisualStyleBackColor = true;
            this.btnCancelarV.Click += new System.EventHandler(this.btn_Cancelar_Vuelo);
            // 
            // btnReempV
            // 
            this.btnReempV.Location = new System.Drawing.Point(238, 252);
            this.btnReempV.Name = "btnReempV";
            this.btnReempV.Size = new System.Drawing.Size(217, 40);
            this.btnReempV.TabIndex = 34;
            this.btnReempV.Text = "Reemplazar Vuelo";
            this.btnReempV.UseVisualStyleBackColor = true;
            this.btnReempV.Click += new System.EventHandler(this.btn_Reemplazar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgVuelos);
            this.groupBox1.Controls.Add(this.horaBFS);
            this.groupBox1.Controls.Add(this.dateFVS);
            this.groupBox1.Controls.Add(this.btnReempV);
            this.groupBox1.Controls.Add(this.btnCancelarV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateBaja);
            this.groupBox1.Controls.Add(this.fechaAlta);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 298);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vuelos de la Aeronave";
            // 
            // dtgVuelos
            // 
            this.dtgVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelos.Location = new System.Drawing.Point(6, 67);
            this.dtgVuelos.Name = "dtgVuelos";
            this.dtgVuelos.ReadOnly = true;
            this.dtgVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVuelos.Size = new System.Drawing.Size(449, 179);
            this.dtgVuelos.TabIndex = 0;
            // 
            // horaBFS
            // 
            this.horaBFS.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaBFS.Location = new System.Drawing.Point(311, 15);
            this.horaBFS.Name = "horaBFS";
            this.horaBFS.Size = new System.Drawing.Size(86, 20);
            this.horaBFS.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha Baja";
            // 
            // dateBaja
            // 
            this.dateBaja.Location = new System.Drawing.Point(95, 15);
            this.dateBaja.Name = "dateBaja";
            this.dateBaja.Size = new System.Drawing.Size(199, 20);
            this.dateBaja.TabIndex = 31;
            this.dateBaja.ValueChanged += new System.EventHandler(this.dateBaja_ValueChanged);
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(268, 18);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fabricante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Peso Disp.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Matricula";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(80, 71);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(98, 20);
            this.txtPeso.TabIndex = 24;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(80, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(98, 20);
            this.txtModelo.TabIndex = 23;
            // 
            // txtFabri
            // 
            this.txtFabri.Location = new System.Drawing.Point(268, 45);
            this.txtFabri.Name = "txtFabri";
            this.txtFabri.Size = new System.Drawing.Size(121, 20);
            this.txtFabri.TabIndex = 22;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(80, 19);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(98, 20);
            this.txtmatricula.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(18, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(226, 37);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmatricula);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbServicio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFabri);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 99);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Aeronave";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BajaFueraServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaFueraServicio";
            this.Text = "BajaFueraServicio";
            this.Load += new System.EventHandler(this.FormBajaFservicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateFVS;
        private System.Windows.Forms.Label fechaAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCancelarV;
        private System.Windows.Forms.Button btnReempV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgVuelos;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.DateTimePicker dateBaja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtFabri;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker horaBFS;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}