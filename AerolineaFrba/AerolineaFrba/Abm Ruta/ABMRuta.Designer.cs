namespace AerolineaFrba.Abm_Ruta
{
    partial class ABMRuta
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
            this.CrearButtonRuta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ModificarButtonRuta = new System.Windows.Forms.Button();
            this.BajaButtonRuta = new System.Windows.Forms.Button();
            this.dataGridViewRuta = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // CrearButtonRuta
            // 
            this.CrearButtonRuta.Location = new System.Drawing.Point(12, 55);
            this.CrearButtonRuta.Name = "CrearButtonRuta";
            this.CrearButtonRuta.Size = new System.Drawing.Size(167, 44);
            this.CrearButtonRuta.TabIndex = 0;
            this.CrearButtonRuta.Text = "Crear";
            this.CrearButtonRuta.UseVisualStyleBackColor = true;
            this.CrearButtonRuta.Click += new System.EventHandler(this.CrearButtonRuta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUTA AEREA";
            // 
            // ModificarButtonRuta
            // 
            this.ModificarButtonRuta.Location = new System.Drawing.Point(194, 55);
            this.ModificarButtonRuta.Name = "ModificarButtonRuta";
            this.ModificarButtonRuta.Size = new System.Drawing.Size(167, 44);
            this.ModificarButtonRuta.TabIndex = 2;
            this.ModificarButtonRuta.Text = "Modificar";
            this.ModificarButtonRuta.UseVisualStyleBackColor = true;
            this.ModificarButtonRuta.Click += new System.EventHandler(this.ModificarButtonRuta_Click);
            // 
            // BajaButtonRuta
            // 
            this.BajaButtonRuta.Location = new System.Drawing.Point(376, 55);
            this.BajaButtonRuta.Name = "BajaButtonRuta";
            this.BajaButtonRuta.Size = new System.Drawing.Size(167, 44);
            this.BajaButtonRuta.TabIndex = 3;
            this.BajaButtonRuta.Text = "Baja";
            this.BajaButtonRuta.UseVisualStyleBackColor = true;
            this.BajaButtonRuta.Click += new System.EventHandler(this.BajaButtonRuta_Click);
            // 
            // dataGridViewRuta
            // 
            this.dataGridViewRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRuta.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewRuta.Name = "dataGridViewRuta";
            this.dataGridViewRuta.Size = new System.Drawing.Size(533, 290);
            this.dataGridViewRuta.TabIndex = 4;
            this.dataGridViewRuta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRuta_CellClick);
            // 
            // comboBoxFiltros
            // 
            this.comboBoxFiltros.AccessibleName = "";
            this.comboBoxFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltros.FormattingEnabled = true;
            this.comboBoxFiltros.Location = new System.Drawing.Point(273, 404);
            this.comboBoxFiltros.Name = "comboBoxFiltros";
            this.comboBoxFiltros.Size = new System.Drawing.Size(270, 21);
            this.comboBoxFiltros.TabIndex = 5;
            this.comboBoxFiltros.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltros_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtros";
            // 
            // ABMRuta
            // 
            this.ClientSize = new System.Drawing.Size(557, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFiltros);
            this.Controls.Add(this.dataGridViewRuta);
            this.Controls.Add(this.BajaButtonRuta);
            this.Controls.Add(this.ModificarButtonRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrearButtonRuta);
            this.Name = "ABMRuta";
            this.Load += new System.EventHandler(this.ABMRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CrearButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CrearButtonRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ModificarButtonRuta;
        private System.Windows.Forms.Button BajaButtonRuta;
        private System.Windows.Forms.DataGridView dataGridViewRuta;
        private System.Windows.Forms.ComboBox comboBoxFiltros;
        private System.Windows.Forms.Label label3;
    }
}