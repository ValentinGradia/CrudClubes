using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FormVoleibolista : FormDatosJugadores, IJugadores<Voleibolista>
    {

        public FormVoleibolista():base()
        {
            InitializeComponent();

            Array manos = Enum.GetValues(typeof(EMano));
            foreach(EMano mano in manos)
            {
                this.cmbMano.Items.Add(mano);
            }
        }

        public FormVoleibolista(Voleibolista v) : this()
        {
            this.CargarDatos(v);
            this.btnAgregar.Text = "Modificar";
        }

        public void CargarDatos(Voleibolista v)
        {
            base.txtApellido.Text = v.Apellido;
            base.txtNombre.Text = v.Nombre;
            base.txtEdad.Text = v.Edad.ToString();
            this.txtPosicion.Text = v.Posicion;
            base.cmbNacionalidades.SelectedIndex = Convert.ToInt32(v.Nacion);
            this.cmbMano.SelectedIndex = Convert.ToInt32(v.ManoDominante);

        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                return;
            }
            else
            {
                this.ValidarCmbNull();

                string n = this.cmbNacionalidades.SelectedItem.ToString();

                ENacionalidad nacion = (ENacionalidad)Enum.Parse(typeof(ENacionalidad), n);

                string m = this.cmbMano.SelectedItem.ToString();

                EMano mano = (EMano)Enum.Parse(typeof(EMano), m);

                if (FormDatosJugadores.ValidarNull(this.txtPosicion.Text))
                {
                    string posicion = this.txtPosicion.Text;

                    base.miDeportista = new Voleibolista(mano, base.nombre, base.apellido, base.edad, nacion, posicion);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.miDeportista = new Voleibolista(mano, base.nombre, base.apellido, base.edad, nacion, "Sin posicion");
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        public void ValidarCmbNull()
        {
            if (this.cmbMano.SelectedItem.ToString() == null | this.cmbNacionalidades.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Complete su informacion", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
