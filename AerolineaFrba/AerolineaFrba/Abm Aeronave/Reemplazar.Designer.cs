namespace AerolineaFrba.Abm_Aeronave
{
    partial class Reemplazar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgAeronaves = new System.Windows.Forms.DataGridView();
            this.txtVuelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReemp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAeron = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgAeronaves);
            this.groupBox1.Location = new System.Drawing.Point(56, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posibles Aeronaves";
            // 
            // dtgAeronaves
            // 
            this.dtgAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAeronaves.Location = new System.Drawing.Point(20, 19);
            this.dtgAeronaves.Name = "dtgAeronaves";
            this.dtgAeronaves.Size = new System.Drawing.Size(514, 158);
            this.dtgAeronaves.TabIndex = 0;
            // 
            // txtVuelo
            // 
            this.txtVuelo.Location = new System.Drawing.Point(120, 36);
            this.txtVuelo.Name = "txtVuelo";
            this.txtVuelo.Size = new System.Drawing.Size(100, 20);
            this.txtVuelo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vuelo";
            // 
            // btnReemp
            // 
            this.btnReemp.Location = new System.Drawing.Point(76, 304);
            this.btnReemp.Name = "btnReemp";
            this.btnReemp.Size = new System.Drawing.Size(128, 23);
            this.btnReemp.TabIndex = 4;
            this.btnReemp.Text = "Reemplazar";
            this.btnReemp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aeronave";
            // 
            // txtAeron
            // 
            this.txtAeron.Location = new System.Drawing.Point(312, 36);
            this.txtAeron.Name = "txtAeron";
            this.txtAeron.Size = new System.Drawing.Size(100, 20);
            this.txtAeron.TabIndex = 6;
            // 
            // Reemplazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 361);
            this.Controls.Add(this.txtAeron);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVuelo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reemplazar";
            this.Text = "Reemplazar";
            this.Load += new System.EventHandler(this.FormReemplazar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgAeronaves;
        private System.Windows.Forms.TextBox txtVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAeron;
    }
}