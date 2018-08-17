namespace SysContabilidad
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planCuentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verPlanCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verParametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaContableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.sistemaContableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.planCuentasToolStripMenuItem1,
            this.verPlanCuentasToolStripMenuItem,
            this.verParametrosToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuracionToolStripMenuItem.Text = "Configuración";
            // 
            // planCuentasToolStripMenuItem1
            // 
            this.planCuentasToolStripMenuItem1.Name = "planCuentasToolStripMenuItem1";
            this.planCuentasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.planCuentasToolStripMenuItem1.Text = "Plan de Cuentas";
            this.planCuentasToolStripMenuItem1.Click += new System.EventHandler(this.planCuentasToolStripMenuItem1_Click);
            // 
            // verPlanCuentasToolStripMenuItem
            // 
            this.verPlanCuentasToolStripMenuItem.Name = "verPlanCuentasToolStripMenuItem";
            this.verPlanCuentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPlanCuentasToolStripMenuItem.Text = "Ver Plan Cuentas";
            this.verPlanCuentasToolStripMenuItem.Click += new System.EventHandler(this.verPlanCuentasToolStripMenuItem_Click);
            // 
            // verParametrosToolStripMenuItem
            // 
            this.verParametrosToolStripMenuItem.Name = "verParametrosToolStripMenuItem";
            this.verParametrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verParametrosToolStripMenuItem.Text = "Ver Parametros";
            this.verParametrosToolStripMenuItem.Click += new System.EventHandler(this.verParametrosToolStripMenuItem_Click);
            // 
            // sistemaContableToolStripMenuItem
            // 
            this.sistemaContableToolStripMenuItem.Name = "sistemaContableToolStripMenuItem";
            this.sistemaContableToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.sistemaContableToolStripMenuItem.Text = "Sistema Contable";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 521);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planCuentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sistemaContableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPlanCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verParametrosToolStripMenuItem;
    }
}

