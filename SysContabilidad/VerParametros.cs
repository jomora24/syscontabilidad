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
    public partial class VerParametros : Form
    {
        DBConexion db = new DBConexion();
        public VerParametros()
        {
            InitializeComponent();

            db.CrearConexion();
            db.SelectParametros();
            db.rst.Read();

            txt_gestion_actual.ReadOnly = true;
            txt_contador.ReadOnly = true;
            txt_gerente.ReadOnly = true;
            txt_empresa.ReadOnly = true;
            txt_nit.ReadOnly = true;
            txt_direccion.ReadOnly = true;
            txt_telefono.ReadOnly = true;

            txt_gestion_actual.Text = Convert.ToString(db.rst.GetInt32(db.rst.GetOrdinal("gestion_actual")));
            txt_contador.Text = db.rst.GetString(db.rst.GetOrdinal("contador"));
            txt_gerente.Text = db.rst.GetString(db.rst.GetOrdinal("gerente"));
            txt_empresa.Text = db.rst.GetString(db.rst.GetOrdinal("empresa"));
            txt_nit.Text = db.rst.GetString(db.rst.GetOrdinal("nit"));
            txt_direccion.Text = db.rst.GetString(db.rst.GetOrdinal("direccion"));
            txt_telefono.Text = db.rst.GetString(db.rst.GetOrdinal("telefono"));

            btn_aceptar.Visible = false;

            db.CerrarConexion();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_contador.ReadOnly = false;
            txt_gerente.ReadOnly = false;
            txt_direccion.ReadOnly = false;
            txt_telefono.ReadOnly = false;

            btn_editar.Visible = false;
            btn_aceptar.Visible = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_contador.Text == "")
            {
                MessageBox.Show("Al parecer te falto llenar el dato del Contador.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contador.Focus();
            }
            else if (txt_gerente.Text == "")
            {
                MessageBox.Show("Al parecer te falto llenar el dato del Gerente.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_gerente.Focus();
            }
            else if (txt_direccion.Text == "")
            {
                MessageBox.Show("Al parecer te falto llenar el dato de la Direccion.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_direccion.Focus();
            }
            else if (txt_telefono.Text == "")
            {
                MessageBox.Show("Al parecer te falto llenar el dato del Telefono.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telefono.Focus();
            }            
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de editar los datos", "Alerta de Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        db.CrearConexion();
                        db.UpdateParametros(txt_contador.Text, txt_gerente.Text, txt_direccion.Text, txt_telefono.Text);
                        db.CerrarConexion();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Al actualizar datos");
                        throw;
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
                
                
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
