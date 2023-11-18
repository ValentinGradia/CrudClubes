using Aplicacion;
using LibreriaDeClases;

internal class Program
{
    private static void Main(string[] args)
    {
        Futbolista f = new Futbolista("Pablo", "Polo", 20, ENacionalidad.Canadiense, "Delantero",34, EPierna.Zurdo);

        AccesoDatos a = new AccesoDatos();

        try
        {
            _ = a.AgregarJugador<Futbolista>(f);
        }
        catch(ObjetoDuplicadoException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}