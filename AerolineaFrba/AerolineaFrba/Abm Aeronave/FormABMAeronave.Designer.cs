namespace AerolineaFrba.Abm_Aeronave
{
    partial class FormABMAeronave
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_fueraServ = new System.Windows.Forms.Button();
            this.btn_bdef = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtfabri = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgAeoronave = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAeoronave)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_fueraServ);
            this.groupBox1.Controls.Add(this.btn_bdef);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.txtfabri);
            this.groupBox1.Controls.Add(this.txtmodelo);
            this.groupBox1.Controls.Add(this.txtmatricula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(339, 73);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Peso Disp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_fueraServ
            // 
            this.btn_fueraServ.Location = new System.Drawing.Point(323, 124);
            this.btn_fueraServ.Name = "btn_fueraServ";
            this.btn_fueraServ.Size = new System.Drawing.Size(75, 37);
            this.btn_fueraServ.TabIndex = 8;
            this.btn_fueraServ.Text = "Baja Tecnica";
            this.btn_fueraServ.UseVisualStyleBackColor = true;
            this.btn_fueraServ.Click += new System.EventHandler(this.btn_bTecnica_Click);
            // 
            // btn_bdef
            // 
            this.btn_bdef.Location = new System.Drawing.Point(186, 124);
            this.btn_bdef.Name = "btn_bdef";
            this.btn_bdef.Size = new System.Drawing.Size(75, 37);
            this.btn_bdef.TabIndex = 7;
            this.btn_bdef.Text = "Baja Definitiva";
            this.btn_bdef.UseVisualStyleBackColor = true;
            this.btn_bdef.Click += new System.EventHandler(this.btn_bDef_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(46, 124);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 37);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtfabri
            // 
            this.txtfabri.Location = new System.Drawing.Point(339, 32);
            this.txtfabri.Name = "txtfabri";
            this.txtfabri.Size = new System.Drawing.Size(100, 20);
            this.txtfabri.TabIndex = 5;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(111, 74);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 4;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(111, 32);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // dtgAeoronave
            // 
            this.dtgAeoronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAeoronave.Location = new System.Drawing.Point(62, 268);
            this.dtgAeoronave.Name = "dtgAeoronave";
            this.dtgAeoronave.Size = new System.Drawing.Size(449, 164);
            this.dtgAeoronave.TabIndex = 1;
            this.dtgAeoronave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(364, 222);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // FormABMAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtgAeoronave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormABMAeronave";
            this.Text = "FormABMAeronave";
            this.Load += new System.EventHandler(this.frmABMAeronave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAeoronave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_fueraServ;
        private System.Windows.Forms.Button btn_bdef;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtfabri;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgAeoronave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}