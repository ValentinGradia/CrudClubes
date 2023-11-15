using LibreriaDeClases;
using System;

namespace TestProject1
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ValidarFutbolistas_CuandoSeanIguales_DeberiaRetornarFalse()
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
    }
}