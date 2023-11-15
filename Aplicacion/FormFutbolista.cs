using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeClases;

namespace Aplicacion
{

    /// <summary>
    /// La clase FormFutbolista representa un formulario específico para la creación y edición de jugadores de fútbol. La clase extiende la clase FormDatosJugadores y 
    /// agrega campos específicos de un futbolista, como nacionalidad, la cantidad de goles, y la pierna preferida. 
    /// Además, controla la lógica para validar y configurar los datos del futbolista antes de guardarlo.
    /// </summary>
    public partial class FormFutbolista : FormDatosJugadores, IJugadores<Futbolista>
    {
        private string pais;
        private bool flag = false;

        public FormFutbolista():base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El constructor FormFutbolista(Futbolista f)  se utiliza para inicializar el formulario FormFutbolista con los datos de un futbolista existente que se va a editar. 
        /// En este constructor, se rellenan los campos del formulario con los detalles del futbolista, como nombre, apellido, edad y la cantidad de goles. También se determina y 
        /// configura el país de nacionalidad del futbolista, y se deshabilita la edición de ciertos campos para evitar modificaciones accidentales. Además, se establece una bandera 
        /// flag para indicar que se están editando datos existentes. En conjunto, este constructor simplifica la tarea de modificar información de futbolistas existentes en el formulario FormFutbolista.
        /// </summary>
        /// <param name="futbolista a modificar"></param>
        public FormFutbolista(Futbolista f) : this()
        {
            this.CargarDatos(f);
            this.txtGoles.Text = f.Goles.ToString();


            string pais = f.Nacion.ToString();

            switch (pais)
            {
                case "Argentino":
                    this.pais = "Argentino";
                    break;
                case "Brasilero":
                    this.pais = "Brasilero";
                    break;
                case "Peruano":
                    this.pais = "Peruano";
                    break;
                default:
                    this.pais = "Canadiense";
                    break;
            }

            this.txtGoles.Enabled = false;
            this.flag = true;

            f.Restablecer("", EPierna.Diestro);
            //this.cmbPierna.SelectedItem = f.Pierna.ToString();
        }

        public void CargarDatos(Futbolista f)
        {
            base.txtApellido.Text = f.Apellido;
            base.txtEdad.Text = f.Edad.ToString();
            base.txtNombre.Text = f.Nombre;
            base.txtApellido.Enabled = false;
            base.txtEdad.Enabled = false;
            base.txtNombre.Enabled = false;
            base.cmbNacionalidades.Enabled = false;
        }

        private void FormAgregarFutbolista_Load(object sender, EventArgs e)
        {

            this.cmbPierna.Items.Add("Diestro");
            this.cmbPierna.Items.Add("Zurdo");
            //Cuando el usuario agregue un futbolista esto va a ser el default de las nacionalidades
            this.VerificarNacionalidades();

            this.cmbPierna.SelectedIndex = 0;

        }

        public void VerificarNacionalidades()
        {
            if (this.flag == false)
            {
                this.cmbNacionalidades.SelectedIndex = 0;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                return;
            }
            else
            {
                string p = this.cmbPierna.SelectedItem.ToString();

                EPierna pierna = (EPierna)Enum.Parse(typeof(EPierna), p);

                //Si la bandera es true, quiere decir que el jugador ya se agrego por lo que se va a modificar datos y la nacionalidad es disabled. Entonces a traves de la opcion que eligio
                // va a ser la opcion que quede. Esto lo cree para que no tire error en el combobox, ya que apareceria como que no selecciono ninguno.
                if (this.flag)
                {
                    switch (this.pais)
                    {
                        case "Argentino":
                            this.cmbNacionalidades.SelectedIndex = 0;
                            break;
                        case "Brasilero":
                            this.cmbNacionalidades.SelectedIndex = 1;
                            break;
                        case "Peruano":
                            this.cmbNacionalidades.SelectedIndex = 2;
                            break;
                        default:
                            this.cmbNacionalidades.SelectedIndex = 3;
                            break;
                    }

                }

                string n = this.cmbNacionalidades.SelectedItem.ToString();

                ENacionalidad nacionalidad = (ENacionalidad)Enum.Parse(typeof(ENacionalidad), n);


                if (this.ValidarGoles())
                {
                    int goles = int.Parse(this.txtGoles.Text);
                    //La posicion es un parametro opcional
                    if (FormDatosJugadores.ValidarNull(this.txtPosicion.Text))
                    {
                        string posicion = this.txtPosicion.Text;

                        base.miDeportista = new Futbolista(base.nombre, base.apellido, base.edad, nacionalidad, posicion,
                                        goles, pierna);

                        this.DialogResult = DialogResult.OK;
                        return;

                    }
                    else
                    {
                        base.miDeportista = new Futbolista(base.nombre, base.apellido, base.edad, nacionalidad,
                            goles, pierna);

                        this.DialogResult = DialogResult.OK;
                        return;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.None;

                }
            }
        }

        private bool ValidarGoles()
        {
            if (int.TryParse(this.txtGoles.Text, out int goles))
            {
                return true;

            }
            else
            {
                MessageBox.Show("Ingrese un numero", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
