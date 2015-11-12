namespace AerolineaFrba.Abm_Rol
{
    partial class FormRol
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.GbActivo = new System.Windows.Forms.GroupBox();
            this.RbNoActivo = new System.Windows.Forms.RadioButton();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GbActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(183, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Rol";
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Location = new System.Drawing.Point(64, 51);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(66, 13);
            this.lblNombreRol.TabIndex = 1;
            this.lblNombreRol.Text = "Nombre Rol:";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(136, 48);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(237, 20);
            this.txtNombreRol.TabIndex = 2;
            // 
            // GbActivo
            // 
            this.GbActivo.Controls.Add(this.RbNoActivo);
            this.GbActivo.Controls.Add(this.RbActivo);
            this.GbActivo.Location = new System.Drawing.Point(116, 83);
            this.GbActivo.Name = "GbActivo";
            this.GbActivo.Size = new System.Drawing.Size(257, 60);
            this.GbActivo.TabIndex = 4;
            this.GbActivo.TabStop = false;
            this.GbActivo.Text = "Activo / No Activo";
            // 
            // RbNoActivo
            // 
            this.RbNoActivo.AutoSize = true;
            this.RbNoActivo.Location = new System.Drawing.Point(131, 24);
            this.RbNoActivo.Name = "RbNoActivo";
            this.RbNoActivo.Size = new System.Drawing.Size(72, 17);
            this.RbNoActivo.TabIndex = 1;
            this.RbNoActivo.TabStop = true;
            this.RbNoActivo.Text = "No Activo";
            this.RbNoActivo.UseVisualStyleBackColor = true;
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Location = new System.Drawing.Point(14, 24);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(55, 17);
            this.RbActivo.TabIndex = 0;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "Activo";
            this.RbActivo.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(12, 162);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.Size = new System.Drawing.Size(464, 184);
            this.dgvFuncionalidades.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(206, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 424);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvFuncionalidades);
            this.Controls.Add(this.GbActivo);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lblNombreRol);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Rol";
            this.Load += new System.EventHandler(this.FormRol_Load);
            this.GbActivo.ResumeLayout(false);
            this.GbActivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.GroupBox GbActivo;
        private System.Windows.Forms.RadioButton RbNoActivo;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
        private System.Windows.Forms.Button btnGuardar;
    }
}
