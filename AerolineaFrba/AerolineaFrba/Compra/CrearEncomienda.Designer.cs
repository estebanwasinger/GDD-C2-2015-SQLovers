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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Location = new System.Drawing.Point(112, 28);
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.ReadOnly = true;
            this.numericUpDownPeso.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownPeso.TabIndex = 0;
            this.numericUpDownPeso.ValueChanged += new System.EventHandler(this.numericUpDownPeso_ValueChanged);
            // 
            // labelKgs
            // 
            this.labelKgs.AutoSize = true;
            this.labelKgs.Location = new System.Drawing.Point(13, 30);
            this.labelKgs.Name = "labelKgs";
            this.labelKgs.Size = new System.Drawing.Size(93, 13);
            this.labelKgs.TabIndex = 1;
            this.labelKgs.Text = "Peso Encomienda";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(13, 65);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(64, 13);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio Total";
            // 
            // textBoxPrecioTotal
            // 
            this.textBoxPrecioTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrecioTotal.Enabled = false;
            this.textBoxPrecioTotal.Location = new System.Drawing.Point(112, 62);
            this.textBoxPrecioTotal.Name = "textBoxPrecioTotal";
            this.textBoxPrecioTotal.Size = new System.Drawing.Size(152, 20);
            this.textBoxPrecioTotal.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(5, 115);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(129, 35);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(140, 115);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(129, 35);
            this.buttonComprar.TabIndex = 5;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // CrearEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 162);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxPrecioTotal);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelKgs);
            this.Controls.Add(this.numericUpDownPeso);
            this.Name = "CrearEncomienda";
            this.Text = "CrearEncomienda";
            this.Load += new System.EventHandler(this.CrearEncomienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.Label labelKgs;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxPrecioTotal;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonComprar;
    }
}