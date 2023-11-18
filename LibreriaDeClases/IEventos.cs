using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public interface IEventos
    {
        event Action<bool, string> ComprobarProceso;

        void VerificarProceso(bool flag, string msg);
        
    }
}
