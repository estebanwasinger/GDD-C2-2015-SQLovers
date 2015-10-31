namespace AerolineaFrba.Abm_Rol
{
    partial class AltaRol
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
            this.Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoActivo = new System.Windows.Forms.RadioButton();
            this.Activo = new System.Windows.Forms.RadioButton();
            this.BtnGuar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(148, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(48, 13);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "AltaRol";
            this.Titulo.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(89, 52);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(158, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoActivo);
            this.groupBox1.Controls.Add(this.Activo);
            this.groupBox1.Location = new System.Drawing.Point(47, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activo/NoActivo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NoActivo
            // 
            this.NoActivo.AutoSize = true;
            this.NoActivo.Location = new System.Drawing.Point(109, 31);
            this.NoActivo.Name = "NoActivo";
            this.NoActivo.Size = new System.Drawing.Size(69, 17);
            this.NoActivo.TabIndex = 1;
            this.NoActivo.TabStop = true;
            this.NoActivo.Text = "NoActivo";
            this.NoActivo.UseVisualStyleBackColor = true;
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Location = new System.Drawing.Point(6, 31);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(55, 17);
            this.Activo.TabIndex = 0;
            this.Activo.TabStop = true;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = true;
            this.Activo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BtnGuar
            // 
            this.BtnGuar.Location = new System.Drawing.Point(114, 224);
            this.BtnGuar.Name = "BtnGuar";
            this.BtnGuar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuar.TabIndex = 4;
            this.BtnGuar.Text = "Guardar";
            this.BtnGuar.UseVisualStyleBackColor = true;
            this.BtnGuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 267);
            this.Controls.Add(this.BtnGuar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titulo);
            this.Name = "AltaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaRol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoActivo;
        private System.Windows.Forms.RadioButton Activo;
        private System.Windows.Forms.Button BtnGuar;
    }
}
