using LibreriaDeClases;
using Microsoft.Data.SqlClient;

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
            this.comando.Connection = this.conexion;
            this.comando.CommandType = System.Data.CommandType.Text;//Propiedad que permite establecer la forma en la que vas a comunicar con la base de datos(enumerado)
            //Con el text es para escribir un comando como de SQL
            this.comando.CommandText = text;//objeto sqlconnection
        }


        /// <summary>
        /// Metodo el cual traigo la lista de jugadores (dependiendo el tipo T)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listaJugadores"></param>
        /// <returns></returns>
        /// 
        public List<Dictionary<string, List<Jugador>>> ObtenerListaDatos<T>()
            where T: Jugador,new()
        {
            string tabla = this.ObtenerNombreTabla<T>();
            Dictionary<string, List<Jugador>> diccionarioClubes = new Dictionary<string, List<Jugador>>();
            List<Dictionary<string, List<Jugador>>> listaDeDiccionarios = new List<Dictionary<string, List<Jugador>>>();

            try
            {
                bool flag = true;
                this.MiComando($"select * from {tabla}");

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader(); //tipo select

                while (this.lector.Read())//devuelve true cuando hay algo para leer
                {
                    T jugador = new T();
                    jugador.Nombre = (string)this.lector["Nombre"];
                    jugador.Apellido = (string)this.lector["Apellido"];
                    jugador.Edad = (int)this.lector["Edad"];
                    jugador.Nacion = (ENacionalidad)Convert.ToInt32(this.lector["Nacion"]);
                    jugador.Posicion = (string)this.lector["Posicion"];
                    jugador.NombreClub = (string)this.lector["NombreClub"];
                    jugador.Id = (int)this.lector["Id"];

                    //Para que no se repitan Id y comience desde el ultimo
                    if (flag)
                    {
                        jugador.Contador = jugador.Id;
                            flag = false;}
                    else
                    {
                        if(jugador.Id > jugador.Contador)
                        {
                            jugador.Contador = jugador.Id;
                        }
                    }
                    //llamo a mi funcion para ver (dependiendo del tipo de jugador) que valores tengo que caster
                    this.ManejoEspecificoJugadores(jugador, this.lector);

                    Club club = new Club(jugador.NombreClub);

                    if (!diccionarioClubes.ContainsKey(club.NombreEquipo))
                    {
                        diccionarioClubes.Add(club.NombreEquipo, new List<Jugador> { jugador });
                    }
                    else
                    {
                        diccionarioClubes[club.NombreEquipo].Add(jugador);
                    }

                }


                this.lector.Close();
                listaDeDiccionarios.Add(diccionarioClubes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) this.conexion.Close();
            }

            return listaDeDiccionarios;

        }


        private void ManejoEspecificoJugadores(Jugador jugador, SqlDataReader lector)
        {
            if (jugador is Futbolista)
            {
                Futbolista futbolista = jugador as Futbolista;
                futbolista.Pierna = (EPierna)Convert.ToInt32(lector["Pierna"]);
                futbolista.Goles = (int)lector["Goles"];
                futbolista.habilidad = futbolista.Habilidad();
            }
            else if (jugador is Basquetbolista)
            {
                Basquetbolista basquetbolista = jugador as Basquetbolista;
                basquetbolista.Altura = (int)lector["Altura"];
                basquetbolista.Calzado = (int)lector["Calzado"];
                basquetbolista.habilidad = basquetbolista.Habilidad();
            }
            else
            {
                Voleibolista voleibolista = jugador as Voleibolista;
                voleibolista.ManoDominante = (EMano)Convert.ToInt32(lector["ManoDominante"]);
                voleibolista.habilidad = voleibolista.Habilidad();
            }
        }

        private string ObtenerNombreTabla<T>()
        {
            if (typeof(T) == typeof(Futbolista))
            {
                return "Futbolistas";
            }
            else if (typeof(T) == typeof(Basquetbolista))
            {
                return "Basquetbolistas";
            }
            else
            {
                return "Voleibolistas";
            }
        } 

        private string ObtenerNombreTabla(Jugador j)
        {
            if (j is Futbolista)
            {
                return "Futbolistas";
            }
            else if (j is Basquetbolista)
            {

                return "Basquetbolistas";
            }
            else
            {
                return "Voleibolistas";
            }
        }


        public bool AgregarJugador<T>(T jugador, string nombreClub)
            where T : Jugador
        {
            bool retorno = false;

            string tabla = this.ObtenerNombreTabla<T>();

            try
            {
                this.comando = new SqlCommand();

                this.RecorrerPropiedades(jugador, this.comando, nombreClub);

                //Valido que el jugador no este repetido o no este guardado en la tabla
                if (this.JugadorExiste(tabla, comando))
                {
                    throw new ObjetoDuplicadoException("No se agrego el guardo el jugador debido a que ya esta guardado en la Base de Datos");
                }
                else
                {
                    this.comando = new SqlCommand();

                    this.RecorrerPropiedades(jugador, this.comando, nombreClub);

                    switch (tabla)
                    {
                        case "Futbolistas":
                            this.MiComando($"insert into {tabla} (Id, Nombre, Apellido, Edad, Nacion, Pierna, Goles, Posicion, NombreClub) values(@Id, @Nombre, @Apellido, @Edad, @Nacion, @Pierna, @Goles, @Posicion, @NombreClub)");
                            break;
                        case "Basquetbolistas":
                            this.MiComando($"insert into {tabla} (Id, Nombre, Apellido, Edad, Nacion, Altura, Calzado, Posicion, NombreClub) values(@Id, @Nombre, @Apellido, @Edad, @Nacion, @Altura, @Calzado, @Posicion, @NombreClub)"); //comando
                            break;
                        default:
                            this.MiComando($"insert into {tabla} (Id, Nombre, Apellido, Edad, Nacion, ManoDominante, Posicion, NombreClub) values(@Id, @Nombre, @Apellido, @Edad, @Nacion, @ManoDominante, @Posicion, @NombreClub)"); //comando
                            break;
                    }
                    this.conexion.Open();
                    int filasAfectadas = this.comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        retorno = true;
                    }
                }
            }
            catch (ObjetoDuplicadoException ex)
            {
                throw ex;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) this.conexion.Close();
            }

            return retorno;

        }
        private void AgregarValoresComando(SqlCommand comando, string columna, string valor)
        {
            comando.Parameters.AddWithValue(columna, valor);
        }

        //Recorro las propiedades del jugador para ir agregando sus respectivos valores dependiendo el tipo de jugador
        //Esto con el fin de no ir agregando uno por uno sino tener una iteracion que lo haga
        private void RecorrerPropiedades(Jugador jugador, SqlCommand comando, string nombreClub)
        {

            foreach (var propiedad in jugador.GetType().GetProperties())
            {
                if (propiedad.Name == "ManoDominante" | propiedad.Name == "Pierna" | propiedad.Name == "Nacion")
                {
                    int valor = Convert.ToInt32(propiedad.GetValue(jugador));
                    this.AgregarValoresComando(comando, $@"{propiedad.Name}", $"{valor}");
                }
                else if(propiedad.Name == "NombreClub")
                {
                    this.AgregarValoresComando(comando, $@"{propiedad.Name}", nombreClub);
                }
                else
                {
                    this.AgregarValoresComando(comando, $@"{propiedad.Name}", $"{propiedad.GetValue(jugador)}");
                }
            }

        }

        /// <summary>
        /// A traves del tipo de jugador que me pase lo voy a modificar en mi tabla de base de datos, la tabla va a depender del tipo
        /// de jugador que sea ya que son 3 tablas diferentes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public bool ModificarJugador(Jugador jugador, string nombreClub)
        {
            bool retorno = false;

            string tabla = this.ObtenerNombreTabla(jugador);

            try
            {
                this.comando = new SqlCommand();

                this.RecorrerPropiedades(jugador, this.comando, nombreClub);

                switch (tabla)
                {
                    case "Futbolistas":
                        this.MiComando($"UPDATE {tabla} SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Nacion = @Nacion, Pierna = @Pierna, Goles = @Goles, Posicion = @Posicion WHERE  Id = @Id");
                        break;
                    case "Basquetbolistas":
                        this.MiComando($"UPDATE {tabla} SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Nacion = @Nacion, Altura = @Altura, Calzado = @Calzado, Posicion = @Posicion WHERE  Id = @Id");
                        break;
                    default:
                        this.MiComando($"UPDATE {tabla} SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Nacion = @Nacion, ManoDominante = @ManoDominante, Posicion = @Posicion WHERE Id = @Id");
                        break;

                }
                 
                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) this.conexion.Close();
            }

            return retorno;

        }

        /// <summary>
        /// Metodo el cual elimino el jugador de la base de datos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public bool EliminarJugador<T>(T jugador, string nombreClub)
            where T : Jugador
        {
            bool retorno = false;

            string tabla = this.ObtenerNombreTabla<T>();

            try
            {
                this.comando = new SqlCommand();
                this.RecorrerPropiedades(jugador, this.comando, nombreClub);

                if (this.JugadorExiste(tabla, this.comando))
                {
                    switch (tabla)
                    {
                        case "Futbolistas":
                            this.MiComando($"delete from {tabla} where Nombre = @Nombre and Apellido = @Apellido and Edad = @Edad and Nacion = @Nacion and Pierna = @Pierna and Goles = @Goles and Posicion = @Posicion and NombreClub = @NombreClub and Id = @Id");
                            break;
                        case "Basquetbolistas":
                            this.MiComando($"delete from {tabla} where Nombre = @Nombre and Apellido = @Apellido and Edad = @Edad and Nacion = @Nacion and Altura = @Altura and Calzado = @Calzado and Posicion = @Posicion and NombreClub = @NombreClub and Id = @Id");
                            break;
                        default:
                            this.MiComando($"delete from {tabla} where Nombre = @Nombre and Apellido = @Apellido and Edad = @Edad and Nacion = @Nacion and ManoDominante = @ManoDominante and Posicion = @Posicion and NombreClub = @NombreClub and Id = @Id");
                            break;

                    }

                    this.conexion.Open();

                    int filasAfectadas = this.comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        retorno = true;
                    }

                }
                else
                {
                    throw new JugadoNoExistenteException("El jugador no existe en la Base de datos");
                }
            }
            catch (JugadoNoExistenteException ex)
            {
                throw ex;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open) this.conexion.Close();
            }

            return retorno;

        }

        public bool JugadorExiste(string tabla, SqlCommand comando)
        {
            bool retorno = false;

            try
            {
                //Comparo si existe de igual manera que las sobrecargas
                switch (tabla)
                {
                    case "Futbolistas":
                        this.MiComando($"SELECT COUNT(*) from {tabla} where Nombre = @Nombre and Apellido = @Apellido and Posicion = @Posicion");
                        break;
                    case "Basquetbolistas":
                        this.MiComando($"select count(*) from {tabla} where Nombre = @Nombre and Apellido = @Apellido and Altura = @Altura");
                        break;
                    default:
                        this.MiComando($"select count(*) from {tabla} where Nombre = @Nombre and Apellido = @Apellido and Posicion = @Posicion ");
                        break;
                }

                this.conexion.Open();

                int filasAfectadas = Convert.ToInt32(comando.ExecuteScalar());

                if (filasAfectadas > 0) retorno = true;


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