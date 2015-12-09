namespace AerolineaFrba.Consulta_Millas
{
    partial class ConsultaMillas
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
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridViewMillas = new System.Windows.Forms.DataGridView();
            this.dataGridViewCanjes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMillas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanjes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(80, 11);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.ReadOnly = true;
            this.textBoxDni.Size = new System.Drawing.Size(100, 20);
            this.textBoxDni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente DNI";
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(198, 9);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(126, 23);
            this.buttonBuscarCliente.TabIndex = 2;
            this.buttonBuscarCliente.Text = "Buscar Cliente";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // dataGridViewMillas
            // 
            this.dataGridViewMillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMillas.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewMillas.Name = "dataGridViewMillas";
            this.dataGridViewMillas.Size = new System.Drawing.Size(296, 168);
            this.dataGridViewMillas.TabIndex = 3;
            // 
            // dataGridViewCanjes
            // 
            this.dataGridViewCanjes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanjes.Location = new System.Drawing.Point(329, 43);
            this.dataGridViewCanjes.Name = "dataGridViewCanjes";
            this.dataGridViewCanjes.Size = new System.Drawing.Size(293, 168);
            this.dataGridViewCanjes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Millas acumuladas:";
            // 
            // textBoxMillas
            // 
            this.textBoxMillas.Location = new System.Drawing.Point(123, 284);
            this.textBoxMillas.Name = "textBoxMillas";
            this.textBoxMillas.ReadOnly = true;
            this.textBoxMillas.Size = new System.Drawing.Size(100, 20);
            this.textBoxMillas.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridViewMillas);
            this.groupBox1.Controls.Add(this.dataGridViewCanjes);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 228);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxDni);
            this.groupBox2.Controls.Add(this.buttonBuscarCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 37);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(449, 280);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(197, 30);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(445, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Canjes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(119, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Millas";
            // 
            // ConsultaMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 323);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMillas);
            this.Name = "ConsultaMillas";
            this.Text = "Consulta Millas";
            this.Load += new System.EventHandler(this.ConsultaMillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanjes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridViewMillas;
        private System.Windows.Forms.DataGridView dataGridViewCanjes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMillas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}