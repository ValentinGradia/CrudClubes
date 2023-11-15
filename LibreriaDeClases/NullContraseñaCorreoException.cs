using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class NullContraseñaCorreoException : Exception
    {

        public NullContraseñaCorreoException(string mensaje):base(mensaje)
        {
            
        }

        public NullContraseñaCorreoException(string mensaje, Exception inner):base(mensaje,inner)
        {

        }


    }
}
