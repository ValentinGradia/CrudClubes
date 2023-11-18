using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public interface IValidarJugadorRepetido
    {

        void ValidarJugadorRepetido(Jugador j, Equipo e);


        void VerificarTipoJugador(Jugador jugador, Equipo equipo);

        public void AgregarJugadores<T>(T jugador, List<T> lista);
    }
}
