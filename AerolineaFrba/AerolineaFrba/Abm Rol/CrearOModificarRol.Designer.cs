namespace AerolineaFrba.Abm_Rol
{
    partial class UpdateOrCreateView
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
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.nombreRolLabel = new System.Windows.Forms.Label();
            this.activoRolCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreRolTextBox = new System.Windows.Forms.TextBox();
            this.activoRolLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(147, 135);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(111, 38);
            this.cancelarButton.TabIndex = 0;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(23, 135);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(105, 38);
            this.aceptarButton.TabIndex = 1;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // nombreRolLabel
            // 
            this.nombreRolLabel.AutoSize = true;
            this.nombreRolLabel.Location = new System.Drawing.Point(20, 51);
            this.nombreRolLabel.Name = "nombreRolLabel";
            this.nombreRolLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreRolLabel.TabIndex = 2;
            this.nombreRolLabel.Text = "Nombre";
            // 
            // activoRolCheckBox
            // 
            this.activoRolCheckBox.AutoSize = true;
            this.activoRolCheckBox.Location = new System.Drawing.Point(102, 96);
            this.activoRolCheckBox.Name = "activoRolCheckBox";
            this.activoRolCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activoRolCheckBox.TabIndex = 3;
            this.activoRolCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreRolTextBox
            // 
            this.nombreRolTextBox.Location = new System.Drawing.Point(102, 44);
            this.nombreRolTextBox.Name = "nombreRolTextBox";
            this.nombreRolTextBox.Size = new System.Drawing.Size(156, 20);
            this.nombreRolTextBox.TabIndex = 4;
            // 
            // activoRolLabel
            // 
            this.activoRolLabel.AutoSize = true;
            this.activoRolLabel.Location = new System.Drawing.Point(20, 96);
            this.activoRolLabel.Name = "activoRolLabel";
            this.activoRolLabel.Size = new System.Drawing.Size(37, 13);
            this.activoRolLabel.TabIndex = 5;
            this.activoRolLabel.Text = "Activo";
            // 
            // UpdateOrCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.activoRolLabel);
            this.Controls.Add(this.nombreRolTextBox);
            this.Controls.Add(this.activoRolCheckBox);
            this.Controls.Add(this.nombreRolLabel);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cancelarButton);
            this.Name = "UpdateOrCreateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrCreateView";
            this.Load += new System.EventHandler(this.UpdateOrCreateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label nombreRolLabel;
        private System.Windows.Forms.CheckBox activoRolCheckBox;
        private System.Windows.Forms.TextBox nombreRolTextBox;
        private System.Windows.Forms.Label activoRolLabel;
    }
}

