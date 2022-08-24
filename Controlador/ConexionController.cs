using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ConexionController
    {
        private static ConexionController con = null;
        public SqlConnection CrearConexion()
        {
          
                SqlConnection Cadena = new SqlConnection(ConfigurationManager.ConnectionStrings["Operaciones.Properties.Settings.ConnectionString"].ConnectionString);
            return Cadena;

        }

        public static ConexionController getInstancia() //Por este metodo accedemos al metodo privado de conexion ya que como que el metodo es privado solo se puede por aca 
        {
            if (con == null)
            {
                con = new ConexionController();
            }
            return con;
        }

    }
}
