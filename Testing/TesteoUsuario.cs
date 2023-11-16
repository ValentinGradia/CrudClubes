using Aplicacion;
using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace Testing
{
    [TestClass]
    public class TesteoUsuario
    {
        [TestMethod]
        public void ValidarUsuario_CuandoContraseñaEsIncorrecta()
        {
            //Arrange
            string correoIncorrecto = "mailincorrecto@gmail.com";
            string contraseñaIncorrecta = "contraseña incorrecta";
            bool flag = false;

            //Act
            try
            {
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                using (StreamReader sr = new StreamReader("MOCK_DATA.json"))
                {
                    string json = sr.ReadToEnd();

                    List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

                    usuarios.ForEach((usuario) =>
                    {
                        if (usuario.correo == correoIncorrecto & usuario.clave == contraseñaIncorrecta)
                        {
                            flag = true;
                        }
                    });


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Assert
            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void ValidarUsuario_CuandoContraseñaEsCorrecta()
        {
            //Arrange
            string correoCorrecto= "admin@admin.com";
            string contraseñaCorrecta = "12345678";
            bool flag = false;

            //Act
            try
            {
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                using (StreamReader sr = new StreamReader("MOCK_DATA.json"))
                {
                    string json = sr.ReadToEnd();

                    List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

                    usuarios.ForEach((usuario) =>
                    {
                        if (usuario.correo == correoCorrecto & usuario.clave == contraseñaCorrecta)
                        {
                            flag = true;
                        }
                    });


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Assert
            Assert.IsTrue(flag);
        }
    }
}
