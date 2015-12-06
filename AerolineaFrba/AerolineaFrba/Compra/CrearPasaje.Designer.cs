namespace AerolineaFrba.Compra
{
    partial class CrearPasaje
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridViewButacas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewButacas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Butacas Disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCancelar.Location = new System.Drawing.Point(12, 298);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(133, 34);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(154, 298);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(133, 34);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridViewButacas
            // 
            this.dataGridViewButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewButacas.Location = new System.Drawing.Point(13, 45);
            this.dataGridViewButacas.Name = "dataGridViewButacas";
            this.dataGridViewButacas.Size = new System.Drawing.Size(274, 247);
            this.dataGridViewButacas.TabIndex = 3;
            this.dataGridViewButacas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewButacas_CellClick);
            this.dataGridViewButacas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewButacas_CellDoubleClick);
            // 
            // CrearPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 344);
            this.Controls.Add(this.dataGridViewButacas);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label1);
            this.Name = "CrearPasaje";
            this.Text = "CrearPasaje";
            this.Load += new System.EventHandler(this.CrearPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewButacas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridViewButacas;
    }
}