using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    /// <summary>
    /// La clase FormDatosJugadoreses una clase que extiende la funcionalidad de un formulario en una aplicación de manejo de datos de jugadores. 
    /// La clase incluye campos protegidos para la edad, nombre, apellido y un objeto Jugador. Además, proporciona un constructor que inicializa componentes visuales 
    /// y métodos protegidos que permiten la validación de datos de entrada, como la edad y la no nulidad de nombres y apellidos. 
    /// Estos métodos se utilizan en el evento de clic del botón "Agregar", que recopila información de los campos de entrada y la asigna a las propiedades correspondientes. 
    /// La clase también incluye un método protegido para validar edades, y métodos adicionales para validar la no nulidad de cadenas, con opciones para uno, dos o tres campos de texto. 
    /// </summary>
    public partial class FormDatosJugadores : Form
    {
        protected int edad;
        protected string nombre;
        protected string apellido;
        protected Jugador miDeportista;

        public virtual Jugador MiDeportista
        {
            get
            {
                return this.miDeportista;
            }
        }

        public FormDatosJugadores()
        {
            InitializeComponent();
            Array paises = Enum.GetValues(typeof(ENacionalidad));

            foreach (ENacionalidad pais in paises)
            {
                this.cmbNacionalidades.Items.Add(pais);

            }
            this.Shown += FormDatosJugadores_Load;
        }

        protected void FormDatosJugadores_Load(object sender, EventArgs e)
        {
            this.txtNombre.Focus();
            this.txtEdad.PlaceholderText = "Entre 18 y 50";
            //int valor = this.cmbNacionalidades.Items.Count;

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormDatosJugadores.ValidarNull(this.txtNombre.Text, this.txtApellido.Text))
                {
                    if (FormDatosJugadores.ValidarEdad(this.txtEdad.Text))
                    {
                        this.nombre = this.txtNombre.Text;
                        this.apellido = this.txtApellido.Text;
                        this.edad = int.Parse(this.txtEdad.Text);
                        this.DialogResult = DialogResult.OK;
                    }

                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Edad: {ex.Message}");
                this.DialogResult = DialogResult.None;
            }


        }

        protected static bool ValidarEdad(string text)
        {
            bool flag = false;
            if (!(int.TryParse(text, out int edad)))
            {
                MessageBox.Show("Edad incorrecta, ingrese un numero", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (edad > 50 | edad < 18)
                {
                    MessageBox.Show("Ingrese una edad valida", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    flag = true;
                }
            }

            return flag;


        }

        protected static bool ValidarNull(string text)
        {
            bool flag = false;

            if (!(string.IsNullOrEmpty(text)))
            {
                flag = true;
            }

            return flag;
        }

        protected static bool ValidarNull(string text, string text2)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(text) | string.IsNullOrEmpty(text2))
            {
                //MessageBox.Show("Error, datos incorrectos", "ERRORR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
