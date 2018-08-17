namespace SysContabilidad
{
    partial class PlanCuentas
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.txt_gestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tipo_cuentas_padres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tipo_cuentas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_cuentas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_cuentas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(164, 247);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(58, 247);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrar.TabIndex = 32;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // txt_gestion
            // 
            this.txt_gestion.Location = new System.Drawing.Point(164, 175);
            this.txt_gestion.Name = "txt_gestion";
            this.txt_gestion.Size = new System.Drawing.Size(100, 20);
            this.txt_gestion.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tipos Cuentas";
            // 
            // txt_tipo_cuentas_padres
            // 
            this.txt_tipo_cuentas_padres.Location = new System.Drawing.Point(164, 143);
            this.txt_tipo_cuentas_padres.Name = "txt_tipo_cuentas_padres";
            this.txt_tipo_cuentas_padres.Size = new System.Drawing.Size(100, 20);
            this.txt_tipo_cuentas_padres.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gestion";
            // 
            // txt_tipo_cuentas
            // 
            this.txt_tipo_cuentas.Location = new System.Drawing.Point(164, 103);
            this.txt_tipo_cuentas.Name = "txt_tipo_cuentas";
            this.txt_tipo_cuentas.Size = new System.Drawing.Size(100, 20);
            this.txt_tipo_cuentas.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipos Cuentas Padre";
            // 
            // txt_nombre_cuentas
            // 
            this.txt_nombre_cuentas.Location = new System.Drawing.Point(164, 66);
            this.txt_nombre_cuentas.Name = "txt_nombre_cuentas";
            this.txt_nombre_cuentas.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_cuentas.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre Cuentas";
            // 
            // txt_codigo_cuentas
            // 
            this.txt_codigo_cuentas.Location = new System.Drawing.Point(164, 29);
            this.txt_codigo_cuentas.Name = "txt_codigo_cuentas";
            this.txt_codigo_cuentas.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_cuentas.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo Cuentas";
            // 
            // PlanCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 344);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_gestion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tipo_cuentas_padres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tipo_cuentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_cuentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo_cuentas);
            this.Controls.Add(this.label1);
            this.Name = "PlanCuentas";
            this.Text = "PlanCuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox txt_gestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tipo_cuentas_padres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tipo_cuentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_cuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo_cuentas;
        private System.Windows.Forms.Label label1;
    }
}