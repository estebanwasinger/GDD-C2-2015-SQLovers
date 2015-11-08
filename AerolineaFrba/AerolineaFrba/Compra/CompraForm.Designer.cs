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
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Compralabel = new System.Windows.Forms.Label();
            this.dateTimePickerCompra = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudadDestino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad destino";
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Location = new System.Drawing.Point(62, 212);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(75, 23);
            this.buttonContinuar.TabIndex = 6;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Compralabel
            // 
            this.Compralabel.AutoSize = true;
            this.Compralabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compralabel.Location = new System.Drawing.Point(12, 22);
            this.Compralabel.Name = "Compralabel";
            this.Compralabel.Size = new System.Drawing.Size(259, 18);
            this.Compralabel.TabIndex = 8;
            this.Compralabel.Text = "Compra de pasajes/encominedas";
            // 
            // dateTimePickerCompra
            // 
            this.dateTimePickerCompra.Location = new System.Drawing.Point(113, 76);
            this.dateTimePickerCompra.Name = "dateTimePickerCompra";
            this.dateTimePickerCompra.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerCompra.TabIndex = 9;
            // 
            // comboBoxCiudadOrigen
            // 
            this.comboBoxCiudadOrigen.FormattingEnabled = true;
            this.comboBoxCiudadOrigen.Location = new System.Drawing.Point(113, 110);
            this.comboBoxCiudadOrigen.Name = "comboBoxCiudadOrigen";
            this.comboBoxCiudadOrigen.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCiudadOrigen.TabIndex = 10;
            this.comboBoxCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudadOrigen_SelectedIndexChanged);
            // 
            // comboBoxCiudadDestino
            // 
            this.comboBoxCiudadDestino.FormattingEnabled = true;
            this.comboBoxCiudadDestino.Location = new System.Drawing.Point(113, 145);
            this.comboBoxCiudadDestino.Name = "comboBoxCiudadDestino";
            this.comboBoxCiudadDestino.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCiudadDestino.TabIndex = 11;
            this.comboBoxCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBoxCiudadDestino);
            this.Controls.Add(this.comboBoxCiudadOrigen);
            this.Controls.Add(this.dateTimePickerCompra);
            this.Controls.Add(this.Compralabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompraForm";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.CompraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Compralabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompra;
        private System.Windows.Forms.ComboBox comboBoxCiudadOrigen;
        private System.Windows.Forms.ComboBox comboBoxCiudadDestino;
    }
}