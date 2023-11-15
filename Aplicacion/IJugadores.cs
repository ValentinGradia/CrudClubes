using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    /// <summary>
    /// Esta interfaz la aplico cargando los datos de la clase base y el metodo verificarNacionalidades se encarga de que cuando el usuario
    /// modifique el jugador,  quede guardada la ultima nacionalidad que guardo
    /// </summary>
    /// <typeparam name="Tipo de jugador"></typeparam>
    public interface IJugadores<T>
        where T: Jugador
    {
        void VerificarNacionalidades();

        void CargarDatos(T jugador);
    }
}
