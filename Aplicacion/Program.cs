namespace Aplicacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormCrud(5,"hola"));

            FormLogin formLogin = new FormLogin();

            Application.Run(new FormCrud(5, "Boca", "administrador"));

            /*
            try
            {
                do
                {
                    formLogin.ShowDialog();
                } while (formLogin.DialogResult == DialogResult.None);

                if (formLogin.DialogResult == DialogResult.OK)
                {
                    //ApplicationConfiguration.Initialize();
                    try
                    {
                        using(StreamWriter sw = new StreamWriter("usuarios.log.txt",true))
                        {
                            sw.WriteLine($"{formLogin.NombreUsuario} - {formLogin.MiUsuario.apellido} - {formLogin.MiUsuario.legajo} " +
                                $" {formLogin.MiUsuario.correo} - {formLogin.MiUsuario.clave} - {formLogin.MiUsuario.perfil} - {DateTime.Now}");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }

                    Application.Run(new FormEquipos(formLogin.NombreUsuario,DateTime.Now,formLogin.Perfil));

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            */
        }
    }
}