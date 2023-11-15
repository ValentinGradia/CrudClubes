using LibreriaDeClases;
internal class Program
{
    private static void Main(string[] args)
    {
        //Equipo equipo = new Equipo(2);

        Futbolista f1 = new Futbolista("Pedro", "Ort", 20, ENacionalidad.Argentino, "Delantero");

        Voleibolista v = (Voleibolista)f1;
        //Futbolista f2 = new Futbolista("Pedro", "Ort", 20, ENacionalidad.Brasilero, "Delantero");

        //if (equipo + f1)
        //{
        //    Console.WriteLine("Se agrego al jugador");
        //}
        //else
        //{
        //    Console.WriteLine("No se agrego");
        //}
        //if (equipo + f2)
        //{
        //    Console.WriteLine("Se agrego al jugador");
        //}
        //else
        //{
        //    Console.WriteLine("No se agrego");
        //}


    }
}