namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix els minuts: ");
        int minuts = Convert.ToInt32(Console.ReadLine());
        int hores = minuts / 60;
        int minutsRestants = minuts % 60;
        Console.WriteLine($"{minuts} minuts són {hores} hora/es i {minutsRestants} minut/s.");
    }
}
