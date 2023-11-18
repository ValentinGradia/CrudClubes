using Aplicacion;
using LibreriaDeClases;
internal class Program
{
    private static void Main(string[] args)
    {

        Basquetbolista b = new Basquetbolista(190, 45, "Sin posicion", "Marco", "Polo", 32, ENacionalidad.Argentino);

        AccesoDatos a = new AccesoDatos();

        if(a.EliminarJugador<Basquetbolista>(b))
        {
            Console.WriteLine("Todo OK");
        }
        else
        {
            Console.WriteLine("NT");
        }
    }
}