using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion;
using LibreriaDeClases;

namespace Testing
{
    [TestClass]
    public class TesteoConexionBBDD
    {
        [TestMethod]
        public void VerificarConexionABBDD_DeberiaRetornarTrue()
        {
            //Arrange
            AccesoDatos acceso = new AccesoDatos();

            bool retono = false;

            //Act
            try
            {
                acceso.conexion.Open();
                retono = true;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                if(acceso.conexion.State == System.Data.ConnectionState.Open)
                {
                    acceso.conexion.Close();
                }
            }

            //Assert
            Assert.IsTrue(retono);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjetoDuplicadoException))]
        public void AgregarJugador_CuandoYaEsteEnLaBBDD_DeberiaRetornarException()
        {
            //Arrange
            Futbolista f = new Futbolista("Marco", "Polo", 34, ENacionalidad.Argentino, "Delantero", 34, EPierna.Zurdo);

            Futbolista f1 = new Futbolista("Marco", "Polo", 20, ENacionalidad.Brasilero, "Delantero", 34, EPierna.Diestro);

            AccesoDatos a = new AccesoDatos();

            //Act
            _ = a.AgregarJugador<Futbolista>(f,"Boca");

            _ = a.AgregarJugador<Futbolista>(f1,"Boca");


        }

        [TestMethod]
        [ExpectedException(typeof(JugadoNoExistenteException))]
        public void ModificarJugador_CuandoNoExistaEnLaBBDD_DeberiaRetornarException()
        {
            //Arrange
            Futbolista f = new Futbolista("Tute", "Pro", 24, ENacionalidad.Canadiense, "Defensor", 34, EPierna.Zurdo);

            AccesoDatos a = new AccesoDatos();

            //Act
            _ = a.ModificarJugador<Futbolista>(f,"Boca");

        }

        [TestMethod]
        [ExpectedException(typeof(JugadoNoExistenteException))]
        public void EliminarJugador_CuandoNoExistaEnLaBBDD_DeberiaRetornarException()
        {
            //Arrange
            Futbolista f = new Futbolista("Tute", "Pro", 24, ENacionalidad.Canadiense, "Defensor", 34, EPierna.Zurdo);

            AccesoDatos a = new AccesoDatos();

            //Act
            _ = a.EliminarJugador<Futbolista>(f,"Bok");

        }
    }
}
