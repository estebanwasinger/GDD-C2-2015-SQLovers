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
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.dateBaja = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtFabri = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.horaBFS = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFVS
            // 
            this.dateFVS.Location = new System.Drawing.Point(549, 169);
            this.dateFVS.Name = "dateFVS";
            this.dateFVS.Size = new System.Drawing.Size(200, 20);
            this.dateFVS.TabIndex = 38;
            // 
            // fechaAlta
            // 
            this.fechaAlta.AutoSize = true;
            this.fechaAlta.Location = new System.Drawing.Point(463, 176);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(83, 13);
            this.fechaAlta.TabIndex = 37;
            this.fechaAlta.Text = "Fecha Vuelta S.";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(484, 326);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(104, 23);
            this.btnBaja.TabIndex = 36;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btn_darBajaFueraDeServicio);
            // 
            // btnCancelarV
            // 
            this.btnCancelarV.Location = new System.Drawing.Point(484, 265);
            this.btnCancelarV.Name = "btnCancelarV";
            this.btnCancelarV.Size = new System.Drawing.Size(104, 23);
            this.btnCancelarV.TabIndex = 35;
            this.btnCancelarV.Text = "Cancelar Vuelo";
            this.btnCancelarV.UseVisualStyleBackColor = true;
            this.btnCancelarV.Click += new System.EventHandler(this.btn_Cancelar_Vuelo);
            // 
            // btnReempV
            // 
            this.btnReempV.Location = new System.Drawing.Point(484, 210);
            this.btnReempV.Name = "btnReempV";
            this.btnReempV.Size = new System.Drawing.Size(104, 23);
            this.btnReempV.TabIndex = 34;
            this.btnReempV.Text = "Reemplazar Vuelo";
            this.btnReempV.UseVisualStyleBackColor = true;
            this.btnReempV.Click += new System.EventHandler(this.btn_Reemplazar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgVuelos);
            this.groupBox1.Location = new System.Drawing.Point(34, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 183);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vuelos de la Aeronave";
            // 
            // dtgVuelos
            // 
            this.dtgVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelos.Location = new System.Drawing.Point(15, 34);
            this.dtgVuelos.Name = "dtgVuelos";
            this.dtgVuelos.Size = new System.Drawing.Size(388, 111);
            this.dtgVuelos.TabIndex = 0;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(307, 94);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 32;
            // 
            // dateBaja
            // 
            this.dateBaja.Location = new System.Drawing.Point(549, 91);
            this.dateBaja.Name = "dateBaja";
            this.dateBaja.Size = new System.Drawing.Size(199, 20);
            this.dateBaja.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fabricante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Peso Disp.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha Baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Matricula";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(307, 43);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(79, 20);
            this.txtPeso.TabIndex = 24;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(99, 99);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 23;
            // 
            // txtFabri
            // 
            this.txtFabri.Location = new System.Drawing.Point(549, 43);
            this.txtFabri.Name = "txtFabri";
            this.txtFabri.Size = new System.Drawing.Size(100, 20);
            this.txtFabri.TabIndex = 22;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(99, 47);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(98, 20);
            this.txtmatricula.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(630, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fecha Baja";
            // 
            // horaBFS
            // 
            this.horaBFS.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaBFS.Location = new System.Drawing.Point(549, 131);
            this.horaBFS.Name = "horaBFS";
            this.horaBFS.Size = new System.Drawing.Size(86, 20);
            this.horaBFS.TabIndex = 41;
            // 
            // BajaFueraServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 371);
            this.Controls.Add(this.horaBFS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dateFVS);
            this.Controls.Add(this.fechaAlta);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnCancelarV);
            this.Controls.Add(this.btnReempV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.dateBaja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtFabri);
            this.Controls.Add(this.txtmatricula);
            this.Name = "BajaFueraServicio";
            this.Text = "BajaFueraServicio";
            this.Load += new System.EventHandler(this.FormBajaFservicio_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker horaBFS;

    }
}