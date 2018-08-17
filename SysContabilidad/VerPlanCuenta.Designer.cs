namespace SysContabilidad
{
    partial class VerPlanCuenta
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
            this.dg_datos = new System.Windows.Forms.DataGridView();
            this.cCodCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cargar_datos = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_datos
            // 
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodCuenta,
            this.cNomCuenta,
            this.cTipoCuenta,
            this.cTipoCP});
            this.dg_datos.Location = new System.Drawing.Point(12, 50);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.Size = new System.Drawing.Size(494, 342);
            this.dg_datos.TabIndex = 0;
            this.dg_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cCodCuenta
            // 
            this.cCodCuenta.HeaderText = "Codigo Cuenta";
            this.cCodCuenta.Name = "cCodCuenta";
            this.cCodCuenta.Width = 50;
            // 
            // cNomCuenta
            // 
            this.cNomCuenta.HeaderText = "Nombre Cuenta";
            this.cNomCuenta.Name = "cNomCuenta";
            this.cNomCuenta.Width = 250;
            // 
            // cTipoCuenta
            // 
            this.cTipoCuenta.HeaderText = "Tipo Cuenta";
            this.cTipoCuenta.Name = "cTipoCuenta";
            this.cTipoCuenta.Width = 50;
            // 
            // cTipoCP
            // 
            this.cTipoCP.HeaderText = "Tipo Cuenta Padre";
            this.cTipoCP.Name = "cTipoCP";
            // 
            // btn_cargar_datos
            // 
            this.btn_cargar_datos.Location = new System.Drawing.Point(546, 50);
            this.btn_cargar_datos.Name = "btn_cargar_datos";
            this.btn_cargar_datos.Size = new System.Drawing.Size(75, 42);
            this.btn_cargar_datos.TabIndex = 1;
            this.btn_cargar_datos.Text = "Cargar Datos";
            this.btn_cargar_datos.UseVisualStyleBackColor = true;
            this.btn_cargar_datos.Click += new System.EventHandler(this.btn_cargar_datos_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(546, 166);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 42);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // VerPlanCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cargar_datos);
            this.Controls.Add(this.dg_datos);
            this.Name = "VerPlanCuenta";
            this.Text = "VerPlanCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoCP;
        private System.Windows.Forms.Button btn_cargar_datos;
        private System.Windows.Forms.Button btn_cancelar;
    }
}