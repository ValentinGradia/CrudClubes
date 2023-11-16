﻿using LibreriaDeClases;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Forms;

namespace Aplicacion
{
    /// <summary>
    /// Mi formulario FormCrud se encarga de hacer que mi aplicacion cumpla los requisitos de un CRUD, basicamente crear jugadores, leerlos y agregarlos a la listbox, modificar los datos de estos y eliminarlos.
    /// Tambien puedes ordenar estos jugadores por distintos criteros, por ejemplo ordenar por edad. Ademas puedes guardar jugadores para luego poder agregarlos en otros equipos(deserealizandolos)
    /// </summary>
    public partial class FormCrud : Form, ICrud<FormDatosJugadores>
    {
        private Equipo equipo;
        private string nombreEquipo;
        protected int cantJugadoresMax;
        private FormJugadores form;
        private string perfilUsuario;

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
                this.equipo = this.equipo + this.form.MiJugador;
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
                this.Actualizar();
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
                    if (this.Eliminar() == DialogResult.Yes)
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
                        this.equipo = this.equipo - this.equipo.MiEquipo[selected];
                        this.Actualizar();
                    }
                }
                else
                {
                    MessageBox.Show("No tiene permiso ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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

            Serializadora<Futbolista> serializarFutbolistas = new Serializadora<Futbolista>();
            serializarFutbolistas.Serealizar(this.equipo.Futbolistas, "Futbolistas.JSON");


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
            Serializadora<Futbolista> deserealizarFutbolistas = new Serializadora<Futbolista>();
            deserealizarFutbolistas.Deserealizar(this.equipo);
            this.Actualizar();

        }

        private void btnGuardarBasquetbolistas_Click(object sender, EventArgs e)
        {

            Serializadora<Basquetbolista> serializarBasquetbolistas = new Serializadora<Basquetbolista>();
            serializarBasquetbolistas.Serealizar(this.equipo.Basquetbolistas, "Basquetbolistas.JSON");

        }

        private void btnDeserealizarBasquetbolistas_Click(object sender, EventArgs e)
        {
            Serializadora<Basquetbolista> deserealizarBasquetbolistas = new Serializadora<Basquetbolista>();
            deserealizarBasquetbolistas.Deserealizar(this.equipo);
            this.Actualizar();

        }

        private void btnGuardarVoleibolistas_Click(object sender, EventArgs e)
        {
            Serializadora<Voleibolista> serializarVoleibolistas = new Serializadora<Voleibolista>();
            serializarVoleibolistas.Serealizar(this.equipo.Voleibolistas, "Voleibolistas.JSON");

        }

        private void btnDeserealizarVoleibolistas_Click(object sender, EventArgs e)
        {
            Serializadora<Voleibolista> deserealizarVoleibolistas = new Serializadora<Voleibolista>();
            deserealizarVoleibolistas.Deserealizar(this.equipo);
            this.Actualizar();

        }

        public DialogResult Eliminar()
        {
            DialogResult pregunta = MessageBox.Show("Estás seguro de que deseas eliminar un jugador?", "Eliminar jugador"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return pregunta;
        }
    }

    
}
