namespace AerolineaFrba.Compra
{
    partial class CrearDatosPasajero
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
            this.textBoxNombrePasajero = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDireccionpasajero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelefonoPasajero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMailPasajero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxApellidoPasajero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombrePasajero
            // 
            this.textBoxNombrePasajero.Location = new System.Drawing.Point(103, 46);
            this.textBoxNombrePasajero.Name = "textBoxNombrePasajero";
            this.textBoxNombrePasajero.Size = new System.Drawing.Size(229, 20);
            this.textBoxNombrePasajero.TabIndex = 1;
            this.textBoxNombrePasajero.TextChanged += new System.EventHandler(this.validar);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(103, 98);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(229, 20);
            this.textBoxDNI.TabIndex = 3;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // textBoxDireccionpasajero
            // 
            this.textBoxDireccionpasajero.Location = new System.Drawing.Point(103, 124);
            this.textBoxDireccionpasajero.Name = "textBoxDireccionpasajero";
            this.textBoxDireccionpasajero.Size = new System.Drawing.Size(229, 20);
            this.textBoxDireccionpasajero.TabIndex = 5;
            this.textBoxDireccionpasajero.TextChanged += new System.EventHandler(this.validar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección";
            // 
            // textBoxTelefonoPasajero
            // 
            this.textBoxTelefonoPasajero.Location = new System.Drawing.Point(103, 150);
            this.textBoxTelefonoPasajero.Name = "textBoxTelefonoPasajero";
            this.textBoxTelefonoPasajero.Size = new System.Drawing.Size(229, 20);
            this.textBoxTelefonoPasajero.TabIndex = 7;
            this.textBoxTelefonoPasajero.TextChanged += new System.EventHandler(this.validar);
            this.textBoxTelefonoPasajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono";
            // 
            // textBoxMailPasajero
            // 
            this.textBoxMailPasajero.Location = new System.Drawing.Point(103, 202);
            this.textBoxMailPasajero.Name = "textBoxMailPasajero";
            this.textBoxMailPasajero.Size = new System.Drawing.Size(229, 20);
            this.textBoxMailPasajero.TabIndex = 9;
            this.textBoxMailPasajero.TextChanged += new System.EventHandler(this.validar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de Nac.";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(103, 176);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(229, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 11;
            // 
            // textBoxApellidoPasajero
            // 
            this.textBoxApellidoPasajero.Location = new System.Drawing.Point(103, 72);
            this.textBoxApellidoPasajero.Name = "textBoxApellidoPasajero";
            this.textBoxApellidoPasajero.Size = new System.Drawing.Size(229, 20);
            this.textBoxApellidoPasajero.TabIndex = 13;
            this.textBoxApellidoPasajero.TextChanged += new System.EventHandler(this.validar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Apellido";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(168, 238);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(164, 43);
            this.buttonConfirmar.TabIndex = 14;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 238);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 43);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Datos Cliente";
            // 
            // CrearDatosPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 291);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxApellidoPasajero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMailPasajero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelefonoPasajero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDireccionpasajero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombrePasajero);
            this.Controls.Add(this.label1);
            this.Name = "CrearDatosPasajero";
            this.Text = "Datos Cliente";
            this.Load += new System.EventHandler(this.DatosPasajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombrePasajero;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDireccionpasajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelefonoPasajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMailPasajero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxApellidoPasajero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label8;
    }
}