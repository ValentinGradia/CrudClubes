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
        private string pais;
        private bool flag;

        public FormBasquetbolista():base()
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
            this.txtCalzado.Text = b.Calzado.ToString();
            this.txtAltura.Text = b.Altura.ToString();
            this.txtPosicion.Text = b.Posicion;

            string pais = b.Nacion.ToString();

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

            this.flag = true;

        }

        public void CargarDatos(Basquetbolista b)
        {
            base.txtApellido.Text = b.Apellido;
            base.txtEdad.Text = b.Edad.ToString();
            base.txtNombre.Text = b.Nombre;
            base.txtApellido.Enabled = false;
            base.txtEdad.Enabled = false;
            base.txtNombre.Enabled = false;
            base.cmbNacionalidades.Enabled = false;
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
                if (this.ValidarAlturaCalzado())
                {
                    int altura = int.Parse(this.txtAltura.Text);

                    float calzado = float.Parse(this.txtCalzado.Text);

                    if (FormDatosJugadores.ValidarNull(this.txtPosicion.Text))
                    {

                        string posicion = this.txtPosicion.Text;

                        base.miDeportista = new Basquetbolista(altura, calzado, posicion, base.nombre, base.apellido, base.edad, nacionalidad);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        base.miDeportista = new Basquetbolista(altura, calzado, base.nombre, base.apellido, base.edad, nacionalidad);
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

        private void FormBasquetbolista_Load_1(object sender, EventArgs e)
        {
            //Cuando el usuario agregue un basquetbolista esto va a ser el default de las nacionalidades
            this.VerificarNacionalidades();
        }

        public void VerificarNacionalidades()
        {
            if (this.flag == false)
            {
                this.cmbNacionalidades.SelectedIndex = 0;
            }

        }
    }
}
