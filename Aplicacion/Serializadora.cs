using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aplicacion
{
    //IMPORTANTE: La clase serializadora no la pude crear en mi libreria de clases porque no me dejaba utilizar el SaveFileDialog y
    //el openFileDialog porque tenia que importar el system.windows.forms y para eso tenia que tener un proyecto de winforms. Por lo
    //que la clase la cree aca para que pueda usar estas dos clases
    public class Serializadora<T>
        where T : Jugador //Cuando yo cree una instancia le voy a indicar que tipo de jugadores voy a serealizar
    {
        public void Serealizar(List<T> jugadores, string path)//Le paso la lista de jugadores a serializar y el nombre
        {
            try
            {
                SaveFileDialog guardarJugadores = new SaveFileDialog();

                guardarJugadores.FileName = path;

                if (guardarJugadores.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(guardarJugadores.FileName))
                    {
                        System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                        opciones.WriteIndented = true;

                        string objJson = JsonSerializer.Serialize(jugadores, opciones);
                        sw.WriteLine(objJson);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deserealizar(Equipo equipo)//Aca le paso como parametro el equipo en el que estan TODOS los jugadores para que los que
            //sean deserealizados me los agregue
        {
            try
            {
                OpenFileDialog traerJugadores = new OpenFileDialog();

                if (traerJugadores.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(traerJugadores.FileName))
                    {
                        string json = sr.ReadToEnd();

                        List<T> jugadores = JsonSerializer.Deserialize<List<T>>(json);

                        foreach (Jugador j in jugadores)
                        {
                            if (equipo.MiEquipo.Count == equipo.CantidadJugadores)
                            {
                                MessageBox.Show("No se podran agregar mas jugadores serializados debido " +
                                    "a que se alcanzo el limite de jugadores", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            this.VerificarJugadoresDeserealizados(j, equipo);
                            //this.Actualizar();
                        }

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
        private void VerificarJugadoresDeserealizados(Jugador jugador, Equipo equipo)
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
                    }
                }
            }
            else
            {
                equipo.MiEquipo.Add(jugador);
            }

        }
    }
}
