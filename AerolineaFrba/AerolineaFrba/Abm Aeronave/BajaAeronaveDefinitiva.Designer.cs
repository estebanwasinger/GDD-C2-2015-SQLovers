namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaAeronaveD
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
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtFabri = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateBaja = new System.Windows.Forms.DateTimePicker();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgVuelos = new System.Windows.Forms.DataGridView();
            this.btnReempV = new System.Windows.Forms.Button();
            this.btnCancelarV = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.horaBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(81, 13);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 0;
            // 
            // txtFabri
            // 
            this.txtFabri.Location = new System.Drawing.Point(284, 40);
            this.txtFabri.Name = "txtFabri";
            this.txtFabri.Size = new System.Drawing.Size(100, 20);
            this.txtFabri.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(81, 39);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(81, 65);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Baja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peso Disp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fabricante";
            // 
            // dateBaja
            // 
            this.dateBaja.Location = new System.Drawing.Point(92, 20);
            this.dateBaja.Name = "dateBaja";
            this.dateBaja.Size = new System.Drawing.Size(199, 20);
            this.dateBaja.TabIndex = 13;
            this.dateBaja.ValueChanged += new System.EventHandler(this.dateBaja_ValueChanged);
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(284, 13);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateBaja);
            this.groupBox1.Controls.Add(this.dtgVuelos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnReempV);
            this.groupBox1.Controls.Add(this.btnCancelarV);
            this.groupBox1.Controls.Add(this.horaBD);
            this.groupBox1.Location = new System.Drawing.Point(15, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 316);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vuelos de la Aeronave";
            // 
            // dtgVuelos
            // 
            this.dtgVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelos.Location = new System.Drawing.Point(6, 46);
            this.dtgVuelos.Name = "dtgVuelos";
            this.dtgVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVuelos.Size = new System.Drawing.Size(505, 217);
            this.dtgVuelos.TabIndex = 0;
            // 
            // btnReempV
            // 
            this.btnReempV.Location = new System.Drawing.Point(263, 269);
            this.btnReempV.Name = "btnReempV";
            this.btnReempV.Size = new System.Drawing.Size(248, 34);
            this.btnReempV.TabIndex = 16;
            this.btnReempV.Text = "Reemplazar Vuelo";
            this.btnReempV.UseVisualStyleBackColor = true;
            this.btnReempV.Click += new System.EventHandler(this.btn_Reemplazar_Click);
            // 
            // btnCancelarV
            // 
            this.btnCancelarV.Location = new System.Drawing.Point(6, 269);
            this.btnCancelarV.Name = "btnCancelarV";
            this.btnCancelarV.Size = new System.Drawing.Size(251, 34);
            this.btnCancelarV.TabIndex = 17;
            this.btnCancelarV.Text = "Cancelar Vuelo";
            this.btnCancelarV.UseVisualStyleBackColor = true;
            this.btnCancelarV.Click += new System.EventHandler(this.btn_Cancelar_Vuelo);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(278, 451);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(248, 44);
            this.btnBaja.TabIndex = 18;
            this.btnBaja.Text = "Confirmar Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btn_darBajaDefinitiva);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(24, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(248, 44);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // horaBD
            // 
            this.horaBD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaBD.Location = new System.Drawing.Point(381, 20);
            this.horaBD.Name = "horaBD";
            this.horaBD.Size = new System.Drawing.Size(87, 20);
            this.horaBD.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hora Baja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmatricula);
            this.groupBox2.Controls.Add(this.txtFabri);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbServicio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 97);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Aeronave";
            // 
            // BajaAeronaveD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 501);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaAeronaveD";
            this.Text = "Baja Definitiva Aeronave";
            this.Load += new System.EventHandler(this.FormBajaDefinitiva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtFabri;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateBaja;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgVuelos;
        private System.Windows.Forms.Button btnReempV;
        private System.Windows.Forms.Button btnCancelarV;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker horaBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}