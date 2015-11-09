namespace AerolineaFrba.Compra
{
    partial class CompraForm
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Compralabel = new System.Windows.Forms.Label();
            this.dateTimePickerCompra = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudadDestino = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVuelos = new System.Windows.Forms.DataGridView();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad destino";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(19, 49);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(683, 29);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Compralabel
            // 
            this.Compralabel.AutoSize = true;
            this.Compralabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compralabel.Location = new System.Drawing.Point(12, 9);
            this.Compralabel.Name = "Compralabel";
            this.Compralabel.Size = new System.Drawing.Size(259, 18);
            this.Compralabel.TabIndex = 8;
            this.Compralabel.Text = "Compra de pasajes/encominedas";
            // 
            // dateTimePickerCompra
            // 
            this.dateTimePickerCompra.Location = new System.Drawing.Point(59, 24);
            this.dateTimePickerCompra.Name = "dateTimePickerCompra";
            this.dateTimePickerCompra.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerCompra.TabIndex = 9;
            // 
            // comboBoxCiudadOrigen
            // 
            this.comboBoxCiudadOrigen.FormattingEnabled = true;
            this.comboBoxCiudadOrigen.Location = new System.Drawing.Point(300, 23);
            this.comboBoxCiudadOrigen.Name = "comboBoxCiudadOrigen";
            this.comboBoxCiudadOrigen.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCiudadOrigen.TabIndex = 10;
            this.comboBoxCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudadOrigen_SelectedIndexChanged);
            // 
            // comboBoxCiudadDestino
            // 
            this.comboBoxCiudadDestino.FormattingEnabled = true;
            this.comboBoxCiudadDestino.Location = new System.Drawing.Point(554, 22);
            this.comboBoxCiudadDestino.Name = "comboBoxCiudadDestino";
            this.comboBoxCiudadDestino.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCiudadDestino.TabIndex = 11;
            this.comboBoxCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCiudadDestino);
            this.groupBox1.Controls.Add(this.dateTimePickerCompra);
            this.groupBox1.Controls.Add(this.comboBoxCiudadOrigen);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 84);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar fecha y destino";
            // 
            // dataGridViewVuelos
            // 
            this.dataGridViewVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVuelos.Location = new System.Drawing.Point(15, 129);
            this.dataGridViewVuelos.Name = "dataGridViewVuelos";
            this.dataGridViewVuelos.Size = new System.Drawing.Size(718, 336);
            this.dataGridViewVuelos.TabIndex = 13;
            this.dataGridViewVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVuelos_CellContentClick);
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Location = new System.Drawing.Point(515, 471);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(218, 35);
            this.buttonContinuar.TabIndex = 14;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 518);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.dataGridViewVuelos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Compralabel);
            this.Controls.Add(this.button2);
            this.Name = "CompraForm";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.CompraForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Compralabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompra;
        private System.Windows.Forms.ComboBox comboBoxCiudadOrigen;
        private System.Windows.Forms.ComboBox comboBoxCiudadDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewVuelos;
        private System.Windows.Forms.Button buttonContinuar;
    }
}