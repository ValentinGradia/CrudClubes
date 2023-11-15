using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Usuario
    {
        private string Nombre;
        private string Apellido;
        private string Correo;
        private string Clave;
        private int Legajo;
        private string Perfil;

        public string nombre
        {
            get { return this.Nombre; }
            set { this.Nombre = value; }
        }

        public string correo
        {
            get { return this.Correo; }
            set { this.Correo = value; }
        }

        public string perfil
        {
            get { return this.Perfil; }
            set { this.Perfil = value; }
        }

        public string apellido
        {
            get { return this.Apellido; }
            set { this.Apellido = value; }
        }

        public string clave
        {
            get
            {
                return this.Clave;
            }
            set
            {
                this.Clave = value;
            }
        }

        public int legajo
        {
            get { return this.Legajo; }
            set { this.Legajo = value; }
        }

        public Usuario()
        {

        }

        public override bool Equals(object? obj)
        {
            bool flag = false;
            if (obj is Usuario)
            {
                flag = this == (Usuario)obj;

            }
            return flag;
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return (u1.correo == u2.correo) & (u1.clave == u2.clave);
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1==u2);
        }

        //public Usuario(string nombre, string apellido, string mail, string contraseña,
        //    int legajo, string perfil)
        //{
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.mail = mail;
        //    this.contraseña = contraseña;
        //    this.legajo = legajo;
        //    this.perfil = perfil;

        //}
    }
}
