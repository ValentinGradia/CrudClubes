using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class AccesoDatos
    {
        public SqlConnection conexion;//Este objeto se va a encargar de conectarse con el motor de base de datos(UN SELECT,UPDATE,DELETE)
        private static string cadenaConexion;

        static AccesoDatos()
        {
            AccesoDatos.cadenaConexion = LibreriaDeClases.Properties.Resources.miConexion;//Hago referencia a la cadena de conexion
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadenaConexion);
        }
    }
}
