namespace AerolineaFrba.Devolucion
{
    partial class DevolucionEncomienda
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
            this.dtgEncomienda = new System.Windows.Forms.DataGridView();
            this.txtEnc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncomienda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEncomienda
            // 
            this.dtgEncomienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEncomienda.Location = new System.Drawing.Point(82, 65);
            this.dtgEncomienda.Name = "dtgEncomienda";
            this.dtgEncomienda.Size = new System.Drawing.Size(300, 163);
            this.dtgEncomienda.TabIndex = 7;
            // 
            // txtEnc
            // 
            this.txtEnc.Location = new System.Drawing.Point(135, 26);
            this.txtEnc.Name = "txtEnc";
            this.txtEnc.Size = new System.Drawing.Size(140, 20);
            this.txtEnc.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo Encomienda";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Continuar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // DevolucionEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 286);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgEncomienda);
            this.Controls.Add(this.txtEnc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionEncomienda";
            this.Text = "DevolucionEncomienda";
            this.Load += new System.EventHandler(this.DevolucionEncomienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncomienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEncomienda;
        private System.Windows.Forms.TextBox txtEnc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}