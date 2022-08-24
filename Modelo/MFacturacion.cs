using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using Variable;
using System.Data;


namespace Modelo
{
    public class MFacturacion
    {
        #region Listar Factura
        public static DataTable ListarFactura(int NumeroFactura, int Estacionamiento)
        {
            Controlador.FacController Datos = new Controlador.FacController();
            return Datos.ListarFactura(NumeroFactura, Estacionamiento);

        }
        #endregion

        #region Listar Estacionamiento
        public static DataTable ListarEstacionamiento()
        {
            Controlador.FacController Datos = new Controlador.FacController();
            return Datos.ListarEstacionamiento();
        }
        #endregion

        #region Anular Factura

        public static string Anular(int num)
        {
            Controlador.FacController Datos = new Controlador.FacController();
            return Datos.Anular(num);
        }
        #endregion

        #region DesAnular Factura

        public static string DesAnular(int num)
        {
            Controlador.FacController Datos = new Controlador.FacController();
            return Datos.DesAnular(num);
        }
        #endregion

        #region Actualizar Resolucion 

        public static string ActualizarResolucion(string FacturaInicial, string FacturaFinal,
            string NumeroResolucion, string FechaResolucion, string FechaFinResolucion, int IdFacturacion, string Prefijo,
            int IdEstacionamiento)
        {
            Controlador.FacController Datos = new Controlador.FacController();
            VFacturacion Obj = new VFacturacion();
            Obj.FacturaInicial = FacturaInicial;
            Obj.FacturaFinal = FacturaFinal;
            Obj.NumeroResolucion = NumeroResolucion;
            Obj.FechaResolucion = FechaResolucion;
            Obj.FechaFinResolucion = FechaFinResolucion;
            Obj.IdFacturacion = IdFacturacion;
            Obj.Prefijo = Prefijo;
            Obj.IdEstacionamiento = IdEstacionamiento;
            return Datos.ActualizarResolucion(Obj);
        }
        #endregion

        #region Listar Factura
        public static DataTable ListarResolucion(int Estacionamiento)
        {
            Controlador.FacController Datos = new Controlador.FacController();
            return Datos.ListarDatosResolucion(Estacionamiento);

        }
        #endregion
    }
}
