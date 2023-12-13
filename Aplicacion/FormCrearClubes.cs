using LibreriaDeClases;

namespace Aplicacion
{
    /// <summary>
    /// La clase FormCrearEquipo es un formulario de Windows Forms para crear equipos deportivos. Permite al usuario ingresar el nombre y la cantidad de jugadores del equipo. 
    /// Al confirmar, valida los datos, abre un formulario adicional para agregar información de los jugadores y almacena el equipo creado.
    /// Muestra mensajes de error si los datos son inválidos o la cantidad de jugadores es insuficiente.
    /// </summary>
    public partial class FormCrearClubes : Form
    {
        private Club equipoCreado;
        private List<Club> equiposLista;
        private string perfilUsuario;
        public delegate void DelegadoEquipoYaCreado(List<Club> clubes, string nombreEquipoACrear);
        public event DelegadoEquipoYaCreado EventoEquipoDuplicado;

        public Club EquipoCreado
        {
            get { return this.equipoCreado; }
        }

        public FormCrearClubes(string perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;

        }

        /// <summary>
        /// Este constructor lo llamo en el caso que ya se hayan creado clubes
        /// </summary>
        /// <param name="listaClubes"></param>
        public FormCrearClubes(List<Club> listaClubes, string perfil) : this(perfil)
        {
            this.equiposLista = listaClubes;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreEquipo = this.txtNombreEquipo.Text;

            this.EventoEquipoDuplicado(this.equiposLista, nombreEquipo);
            

            if (!(this.DialogResult == DialogResult.None))
            {
                FormCrud formCrud = new FormCrud(nombreEquipo, this.perfilUsuario);

                formCrud.ShowDialog();
                this.equipoCreado = formCrud.MiEquipo;
                this.DialogResult = DialogResult.OK;
            }
        }

        public void VerificarEquipoDuplicado(List<Club> clubes, string nombreEquipo)
        {
            if (clubes != null)
            {
                foreach (Club club in clubes)
                {
                    if (club.NombreEquipo.ToLower() == nombreEquipo.ToLower())
                    {
                        MessageBox.Show("El equipo ya existe!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.None;
                        return;
                    }

                    this.DialogResult = DialogResult.OK;

                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void FormCrearClubes_Load(object sender, EventArgs e)
        {
            DelegadoEquipoYaCreado delegado = new DelegadoEquipoYaCreado(this.VerificarEquipoDuplicado);

            this.EventoEquipoDuplicado = delegado;
        }
    }
}
