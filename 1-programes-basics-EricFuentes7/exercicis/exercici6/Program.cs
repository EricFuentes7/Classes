namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix la mida del costat del quadrat: ");
        double perimetre = 4 * (Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine($"El perímetre del quadrat és: {perimetre}");
    }
}
