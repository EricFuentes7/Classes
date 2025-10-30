namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        int anyActual = 2025;

        Console.Write("Com et dius? : ");
        string nom = Console.ReadLine();
        Console.Write("En quin any vas néixer? : ");
        int anyNaixement = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hola {nom}! Ja tens {anyActual - anyNaixement} anys?");
    }
}
