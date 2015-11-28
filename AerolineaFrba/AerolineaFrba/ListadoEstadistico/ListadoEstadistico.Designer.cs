namespace AerolineaFrba.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.gbElegir = new System.Windows.Forms.GroupBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbListado = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.gbElegir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElegir
            // 
            this.gbElegir.Controls.Add(this.lblSemestre);
            this.gbElegir.Controls.Add(this.lblAnio);
            this.gbElegir.Controls.Add(this.lblListado);
            this.gbElegir.Controls.Add(this.cmbSemestre);
            this.gbElegir.Controls.Add(this.cmbAnio);
            this.gbElegir.Controls.Add(this.cmbListado);
            this.gbElegir.Controls.Add(this.btnListar);
            this.gbElegir.Location = new System.Drawing.Point(12, 10);
            this.gbElegir.Name = "gbElegir";
            this.gbElegir.Size = new System.Drawing.Size(645, 57);
            this.gbElegir.TabIndex = 1;
            this.gbElegir.TabStop = false;
            this.gbElegir.Text = "Elegir";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(9, 21);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(54, 13);
            this.lblSemestre.TabIndex = 6;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(166, 21);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 5;
            this.lblAnio.Text = "Año:";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(251, 21);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(41, 13);
            this.lblListado.TabIndex = 4;
            this.lblListado.Text = "Listado";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(69, 17);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(91, 21);
            this.cmbSemestre.TabIndex = 3;
            // 
            // cmbAnio
            // 
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(201, 17);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(40, 21);
            this.cmbAnio.TabIndex = 2;
            // 
            // cmbListado
            // 
            this.cmbListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListado.FormattingEnabled = true;
            this.cmbListado.Location = new System.Drawing.Point(298, 17);
            this.cmbListado.Name = "cmbListado";
            this.cmbListado.Size = new System.Drawing.Size(281, 21);
            this.cmbListado.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(585, 16);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(54, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 73);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(645, 282);
            this.dgvListado.TabIndex = 2;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 370);
            this.Controls.Add(this.gbElegir);
            this.Controls.Add(this.dgvListado);
            this.Name = "ListadoEstadistico";
            this.Text = "ListadoEstadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.gbElegir.ResumeLayout(false);
            this.gbElegir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElegir;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbListado;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}
