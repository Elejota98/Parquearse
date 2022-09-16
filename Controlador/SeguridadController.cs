using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class SeguridadController
    {
        public string GenerarCopiaBd(string ruta, string nombreCopiaBd, string nombreBaseDeDatos)
        {
            string Rta = "";
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                string rutaFinal = ""+ruta+""+nombreCopiaBd+"";
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("USE "+nombreBaseDeDatos+"; \n "+
                "BACKUP DATABASE Parking \n " +
                "TO DISK = '"+rutaFinal+"' \n"+
                "WITH FORMAT,\n MEDIANAME = 'SQLServerBackups', \n  NAME = 'Full Backup of SQLTestDB';");
                 SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                comando.ExecuteReader();
                Rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rta;

        }

        public DataTable ListarBaseDeDatos()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Controlador.ConexionController.getInstancia().CrearConexion();
                string cadena = ("SELECT name as 'BASE DE DATOS' FROM master.sys.databases");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                tabla.Load(rta);
                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }

        public DataTable ListarDatosConfiguracion()
        {

            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Controlador.ConexionController.getInstancia().CrearConexion();
                string cadena = ("Select * from T_Configuracion");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                tabla.Load(rta);
                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
    }
}
