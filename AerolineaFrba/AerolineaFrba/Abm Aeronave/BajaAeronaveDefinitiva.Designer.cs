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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(118, 42);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 0;
            // 
            // txtFabri
            // 
            this.txtFabri.Location = new System.Drawing.Point(568, 38);
            this.txtFabri.Name = "txtFabri";
            this.txtFabri.Size = new System.Drawing.Size(100, 20);
            this.txtFabri.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(118, 94);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(326, 38);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(79, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Baja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peso Disp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fabricante";
            // 
            // dateBaja
            // 
            this.dateBaja.Location = new System.Drawing.Point(568, 86);
            this.dateBaja.Name = "dateBaja";
            this.dateBaja.Size = new System.Drawing.Size(199, 20);
            this.dateBaja.TabIndex = 13;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(326, 89);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgVuelos);
            this.groupBox1.Location = new System.Drawing.Point(53, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 161);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vuelos de la Aeronave";
            // 
            // dtgVuelos
            // 
            this.dtgVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelos.Location = new System.Drawing.Point(16, 31);
            this.dtgVuelos.Name = "dtgVuelos";
            this.dtgVuelos.Size = new System.Drawing.Size(388, 111);
            this.dtgVuelos.TabIndex = 0;
            // 
            // btnReempV
            // 
            this.btnReempV.Location = new System.Drawing.Point(503, 171);
            this.btnReempV.Name = "btnReempV";
            this.btnReempV.Size = new System.Drawing.Size(104, 23);
            this.btnReempV.TabIndex = 16;
            this.btnReempV.Text = "Reemplazar Vuelo";
            this.btnReempV.UseVisualStyleBackColor = true;
            this.btnReempV.Click += new System.EventHandler(this.btn_Reemplazar_Click);
            // 
            // btnCancelarV
            // 
            this.btnCancelarV.Location = new System.Drawing.Point(503, 221);
            this.btnCancelarV.Name = "btnCancelarV";
            this.btnCancelarV.Size = new System.Drawing.Size(104, 23);
            this.btnCancelarV.TabIndex = 17;
            this.btnCancelarV.Text = "Cancelar Vuelo";
            this.btnCancelarV.UseVisualStyleBackColor = true;
            this.btnCancelarV.Click += new System.EventHandler(this.btn_Cancelar_Vuelo);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(503, 270);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(104, 23);
            this.btnBaja.TabIndex = 18;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btn_darBajaDefinitiva);
            // 
            // BajaAeronaveD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 371);
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
            this.Name = "BajaAeronaveD";
            this.Text = "Baja Definitiva Aeronave";
            this.Load += new System.EventHandler(this.FormBajaDefinitiva_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

    }
}