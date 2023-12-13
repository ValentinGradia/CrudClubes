using Aplicacion;
using LibreriaDeClases;

internal class Program
{
    private static void Main(string[] args)
    {
        AccesoDatos sql = new AccesoDatos();

        List<Dictionary<Club, List<Jugador>>> lista = sql.ObtenerListaDatos<Futbolista>();
        List<Dictionary<Club, List<Jugador>>> lista1 = sql.ObtenerListaDatos<Basquetbolista>();
        List<Dictionary<Club, List<Jugador>>> lista2 = sql.ObtenerListaDatos<Voleibolista>();

        List<Dictionary<Club, List<Jugador>>> clubes = new List<Dictionary<Club, List<Jugador>>>();
        clubes.AddRange(lista1);
        clubes.AddRange(lista2);
        clubes.AddRange(lista);

        Dictionary<Club, List<Jugador>> jugadoresPorClub = new Dictionary<Club, List<Jugador>>();

        foreach (Dictionary<Club, List<Jugador>> diccionario in clubes)
        {
            foreach (var claveValor in diccionario)
            {

                if (jugadoresPorClub.ContainsKey(claveValor.Key))
                {
                    jugadoresPorClub[claveValor.Key].AddRange(claveValor.Value);
                }
                else
                {
                    jugadoresPorClub[claveValor.Key] = new List<Jugador>(claveValor.Value);
                }
            }
        }

        Console.WriteLine($"{jugadoresPorClub}");

    }


}