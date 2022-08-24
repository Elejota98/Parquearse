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
    public class MAutorizado
    {

        public static DataTable BuscarAutorizado(string Documento, string Placa1, string Placa2)
        {
            Controlador.AutorizadoController Datos = new Controlador.AutorizadoController();
            return Datos.BuscarAutorizado(Documento, Placa1, Placa2);
        }

        public static string ActualizarFecha(string Documento, string Fecha)
        {
            Controlador.AutorizadoController Datos = new Controlador.AutorizadoController();
            return Datos.ActualizarFechaFin(Fecha, Documento);
        }

        public static DataTable ListarAutorizaciones()
        {
            Controlador.AutorizadoController Datos = new Controlador.AutorizadoController();
            return Datos.ListarAutorizaciones();
        }

        public static DataTable ListarPersonasAutorizadas()
        {
            Controlador.AutorizadoController Datos = new Controlador.AutorizadoController();
            return Datos.ListarPersonasAutorizadas();
        }

        public static string InsertarAutorizado(string Documento, int IdAutorizado, string NombreApellidos, string IdTarjeta, string NombreEmpresa, string Nit, string FechaCreacion, string DocumentoUsuarioCreacion, string Telefono, string Email, string Placa1, string Placa2, string Placa3, string Placa4)
        {
            Controlador.AutorizadoController Datos = new AutorizadoController();
            return Datos.InsertarAutorizado(Documento, IdAutorizado, NombreApellidos, IdTarjeta, NombreEmpresa, Nit, FechaCreacion, DocumentoUsuarioCreacion, Telefono, Email, Placa1, Placa2, Placa3, Placa4);

        }

        public static string ActualizarAutorizado(string Documento, int IdAutorizado, string NombreApellidos, string NombreEmpresa, string Nit, string FechaInicio, string FechaFin, string Telefono, string Email, string Placa1, string Placa2, string Placa3, string Placa4)
        {
            Controlador.AutorizadoController Datos = new AutorizadoController();
            return Datos.ActualizarAutorizado(Documento, IdAutorizado, NombreApellidos, NombreEmpresa, Nit, FechaInicio, FechaFin, Telefono, Email, Placa1, Placa2, Placa3, Placa4);

        }

        public static string ActualizarTarjeta(string idTarjeta, string idTarjetaOld, string documento)
        {
            Controlador.AutorizadoController Datos = new AutorizadoController();
            return Datos.ActualizarTarjeta(idTarjeta, idTarjetaOld, documento);

        }
   
    }
}
