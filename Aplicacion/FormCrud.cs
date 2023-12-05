using LibreriaDeClases;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace Aplicacion
{
    /// <summary>
    /// Mi formulario FormCrud se encarga de hacer que mi aplicacion cumpla los requisitos de un CRUD, basicamente crear jugadores, leerlos y agregarlos a la listbox, modificar los datos de estos y eliminarlos.
    /// Tambien puedes ordenar estos jugadores por distintos criteros, por ejemplo ordenar por edad. Ademas puedes guardar jugadores para luego poder agregarlos en otros equipos(deserealizandolos)
    /// </summary>
    public partial class FormCrud : Form, ICrud<FormDatosJugadores>, IValidarJugadorRepetido
    {
        private Equipo equipo;
        private string nombreEquipo;
        protected int cantJugadoresMax;
        private FormJugadores form;
        private string perfilUsuario;
        private event Action<bool, string> ComprobarProceso;
        private event Action<Equipo, Jugador, string> ActualizarEquipo;
        private event Func<DialogResult> ConfirmarEliminacion;


        private FormCrud()
        {
            InitializeComponent();
        }

        //Cuando crea un equipo nuevo estos son los parametros que requieren para crearlo
        public FormCrud(int cantJugadores, string nombreEquipo, string perfil) : this()
        {
            this.equipo = new Equipo(cantJugadores, nombreEquipo);
            this.nombreEquipo = nombreEquipo;
            this.cantJugadoresMax = cantJugadores;
            this.perfilUsuario = perfil;
        }

        //Si quiere modificar jugadores de un equipo, el parametro va a ser el equipo que selecciono modificar
        public FormCrud(Equipo equipo, string perfil) : this()
        {
            this.equipo = equipo;
            this.cantJugadoresMax = equipo.CantidadJugadores;
            this.nombreEquipo = equipo.NombreEquipo;
            this.perfilUsuario = perfil;
            this.Actualizar();
        }

        public Equipo MiEquipo
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
            else if (this.equipo.MiEquipo.Count == this.cantJugadoresMax)
            {
                MessageBox.Show("Se alcanzo el limite de jugadores", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //En el caso qu ya haya jugadores, le paso como parametro la lista para que no pase el limite de jugadores
                this.form = new FormJugadores(this.equipo.MiEquipo);
            }

            this.form.ShowDialog();

            if (this.form.DialogResult == DialogResult.OK)
            {
                //Esto lo hago para luego poder serealizar por tipos de jugador
                switch (this.form.MiJugador)
                {
                    case Futbolista:
                        this.equipo.Futbolistas.Add((Futbolista)this.form.MiJugador);
                        break;
                    case Basquetbolista:
                        this.equipo.Basquetbolistas.Add((Basquetbolista)this.form.MiJugador);
                        break;
                    default:
                        this.equipo.Voleibolistas.Add((Voleibolista)this.form.MiJugador);
                        break;
                }

                this.ActualizarEquipo.Invoke(this.equipo, this.form.MiJugador, "Agregar");
            }
            else
            {
                this.form.Close();
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
                        //this.equipo = this.equipo - this.equipo.MiEquipo[selected];
                        switch (this.equipo.MiEquipo[selected]) //Aca no le paso como parametro el this.form.Mijugador ya que me devuelve el ultimo
                                                                //jugador que se agrego a la lista y por eso tiraba error solo al eliminar
                        {
                            case Futbolista:
                                this.equipo.Futbolistas.Remove((Futbolista)this.equipo.MiEquipo[selected]);
                                break;
                            case Basquetbolista:
                                this.equipo.Basquetbolistas.Remove((Basquetbolista)this.equipo.MiEquipo[selected]);
                                break;
                            default:
                                this.equipo.Voleibolistas.Remove((Voleibolista)this.equipo.MiEquipo[selected]);
                                break;
                        }

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
        private void ActualizarMiEquipo(Equipo equipo, Jugador jugador, string msg)
        {
            if (msg == "Agregar")
            {
                equipo = equipo + jugador;
            }
            else if (msg == "Eliminar") { equipo = equipo - jugador; }

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


        /// <summary>
        /// El método btnGuardarFutbolistas_Click se encarga de guardar la información de los futbolistas del equipo en un archivo JSON. Primero, define el nombre predeterminado del archivo y 
        /// muestra un cuadro de diálogo para que el usuario elija dónde guardar el archivo. Si el usuario confirma la ubicación de guardado, utiliza la clase StreamWriter para escribir los datos 
        /// de los futbolistas en formato JSON en el archivo. Además, se maneja cualquier excepción que pueda ocurrir y muestra un mensaje de error si se produce un problema durante la operación. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarFutbolistas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Serializadora<Futbolista> serializarFutbolistas = new Serializadora<Futbolista>();
                serializarFutbolistas.Serealizar(this.equipo.Futbolistas, "Futbolistas.JSON");
            });

            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        /// <summary>
        /// El método btnDeserealizarFutbolistas_Click se encarga de deserializar datos de futbolistas desde un archivo JSON. Primero, el usuario selecciona el archivo a través de un cuadro de diálogo, 
        /// y luego el método lee y deserializa los datos en una lista de objetos Futbolista, que se almacena en la propiedad correspondiente del equipo. 
        /// Luego, se verifica si el equipo ha alcanzado su límite de jugadores, mostrando una advertencia en caso afirmativo. Posteriormente, se verifica 
        /// y actualiza la información de los jugadores deserializados en el equipo y se llama al método Actualizar para reflejar estos cambios en la interfaz de usuario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeserealizarFutbolistas_Click(object sender, EventArgs e)
        {
            //Creo un hilo para poder serealizar trabajando con llamadas a interfaces ya que antes tenia el error
            //de System.Threading.ThreadStateException
            Thread thread = new Thread(async () =>
            {
                Serializadora<Futbolista> deserealizarFutbolistas = new Serializadora<Futbolista>();
                deserealizarFutbolistas.Deserealizar(this.equipo);
                await ActualizarListBox();//llamo a mi metodo actualizarlistbox porque la listbox va a ser modificada desde otro hilo al
                                          // que se inicio
            });

            thread.IsBackground = true; //Esto es para considerar el hilo de fondo, esto para que no siga ejecutando en segundo plano
            thread.SetApartmentState(ApartmentState.STA);//Por lo que vi sirve para tener acceso a objetos COM (El error que tenia antes venia con
                                                         //algo relacionado a esto)
            thread.Start();
        }

        private void btnGuardarBasquetbolistas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Serializadora<Basquetbolista> serializarBasquetbolistas = new Serializadora<Basquetbolista>();
                serializarBasquetbolistas.Serealizar(this.equipo.Basquetbolistas, "Basquetbolistas.JSON");
            });

            thread.IsBackground = true; //Esto es para considerar el hilo de fondo, esto para que no siga ejecutando en segundo plano
            thread.SetApartmentState(ApartmentState.STA);//Por lo que vi sirve para tener acceso a objetos COM (El error que tenia antes venia con
                                                         //algo relacionado a esto)
            thread.Start();
        }

        private void btnDeserealizarBasquetbolistas_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(async () =>
            {
                Serializadora<Basquetbolista> deserealizarBasquetbolistas = new Serializadora<Basquetbolista>();
                deserealizarBasquetbolistas.Deserealizar(this.equipo);
                await ActualizarListBox();
            });

            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void btnGuardarVoleibolistas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Serializadora<Voleibolista> serializarVoleibolistas = new Serializadora<Voleibolista>();
                serializarVoleibolistas.Serealizar(this.equipo.Voleibolistas, "Voleibolistas.JSON");
            });

            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void btnDeserealizarVoleibolistas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(async () =>
            {
                Serializadora<Voleibolista> deserealizarVoleibolistas = new Serializadora<Voleibolista>();
                deserealizarVoleibolistas.Deserealizar(this.equipo);
                await ActualizarListBox();
            });

            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        public DialogResult Eliminar()
        {
            DialogResult pregunta = MessageBox.Show("Estás seguro de que deseas eliminar un jugador?", "Eliminar jugador"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return pregunta;
        }

        /// <summary>
        /// Metodo el cual guardo mi jugador en la bbdd. Primero, verifico si se ha seleccionado un elemento en la listbox (lstEquipo).
        /// Luego creo una instancia de la clase AccesoDatos para conectarme  a la BBDD
        ///  Despues agrego el jugador a la base de datos, invocando un evento (ComprobarProceso) para informar sobre el resultado. 
        /// Si ocurre una excepción del tipo ObjetoDuplicadoException (que el jugador ya este guardado en la BBDD), muestra un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarBBDD_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipo.SelectedIndex;
            bool flag;

            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccesoDatos acceso = new AccesoDatos();
                Jugador j = this.equipo.MiEquipo[selected];
                try
                {
                    if (j is Futbolista)
                    {
                        Futbolista f = (Futbolista)j;
                        flag = acceso.AgregarJugador<Futbolista>(f);
                        this.ComprobarProceso.Invoke(flag, "guardo");
                    }
                    else if (j is Basquetbolista)
                    {
                        Basquetbolista b = (Basquetbolista)j;
                        flag = acceso.AgregarJugador<Basquetbolista>(b);
                        this.ComprobarProceso.Invoke(flag, "guardo");
                    }
                    else
                    {
                        Voleibolista v = (Voleibolista)j;
                        flag = acceso.AgregarJugador<Voleibolista>(v);
                        this.ComprobarProceso.Invoke(flag, "guardo");
                    }
                }
                catch (ObjetoDuplicadoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void VerificarProceso(bool flag, string msg)
        {
            if (flag) { MessageBox.Show($"Se {msg} el jugador en la base de datos", "SUCCESFULLY", MessageBoxButtons.OK); }
            else MessageBox.Show("Algo salio mal...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnModificarBBDD_MouseHover(object sender, EventArgs e)
        {
            this.CrearToolTip(this.btnModificarBBDD, "Dicho jugador a modificar debe estar previamente guardado en la BBDD");
        }

        private void btnEliminarBBDD_MouseHover(object sender, EventArgs e)
        {
            this.CrearToolTip(this.btnEliminarBBDD, "Dicho jugador a modificar debe estar previamente guardado en la BBDD");
        }


        /// <summary>
        /// Metodo el cual modifico mi jugador en la BBDD. Primero, verifico si se ha seleccionado un elemento en la listbox (lstEquipo).
        /// Luego creo una instancia de la clase AccesoDatos para conectarme  a la BBDD
        ///  Despues valido que el jugador este guardado previamenete en la base de datos
        /// Si ocurre una excepción del tipo JugadorNoexistente (que el jugador no este guardado en la BBDD), muestra un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarBBDD_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipo.SelectedIndex;
            bool flag;

            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccesoDatos acceso = new AccesoDatos();
                Jugador j = this.equipo.MiEquipo[selected];
                try
                {
                    if (j is Futbolista)
                    {
                        Futbolista f = (Futbolista)j;
                        flag = acceso.ModificarJugador<Futbolista>(f);
                        this.ComprobarProceso.Invoke(flag, "modifico");
                    }
                    else if (j is Basquetbolista)
                    {
                        Basquetbolista b = (Basquetbolista)j;
                        flag = acceso.ModificarJugador<Basquetbolista>(b);
                        this.ComprobarProceso.Invoke(flag, "modifico");
                    }
                    else
                    {
                        Voleibolista v = (Voleibolista)j;
                        flag = acceso.ModificarJugador<Voleibolista>(v);
                        this.ComprobarProceso.Invoke(flag, "modifico");
                    }
                }
                catch (JugadoNoExistenteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        /// <summary>
        /// Mismo procedimiento que la funcion de Modificar_BBDD pero en este caso elimino en vez de modificar
        /// Todos los pasos son los mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarBBDD_Click(object sender, EventArgs e)
        {
            int selected = this.lstEquipo.SelectedIndex;
            bool flag;

            if (selected == -1)
            {
                MessageBox.Show("Seleccione uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccesoDatos acceso = new AccesoDatos();
                Jugador j = this.equipo.MiEquipo[selected];
                try
                {
                    if (j is Futbolista)
                    {
                        Futbolista f = (Futbolista)j;
                        flag = acceso.EliminarJugador<Futbolista>(f);
                        this.ComprobarProceso.Invoke(flag, "elimino");
                    }
                    else if (j is Basquetbolista)
                    {
                        Basquetbolista b = (Basquetbolista)j;
                        flag = acceso.EliminarJugador<Basquetbolista>(b);
                        this.ComprobarProceso.Invoke(flag, "elimino");
                    }
                    else
                    {
                        Voleibolista v = (Voleibolista)j;
                        flag = acceso.EliminarJugador<Voleibolista>(v);
                        this.ComprobarProceso.Invoke(flag, "elimino");
                    }
                }
                catch (JugadoNoExistenteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        /// <summary>
        /// Metodo para obtener la tabla (que en este caso seria la lista de tipos de jugadores) de la BBDD
        /// Primero verifico el radiobutton para ver que tipo de tabla /lista voy a traer y luego valido que los jugadores
        /// que traiga no esten agregados en el equipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObtenerBBDD_Click(object sender, EventArgs e)
        {
            AccesoDatos acceso = new AccesoDatos();

            if (this.rdbFutbolistas.Checked)
            {
                List<Futbolista> listaFutbolistas = acceso.ObtenerListaDatos<Futbolista>();
                listaFutbolistas.ForEach((jugador) => this.ValidarJugadorRepetido(jugador, this.equipo));
            }
            else if (this.rdbBasquetbolistas.Checked)
            {
                List<Basquetbolista> listaBasquetbolistas = acceso.ObtenerListaDatos<Basquetbolista>();
                listaBasquetbolistas.ForEach((jugador) => this.ValidarJugadorRepetido(jugador, this.equipo));
            }
            else
            {
                List<Voleibolista> listaVoleibolistas = acceso.ObtenerListaDatos<Voleibolista>();
                listaVoleibolistas.ForEach((jugador) => this.ValidarJugadorRepetido(jugador, this.equipo));

            }
        }

        /// <summary>
        /// Al deserealizar los jugadores que tenga en la BBDD tengo que fijarme si alguno de esos jugadores ya estan en el equipo o no
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="equipo"></param>
        public void ValidarJugadorRepetido(Jugador jugador, Equipo equipo)
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
                        this.VerificarTipoJugador(jugador, equipo);
                    }
                }
            }
            else
            {
                equipo.MiEquipo.Add(jugador);
                this.VerificarTipoJugador(jugador, equipo);
            }

            this.Actualizar();

        }

        public void VerificarTipoJugador(Jugador jugador, Equipo equipo)
        {
            if (jugador is Futbolista)
            {
                this.AgregarJugadores<Futbolista>((Futbolista)jugador, equipo.Futbolistas);
            }
            else if (jugador is Basquetbolista)
            {
                this.AgregarJugadores<Basquetbolista>((Basquetbolista)jugador, equipo.Basquetbolistas);
            }
            else
            {
                this.AgregarJugadores<Voleibolista>((Voleibolista)jugador, equipo.Voleibolistas);
            }
        }

        private void FormCrud_Load(object sender, EventArgs e)
        {
            this.ComprobarProceso = this.VerificarProceso;
            this.ActualizarEquipo = this.ActualizarMiEquipo;
            this.ConfirmarEliminacion = this.Eliminar;
        }

        public void AgregarJugadores<T>(T jugador, List<T> lista)
        {

            lista.Add(jugador);

        }
    }


}
