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
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtButacasVentanilla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeFA = new System.Windows.Forms.DateTimePicker();
            this.BAlta = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtButPasillo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kg de Carga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fabricante";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(160, 29);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(115, 20);
            this.txtMatricula.TabIndex = 5;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(160, 167);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(115, 20);
            this.txtFabricante.TabIndex = 6;
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(160, 116);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(41, 20);
            this.txtCarga.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(160, 72);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(115, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Butacas Ventanilla";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtButacasVentanilla
            // 
            this.txtButacasVentanilla.Location = new System.Drawing.Point(160, 211);
            this.txtButacasVentanilla.Name = "txtButacasVentanilla";
            this.txtButacasVentanilla.Size = new System.Drawing.Size(41, 20);
            this.txtButacasVentanilla.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Alta";
            // 
            // dateTimeFA
            // 
            this.dateTimeFA.Location = new System.Drawing.Point(120, 369);
            this.dateTimeFA.Name = "dateTimeFA";
            this.dateTimeFA.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFA.TabIndex = 13;
            // 
            // BAlta
            // 
            this.BAlta.Location = new System.Drawing.Point(67, 426);
            this.BAlta.Name = "BAlta";
            this.BAlta.Size = new System.Drawing.Size(75, 23);
            this.BAlta.TabIndex = 14;
            this.BAlta.Text = "Alta";
            this.BAlta.UseVisualStyleBackColor = true;
            this.BAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(200, 426);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 15;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo Servicio";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(154, 316);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Butacas Pasillo";
            // 
            // txtButPasillo
            // 
            this.txtButPasillo.Location = new System.Drawing.Point(160, 263);
            this.txtButPasillo.Name = "txtButPasillo";
            this.txtButPasillo.Size = new System.Drawing.Size(41, 20);
            this.txtButPasillo.TabIndex = 19;
            // 
            // AltaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 487);
            this.Controls.Add(this.txtButPasillo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAlta);
            this.Controls.Add(this.dateTimeFA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtButacasVentanilla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaAeronave";
            this.Text = "AltaAeronave";
            this.Load += new System.EventHandler(this.AltaAeronave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtButacasVentanilla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeFA;
        private System.Windows.Forms.Button BAlta;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtButPasillo;
    }
}