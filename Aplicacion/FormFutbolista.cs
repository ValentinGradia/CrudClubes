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

        public FormFutbolista():base()
        {
            InitializeComponent(); 
            Array piernas = Enum.GetValues(typeof(EPierna));

            foreach (EPierna pierna in piernas)
            {
                this.cmbPierna.Items.Add(pierna);
            }
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
            this.btnAgregar.Text = "Modificar";

        }

        public void CargarDatos(Futbolista f)
        {
            base.txtApellido.Text = f.Apellido;
            base.txtEdad.Text = f.Edad.ToString();
            base.txtNombre.Text = f.Nombre;
            this.txtGoles.Text = f.Goles.ToString();
            base.cmbNacionalidades.SelectedIndex = Convert.ToInt32(f.Nacion);
            this.cmbPierna.SelectedIndex = Convert.ToInt32(f.Pierna);
            this.txtPosicion.Text = f.Posicion;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                return;
            }
            else
            {
                try
                {
                    this.cmbPierna.SelectedItem.ToString();

                    this.cmbNacionalidades.SelectedItem.ToString();
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show("Complete sus datos", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                string p = this.cmbPierna.SelectedItem.ToString();

                EPierna pierna = (EPierna)Enum.Parse(typeof(EPierna), p);

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
                        base.miDeportista = new Futbolista(base.nombre, base.apellido, base.edad, nacionalidad, "Sin posicion",
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
