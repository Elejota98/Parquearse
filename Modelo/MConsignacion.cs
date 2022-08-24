using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variable;
using Controlador;
using System.Data;

namespace Modelo
{
   public  class MConsignacion
    {
        public static DataTable BuscarConsignacion( string fecha1, string fecha2, int idEstacionamiento)
        {
            Controlador.ConsignacionesController Datos = new Controlador.ConsignacionesController();
            return Datos.BuscarConsignacion(fecha1,fecha2, idEstacionamiento);
        }

        public static string ActualizarConsignacion(int idConsignacion, int idEstacionamiento, string fechaConsignacion, int valor, string referencia, string documentoUsuario, int idDeposito, bool sincronizacion)
        {
            Controlador.ConsignacionesController Datos = new Controlador.ConsignacionesController();
            return Datos.ActualizarConsignacion(idConsignacion,idEstacionamiento,fechaConsignacion,valor,referencia,documentoUsuario,idDeposito,sincronizacion);
        }
   
        public static DataTable ListarEstacionamiento()
        {
            Controlador.ConsignacionesController Datos = new Controlador.ConsignacionesController();
            return Datos.ListarEstacionamiento();
        }
     

        public static DataTable ListarTipoConsignacion()
        {
            Controlador.ConsignacionesController Datos = new Controlador.ConsignacionesController();
            return Datos.ListarTipoConsignacion();
        }
    }
}
