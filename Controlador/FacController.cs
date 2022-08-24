using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Variable;

namespace Controlador
{
    public class FacController
    {
        #region Listar Factura
        public DataTable ListarFactura(int NumeroFactura, int Estacionamiento)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = ConexionController.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("P_Buscar_Factura", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Numerofactura", SqlDbType.VarChar).Value = NumeroFactura;
                Comando.Parameters.Add("@IdEstacionamiento", SqlDbType.VarChar).Value = Estacionamiento;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        #endregion

        #region Listar Estacionamiento
        public DataTable ListarEstacionamiento()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = ConexionController.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("P_Listar_Estacionamiento", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        #endregion

        #region Anular Factura


        public string Anular(int Num)
        {
            string Rta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = ConexionController.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("P_Anular_Factura", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdPago", SqlDbType.VarChar).Value = Num;
                Sqlcon.Open();
                Rta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo anular la factura";



            }
            catch (Exception ex)
            {

                Rta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rta;
        }

        public string DesAnular(int Num)
        {
            string Rta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = ConexionController.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("P_DesAnular_Factura", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdPago", SqlDbType.VarChar).Value = Num;
                Sqlcon.Open();
                Rta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo cancelar la anulación de la factura";



            }
            catch (Exception ex)
            {

                Rta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rta;
        }

        #endregion

        #region Actualizar Resolucion

        public string ActualizarResolucion(VFacturacion Obj)
        {
            string Rta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = ConexionController.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("P_Actualizar_Resolucion", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@FacturaInicial", SqlDbType.VarChar).Value = Obj.FacturaInicial;
                Comando.Parameters.Add("@FacturaFinal", SqlDbType.VarChar).Value = Obj.FacturaFinal;
                Comando.Parameters.Add("@Numeroresolucion", SqlDbType.VarChar).Value = Obj.NumeroResolucion;
                Comando.Parameters.Add("@FechaResolucion", SqlDbType.VarChar).Value = Obj.FechaResolucion;
                Comando.Parameters.Add("@FechaFinResolucion", SqlDbType.VarChar).Value = Obj.FechaFinResolucion;
                Comando.Parameters.Add("@IdFacturacion", SqlDbType.Int).Value = Obj.IdFacturacion;
                Comando.Parameters.Add("@Prefijo", SqlDbType.VarChar).Value = Obj.Prefijo;
                Comando.Parameters.Add("@IdEstacionamiento", SqlDbType.Int).Value = Obj.IdEstacionamiento;
                Sqlcon.Open();
                Rta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó la resolucion";

            }
            catch (Exception ex)
            {

                Rta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rta;
        }

        #endregion

        #region Listar Datos Resolucion
        public DataTable ListarDatosResolucion(int IdEstacionamiento)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = ConexionController.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("P_Listar_Facturacion", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdEstacionamiento", SqlDbType.VarChar).Value = IdEstacionamiento;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
        #endregion

    }
}
