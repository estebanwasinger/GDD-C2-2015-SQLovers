namespace AerolineaFrba.Abm_Ciudad
{
    partial class ABMCiudad
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
            this.dataGridViewCiudad = new System.Windows.Forms.DataGridView();
            this.crearButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.borrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCiudad
            // 
            this.dataGridViewCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCiudad.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewCiudad.Name = "dataGridViewCiudad";
            this.dataGridViewCiudad.Size = new System.Drawing.Size(312, 263);
            this.dataGridViewCiudad.TabIndex = 0;
            this.dataGridViewCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCiudad_CellClick);
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(12, 12);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(100, 60);
            this.crearButton.TabIndex = 1;
            this.crearButton.Text = "Crear";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(119, 12);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(100, 60);
            this.modificarButton.TabIndex = 2;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // borrarButton
            // 
            this.borrarButton.Location = new System.Drawing.Point(224, 12);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(100, 60);
            this.borrarButton.TabIndex = 3;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // ABMCiudad
            // 
            this.ClientSize = new System.Drawing.Size(338, 353);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.dataGridViewCiudad);
            this.Name = "ABMCiudad";
            this.Load += new System.EventHandler(this.ABMCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewCiudad;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button borrarButton;
    }
}