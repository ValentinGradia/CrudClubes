using LibreriaDeClases;
internal class Program
{
    private static void Main(string[] args)
    {
        Futbolista f = new Futbolista("pedro", "ars", 30, ENacionalidad.Argentino, "Delantero", 20, EPierna.Diestro);

        Futbolista f1 = new Futbolista("pedro", "arss", 20, ENacionalidad.Brasilero, "Delantero", 20, EPierna.Diestro);

        if(f1.Equals(f))
        {
            Console.WriteLine("son iguales");
        }
        else
        {
            Console.WriteLine("No son iguales");
        }
    }
}