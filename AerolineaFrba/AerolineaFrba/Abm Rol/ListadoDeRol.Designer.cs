namespace AerolineaFrba.Abm_Rol
{
    partial class Listado
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Buscador = new System.Windows.Forms.GroupBox();
            this.rbNoActivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.LBLFiltro = new System.Windows.Forms.Label();
            this.Filtro = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.Buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscador
            // 
            this.Buscador.Controls.Add(this.btnReset);
            this.Buscador.Controls.Add(this.rbNoActivo);
            this.Buscador.Controls.Add(this.rbActivo);
            this.Buscador.Controls.Add(this.LBLFiltro);
            this.Buscador.Controls.Add(this.Filtro);
            this.Buscador.Controls.Add(this.BtnBuscar);
            this.Buscador.Location = new System.Drawing.Point(66, 37);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(498, 100);
            this.Buscador.TabIndex = 0;
            this.Buscador.TabStop = false;
            this.Buscador.Text = "Buscador";
            // 
            // rbNoActivo
            // 
            this.rbNoActivo.AutoSize = true;
            this.rbNoActivo.Location = new System.Drawing.Point(294, 33);
            this.rbNoActivo.Name = "rbNoActivo";
            this.rbNoActivo.Size = new System.Drawing.Size(69, 17);
            this.rbNoActivo.TabIndex = 5;
            this.rbNoActivo.TabStop = true;
            this.rbNoActivo.Text = "NoActivo";
            this.rbNoActivo.UseVisualStyleBackColor = true;
            this.rbNoActivo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(233, 33);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 4;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LBLFiltro
            // 
            this.LBLFiltro.AutoSize = true;
            this.LBLFiltro.Location = new System.Drawing.Point(6, 37);
            this.LBLFiltro.Name = "LBLFiltro";
            this.LBLFiltro.Size = new System.Drawing.Size(35, 13);
            this.LBLFiltro.TabIndex = 2;
            this.LBLFiltro.Text = "Filtro: ";
            this.LBLFiltro.Click += new System.EventHandler(this.LBLFiltro_Click);
            // 
            // Filtro
            // 
            this.Filtro.Location = new System.Drawing.Point(47, 34);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(180, 20);
            this.Filtro.TabIndex = 1;
            this.Filtro.TextChanged += new System.EventHandler(this.Filtro_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(369, 27);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(241, 297);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(75, 23);
            this.BtnAlta.TabIndex = 1;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // DGVListado
            // 
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Location = new System.Drawing.Point(66, 141);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.Size = new System.Drawing.Size(498, 150);
            this.DGVListado.TabIndex = 2;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitulo.Location = new System.Drawing.Point(268, 13);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(96, 13);
            this.LBLTitulo.TabIndex = 3;
            this.LBLTitulo.Text = "ListadoDeRoles";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(369, 56);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 347);
            this.Controls.Add(this.LBLTitulo);
            this.Controls.Add(this.DGVListado);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.Buscador);
            this.Name = "Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoDeRol";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.Buscador.ResumeLayout(false);
            this.Buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Buscador;
        private System.Windows.Forms.TextBox Filtro;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.Label LBLTitulo;
        private System.Windows.Forms.Label LBLFiltro;
        private System.Windows.Forms.RadioButton rbNoActivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Button btnReset;
    }
}

