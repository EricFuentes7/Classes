namespace exercici1;

class Program
{
    static void Main(string[] args)
    {
        /*
        Feu un programa on entrem la nota d’un examen i ens diu si ha aprovat o no
        Entra la nota: 3
        No has aprovat
        */
        
        Console.Write("Entra la nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((nota >= 5) ? "Has aprovat" : "No has aprovat");
    }
}

