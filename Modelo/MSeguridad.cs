using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Data;
namespace Modelo
{
    public class MSeguridad
    {
        public static string GenerarCopiaBd(string ruta, string nombreCopiaBd, string nombreBaseDeDatos)
        {
            Controlador.SeguridadController Datos = new Controlador.SeguridadController();
            return Datos.GenerarCopiaBd(ruta,nombreCopiaBd, nombreBaseDeDatos);
        }
        public static DataTable ListarBaseDeDatos()
        {
            Controlador.SeguridadController Datos = new Controlador.SeguridadController();
            return Datos.ListarBaseDeDatos();
        }
    }
}
