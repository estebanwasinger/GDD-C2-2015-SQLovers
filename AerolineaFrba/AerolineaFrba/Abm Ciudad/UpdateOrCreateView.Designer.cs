namespace AerolineaFrba.Abm_Ciudad
{
    partial class UpdateOrCreateView
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
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.nombreCiudadLabel = new System.Windows.Forms.Label();
            this.estadoCiudadCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreCiudadTextBox = new System.Windows.Forms.TextBox();
            this.estadoCiudadLabel = new System.Windows.Forms.Label();
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
            // nombreCiudadLabel
            // 
            this.nombreCiudadLabel.AutoSize = true;
            this.nombreCiudadLabel.Location = new System.Drawing.Point(20, 51);
            this.nombreCiudadLabel.Name = "nombreCiudadLabel";
            this.nombreCiudadLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreCiudadLabel.TabIndex = 2;
            this.nombreCiudadLabel.Text = "Nombre";
            // 
            // estadoCiudadCheckBox
            // 
            this.estadoCiudadCheckBox.AutoSize = true;
            this.estadoCiudadCheckBox.Location = new System.Drawing.Point(102, 96);
            this.estadoCiudadCheckBox.Name = "estadoCiudadCheckBox";
            this.estadoCiudadCheckBox.Size = new System.Drawing.Size(15, 14);
            this.estadoCiudadCheckBox.TabIndex = 3;
            this.estadoCiudadCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreCiudadTextBox
            // 
            this.nombreCiudadTextBox.Location = new System.Drawing.Point(102, 44);
            this.nombreCiudadTextBox.Name = "nombreCiudadTextBox";
            this.nombreCiudadTextBox.Size = new System.Drawing.Size(156, 20);
            this.nombreCiudadTextBox.TabIndex = 4;
            // 
            // estadoCiudadLabel
            // 
            this.estadoCiudadLabel.AutoSize = true;
            this.estadoCiudadLabel.Location = new System.Drawing.Point(20, 96);
            this.estadoCiudadLabel.Name = "estadoCiudadLabel";
            this.estadoCiudadLabel.Size = new System.Drawing.Size(37, 13);
            this.estadoCiudadLabel.TabIndex = 5;
            this.estadoCiudadLabel.Text = "Activo";
            // 
            // UpdateOrCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.estadoCiudadLabel);
            this.Controls.Add(this.nombreCiudadTextBox);
            this.Controls.Add(this.estadoCiudadCheckBox);
            this.Controls.Add(this.nombreCiudadLabel);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cancelarButton);
            this.Name = "UpdateOrCreateView";
            this.Text = "UpdateOrCreateView";
            this.Load += new System.EventHandler(this.UpdateOrCreateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label nombreCiudadLabel;
        private System.Windows.Forms.CheckBox estadoCiudadCheckBox;
        private System.Windows.Forms.TextBox nombreCiudadTextBox;
        private System.Windows.Forms.Label estadoCiudadLabel;
    }
}