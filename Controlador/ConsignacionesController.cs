using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Controlador
{
    public class ConsignacionesController
    {
        public DataTable BuscarConsignacion(string fecha1, string fecha2, int idEstacionamiento)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("select * from T_Consignacion where dbo.T_Consignacion.FechaConsignacion between '" + fecha1 + "' AND '" + fecha2 + "' AND dbo.T_Consignacion.IdEstacionamiento='" + idEstacionamiento + "' ORDER BY dbo.T_Consignacion.FechaConsignacion DESC");
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

        public string ActualizarConsignacion(int idConsignacion, int idEstacionamiento, string fechaConsignacion, int valor, string referencia, string documentoUsuario, int idDeposito, bool sincronizacion)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("update T_Consignacion set FechaConsignacion='" + fechaConsignacion + "', Valor='" + valor + "', Referencia='" + referencia + "', DocumentoUsuario='" + documentoUsuario + "', IdTipoDeposito='" + idDeposito + "', Sincronizacion='1' where IdConsignacion='" + idConsignacion + "' and IdEstacionamiento='" + idEstacionamiento + "'");
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
        public DataTable ListarTipoConsignacion()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = (" SELECT IdDeposito, Consignacion FROM T_TipoConsignacion");
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
     
    }
}

