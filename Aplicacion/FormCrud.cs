using LibreriaDeClases;
using System.Windows.Forms;

namespace Aplicacion
{
    /// <summary>
    /// Mi formulario FormCrud se encarga de hacer que mi aplicacion cumpla los requisitos de un CRUD, basicamente crear jugadores, leerlos y agregarlos a la listbox, modificar los datos de estos y eliminarlos.
    /// Tambien puedes ordenar estos jugadores por distintos criteros, por ejemplo ordenar por edad. Ademas puedes guardar jugadores para luego poder agregarlos en otros equipos(deserealizandolos)
    /// </summary>
    public partial class FormCrud : Form, ICrud<FormDatosJugadores>, IValidarJugadorRepetido
    {
        private Club equipo;
        private string nombreEquipo;
        private FormJugadores form;
        private string perfilUsuario;
        private event Action<Club, Jugador, string> ActualizarEquipo;
        private event Func<DialogResult> ConfirmarEliminacion;
        private event DelegadoGuardarBBDD GuardarJugadores;
        private event DelegadoEliminarBBDD EliminarJugadores;
        private event DelegadoModificarBBDD ModificarJugadores;
        private delegate void DelegadoModificarBBDD(Jugador jugador);
        private delegate void DelegadoEliminarBBDD(Jugador jugador);
        private delegate void DelegadoGuardarBBDD(Jugador jugador);
        private AccesoDatos sql = new AccesoDatos();

        private FormCrud()
        {
            InitializeComponent();
        }

        //Cuando crea un equipo nuevo estos son los parametros que requieren para crearlo
        public FormCrud(string nombreEquipo, string perfil) : this()
        {
            this.equipo = new Club(nombreEquipo);
            this.nombreEquipo = nombreEquipo;
            this.perfilUsuario = perfil;
            this.Text = nombreEquipo;
        }

        //Si quiere modificar jugadores de un equipo, el parametro va a ser el equipo que selecciono modificar
        public FormCrud(Club equipo, string perfil) : this()
        {
            this.equipo = equipo;
            this.nombreEquipo = equipo.NombreEquipo;
            this.Text = nombreEquipo;
            this.perfilUsuario = perfil;
            this.Actualizar();
            this.btnAgregarEquipo.Text = "Modificar Equipo";
        }

        public Club MiEquipo
        { get { return this.equipo; } }


        public void Actualizar()
        {
            this.lstEquipo.Items.Clear();
            foreach (Jugador jugadores in equipo.MiEquipo)
            {
                lstEquipo.Items.Add(jugadores.ToString());
            }
        }

        private async Task ActualizarListBox()
        {
            if (this.lstEquipo.InvokeRequired)
            {
                //Invoco nuevamente a mi metodo Actualizar para que ingrese desde el hilo principal
                await Task.Run(() => lstEquipo.Invoke(ActualizarListBox));
            }
            else
            {
                this.Actualizar();

            }
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            this.CrearToolTip(this.btnAgregar, "Agregar Jugador");
        }

        private void CrearToolTip(Control button, string texto)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(button, texto);
        }

        /// <summary>
        /// El método btnModificar_Click se utiliza para gestionar la modificación de jugadores en una lista. Primero, verifica si se ha seleccionado un jugador y muestra un mensaje de error si no. 
        /// Luego, determina el tipo de jugador (Futbolista, Basquetbolista o Voleibolista) y abre un formulario correspondiente en modo de diálogo modal. 
        /// Finalmente, llama a un método FormModificar con el formulario y el índice seleccionado para permitir modificaciones en los datos del jugador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipo.SelectedIndex;

            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Jugador j = this.equipo.MiEquipo[selected];

