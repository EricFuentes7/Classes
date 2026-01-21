namespace BoxeCombat;

class Program
{
    static void Main(string[] args)
    {
        Boxejador jugador1 = new Boxejador("Eric", 10);
        Boxejador jugador2 = new Boxejador("Pol", 10);
        
        while (!jugador1.estaDerribat() && !jugador2.estaDerribat())
        {
            Console.WriteLine($"El boxejador {jugador1.Nom} pica");
            Console.WriteLine(jugador2.Rebre(jugador1.Picar()));
            if (jugador2.estaDerribat()) break;
            Console.WriteLine($"El boxejador {jugador2.Nom} pica");
            Console.WriteLine(jugador1.Rebre(jugador2.Picar()));
        }

        if (jugador1.estaDerribat())
        {
            Console.WriteLine($"Ha guanyat {jugador2.Nom}");
        }
        else
        {
            Console.WriteLine($"Ha guanyat {jugador1.Nom}");

        }
        /*
        while (true)
        {
            if (!jugador1.estaDerribat())
            {
                Console.WriteLine($"{jugador1.Nom} ataca:");
                (bool, string) jugada = jugador2.Rebre(jugador1.Picar());

                if (jugada.Item1)
                {
                    Console.WriteLine($"\t{jugador2.Nom} ha rebut un cop a {jugada.Item2}\n");
                }
                else
                {
                    Console.WriteLine($"\t{jugador2.Nom} ha protegit!\n");
                }
            }
            else
            {
                Console.WriteLine($"\n-------\n{jugador2.Nom} guanya");
                return;
                
            }
            if (!jugador2.estaDerribat())
            {
                Console.WriteLine($"{jugador2.Nom} ataca:");
                (bool, string) jugada = jugador1.Rebre(jugador2.Picar());

                if (jugada.Item1)
                {
                    Console.WriteLine($"\t{jugador1.Nom} ha rebut un cop a {jugada.Item2}\n");
                }
                else
                {
                    Console.WriteLine($"\t{jugador1.Nom} ha protegit!\n");
                }
            }
            else
            {
                Console.WriteLine($"\n-------\n{jugador1.Nom} guanya");
                return;
                
            }
        }
        */
    }
}