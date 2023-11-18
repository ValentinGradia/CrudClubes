using LibreriaDeClases;

namespace Aplicacion
{
    /// <summary>
    /// La clase FormCrearEquipo es un formulario de Windows Forms para crear equipos deportivos. Permite al usuario ingresar el nombre y la cantidad de jugadores del equipo. 
    /// Al confirmar, valida los datos, abre un formulario adicional para agregar información de los jugadores y almacena el equipo creado.
    /// Muestra mensajes de error si los datos son inválidos o la cantidad de jugadores es insuficiente.
    /// </summary>
    public partial class FormCrearEquipo : Form
    {
        private Equipo equipoCreado;
        private List<Equipo> equiposLista;
        private string perfilUsuario;

        public Equipo EquipoCreado
        {
            get { return this.equipoCreado; }
        }

        public FormCrearEquipo(string perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
        }

        /// <summary>
        /// Este constructor lo llamo en el caso que ya se hayan creado equipos
        /// </summary>
        /// <param name="listaEquipos"></param>
        public FormCrearEquipo(List<Equipo> listaEquipos, string perfil) : this(perfil)
        {
            this.equiposLista = listaEquipos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtCantJugadores.Text, out int cantJugadores))
            {
                if (cantJugadores > 0)
                {
                    string nombreEquipo = this.txtNombreEquipo.Text;

                    FormCrud formCrud = new FormCrud(cantJugadores, nombreEquipo, this.perfilUsuario);

                    formCrud.ShowDialog();
                    this.equipoCreado = formCrud.MiEquipo;
                    this.DialogResult = DialogResult.OK;


                    //this.Visible = false;
                    /*formCrud.ShowDialog();
                    this.equipoCreado = formCrud.MiEquipo;

                    this.DialogResult = DialogResult.OK;*/


                }
                else
                {
                    MessageBox.Show("Minimo debe tener un jugador", "ERRORR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }

            }
            else
            {
                MessageBox.Show("Datos incorrectos", "ERRORR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }

        }



    }
}
