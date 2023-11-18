using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class ObjetoDuplicadoException : Exception
    {
        public ObjetoDuplicadoException(string mensaje) : base(mensaje)
        {

        }

        public ObjetoDuplicadoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
