using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    /// <summary>
    /// La clase "Basquetbolista" modela a un jugador de baloncesto, con atributos para su altura, tamaño de calzado y posición en el campo, 
    /// junto con métodos para obtener una habilidad aleatoria y comparar jugadores por su altura.
    /// </summary>
    public class Basquetbolista : Jugador
    {
        private int altura;
        private float calzado;
        private string posicion;

        public int Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }

        public float Calzado
        {
            get { return this.calzado; }
            set { this.calzado = value; }
        }

        public override string Posicion
        {
            get
            {
                return this.posicion;
            }
            set { this.posicion = value; }
        }

        public Basquetbolista():base()
        {

        }


        public Basquetbolista(int altura, float calzado,string nombre,string apellido,
            int edad,ENacionalidad nacion):base(nombre, apellido, edad,nacion)
        {
            this.altura = altura;
            this.calzado = calzado;
            this.posicion = "";
        }

        public Basquetbolista(int altura, float calzado, string posicion ,string nombre, string apellido,
            int edad, ENacionalidad nacion) : this(altura,calzado,nombre, apellido, edad,nacion)
        {
            this.posicion = posicion;

        }


        public override string Habilidad()
        {
            int numero = Jugador.Aleatorio(1, 2);
              
            switch (numero)
            {
                case 1:
                    return ": Tiro -";
                default:
                    return ": Pase -";
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Altura: {this.altura} - Posicion: {this.posicion}";
        }

        public override bool Equals(object? obj)
        {
            bool flag = false;
            if (obj is Basquetbolista)
            {
                flag = this == ((Basquetbolista)obj) & (base.Equals(obj));
            }

            return flag;
        }

        public static bool operator ==(Basquetbolista b1, Basquetbolista b2)
        {
            return (b1.altura == b2.altura);
        }

        public static bool operator !=(Basquetbolista b1, Basquetbolista b2)
        {
            return !(b1 == b2);
        }

    }
}
