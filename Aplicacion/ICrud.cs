using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    /// <summary>
    /// La interfaz la aplico en los dos crud que tengo(que seria el de mi clase independiente y el de mis clases hijas)
    /// </summary>
    /// <typeparam name="Formulario que va a ser modificado"></typeparam>
    public interface ICrud<T>
        where T: Form
    {
        void Actualizar();

        DialogResult Eliminar();

        void Modificar(T form, int selected);
    }
}
