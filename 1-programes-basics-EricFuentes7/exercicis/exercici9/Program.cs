namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduex els metres: ");
        double peus = 3.28084 * (Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine($"El valor en peus és de: {peus} ft");
    }
}
