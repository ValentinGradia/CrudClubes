using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class JugadoNoExistenteException : Exception
    {
        public JugadoNoExistenteException(string mensaje) : base(mensaje)
        {

        }

        public JugadoNoExistenteException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
