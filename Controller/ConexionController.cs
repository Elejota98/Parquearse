using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
     public class ConexionController
    {
        public SqlConnection CrearConexion()
        {

            SqlConnection Cadena = new SqlConnection(ConfigurationManager.ConnectionStrings["Vista.Properties.Settings.ParkingConnectionString"].ConnectionString);
            return Cadena;

        }

        public static Conexion getInstancia() //Por este metodo accedemos al metodo privado de conexion ya que como que el metodo es privado solo se puede por aca 
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
