using Aplicacion;
using LibreriaDeClases;
internal class Program
{
    private static void Main(string[] args)
    {

        Futbolista f = new Futbolista("Marco", "Polo", 32, ENacionalidad.Argentino, "Delantero", 20, EPierna.Zurdo);

        AccesoDatos a = new AccesoDatos();

        if(a.AgregarJugador<Futbolista>(f))
        {
            Console.WriteLine("Todo OK");
        }
        else
        {
            Console.WriteLine("NT");
        }
    }
}