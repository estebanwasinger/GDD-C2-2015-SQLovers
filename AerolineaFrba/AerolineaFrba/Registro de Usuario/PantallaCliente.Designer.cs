namespace AerolineaFrba.Registro_de_Usuario
{
    partial class PantallaCliente
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCanjMillas = new System.Windows.Forms.Button();
            this.btnConsMillas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(63, 31);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(288, 46);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.buttonCompra_Click);
            // 
            // btnCanjMillas
            // 
            this.btnCanjMillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanjMillas.Location = new System.Drawing.Point(63, 155);
            this.btnCanjMillas.Name = "btnCanjMillas";
            this.btnCanjMillas.Size = new System.Drawing.Size(288, 46);
            this.btnCanjMillas.TabIndex = 1;
            this.btnCanjMillas.Text = "Canjear Millas";
            this.btnCanjMillas.UseVisualStyleBackColor = true;
            this.btnCanjMillas.Click += new System.EventHandler(this.buttonCanjeMillas_Click);
            // 
            // btnConsMillas
            // 
            this.btnConsMillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsMillas.Location = new System.Drawing.Point(63, 92);
            this.btnConsMillas.Name = "btnConsMillas";
            this.btnConsMillas.Size = new System.Drawing.Size(288, 46);
            this.btnConsMillas.TabIndex = 2;
            this.btnConsMillas.Text = "Consultar Millas";
            this.btnConsMillas.UseVisualStyleBackColor = true;
            this.btnConsMillas.Click += new System.EventHandler(this.buttonConsultarMillas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(158, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // PantallaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 277);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsMillas);
            this.Controls.Add(this.btnCanjMillas);
            this.Controls.Add(this.btnComprar);
            this.Name = "PantallaCliente";
            this.Text = "Hola Cliente!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCanjMillas;
        private System.Windows.Forms.Button btnConsMillas;
        private System.Windows.Forms.Button btnCancelar;
    }
}