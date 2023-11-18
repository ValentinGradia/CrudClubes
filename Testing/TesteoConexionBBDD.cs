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
    }
}
