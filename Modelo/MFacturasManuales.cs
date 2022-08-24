using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Controlador;
using Variable;
using System.Threading.Tasks;

namespace Modelo
{
   public  class MFacturasManuales
    {

        #region Listados
        #region Listar Estacionamiento
        public static DataTable ListarEstacionamiento()
        {
            Controlador.FacManualesController Datos = new FacManualesController();
            return Datos.ListarEstacionamiento();
        }
        #endregion

        #region Listar Estacionamiento Modificar
        public static DataTable ListarEstacionamientoModificar(string idEstacionamiento)
        {
            Controlador.FacManualesController Datos = new FacManualesController();
            return Datos.ListarEstacionamientoModificar(idEstacionamiento);
        }
        #endregion

        #region Listar TipoCobro

        public static DataTable ListarTipoCobro()
        {
            Controlador.FacManualesController Datos = new Controlador.FacManualesController();
            return Datos.ListarTipoCobro();
        }
        #endregion

        #region Listar TipoCobro Modificar

        public static DataTable ListarTipoCobroModificar()
        {
            Controlador.FacManualesController Datos = new Controlador.FacManualesController();
            return Datos.ListarTipoCobroModificar();
        }
        #endregion

        #region Listar Carril

        public static DataTable ListarCarril()
        {
            Controlador.FacManualesController Datos = new Controlador.FacManualesController();
            return Datos.ListarCarril();
        }
        #endregion

        public static DataTable ListarUsuario()
        {
            Controlador.FacManualesController datos = new Controlador.FacManualesController();
            return datos.ListarUsuario();
        }
        public static DataTable ListarUsuarioModificar(string documentoUsuario)
        {
            Controlador.FacManualesController datos = new Controlador.FacManualesController();
            return datos.ListarUsuarioModificar(documentoUsuario);
        }
        public static DataTable ListarFacManuales(int idEstacionamiento, string fechadesde, string fechahasta)
        {
            Controlador.FacManualesController datos = new Controlador.FacManualesController();
            return datos.ListarFacManuales(idEstacionamiento, fechadesde, fechahasta);
        }
        #endregion

        #region Crud
        public static string InsertarFactura(string idModulo, int idEstacionamiento, string fechaPago, double subtotal, double iva, double total, string prefijo, int numerofactura, int idTipoVehiculo, int documentoUsuario)
        {
            Controlador.FacManualesController datos = new Controlador.FacManualesController();
            return datos.InsertarFactura(idModulo, idEstacionamiento, fechaPago, subtotal, iva, total, prefijo, numerofactura, idTipoVehiculo, documentoUsuario);
        }
        public static string ModificarFactura(string idModulo, int idEstacionamiento, string fechaPago, double subtotal, double iva, double total, string prefijo, int numerofactura, int idTipoVehiculo, int documentoUsuario)
        {
            Controlador.FacManualesController datos = new Controlador.FacManualesController();
            return datos.ModificarFactura(idModulo, idEstacionamiento, fechaPago, subtotal, iva, total, prefijo, numerofactura, idTipoVehiculo, documentoUsuario);
        }
        #endregion


    }
}
