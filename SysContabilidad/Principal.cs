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
    public partial class Principal : Form
    { 

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.ShowDialog();
        }

        private void planCuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PlanCuentas formPlanCuentas = new PlanCuentas();
            formPlanCuentas.MdiParent = this;
            formPlanCuentas.Show();
        }

        private void verPlanCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPlanCuenta formVerPlanCuenta = new VerPlanCuenta();
            formVerPlanCuenta.MdiParent = this;
            formVerPlanCuenta.Show();
        }

        private void verParametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerParametros formVerPatametros = new VerParametros();
            formVerPatametros.MdiParent = this;
            formVerPatametros.Show();
        }
    }
}
