using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;

namespace LibreriaDeClases
{
    /// <summary>
    /// La clase Voleibolista representa a un jugador de voleibol y hereda de la clase Jugador. Almacena información específica del deporte, como la mano dominante, 
    /// la posición en el campo y las habilidades relacionadas con el voleibol. Permite realizar comparaciones entre voleibolistas y otros jugadores, así como conversiones desde futbolistas.
    /// </summary>
    public class Voleibolista : Jugador
    {
        private EMano manoDominante;
        private string posicion;
        private static int contador = 0;
        private int id;

        public EMano ManoDominante
        {
            get { return this.manoDominante; }
            set { this.manoDominante = value; }
        }

        public override int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public override int Contador
        {
            set { Voleibolista.contador = value; }
            get { return Voleibolista.contador; }
        }

        public override string Posicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }

        public Voleibolista():base()
        {

        }

        public Voleibolista(string nombre, string apellido, int edad,
        ENacionalidad nacion) : base(nombre, apellido, edad, nacion)
        {
            this.manoDominante = EMano.Derecha;
            this.posicion = "";

        }

        public Voleibolista(string nombre, string apellido, int edad,
            ENacionalidad nacion,EMano mano):base(nombre, apellido, edad, nacion)
        {
            this.manoDominante = mano;
            this.posicion = "";
            Voleibolista.contador++;
            this.Id = Voleibolista.contador;

        }

        public Voleibolista(EMano manodominante, string nombre, string apellido, int edad,
            ENacionalidad nacion,string posicion) : this(nombre, apellido, edad, nacion,manodominante)
        {
            this.posicion = posicion;
        }

        public override string Habilidad()
        {
            int numero = Jugador.Aleatorio(1, 3);

            switch (numero)
            {
                case 1:
                    return "Remate";
                case 2:
                    return "Salto";
                default:
                    return "Defensa";
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" - ManoDominante: {this.manoDominante} - Posicion {this.posicion} - VOLEIBOLISTA";
        }

        public override bool Equals(object? obj)
        {
            bool flag = false;
            if (obj is Voleibolista)
            {
                flag = this == ((Voleibolista)obj) & (base.Equals(obj));
            }

            return flag;
        }

        public static bool operator ==(Voleibolista v1, Voleibolista v2)
        {
            return (v1.posicion == v2.posicion) & (v1.manoDominante == v2.manoDominante);
        }

        public static bool operator !=(Voleibolista v1, Voleibolista v2)
        {
            return !(v1 == v2);
        }

        public static explicit operator Voleibolista(Futbolista f)
        {
            return new Voleibolista(f.Nombre, f.Apellido, f.Edad, f.Nacion);
        }

    }


    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EMano
    {
        Izquierda,
        Derecha
    }
}
