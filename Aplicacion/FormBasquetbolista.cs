using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    /// <summary>
    /// FormBasquetbolista es un formulario de Windows Forms que permite ingresar y editar información de un basquetbolista. 
    /// Permite cargar datos de un jugador existente para edición, valida datos como altura y calzado, y facilita la creación de un objeto "Basquetbolista". 
    /// Este formulario se utiliza en una aplicación de gestión de basquetbolistas.
    /// </summary>
    public partial class FormBasquetbolista : FormDatosJugadores, IJugadores<Basquetbolista>
    {


        public FormBasquetbolista() : base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Este constructor de "FormBasquetbolista" permite cargar los datos de un basquetbolista existente para su edición en el formulario. 
        /// Establece los campos de nombre, apellido, edad, calzado, altura y posición con los valores del basquetbolista proporcionado. 
        /// Además, determina la nacionalidad del jugador y ajusta la interfaz para bloquear la edición de ciertos campos.
        /// </summary>
        /// <param name="basquetbolista"></param>
        public FormBasquetbolista(Basquetbolista b) : this()
        {
            this.CargarDatos(b);
            this.btnAgregar.Text = "Modificar";
        }

        public void CargarDatos(Basquetbolista b)
        {
            base.txtApellido.Text = b.Apellido;
            base.txtEdad.Text = b.Edad.ToString();
            base.txtNombre.Text = b.Nombre;
            this.txtCalzado.Text = b.Calzado.ToString();
            this.txtAltura.Text = b.Altura.ToString();
            this.txtPosicion.Text = b.Posicion;
            base.cmbNacionalidades.SelectedIndex = Convert.ToInt32(b.Nacion);
        }

        /// <summary>
        /// El método btnAgregar_Click_1  verifica si se debe agregar un basquetbolista, ajusta la nacionalidad si es necesario, valida datos de altura y calzado, 
        /// crea un objeto "Basquetbolista" y establece el resultado del diálogo como "OK". Si los datos no son válidos, muestra un mensaje de error y establece el resultado como "None".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                return;
            }
            else
            {
                this.ValidarCmbNull();

                string n = this.cmbNacionalidades.SelectedItem.ToString();

                ENacionalidad nacionalidad = (ENacionalidad)Enum.Parse(typeof(ENacionalidad), n);
                if (this.ValidarAlturaCalzado())
                {
                    int altura = int.Parse(this.txtAltura.Text);

                    int calzado = int.Parse(this.txtCalzado.Text);

                    if (FormDatosJugadores.ValidarNull(this.txtPosicion.Text))
                    {

                        string posicion = this.txtPosicion.Text;

                        base.miDeportista = new Basquetbolista(altura, calzado, posicion, base.nombre, base.apellido, base.edad, nacionalidad);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        base.miDeportista = new Basquetbolista(altura, calzado, "Sin posicion", base.nombre, base.apellido, base.edad, nacionalidad);
                        this.DialogResult = DialogResult.OK;
                    }

                }
                else
                {
                    MessageBox.Show("Error, datos incorrectos", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }

        }

        public void ValidarCmbNull()
        {
            if (this.cmbNacionalidades.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Complete su informacion", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarAlturaCalzado()
        {
            bool flag = false;

            if (int.TryParse(this.txtAltura.Text, out int altura))
            {
                if (int.TryParse(this.txtCalzado.Text, out int calzado))
                {
                    flag = true;
                }
            }

            return flag;
        }



    }
}
