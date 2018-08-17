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
    public partial class Login : Form
    {
        DBConexion db = new DBConexion();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            

            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Al parecer te falto llenar el dato del Usuario.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();
            }
            else if (txt_clave.Text == "")
            {
                MessageBox.Show("Al parecer te falto llenar el dato de la Clave.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();
            }
            else
            {
                    db.CrearConexion();

                if (db.SelectVerificarLogin(txt_usuario.Text, txt_clave.Text))
                {
                    db.CerrarConexion();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado");
                    Application.Exit();
                }
                
            }

        }


    }
}
