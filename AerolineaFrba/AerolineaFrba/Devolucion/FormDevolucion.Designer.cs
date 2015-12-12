namespace AerolineaFrba.Devolucion
{
    partial class FormDevolucion
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
            System.Windows.Forms.Label label2;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgPasajes = new System.Windows.Forms.DataGridView();
            this.Pasajes = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgEncomiendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Detalle = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajes)).BeginInit();
            this.Pasajes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncomiendas)).BeginInit();
            this.Detalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Devolver Pasaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPasaje_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Devolver Encomienda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEncomienda_Click);
            // 
            // dtgPasajes
            // 
            this.dtgPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPasajes.Location = new System.Drawing.Point(6, 65);
            this.dtgPasajes.Name = "dtgPasajes";
            this.dtgPasajes.Size = new System.Drawing.Size(246, 169);
            this.dtgPasajes.TabIndex = 2;
            // 
            // Pasajes
            // 
            this.Pasajes.Controls.Add(this.dtgPasajes);
            this.Pasajes.Controls.Add(this.button1);
            this.Pasajes.Location = new System.Drawing.Point(12, 49);
            this.Pasajes.Name = "Pasajes";
            this.Pasajes.Size = new System.Drawing.Size(264, 240);
            this.Pasajes.TabIndex = 3;
            this.Pasajes.TabStop = false;
            this.Pasajes.Text = "Pasajes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgEncomiendas);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(282, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encomiendas";
            // 
            // dtgEncomiendas
            // 
            this.dtgEncomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEncomiendas.Location = new System.Drawing.Point(6, 65);
            this.dtgEncomiendas.Name = "dtgEncomiendas";
            this.dtgEncomiendas.Size = new System.Drawing.Size(245, 169);
            this.dtgEncomiendas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detalle Devolucion:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(140, 19);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(381, 20);
            this.txtDetalle.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(288, 355);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(245, 33);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(18, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(246, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Detalle
            // 
            this.Detalle.Controls.Add(this.txtDetalle);
            this.Detalle.Controls.Add(this.label1);
            this.Detalle.Location = new System.Drawing.Point(12, 295);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(533, 54);
            this.Detalle.TabIndex = 11;
            this.Detalle.TabStop = false;
            this.Detalle.Text = "Detalle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            label2.Location = new System.Drawing.Point(109, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(346, 25);
            label2.TabIndex = 12;
            label2.Text = "Devolucion de pasajes y encomiendas";
            // 
            // FormDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 398);
            this.Controls.Add(label2);
            this.Controls.Add(this.Detalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Pasajes);
            this.Name = "FormDevolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajes)).EndInit();
            this.Pasajes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncomiendas)).EndInit();
            this.Detalle.ResumeLayout(false);
            this.Detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgPasajes;
        private System.Windows.Forms.GroupBox Pasajes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgEncomiendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox Detalle;
    }
}