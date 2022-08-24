using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class AutorizadoController
    {
        public DataTable BuscarAutorizado(string Documento, string Placa1, string Placa2)
        {

            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("SELECT dbo.T_PersonasAutorizadas.Documento, dbo.T_Autorizaciones.NombreAutorizacion, dbo.T_PersonasAutorizadas.IdEstacionamiento, dbo.T_PersonasAutorizadas.NombreApellidos, dbo.T_PersonasAutorizadas.IdTarjeta," +
                  "dbo.T_PersonasAutorizadas.NombreEmpresa, dbo.T_PersonasAutorizadas.Nit, dbo.T_PersonasAutorizadas.FechaCreacion, dbo.T_PersonasAutorizadas.DocumentoUsuarioCreacion, dbo.T_PersonasAutorizadas.Estado, " +
                  "dbo.T_PersonasAutorizadas.Sincronizacion, dbo.T_PersonasAutorizadas.FechaInicio, dbo.T_PersonasAutorizadas.FechaFin, dbo.T_PersonasAutorizadas.Telefono, dbo.T_PersonasAutorizadas.Email, dbo.T_PersonasAutorizadas.Placa1, " +
                  "dbo.T_PersonasAutorizadas.Placa2, dbo.T_PersonasAutorizadas.Placa3, dbo.T_PersonasAutorizadas.Placa4, dbo.T_PersonasAutorizadas.Placa5, dbo.T_PersonasAutorizadas.ValorBolsa, dbo.T_PersonasAutorizadas.CobroTarjeta " +
                  " FROM     dbo.T_Autorizaciones INNER JOIN " +
                  "dbo.T_PersonasAutorizadas ON dbo.T_Autorizaciones.IdEstacionamiento = dbo.T_PersonasAutorizadas.IdEstacionamiento AND dbo.T_Autorizaciones.IdAutorizacion = dbo.T_PersonasAutorizadas.IdAutorizacion where documento like '%" + Documento + "%' and Placa1 like '%" + Placa1 + "%' and Placa2 like '%" + Placa2 + "%'");
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

        public DataTable ListarAutorizaciones()
        {
            string Rta = "";
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("select IdAutorizacion,NombreAutorizacion from T_Autorizaciones");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
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

        public DataTable ListarPersonasAutorizadas()
        {

            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("SELECT dbo.T_PersonasAutorizadas.Documento, dbo.T_Autorizaciones.NombreAutorizacion, dbo.T_PersonasAutorizadas.IdEstacionamiento, dbo.T_PersonasAutorizadas.NombreApellidos, dbo.T_PersonasAutorizadas.IdTarjeta," +
                  "dbo.T_PersonasAutorizadas.NombreEmpresa, dbo.T_PersonasAutorizadas.Nit, dbo.T_PersonasAutorizadas.FechaCreacion, dbo.T_PersonasAutorizadas.DocumentoUsuarioCreacion, dbo.T_PersonasAutorizadas.Estado, " +
                  "dbo.T_PersonasAutorizadas.Sincronizacion, dbo.T_PersonasAutorizadas.FechaInicio, dbo.T_PersonasAutorizadas.FechaFin, dbo.T_PersonasAutorizadas.Telefono, dbo.T_PersonasAutorizadas.Email, dbo.T_PersonasAutorizadas.Placa1, " +
                  "dbo.T_PersonasAutorizadas.Placa2, dbo.T_PersonasAutorizadas.Placa3, dbo.T_PersonasAutorizadas.Placa4, dbo.T_PersonasAutorizadas.Placa5, dbo.T_PersonasAutorizadas.ValorBolsa, dbo.T_PersonasAutorizadas.CobroTarjeta " +
                  " FROM     dbo.T_Autorizaciones INNER JOIN " +
                  "dbo.T_PersonasAutorizadas ON dbo.T_Autorizaciones.IdEstacionamiento = dbo.T_PersonasAutorizadas.IdEstacionamiento AND dbo.T_Autorizaciones.IdAutorizacion = dbo.T_PersonasAutorizadas.IdAutorizacion");
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

        public string ActualizarFechaFin(string FechaFin, string Documento)
        {
            string Rta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = ConexionController.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("P_ActualizarFechaCorteAutorizado", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = FechaFin;
                Comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = Documento;
                Sqlcon.Open();
                Comando.ExecuteNonQuery();
                Rta = "OK";

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

        public string InsertarAutorizado(string Documento, int IdAutorizado, string NombreApellidos, string IdTarjeta, string NombreEmpresa, string Nit, string FechaCreacion, string DocumentoUsuarioCreacion, string Telefono, string Email, string Placa1, string Placa2, string Placa3, string Placa4)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("insert into T_PersonasAutorizadas (Documento, IdAutorizacion, IdEstacionamiento, NombreApellidos, IdTarjeta, NombreEmpresa," +
                "Nit, FechaCreacion, DocumentoUsuarioCreacion, Estado, Sincronizacion, FechaInicio, FechaFin, Telefono, Email, Placa1, Placa2," +
                "Placa3, Placa4, Placa5, ValorBolsa, CobroTarjeta) values ('" + Documento + "','" + IdAutorizado + "','" + 1 + "','" + NombreApellidos + "','" + IdTarjeta + "','" + NombreEmpresa + "','" + Nit + "','" + FechaCreacion + "','" + DocumentoUsuarioCreacion + "','" + 1 + "','" + 1 + "','','','" + Telefono + "','" + Email + "','" + Placa1 + "','" + Placa2 + "','" + Placa3 + "','" + Placa4 + "','','','" + 0 + "')");
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

        public string ActualizarAutorizado(string Documento, int IdAutorizado, string NombreApellidos, string NombreEmpresa, string Nit, string FechaInicio, string FechaFin, string Telefono, string Email, string Placa1, string Placa2, string Placa3, string Placa4)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("update T_PersonasAutorizadas set IdAutorizacion='" + IdAutorizado + "', NombreApellidos='" + NombreApellidos + "', NombreEmpresa='" + NombreEmpresa + "', Nit='" + Nit + "', FechaInicio='" + FechaInicio + "', FechaFin='" + FechaFin + "', Telefono='" + Telefono + "', Email='" + Email + "', Placa1='" + Placa1 + "', Placa2='" + Placa2 + "', Placa3='" + Placa3 + "', Placa4='" + Placa4 + "' where Documento='" + Documento + "' and IdEstacionamiento='1'");
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

        public string ActualizarTarjeta(string idTarjeta, string idTarjetaOld, string documento)
        {
            string Rta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = ConexionController.getInstancia().CrearConexion();
                string cadena = ("update T_PersonasAutorizadas set IdTarjeta='" + idTarjeta + "' where Documento='" + documento + "' and IdTarjeta='" + idTarjetaOld + "'");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                comando.ExecuteNonQuery();
                Rta = "OK";

            }
            catch (Exception ex)
            {

                Rta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rta;
        }
    }
}
