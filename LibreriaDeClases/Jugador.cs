using System.Text;
using System.Xml.Serialization;

namespace LibreriaDeClases
{
    /// <summary>
    /// La clase abstracta Jugador sirve como base para representar a un jugador de deportes. Contiene información fundamental como nombre, apellido, edad, nacionalidad y habilidad. 
    /// Además, define métodos para comparar jugadores, generar habilidades aleatorias y proporciona una descripción general del jugador. Las clases de jugadores específicos, 
    /// como futbolistas o baloncestistas, heredan de esta clase para agregar detalles particulares a sus deportes. 
    /// </summary>
    [XmlInclude(typeof(Futbolista))]
    [XmlInclude(typeof(Voleibolista))]
    [XmlInclude(typeof(Basquetbolista))]
    public abstract class Jugador
    {
        protected string nombre;
        protected string apellido;
        protected ENacionalidad nacion;
        protected int edad;
        public string habilidad;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }


        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public ENacionalidad Nacion
        {
            get { return this.nacion; }
            set { this.nacion = value; }
        }



        public abstract string Posicion { get; set; }


        public Jugador()
        {
            this.nombre = "";
            this.apellido = "";
            this.nacion = ENacionalidad.Argentino;
            this.edad = 0;
            this.habilidad = "";

        }


        public Jugador(string nombre, string apellido, int edad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.habilidad = this.Habilidad();
        }

        public Jugador(string nombre, string apellido, int edad, ENacionalidad pais) : this(nombre, apellido, edad)
        {
            this.nacion = pais;
        }


        public virtual string Habilidad()
        {
            return "No tiene";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.nombre} ");
            sb.Append($"- Apellido: {this.apellido} ");
            sb.Append($"- Edad: {this.edad} ");
            sb.Append($"- Nacionalidad: {this.nacion} ");
            sb.Append($"- Habilidad {this.habilidad} ");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            bool flag = false;

            if (obj is Jugador)
            {
                flag = this == (Jugador)obj;
            }

            return flag;
        }

        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return (j1.apellido == j2.apellido) & (j1.nombre == j2.nombre);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }



        public static int Aleatorio(int min, int max)
        {
            Random random = new Random();

            int numero = random.Next(min, max);

            return numero;
        }

    }
}