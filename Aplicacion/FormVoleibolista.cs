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
    //public delegate void DelegateNacionalidades(bool flag, string pais, ComboBox cmb);
    public partial class FormVoleibolista : FormDatosJugadores, IJugadores<Voleibolista>
    {
        private string pais;
        private bool flag = false;

        public FormVoleibolista():base()
        {
            InitializeComponent();
        }

        private void FormVoleibolista_Load(object sender, EventArgs e)
        {
            this.cmbMano.Items.Add("Derecha");
            this.cmbMano.Items.Add("Izquierda");
            this.VerificarNacionalidades();

            this.cmbMano.SelectedIndex = 0;
        }

        public void VerificarNacionalidades()
        {
            if (this.flag == false)
            {
                this.cmbNacionalidades.SelectedIndex = 0;
            }
        }
        public FormVoleibolista(Voleibolista v) : this()
        {
            this.CargarDatos(v);
            this.txtPosicion.Text = v.Posicion;

            string pais = v.Nacion.ToString();

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

        public void CargarDatos(Voleibolista v)
        {
            base.txtApellido.Text = v.Apellido;
            base.txtNombre.Text = v.Nombre;
            base.txtEdad.Text = v.Edad.ToString();
            base.txtApellido.Enabled = false;
            base.txtNombre.Enabled = false;
            base.txtEdad.Enabled = false;
            base.cmbNacionalidades.Enabled = false;

        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
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
                    base.miDeportista = new Voleibolista(base.nombre, base.apellido, base.edad, nacion, mano);
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        /*private void RestablecerNacionalidades(bool flag, string pais, ComboBox cmb)
        {
            if (flag)
            {
                switch (pais)
                {
                    case "Argentino":
                        cmb.SelectedIndex = 0;
                        break;
                    case "Brasilero":
                        cmb.SelectedIndex = 1;
                        break;
                    case "Peruano":
                        cmb.SelectedIndex = 2;
                        break;
                    default:
                        cmb.SelectedIndex = 3;
                        break;
                }
            }

        }*/
    }
}