                if (j is Futbolista)
                {
                    Futbolista f = (Futbolista)j;
                    FormFutbolista form = new FormFutbolista(f);
                    form.ShowDialog();

                    this.Modificar(form, selected);
                }
                else if (j is Basquetbolista)
                {
                    Basquetbolista b = (Basquetbolista)j;
                    FormBasquetbolista form = new FormBasquetbolista(b);
                    form.ShowDialog();

                    this.Modificar(form, selected);

                }
                else
                {
                    Voleibolista v = (Voleibolista)j;
                    FormVoleibolista form = new FormVoleibolista(v);
                    form.ShowDialog();

                    this.Modificar(form, selected);
                }
            }

        }

        /// <summary>
        /// Metodo creado con el fin de reutilizar codigo, basicamente que los datos modificados sean validos 
        /// </summary>
        /// <param name="formulario de un jugador"></param>
        /// <param name="el jugador seleccionado de la lista que va a ser modificado"></param>
        public void Modificar(FormDatosJugadores form, int selected)
        {
            if (form.DialogResult == DialogResult.OK)
            {
                this.ModificarJugadores.Invoke(form.MiDeportista);
                this.equipo.MiEquipo[selected] = form.MiDeportista;

                this.Actualizar();
            }
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            this.CrearToolTip(this.btnModificar, "Modificar Jugador");
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            this.CrearToolTip(this.btnEliminar, "Eliminar Jugador");
        }

        /// <summary>
        /// El método btnAgregar_Click en C# se utiliza para agregar jugadores a un equipo. Dependiendo de si el equipo está vacío o ha alcanzado su límite de jugadores, 
        /// se abre un formulario FormJugadores con la opción de agregar jugadores de diferentes tipos (Futbolistas, Basquetbolistas o Voleibolistas). 
        /// Si el usuario confirma la acción, el jugador se agrega al equipo y se actualiza la lista correspondiente. El método se encarga de manejar la interacción con el formulario y 
        /// realizar las modificaciones necesarias en el equipo en función de las elecciones del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.equipo.MiEquipo.Count == 0)
            {
                this.form = new FormJugadores();
            }
            else
            {
                //En el caso qu ya haya jugadores, le paso como parametro la lista para que no pase el limite de jugadores
                this.form = new FormJugadores(this.equipo.MiEquipo);
            }

            this.form.ShowDialog();

            if (this.form.DialogResult == DialogResult.OK)
            {

                this.GuardarJugadores.Invoke(this.form.MiJugador);
                this.ActualizarEquipo.Invoke(this.equipo, this.form.MiJugador, "Agregar");
            }
            else
            {
                this.form.Close();
            }
        }

        private void GuardarJugadoresBBDD(Jugador jugador)
        {

            if (jugador is Futbolista)
            {
                Futbolista f = (Futbolista)jugador;
                sql.AgregarJugador<Futbolista>(f, this.equipo.NombreEquipo);
            }
            else if (jugador is Basquetbolista)
            {
                Basquetbolista b = (Basquetbolista)jugador;
                sql.AgregarJugador<Basquetbolista>(b, this.equipo.NombreEquipo);
            }
            else
            {
                Voleibolista v = (Voleibolista)jugador;
                sql.AgregarJugador<Voleibolista>(v, this.equipo.NombreEquipo);
            }

        }

        private void EliminarJugadoresBBDD(Jugador jugador)
        {

            if (jugador is Futbolista)
            {
                Futbolista f = (Futbolista)jugador;
                sql.EliminarJugador<Futbolista>(f, equipo.NombreEquipo);
            }
            else if (jugador is Basquetbolista)
            {
                Basquetbolista b = (Basquetbolista)jugador;
                sql.EliminarJugador<Basquetbolista>(b, equipo.NombreEquipo);
            }
            else
            {
                Voleibolista v = (Voleibolista)jugador;
                sql.EliminarJugador<Voleibolista>(v, equipo.NombreEquipo);
            }


        }


        private void ModificarJugadoresBBDD(Jugador jugador)
        {
            try
            {
                if (jugador is Futbolista)
                {
                    Futbolista f = (Futbolista)jugador;
                    sql.ModificarJugador(f, equipo.NombreEquipo);
                }
                else if (jugador is Basquetbolista)
                {
                    Basquetbolista b = (Basquetbolista)jugador;
                    sql.ModificarJugador(b, equipo.NombreEquipo);
                }
                else
                {
                    Voleibolista v = (Voleibolista)jugador;
                    sql.ModificarJugador(v, equipo.NombreEquipo);
                }
            }
            catch (JugadoNoExistenteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipo.SelectedIndex;

            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!(this.perfilUsuario == "supervisor"))
                {
                    if (this.ConfirmarEliminacion.Invoke() == DialogResult.Yes)
                    {
                        this.EliminarJugadores.Invoke(this.equipo.MiEquipo[selected]);
                        this.ActualizarEquipo.Invoke(this.equipo, this.equipo.MiEquipo[selected], "Eliminar");
                    }
                }
                else
                {
                    MessageBox.Show("No tiene permiso ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Le asocio a mi evento ActualizarEquipo este metodo para que una vez que agregue o elimine un jugador llamar a este para
        /// no tener que hacerlo en la funcion click
        /// </summary>
        /// <param name="equipo"></param>
        /// <param name="jugador"></param>
        /// <param name="Accion que voy a hacer"></param>
        private void ActualizarMiEquipo(Club equipo, Jugador jugador, string msg)
        {
            if (msg == "Agregar")
            {
                equipo += jugador;
            }
            else if (msg == "Eliminar") { equipo -= jugador; }

            this.Actualizar();
        }

        /// <summary>
        /// Metodo para que finalizar el agregado de jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnOrdenarEdadAscendente_Click(object sender, EventArgs e)
        {
            this.equipo.OrdenarEdad(0);
            this.Actualizar();
        }

        private void btnOrdenarEdadDescendente_Click(object sender, EventArgs e)
        {
            this.equipo.OrdenarEdad(1);
            this.Actualizar();
        }

        private void btnOrdenarApellidosAscendente_Click(object sender, EventArgs e)
        {
            this.equipo.OrdenarApellido(0);
            this.Actualizar();
        }

        private void btnOrdenarApellidosDescendente_Click(object sender, EventArgs e)
        {
            this.equipo.OrdenarApellido(1);
            this.Actualizar();
        }

        /*
        private void btnSerealizar_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipo.SelectedIndex;

            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Thread thread = new Thread(() =>
                {
                    Serializadora<Jugador> serializar = new Serializadora<Jugador>();
                    serializar.Serealizar(this.equipo.MiEquipo[selected], $"{this.equipo.MiEquipo[selected].Nombre}.XML");
                });

                thread.IsBackground = true;
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }

        }

        private void btnDeserealizar_Click(object sender, EventArgs e)
        {
            //Creo un hilo para poder serealizar trabajando con llamadas a interfaces ya que antes tenia el error
            //de System.Threading.ThreadStateException
            Thread thread = new Thread(async () =>
            {
                Serializadora<Jugador> Deserializar = new Serializadora<Jugador>();
                Deserializar.Deserealizar(this.equipo);
                await ActualizarListBox();//llamo a mi metodo actualizarlistbox porque la listbox va a ser modificada desde otro hilo al
                                          // que se inicio
            });

            thread.IsBackground = true; //Esto es para considerar el hilo de fondo, esto para que no siga ejecutando en segundo plano
            thread.SetApartmentState(ApartmentState.STA);//Por lo que vi sirve para tener acceso a objetos COM (El error que tenia antes venia con
                                                         //algo relacionado a esto)
            thread.Start();
        }*/

        public DialogResult Eliminar()
        {
            DialogResult pregunta = MessageBox.Show("Estás seguro de que deseas eliminar un jugador?", "Eliminar jugador"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return pregunta;
        }


        /// <summary>
        /// Al deserealizar los jugadores que tenga en la BBDD tengo que fijarme si alguno de esos jugadores ya estan en el equipo o no
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="equipo"></param>
        public void ValidarJugadorRepetido(Jugador jugador, Club equipo)
        {
            bool flag = true;
            if (equipo.MiEquipo.Count != 0)//Si en mi equipo no hay jugadores no tengo que hacer la validacion, esto lo hago porque antes si queria hacer
                                           //el foreach a la lista de equipo.Miequipo me rompia ya que no existian jugadores.
            {
                foreach (Jugador j in equipo.MiEquipo)
                {
                    if (j.Equals(jugador))
                    {
                        if (flag)
                        {
                            MessageBox.Show("Hay jugador/jugadores que ya pertenecen al equipo por lo que no seran agregados",
                                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //Aca le indico que sea false, para que si hay mas jugadores repetidos no vuelva a mostrar el mensaje y lo muestre solo una vez
                        flag = false;
                    }
                    else
                    {
                        equipo.MiEquipo.Add(jugador);
                        //Recordemos que mi equipo tiene listas diferentes para cada tipo de jugador (esto por la serializacion de json y sus errores) entonces
                        //no solo tengo que agregar el jugador a la lista general sino a la lista del tipo del jugador
                    }
                }
            }
            else
            {
                equipo.MiEquipo.Add(jugador);
            }

            this.Actualizar();

        }

        private void FormCrud_Load(object sender, EventArgs e)
        {
            this.ActualizarEquipo = this.ActualizarMiEquipo;
            this.ConfirmarEliminacion = this.Eliminar;

            DelegadoGuardarBBDD delegado = new DelegadoGuardarBBDD(this.GuardarJugadoresBBDD);
            DelegadoEliminarBBDD delegadoEliminar = new DelegadoEliminarBBDD(this.EliminarJugadoresBBDD);
            DelegadoModificarBBDD delegadoModificar = new DelegadoModificarBBDD(this.ModificarJugadoresBBDD);

            this.GuardarJugadores = delegado;
            this.ModificarJugadores = delegadoModificar;
            this.EliminarJugadores = delegadoEliminar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AgregarJugadores<T>(T jugador, List<T> lista)
        {

            lista.Add(jugador);

        }
    }


}
