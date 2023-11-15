using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    /// <summary>
    /// La clase "Futbolista" representa a un jugador de fútbol, con propiedades para pierna, goles y posición en el campo. Incluye métodos para gestionar y comparar futbolistas, así como una conversión desde un "Voleibolista".
    /// </summary>
    public class Futbolista : Jugador
    {
        private EPierna pierna;
        private int cantGoles;
        private string posicion;

        public EPierna Pierna
        {
            get { return this.pierna; }
        }

        public int Goles    
        {
            get { return this.cantGoles; }
            set { this.cantGoles = value;}
        }

        public Futbolista():base()
        {

        }

        public Futbolista(string nombre, string apellido, int edad, ENacionalidad nacion
            ) : base(nombre, apellido, edad, nacion)
        {
            this.pierna = EPierna.Diestro;
            this.cantGoles = 0;
            this.posicion = "";
        }

        public Futbolista(string nombre, string apellido, int edad, ENacionalidad nacion,
            int cantGoles, EPierna pierna):base(nombre,apellido,edad,nacion)
        {
            this.cantGoles = cantGoles;
            this.pierna = pierna;
        }

        public Futbolista(string nombre, string apellido, int edad, ENacionalidad nacion, string posicion
            ,int goles, EPierna pierna):this(nombre,apellido,edad,nacion,goles,pierna) 
        {
            this.posicion = posicion;
        }

        public override string Posicion
        {
            get
            {
                return this.posicion;
            }

        }

        public override string Habilidad()
        {

            int numero = Jugador.Aleatorio(1,3);

            switch (numero)
            {
                case 1:
                    return ": Regatear";
                case 2:
                    return ": Pegada";
                default:
                    return ": Cabezaso";
            }
        }

        public void Restablecer(string posicion)
        {
            this.posicion = posicion;
        }

        public void Restablecer(string posicion, EPierna pierna)
        {
            this.posicion = posicion;
            this.pierna = pierna;
        }

        public void Restablecer(EPierna pierna)
        {
            this.pierna = pierna;
        }

        public override string ToString()
        {
            return base.ToString() + $"- Posicion: {this.posicion} - Goles: {this.cantGoles} " +
                $" - Pierna habil: {this.pierna}";
        }

        public override bool Equals(object? obj)
        {
            bool flag = false;
            if (obj is Futbolista)
            {
                flag = this == ((Futbolista)obj) & (base.Equals(obj));

            }

            return flag;
        }

        public static bool operator ==(Futbolista f1, Futbolista f2)
        {
            return  (f1.posicion == f2.posicion);
        }

        public static bool operator !=(Futbolista f1, Futbolista f2)
        {
            return !(f1==f2);
        }

        public static explicit operator Futbolista(Voleibolista v)
        {
            return new Futbolista(v.Nombre, v.Apellido, v.Edad, v.Nacion);
        }

    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EPierna
    {
        Diestro,
        Zurdo
    }


}
