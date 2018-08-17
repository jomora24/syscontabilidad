using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysContabilidad
{
    class DBConexion
    {
        static MySqlConnection Conexion = new MySqlConnection();
        static string Servidor = "Server = localhost;";
        static string BD = "Database = dbcontabilidad;";
        static string Usuario = "UID = root;";
        static string Clave = "Password = ;";

        string CadenaConexion = Servidor + BD + Usuario + Clave;

        static MySqlCommand Comando = new MySqlCommand();
        static MySqlDataAdapter Adaptador = new MySqlDataAdapter();
        public MySqlDataReader rst;

        public void CrearConexion()
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                //MessageBox.Show("Conexion Creada");
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexion");
                throw;
            }
        }

        public void CerrarConexion()
        {
            Conexion.Close();
        }

        public void InsertPlanCuenta(String codigo_cuenta, String nombre_cuenta, String tipo_cuenta, String tipo_cuenta_padre, int gestion)
        {

            string strSQL = "INSERT INTO plan_cuentas VALUES( 0,'" + codigo_cuenta + "','" + nombre_cuenta + "','" + tipo_cuenta + "','" + tipo_cuenta_padre + "'," + gestion + " )";
            Comando.CommandText = strSQL;
            Comando.Connection = Conexion;
            Comando.ExecuteNonQuery();

        }

        public void SelectPlanCuenta()
        {

            try
            {
                string strSQL = "SELECT * FROM plan_cuentas";
                Comando.CommandText = strSQL;
                Comando.Connection = Conexion;
                rst = Comando.ExecuteReader();

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexion");
                throw;
            }



        }
        public void SelectPlanCuentaPorCodigo(string codigo)
        {

            try
            {
                string strSQL = "SELECT * FROM plan_cuentas WHERE codigo_cuenta = '" + codigo + "'";
                Comando.CommandText = strSQL;
                Comando.Connection = Conexion;
                rst = Comando.ExecuteReader();

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexion");
                throw;
            }



        }

        public void InsertarParametros(int gestion_actual, String contador, String gerente, String empresa, String nit, String direccion, string telefono)
        {
            string strSQL = "INSERT INTO parametros VALUES( " + gestion_actual + "','" + contador + "','" + gerente + "','" + empresa + "','" + nit + "','" + direccion + "','" + telefono + "')";
            Comando.CommandText = strSQL;
            Comando.Connection = Conexion;
            Comando.ExecuteNonQuery();
        }

        public void SelectParametros()
        {
            try
            {
                string strSQL = "SELECT * FROM parametros";
                Comando.CommandText = strSQL;
                Comando.Connection = Conexion;
                rst = Comando.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexion");
                throw;
            }
        }

        public void UpdateParametros(string contador, string gerente, string direccion, string telefono ){
            try
            {
                string strSQL = "UPDATE parametros SET contador = '" + contador + "',gerente = '" + gerente + "', direccion = '"+ direccion + "', telefono = '"+ telefono +"'";
                Comando.CommandText = strSQL;
                Comando.Connection = Conexion;
                Comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool SelectVerificarLogin(string login,string clave) {

            string strSQL = "SELECT * FROM usuarios WHERE login = '" + login + "' AND clave = '" + clave + "' AND estado = 'activo' ";
            Comando.CommandText = strSQL;
            Comando.Connection = Conexion;
            rst = Comando.ExecuteReader();
            return rst.HasRows;            
        }
    }
}
