using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public interface IValidarJugadorRepetido
    {

        void ValidarJugadorRepetido(Jugador j, Club e);


        public void AgregarJugadores<T>(T jugador, List<T> lista);
    }
}
