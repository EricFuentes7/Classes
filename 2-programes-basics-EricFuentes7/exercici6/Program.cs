namespace exercici6;

class Program
{
    static void Main(string[] args)
    {
        /*
        Feu un programa que demana el nom i l'edat de dues persones i ens
        digui quina de les dues és més jove
        Entra el primer nom: Pere
        Entra l'edat d’en Pere: 23
        Entra el segon nom: Frederic
        Entra l'edat d’en Frederic: 34
        En Pere és més jove que en Frederic
        */

        Console.Write("Entra el primer nom: ");
        string nom1 = Console.ReadLine();
        Console.Write($"Entra l'edat d'en {nom1}: ");
        int edat1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Entra el segon nom: ");
        string nom2 = Console.ReadLine();
        Console.Write($"Entra l'edat d'en {nom2}: ");
        int edat2 = Convert.ToInt32(Console.ReadLine());
        string jove;
        string vell;
        if (edat1 < edat2)
        {
            jove = nom1;
            vell = nom2;
        }
        else if (edat2 < edat1)
        {
            jove = nom2;
            vell = nom1;
        }
        else
        {
            Console.WriteLine($"{nom1} i {nom2} tenen la mateixa edat.");
            return;
        }

        Console.WriteLine($"En {jove} és més jove que en {vell}");
    }
}
