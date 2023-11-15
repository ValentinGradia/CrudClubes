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

    /// <summary>
    /// La clase FormJugadores es un formulario que permite a los usuarios agregar jugadores de diferentes deportes (fútbol, baloncesto y voleibol) a un equipo. 
    /// La clase incluye campos para el jugador actual (miJugador) y una lista de jugadores (listaJugadores).
    /// </summary>
    public partial class FormJugadores : Form
    {
        private Jugador miJugador;
        private List<Jugador> listaJugadores;

        public Jugador MiJugador
        {
            get { return this.miJugador; }
        }
        public FormJugadores()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este constructor va a ser llamado en el caso que ya existan jugadores
        /// </summary>
        /// <param name="equipo"></param>
        public FormJugadores(List<Jugador> equipo) : this()
        {
            this.listaJugadores = equipo;
        }

        private bool ValidarJugador(Jugador j)
        {
            return (this.listaJugadores.Contains(j));
        }

        private void btnAgregarFutbolista_Click(object sender, EventArgs e)
        {
            FormFutbolista formFutbolista = new FormFutbolista();
            formFutbolista.ShowDialog();

            this.ValidarForm(formFutbolista);


        }

        private void btnAgregarBasquetbolista_Click(object sender, EventArgs e)
        {
            FormBasquetbolista formBasquetbolista = new FormBasquetbolista();

            formBasquetbolista.ShowDialog();

            this.ValidarForm(formBasquetbolista);

        }

        /// <summary>
        /// Esta funcion (se crea con el fin de reutilizar codigo) se encarga de validar la respuesta de un formulario de datos de jugadores y toma acciones dependiendo de la decisión del usuario. 
        /// Inicia un bucle que espera hasta que el usuario tome una decisión en el formulario. Si el usuario cancela la operación, el formulario se cierra. 
        /// Si no hay jugadores en la lista, se asigna el jugador actual con los datos del formulario y se establece el resultado del formulario como "OK". 
        /// Si existe una lista de jugadores y el jugador del formulario ya está en ella, se muestra un mensaje de error y se mantiene el resultado en "None", evitando la duplicación de jugadores en el equipo. 
        /// </summary>
        /// <param name="formJugador"></param>
        private void ValidarForm(FormDatosJugadores formJugador)
        {

            while (formJugador.DialogResult == DialogResult.None)
            {
                formJugador.ShowDialog();
            }

            if (formJugador.DialogResult == DialogResult.Cancel)
            {
                formJugador.Close();

            }
            else
            {
                if (this.listaJugadores == null)
                {
                    this.miJugador = formJugador.MiDeportista;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (!(this.ValidarJugador(formJugador.MiDeportista)))
                    {
                        this.miJugador = formJugador.MiDeportista;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("El jugador ya pertenece al equipo", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnAgregarVoleibolista_Click_1(object sender, EventArgs e)
        {
            FormVoleibolista formVoleibolista = new FormVoleibolista();

            formVoleibolista.ShowDialog();
            this.ValidarForm(formVoleibolista);

        }
    }
}
