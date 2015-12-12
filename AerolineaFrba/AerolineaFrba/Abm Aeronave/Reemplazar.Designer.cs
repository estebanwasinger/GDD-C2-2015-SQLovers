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
            this.btn_nvAer = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAeronaves)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgAeronaves);
            this.groupBox1.Controls.Add(this.btnReemp);
            this.groupBox1.Controls.Add(this.btn_nvAer);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posibles Aeronaves";
            // 
            // dtgAeronaves
            // 
            this.dtgAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAeronaves.Location = new System.Drawing.Point(6, 19);
            this.dtgAeronaves.Name = "dtgAeronaves";
            this.dtgAeronaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAeronaves.Size = new System.Drawing.Size(539, 158);
            this.dtgAeronaves.TabIndex = 0;
            // 
            // txtVuelo
            // 
            this.txtVuelo.Location = new System.Drawing.Point(63, 20);
            this.txtVuelo.Name = "txtVuelo";
            this.txtVuelo.Size = new System.Drawing.Size(100, 20);
            this.txtVuelo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vuelo";
            // 
            // btnReemp
            // 
            this.btnReemp.Location = new System.Drawing.Point(278, 183);
            this.btnReemp.Name = "btnReemp";
            this.btnReemp.Size = new System.Drawing.Size(267, 41);
            this.btnReemp.TabIndex = 4;
            this.btnReemp.Text = "Reemplazar";
            this.btnReemp.UseVisualStyleBackColor = true;
            this.btnReemp.Click += new System.EventHandler(this.btnReemp_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aeronave";
            // 
            // txtAeron
            // 
            this.txtAeron.Location = new System.Drawing.Point(251, 20);
            this.txtAeron.Name = "txtAeron";
            this.txtAeron.Size = new System.Drawing.Size(100, 20);
            this.txtAeron.TabIndex = 6;
            // 
            // btn_nvAer
            // 
            this.btn_nvAer.Location = new System.Drawing.Point(6, 183);
            this.btn_nvAer.Name = "btn_nvAer";
            this.btn_nvAer.Size = new System.Drawing.Size(266, 41);
            this.btn_nvAer.TabIndex = 7;
            this.btn_nvAer.Text = "Nueva Aeronave";
            this.btn_nvAer.UseVisualStyleBackColor = true;
            this.btn_nvAer.Click += new System.EventHandler(this.btnNvaAero_click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(152, 333);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(132, 35);
            this.btnRefrescar.TabIndex = 8;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefresh_click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(18, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtVuelo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAeron);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Vuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(181, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reemplazar Aeronave";
            // 
            // Reemplazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reemplazar";
            this.Text = "Reemplazar";
            this.Load += new System.EventHandler(this.FormReemplazar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAeronaves)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btn_nvAer;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}