
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class UsuarioController
    {
        #region Login
      
            public DataTable Login(string Usuario, string Clave)
            {
                SqlDataReader Resultado;
                DataTable Tabla = new DataTable();
                SqlConnection Sqlcon = new SqlConnection();
                try
                {
                    Sqlcon = ConexionController.getInstancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("P_AdminValidarClave", Sqlcon);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                    Comando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Clave;
                    Sqlcon.Open();
                    Resultado = Comando.ExecuteReader();
                    Tabla.Load(Resultado);
                    return Tabla;

                }
                catch (Exception ex)
                {
                    return null;


                    throw ex;
                }
                finally
                {
                    if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
                }

            }

        }

        #endregion
    }

