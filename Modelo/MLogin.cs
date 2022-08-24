using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using Variable;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class MLogin
    {
        #region Funcion Login
        public static DataTable Login(string Usuario, string Clave)
        {
            UsuarioController Datos = new UsuarioController();
            return Datos.Login(Usuario, Clave);
        }

        #endregion
    }
}
