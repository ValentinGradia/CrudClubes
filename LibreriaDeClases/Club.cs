using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    /// <summary>
    /// Club es una clase que modela un equipo deportivo y gestiona jugadores de varios deportes. Permite agregar y quitar jugadores, así como ordenarlos por apellido o edad.
    /// </summary>
    public class Club
    {
        private List<Jugador> miEquipo;
        private string nombreEquipo;


        public int CantidadJugadoresActual
        {
            get { return this.miEquipo.Count; }
        }

        public string NombreEquipo
        {
            get { return this.nombreEquipo; }
            set { this.nombreEquipo = value; }
        }

        public List<Jugador> MiEquipo
        {
            get { return this.miEquipo; }
            set { this.miEquipo = value; }
        }

        public Club()
        {

        }

        public Club(string nombreEquipo) : this()
        {
            this.nombreEquipo = nombreEquipo;
            this.miEquipo = new List<Jugador>();
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombreEquipo}";
        }

        public override bool Equals(object? obj)
        {
            bool flag = false;
            if (obj is Club)
            {
                flag = this == ((Club)obj);

            }

            return flag;
        }

        public override int GetHashCode()
        {
            return nombreEquipo.GetHashCode();
        }

        public static Club operator +(Club e, Jugador j)
        {

            e.miEquipo.Add(j); //las validaciones las hice en el crud
            return e;

        }

        public static Club operator -(Club e, Jugador j)
        {

           e.miEquipo.Remove(j);

            return e;
        }


        public static bool operator ==(Club e, Jugador j)
        {
            return e.miEquipo.Contains(j);
        }

        public static bool operator ==(Club e, Club e2)
        {
            return (e.nombreEquipo == e2.nombreEquipo);
        }

        public static bool operator !=(Club e, Club e2)
        {
            return !(e==e2);
        }

        public static bool operator !=(Club e, Jugador j)
        {
            return !(e==j);
        }

        public List<Jugador> OrdenarApellido(int value)
        {
            if (value == 1)
            {
                this.miEquipo = this.miEquipo.OrderByDescending(jugador => jugador.Apellido).ToList();
            }
            else
            {
                this.miEquipo = this.miEquipo.OrderBy(jugador => jugador.Apellido).ToList();
            }

            return this.miEquipo;
        }

        public List<Jugador> OrdenarEdad(int value)
        {
            if (value == 1)
            {
                this.miEquipo = this.miEquipo.OrderByDescending(jugador => jugador.Edad).ToList();
            }
            else
            {
                this.miEquipo = this.miEquipo.OrderBy(jugador => jugador.Edad).ToList();
            }

            return this.miEquipo;
        }
    }
}
