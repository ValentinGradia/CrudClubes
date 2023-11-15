using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    /// <summary>
    /// Equipo es una clase que modela un equipo deportivo y gestiona jugadores de varios deportes. Permite agregar y quitar jugadores, así como ordenarlos por apellido o edad.
    /// </summary>
    public class Equipo
    {
        private List<Jugador> miEquipo;
        private int cantidadJugadores;
        private string nombreEquipo;
        private List<Futbolista> futbolistas;
        private List<Basquetbolista> basquetbolistas;
        private List<Voleibolista> voleibolistas;

        public List<Voleibolista> Voleibolistas
        {
            get { return this.voleibolistas; }
            set { this.voleibolistas = value; }
        }


        public List<Basquetbolista> Basquetbolistas
        {
            get { return this.basquetbolistas; }
            set { this.basquetbolistas = value; }
        }


        public List<Futbolista> Futbolistas
        {
            get { return this.futbolistas; }
            set { this.futbolistas = value; }
        }


        public int CantidadJugadores
        {
            get { return this.cantidadJugadores; }
            set { this.cantidadJugadores = value; }
        }

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

        public Equipo()
        {

        }

        public Equipo(int cantidadJugadores, string nombreEquipo) : this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombreEquipo = nombreEquipo;
            this.miEquipo = new List<Jugador>();
            this.futbolistas = new List<Futbolista>();
            this.basquetbolistas = new List<Basquetbolista>();
            this.voleibolistas = new List<Voleibolista>();
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombreEquipo}";
        }

        public override bool Equals(object? obj)
        {
            bool flag = false;
            if (obj is Equipo)
            {
                flag = this == ((Equipo)obj);

            }

            return flag;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {

            e.miEquipo.Add(j); //las validaciones las hice en el crud
            return e;

        }

        public static Equipo operator -(Equipo e, Jugador j)
        {

           e.miEquipo.Remove(j);

            return e;
        }


        public static bool operator ==(Equipo e, Jugador j)
        {
            return e.miEquipo.Contains(j);
        }

        public static bool operator ==(Equipo e,Equipo e2)
        {
            return (e.nombreEquipo == e2.nombreEquipo);
        }

        public static bool operator !=(Equipo e, Equipo e2)
        {
            return !(e==e2);
        }

        public static bool operator !=(Equipo e, Jugador j)
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
