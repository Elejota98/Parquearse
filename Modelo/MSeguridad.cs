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
        public static DataTable ListarConfiguracion()
        {
            Controlador.SeguridadController Datos = new Controlador.SeguridadController();
            return Datos.ListarDatosConfiguracion();
        }

        public static string ActualizarDatosConfiguracion(string idModulo, string Ip, string Mac, string Carril, string idTipoModulo)
        {
            Controlador.SeguridadController Datos = new Controlador.SeguridadController();
            return Datos.ActualizarDatosConfiguracion(idModulo, Ip, Mac, Carril, idTipoModulo);
        }
    }
}
