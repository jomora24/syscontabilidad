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
    public partial class VerPlanCuenta : Form
    {
        DBConexion db = new DBConexion();
        public VerPlanCuenta()
        {
            
            InitializeComponent();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cargar_datos_Click(object sender, EventArgs e)
        {
            int fila = 0;
            db.CrearConexion();

            db.SelectPlanCuenta();

            while (db.rst.Read())
            {
                fila = dg_datos.Rows.Add();
                //nombre de la columna en el DataGrid - Nombre de la columna en la Base de datos
                dg_datos.Rows[fila].Cells["cCodCuenta"].Value = db.rst.GetString(db.rst.GetOrdinal("codigo_cuentas"));
                dg_datos.Rows[fila].Cells["cNomCuenta"].Value = db.rst.GetString(db.rst.GetOrdinal("nombre_cuentas"));
                dg_datos.Rows[fila].Cells["cTipoCuenta"].Value = db.rst.GetString(db.rst.GetOrdinal("tipo_cuentas"));
                dg_datos.Rows[fila].Cells["cTipoCP"].Value = db.rst.GetString(db.rst.GetOrdinal("tipo_cuentas_padre"));

            }
            db.CerrarConexion();
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
