using LibreriaDeClases;
using System.Collections.Generic;
using Aplicacion;
using System;

namespace Testeo
{
    [TestClass]
    public class TesteoLibreriaClases
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
        public void ValidarBasquetbolistas_CuandoSeanIguales()
        {
            //Arrange
            bool expected = true;

            Basquetbolista b1 = new Basquetbolista(190, 44, "Maxi", "Neiner", 28, ENacionalidad.Argentino);
            Basquetbolista b2 = new Basquetbolista(190, 39, "Maxi", "Neiner", 25, ENacionalidad.Argentino); //te hice jovencito maxi jeje

            //Act
            bool flag = b1 == b2;

            //Assert
            Assert.AreEqual(expected, flag);

        }

        [TestMethod]
        public void ValidarVoleibolistas_CuandoSeanIguales()
        {
            //Arrange
            bool expected = true;

            Voleibolista v1 = new Voleibolista("Facu", "Rocha", 22, ENacionalidad.Brasilero, EMano.Izquierda);
            Voleibolista v2 = new Voleibolista("Facu", "Rocha", 29, ENacionalidad.Argentino, EMano.Izquierda);

            //Act
            bool flag = v1 == v2;

            //Assert
            Assert.AreEqual(expected, flag);

        }

        [TestMethod]
        public void VerificarJugador_CuandoYaEsteEnLaLista_DeberiaRetornarTrue()
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


    }
}