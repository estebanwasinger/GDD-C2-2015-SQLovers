namespace AerolineaFrba.Abm_Rol
{
    partial class ABMRol
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
            this.dataGridViewRol = new System.Windows.Forms.DataGridView();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRol
            // 
            this.dataGridViewRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRol.Location = new System.Drawing.Point(14, 64);
            this.dataGridViewRol.Name = "dataGridViewRol";
            this.dataGridViewRol.Size = new System.Drawing.Size(537, 213);
            this.dataGridViewRol.TabIndex = 0;
            this.dataGridViewRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRol_CellContentClick);
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(259, 304);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(75, 23);
            this.btnCrearRol.TabIndex = 4;
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listado de Roles";

            // 
            // ABMRol
            // 
            this.ClientSize = new System.Drawing.Size(563, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.dataGridViewRol);
            this.Name = "ABMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ABMRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        
        private System.Windows.Forms.DataGridView dataGridViewRol;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.Label label1;

       

    }
}
