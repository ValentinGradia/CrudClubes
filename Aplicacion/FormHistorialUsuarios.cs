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
    /// La clase FormHistorialUsuarios es un formulario diseñado para mostrar un historial de usuarios previamente registrados en la aplicación. Durante la carga del formulario, 
    /// busca y lee un archivo llamado "usuarios.log.txt" que contiene información de usuarios. Si encuentra el archivo, muestra los datos de usuarios en la lista lstUsuarios. 
    /// Sin embargo, si el archivo no existe, muestra un mensaje de error indicando que aún no se ha generado un historial de usuarios.
    public partial class FormHistorialUsuarios : Form
    {
        public FormHistorialUsuarios()
        {
            InitializeComponent();
        }

        private void FormHistorialUsuarios_Load(object sender, EventArgs e)
        {
            string archivo = "usuarios.log.txt";

            if (File.Exists(archivo))
            {
                string[] usuarios = File.ReadAllLines(archivo);
                this.lstUsuarios.Items.Clear();
                this.lstUsuarios.Items.AddRange(usuarios);
            }
            else
            {
                MessageBox.Show("Aun no se genero un historial de usuarios", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
