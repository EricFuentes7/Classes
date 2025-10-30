namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el nom d'usuari: ");
        string nomUsuari = Console.ReadLine();
        Console.Write("Introdueix el domini: ");
        string domini = Console.ReadLine();
        Console.WriteLine($"La teva adreça de correu és: {nomUsuari}@{domini}");
    }
}
