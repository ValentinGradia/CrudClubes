using LibreriaDeClases;
internal class Program
{
    private static void Main(string[] args)
    {
        Equipo e = new Equipo(4, "hola");
        Futbolista f = new Futbolista("hola", "hola", 20, ENacionalidad.Argentino);
        Futbolista f1 = new Futbolista("holaa", "holaa", 40, ENacionalidad.Argentino);
        Futbolista f2 = new Futbolista("hol", "hol", 30, ENacionalidad.Argentino);

        e.MiEquipo.Add(f); e.MiEquipo.Add(f1); e.MiEquipo.Add(f2);

        e.MiEquipo = e.OrdenarEdad(1);

        foreach(Jugador j in e.MiEquipo)
        {
            Console.WriteLine(j.ToString());
        }
    }
}