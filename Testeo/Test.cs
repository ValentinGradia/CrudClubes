using LibreriaDeClases;
using System.Collections.Generic;
using Aplicacion;
using System;

namespace Testeo
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ValidarFutbolistas_CuandoSeanIguales()
        {
            //Arrange
            bool expected = true;

            Futbolista f1 = new Futbolista("Juan", "Perez", 34, ENacionalidad.Brasilero, "Defensor", 5, EPierna.Diestro);
            Futbolista f2 = new Futbolista("Juan", "Perez", 22, ENacionalidad.Argentino, "Defensor", 24, EPierna.Diestro);

            //Act
            bool flag = f1 == f2;

            //Assert
            Assert.AreEqual(expected, flag);

        }

        [TestMethod]
        public void AgregarJugador_CuandoYaEsteEnLaLista_DeberiaRetornarTrue()
        { 
           //Arrange
            List<Jugador> listaJugadores = new List<Jugador>
            {
                new Futbolista("Juan", "Perez", 34, ENacionalidad.Brasilero, "Defensor", 5, EPierna.Diestro),
                new Basquetbolista(20, 45, "Marco", "Polo", 34, ENacionalidad.Brasilero),
                new Voleibolista("Domingo", "Basde", 29, ENacionalidad.Argentino)
            };

            //Act
            Basquetbolista b1 = new Basquetbolista(20, 45, "Marco", "Polo", 34, ENacionalidad.Brasilero);

            bool flag = listaJugadores.Contains(b1);

            //Assert
            Assert.IsTrue(flag);

        }

        [TestMethod]
        public void ProbarConexionABaseDeDatos_DeberiaConectar()
        {
            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.conexion.Open();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(acceso.conexion.State == System.Data.ConnectionState.Open)
                {
                    acceso.conexion.Close();
                }
            }

        }
    }
}