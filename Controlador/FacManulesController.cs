using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class FacManualesController
    {
        #region Listar Estacionamiento


        public DataTable ListarEstacionamiento()
        {
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("Select IdEstacionamiento,Nombre from T_Estacionamientos");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                Tabla.Load(rta);
                return Tabla;

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
        #endregion     

        #region Listar Tipo Cobro

        public DataTable ListarTipoCobro()
        {

            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = "select * from t_tipovehiculo";
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                Tabla.Load(rta);
                return Tabla;
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

        #endregion

        #region Listar Carril

        public DataTable ListarCarril()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("select * from T_TipoModulo where TipoModulo<>'ENTRADA' and TipoModulo<>'SALIDA'");
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

        #endregion

        #region ListarFacManuales

        public DataTable ListarFacManuales(int idEstacionamiento, string fechadesde, string fechahasta)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("Select * from T_FacturasManuales where FechaPago between '" + fechadesde + "' and '" + fechahasta + "'  and IdEstacionamiento ='" + idEstacionamiento + "' order by fechapago desc");
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

        #endregion

        #region Listar Usuario

        public DataTable ListarUsuario()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("Select documento, nombres, apellidos from t_usuarios where estado=1 and cargo<>'CONTROL INTERNO' and cargo<>'SUBGERENTE' and cargo<>'JEFE DE OPERACIONES' and cargo<>'ADMIN'");
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

        #endregion

        #region Listar Usuario Modificar

        public DataTable ListarUsuarioModificar(string documentoUsuario)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("Select documento, nombres, apellidos from t_usuarios where estado=1 and cargo<>'CONTROL INTERNO' and cargo<>'SUBGERENTE' and cargo<>'JEFE DE OPERACIONES' and cargo<>'ADMIN' and Documento='" + documentoUsuario + "'");
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

        #endregion

        #region Listar Estacionamiento Modificar


        public DataTable ListarEstacionamientoModificar(string idEstacionamiento)
        {
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("Select IdEstacionamiento,Nombre from T_Estacionamientos Where IdEstacionamiento='" + idEstacionamiento + "'");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                Tabla.Load(rta);
                return Tabla;

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
        #endregion

        #region Listar Tipo Cobro Modificar

        public DataTable ListarTipoCobroModificar()
        {

            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = "select * from t_tipovehiculo";
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                Tabla.Load(rta);
                return Tabla;
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

        #endregion

        #region Crud
        public string InsertarFactura(string idModulo, int idEstacionamiento, string fechaPago, double subtotal, double iva, double total, string prefijo, int numerofactura, int idTipoVehiculo, int documentoUsuario)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("insert into T_FacturasManuales(IdModulo,IdEstacionamiento,FechaPago,Subtotal,Iva,Total,Prefijo,NumeroFactura,IdTipovehiculo,DocumentoUsuario,Sincronizacion) " +
                "Values('" + idModulo + "','" + idEstacionamiento + "', '" + fechaPago + "', '" + subtotal + "', '" + iva + "', '" + total + "', '" + prefijo + "', '" + numerofactura + "', '" + idTipoVehiculo + "', '" + documentoUsuario + "', '" + 1 + "')");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                comando.ExecuteNonQuery();
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

        public string ModificarFactura(string idModulo, int idEstacionamiento, string fechaPago, double subtotal, double iva, double total, string prefijo, int numerofactura, int idTipoVehiculo, int documentoUsuario)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("update T_FacturasManuales set FechaPago='" + fechaPago + "', Subtotal='" + subtotal + "', Iva='" + iva + "', Total='"+total+"', Prefijo='" + prefijo + "', NumeroFactura='" + numerofactura + "', IdTipoVehiculo='" + idTipoVehiculo + "',DocumentoUsuario='" + documentoUsuario + "', Sincronizacion=1 where Prefijo='" + prefijo + "' and IdEstacionamiento='" + idEstacionamiento + "' and NumeroFactura='" + numerofactura + "'");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                comando.ExecuteNonQuery();
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
        #endregion

    }
}


