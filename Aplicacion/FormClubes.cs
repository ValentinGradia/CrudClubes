using LibreriaDeClases;

namespace Aplicacion
{
    /// <summary>
    /// La clase FormEquipos representa un formulario que permite a los usuarios gestionar una lista de equipos deportivos. Esta clase incluye una lista de equipos, 
    /// un formulario para crear equipos (formCrearEquipo), información de nombre de usuario y fecha de registro. El constructor inicializa la lista de equipos y puede recibir el 
    /// nombre de usuario y la fecha de registro como parámetros.
    /// </summary>
    public partial class FormClubes : Form, ICrud<FormCrud>
    {
        private List<Club> listaEquipos;
        private FormCrearClubes formCrearClubes;
        private string nombreUsuario;
        private DateTime fechaRegistro;
        private string perfilUsuario;
        public delegate void DelegadoImagenes(int num);


        public FormClubes()
        {
            InitializeComponent();
            this.listaEquipos = new List<Club>();
            CargarImagenes();
            Task hiloSecundario = Task.Run(() => CargarClubes());
        }

        private void CargarClubes()
        {
            do
            {
                Random random = new Random();
                MostrarImagenEquipo(random.Next(1, 6));
                Thread.Sleep(2500);

            } while (true);
        }

        private async void MostrarImagenEquipo(int num)
        {
            if (pictureBox4.InvokeRequired)
            {
                //Instancio mi delegado
                this.pictureBox4.Invoke((Action)(() => MostrarImagenEquipo(num)));
            }
            else
            {
                pictureBox4.Image = System.Drawing.Image.FromFile($@"{num}.png");

                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        /// <summary>
        /// Al crearlo tengo le paso los parametros del usuario que ingreso con la fecha para agregarlo al visualizador
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="fechaRegistro"></param>
        public FormClubes(string nombreUsuario, DateTime fechaRegistro, string perfilUsuario) : this()
        {
            this.nombreUsuario = nombreUsuario;
            this.fechaRegistro = fechaRegistro;
            this.perfilUsuario = perfilUsuario;
        }

        /// <summary>
        /// Instancio mi formCrearEquipo, en el caso de que ya haya creado un equipo anteriormente le pasare como parametro la lista de los equipos para luego hacer validaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(this.Validar_perfil_vendedor()))
            {
                if (listaEquipos.Count == 0)
                {
                    this.formCrearClubes = new FormCrearClubes(this.perfilUsuario);
                }
                else
                {
                    this.formCrearClubes = new FormCrearClubes(this.listaEquipos, this.perfilUsuario);
                }

                await Task.Run(() => formCrearClubes.ShowDialog());

                if (this.formCrearClubes.DialogResult == DialogResult.OK)
                {

                    this.listaEquipos.Add(this.formCrearClubes.EquipoCreado);
                    await ActualizarInterfaz();
                    this.Actualizar();
                }
            }
            else
            {
                this.Mostrar_Mensaje_Permiso();
            }

        }

        private void CargarImagenes()
        {
            try
            {

                pictureBox1.Image = System.Drawing.Image.FromFile(@"agregar.png");
                pictureBox2.Image = System.Drawing.Image.FromFile(@"modificar.png");
                pictureBox3.Image = System.Drawing.Image.FromFile(@"eliminar.png");

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task ActualizarInterfaz()
        {

            if (this.formCrearClubes.DialogResult == DialogResult.OK)
            {
                if (this.lstEquipos.InvokeRequired)
                {
                    //Invoco nuevamente a mi metodo Actualizar para que ingrese desde el hilo principal
                    await Task.Run(() => lstEquipos.Invoke(ActualizarInterfaz));
                }
                else
                {
                    this.Actualizar();

                }
            }

        }

        /// <summary>
        /// Mantener la listbox actualizada
        /// </summary>
        public void Actualizar()
        {
            this.lstEquipos.Items.Clear();
            foreach (Club equipo in this.listaEquipos)
            {
                lstEquipos.Items.Add(equipo.ToString() + $" - Cantidad jugadores: {equipo.CantidadJugadoresActual}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipos.SelectedIndex;


            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!(this.Validar_perfil_vendedor()))
                {
                    Club equipo = this.listaEquipos[selected];
                    FormCrud form = new FormCrud(equipo, this.perfilUsuario);
                    form.ShowDialog();
                    this.Modificar(form, selected);
                }
                else
                {
                    this.Mostrar_Mensaje_Permiso();
                }
            }
        }

        public void Modificar(FormCrud form, int selected)
        {
            if (form.DialogResult == DialogResult.OK)
            {
                this.listaEquipos[selected] = form.MiEquipo;
                this.Actualizar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipos.SelectedIndex;

            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!(this.Validar_perfil_vendedor()) & (!(this.Validar_perfil_supervisor())))
                {
                    if (this.Eliminar() == DialogResult.Yes)
                    {
                        this.listaEquipos.RemoveAt(selected); this.Actualizar();
                    }
                }
                else
                {
                    this.Mostrar_Mensaje_Permiso();
                }
            }

        }

        /// <summary>
        /// En el caso de que el usuario cierre el formulario le tiro un mensaje indicandole si esta seguro que quiere cerrar la aplicacion, esto con el fin de poder cancelar el cierre de dicha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEquipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Estás seguro de que deseas cerrar la aplicación?", "Cerrar la aplicación"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Esto es para que se muestre el nombre del usuario que ingreso con la fecha en la que ingreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEquipos_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = this.nombreUsuario;
            string fechaFormateada = this.fechaRegistro.ToString("yyyy-MM-dd");
            this.lblFechaRegistro.Text = fechaFormateada;

        }

        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialUsuarios form = new FormHistorialUsuarios();

            form.ShowDialog();


        }

        public DialogResult Eliminar()
        {
            DialogResult pregunta = MessageBox.Show("Estás seguro de que deseas eliminar el equipo?", "Eliminar equipo"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return pregunta;
        }

        private bool Validar_perfil_vendedor()
        {
            if (this.perfilUsuario == "vendedor")
            {
                return true;
            }

            return false;
        }

        private bool Validar_perfil_supervisor()
        {
            if (this.perfilUsuario == "supervisor")
            {
                return true;
            }

            return false;
        }

        private void Mostrar_Mensaje_Permiso()
        {
            MessageBox.Show("No tiene permiso ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
