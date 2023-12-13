using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Aplicacion
{
    //IMPORTANTE: La clase serializadora no la pude crear en mi libreria de clases porque no me dejaba utilizar el SaveFileDialog y
    //el openFileDialog porque tenia que importar el system.windows.forms y para eso tenia que tener un proyecto de winforms. Por lo
    //que la clase la cree aca para que pueda usar estas dos clases
    public class Serializadora<T> : IValidarJugadorRepetido
        where T : Jugador //Cuando yo cree una instancia le voy a indicar que tipo de jugadores voy a serealizar
    {
        public void Serealizar(T jugador, string path)//Le paso la lista de jugadores a serializar y el nombre
        {
            try
            {
                SaveFileDialog guardarJugadores = new SaveFileDialog();

                guardarJugadores.FileName = path;

                if (guardarJugadores.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(guardarJugadores.FileName))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));

                        serializer.Serialize(sw, jugador);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deserealizar(Club equipo)//Aca le paso como parametro el equipo en el que estan TODOS los jugadores para que los que
            //sean deserealizados me los agregue
        {
            try
            {
                OpenFileDialog jugador = new OpenFileDialog();

                if (jugador.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(jugador.FileName))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Jugador));

                        Jugador j = (Jugador)serializer.Deserialize(sr);


                        this.ValidarJugadorRepetido(j, equipo);
                            //this.Actualizar();     

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodo el cual consiste en que no se repitan jugadores, verificando si los jugadores que deserealize ya pertenecen al equipo o no
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="equipo"></param>
        public void ValidarJugadorRepetido(Jugador jugador, Club equipo)
        {
            bool flag = true;
            if (equipo.MiEquipo.Count != 0)//Si en mi equipo no hay jugadores no tengo que hacer la validacion, esto lo hago porque antes si queria hacer
                //el foreach a la lista de equipo.Miequipo me rompia ya que no existian jugadores.
            {
                foreach (Jugador j in equipo.MiEquipo)
                {
                    if (j.Equals(jugador))
                    {
                        if (flag)
                        {
                            MessageBox.Show("Hay jugador/jugadores que ya pertenecen al equipo por lo que no seran agregados",
                                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //Aca le indico que sea false, para que si hay mas jugadores repetidos no vuelva a mostrar el mensaje y lo muestre solo una vez
                        flag = false;
                    }
                    else
                    {
                        equipo.MiEquipo.Add(jugador);
                        //Recordemos que mi equipo tiene listas diferentes para cada tipo de jugador (esto por la serializacion de json y sus errores) entonces
                        //no solo tengo que agregar el jugador a la lista general sino a la lista del tipo del jugador

                    }
                }
            }
            else
            {
                equipo.MiEquipo.Add(jugador);
            }

        }


        public void AgregarJugadores<T>(T jugador, List<T> lista)
        {

            lista.Add(jugador);

        }
    }
}
