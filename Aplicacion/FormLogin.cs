using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{

    /// <summary>
    /// La clase FormLogin es un formulario de inicio de sesión que facilita a los usuarios ingresar sus credenciales, como correo y contraseña, para autenticarse en la aplicación. 
    /// Cuando el usuario hace clic en el botón "Aceptar", el formulario intenta leer información de usuarios desde un archivo JSON llamado "MOCK_DATA.json" y valida las credenciales ingresadas 
    /// comparándolas con la lista de usuarios. Si se encuentra una coincidencia, el usuario es autenticado y se almacena su información. 
    /// En caso de una autenticación exitosa, se establece el resultado del formulario como "OK"; de lo contrario, se muestra un mensaje de error.
    /// </summary>
    public partial class FormLogin : Form
    {
        private string nombreUsuario;
        private Usuario miUsuario;
        private string perfil;
        private event Action<bool> comprobarUsuario;
        private event Action<TextBox, TextBox> limpiarTxt;

        public Usuario MiUsuario
        {
            get
            {
                return this.miUsuario;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
        }

        public string Perfil { get => perfil; set => perfil = value; }

        public FormLogin()
        {
            InitializeComponent();
            cbxContraseña.CheckedChanged += cbxContraseña_CheckedChanged;
            CargarImagenes();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                using (StreamReader sr = new StreamReader("MOCK_DATA.json"))
                {
                    string json = sr.ReadToEnd();

                    List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);


                    try
                    {
                        this.comprobarUsuario.Invoke(Validar(usuarios));
                    }
                    catch (NullContraseñaCorreoException ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.limpiarTxt.Invoke(this.txtMail, this.txtContraseña);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Validar que el usuario ingresado pertenezca al archivo de MOCKDATA
        /// </summary>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        private bool Validar(List<Usuario> usuarios)
        {
            bool flag = false;
            string correo = this.txtMail.Text;
            string contraseña = this.txtContraseña.Text;
            try
            {
                this.ValidarContraseñaCorreo();
                usuarios.ForEach((usuario) =>
                {
                    if (usuario.clave == contraseña & usuario.correo == correo)
                    {
                        flag = true;
                        this.miUsuario = usuario;
                        this.nombreUsuario = usuario.nombre;
                        this.perfil = usuario.perfil;
                    }
                });
                return flag;

            }
            catch (NullContraseñaCorreoException e)
            {
                throw e;
                //return false;
            }
        }

        /// <summary>
        /// En el caso que el usuario no pertenezca, tiro un mensaje diciendol error. Caso contrario accede a la aplicacion
        /// </summary>
        /// <param name="flag"></param>
        private void Mostrar(bool flag)
        {
            if (flag)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Contraseña y/o mail incorrecto", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                this.limpiarTxt.Invoke(this.txtMail, this.txtContraseña);
            }
        }

        private void ValidarContraseñaCorreo()
        {
            if (this.txtMail.Text == "" | this.txtContraseña.Text == "")
            {
                throw new NullContraseñaCorreoException("Error, Complete con sus datos");
            }
        }

        private void CargarImagenes()
        {
            try
            {

                pictureBox1.Image = System.Drawing.Image.FromFile(@"welcome.png");
                pictureBox2.Image = System.Drawing.Image.FromFile(@"hola.png");

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarTextBox(TextBox txt1, TextBox txt2)
        {
            txt1.Text = "";
            txt2.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.comprobarUsuario = this.Mostrar;
            this.limpiarTxt = this.LimpiarTextBox;
        }

        private void cbxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = cbxContraseña.Checked ? '\0' : '*';
        }
    }

}
