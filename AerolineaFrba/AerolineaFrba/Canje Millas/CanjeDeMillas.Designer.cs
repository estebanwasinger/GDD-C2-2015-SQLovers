namespace AerolineaFrba.Canje_Millas
{
    partial class CanjeDeMillas
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCanjear = new System.Windows.Forms.Button();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.Producto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_cant = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cant)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(135, 193);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCanjear
            // 
            this.buttonCanjear.Location = new System.Drawing.Point(25, 193);
            this.buttonCanjear.Name = "buttonCanjear";
            this.buttonCanjear.Size = new System.Drawing.Size(75, 23);
            this.buttonCanjear.TabIndex = 2;
            this.buttonCanjear.Text = "Canjear";
            this.buttonCanjear.UseVisualStyleBackColor = true;
            this.buttonCanjear.Click += new System.EventHandler(this.buttonCanjear_Click);
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(89, 86);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducto.TabIndex = 3;
            this.comboBoxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducto_SelectedIndexChanged);
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(22, 89);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 4;
            this.Producto.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CANJE DE MILLAS";
            // 
            // numericUpDown_cant
            // 
            this.numericUpDown_cant.Location = new System.Drawing.Point(89, 113);
            this.numericUpDown_cant.Name = "numericUpDown_cant";
            this.numericUpDown_cant.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cant.TabIndex = 9;
            this.numericUpDown_cant.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "DNI Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(89, 59);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(120, 20);
            this.textBoxDNI.TabIndex = 11;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(233, 57);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(75, 23);
            this.buttonValidar.TabIndex = 14;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
          //  this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // CanjeDeMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 242);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_cant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.buttonCanjear);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "CanjeDeMillas";
            this.Text = "Canje de millas";
            this.Load += new System.EventHandler(this.CanjeDeMillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCanjear;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_cant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button buttonValidar;
    }
}