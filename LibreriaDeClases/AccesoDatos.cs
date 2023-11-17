using LibreriaDeClases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class AccesoDatos
    {
        public SqlConnection conexion;//Este objeto se va a encargar de conectarse con el motor de base de datos(UN SELECT,UPDATE,DELETE)
        private static string cadenaConexion;
        private SqlCommand comando;
        private SqlDataReader lector; //contener tipo de dato a traves de una consulta tipo select(lectura)

        static AccesoDatos()
        {
            AccesoDatos.cadenaConexion = LibreriaDeClases.Properties.Resources.miConexion;//Hago referencia a la cadena de conexion
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadenaConexion);
            this.comando = new SqlCommand();
        }

        private void MiComando(string text)
        {
            this.comando.Connection = conexion;
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.CommandText = text;
        }



        public List<T> ObtenerListaDatos<T>(List<T> listaJugadores)
            where T: Jugador, new()
        {
            try
            {   
                this.comando.CommandType = System.Data.CommandType.Text;//Propiedad que permite establecer la forma en la que vas a comunicar con la base de datos(enumerado)
                //Con el text es para escribir un comando como de SQL
                this.comando.CommandText = "select into"; //comando
                this.comando.Connection = this.conexion;//objeto sqlconnection

                this.conexion.Open();

                //this.comando.ExecuteNonQuery() -> tipo insert,update, delete
                this.lector = this.comando.ExecuteReader(); //tipo select

                while(this.lector.Read())//devuelve true cuando hay algo para leer
                {
                    T jugador = new T();
                    jugador.Nombre = (string)this.lector["Nombre"];
                    jugador.Apellido = (string)this.lector["Apellido"];
                    jugador.Edad = (int)this.lector["Edad"];
                    jugador.Nacion = (ENacionalidad)Convert.ToInt32(this.lector["Nacion"]);
                    jugador.Posicion = (string)this.lector["Posicion"];

                    this.ManejoEspecificoJugadores(jugador, this.lector);

                    listaJugadores.Add(jugador);

                }
                this.lector.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) this.conexion.Close();
            }

            return listaJugadores;
        }

        private void ManejoEspecificoJugadores(Jugador jugador, SqlDataReader lector)
        {
            if (jugador is Futbolista)
            {
                Futbolista futbolista = jugador as Futbolista;
                futbolista.Pierna = (EPierna)Convert.ToInt32(lector["Pierna"]);
                futbolista.Goles = (int)lector["Goles"];
            }
            else if (jugador is Basquetbolista)
            {
                Basquetbolista basquetbolista = jugador as Basquetbolista;
                basquetbolista.Altura = (int)lector["Altura"];
                basquetbolista.Calzado = lector.GetFloat(6);
            }
            else
            {
                Voleibolista voleibolista = jugador as Voleibolista;
                voleibolista.ManoDominante = (EMano)Convert.ToInt32(lector["ManoDominante"]);
            }

        }

        public bool AgregarJugador(Jugador j)
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue(@"columna", "valor de dicha columna");
                this.comando.CommandType = System.Data.CommandType.Text;//Propiedad que permite establecer la forma en la que vas a comunicar con la base de datos(enumerado)
                //Con el text es para escribir un comando como de SQL
                this.comando.CommandText = "insert into (nombre_tabla) set columna = @columna where (poner algo sino cambia todo)"; //comando
                this.comando.Connection = this.conexion;//objeto sqlconnection

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if(filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) this.conexion.Close();
            }

            return retorno;

        }

        public bool ModificarJugador<T>(T jugador)
            where T: Jugador
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue(@"columna", "valor de dicha columna");
                this.comando.CommandType = System.Data.CommandType.Text;//Propiedad que permite establecer la forma en la que vas a comunicar con la base de datos(enumerado)
                //Con el text es para escribir un comando como de SQL
                this.comando.CommandText = "update into (nombre_tabla) set columna = @columna where (poner algo sino cambia todo)"; //comando
                this.comando.Connection = this.conexion;//objeto sqlconnection

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) this.conexion.Close();
            }

            return retorno;

        }
    }
}
