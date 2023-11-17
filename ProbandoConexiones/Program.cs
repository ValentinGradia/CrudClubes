using Aplicacion;
using LibreriaDeClases;
internal class Program
{
    private static void Main(string[] args)
    {

        Futbolista f = new Futbolista("Marco", "Polo", 32, ENacionalidad.Argentino, "Defensor", 40, EPierna.Zurdo);

        AccesoDatos a = new AccesoDatos();

        if(a.ModificarJugador<Futbolista>(f))
        {
            Console.WriteLine("Todo OK");
        }
        else
        {
            Console.WriteLine("NT");
        }
    }
}