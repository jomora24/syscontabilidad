using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysContabilidad
{
    public partial class PlanCuentas : Form
    {
        DBConexion db = new DBConexion();
        public PlanCuentas()
        {
            InitializeComponent();
        }

        public void LimpiarEdits() {

            txt_codigo_cuentas.Text = "";
            txt_gestion.Text = "";
            txt_nombre_cuentas.Text = "";
            txt_tipo_cuentas.Text = "";
            txt_tipo_cuentas_padres.Text = "";
            txt_codigo_cuentas.Focus();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if ((txt_codigo_cuentas.Text == "") || (txt_nombre_cuentas.Text == "") || (txt_tipo_cuentas.Text == "") || (txt_tipo_cuentas_padres.Text == "") || (txt_gestion.Text) == "")
            {
                //MessageBox.Show("Faltan Datos por Ingresar", "Mensaje de Error",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                MessageBox.Show("Faltan Datos por Ingresar", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.CrearConexion();
                db.SelectPlanCuentaPorCodigo(txt_codigo_cuentas.Text);
                try
                {
                    if (!db.rst.HasRows)
                    {
                        db.InsertPlanCuenta(txt_codigo_cuentas.Text, txt_nombre_cuentas.Text, txt_tipo_cuentas.Text, txt_tipo_cuentas_padres.Text, Convert.ToInt32(txt_gestion.Text));
                        MessageBox.Show("Cuenta Registrada con exito!!!");
                        LimpiarEdits();
                    }
                    else
                    {
                        MessageBox.Show("El Codigo:" + txt_codigo_cuentas.Text + " ya Existe");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en registro");
                    throw;
                }
                db.CerrarConexion();
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
