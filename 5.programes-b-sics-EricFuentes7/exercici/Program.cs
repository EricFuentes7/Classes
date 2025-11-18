namespace exercici;
using System.Collections;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int opcio = 1;

        while (opcio != 0)
        {
            Console.WriteLine("===== MENÚ DE COL·LECCIONS =====");
            Console.WriteLine("1. Afegir i eliminar noms d’una llista (List)");
            Console.WriteLine("2. Cercar noms que comencen per una lletra concreta (List)");
            Console.WriteLine("3. Comptar paraules repetides (Dictionary)");
            Console.WriteLine("4. Mostrar el producte més car d’un catàleg (Dictionary)");
            Console.WriteLine("5. Simular una cua d’atenció al client (Queue)");
            Console.WriteLine("6. Simular una cua circular amb prioritat (Queue)");
            Console.WriteLine("7. Simular una pila de navegació (Stack)");
            Console.WriteLine("8. Comprovar si una paraula és palíndrom (Stack)");
            Console.WriteLine("9. Crear un conjunt únic de números (HashSet)");
            Console.WriteLine("10. Intersecció de conjunts (HashSet)");
            Console.WriteLine("11. Ordenar i filtrar llista de nombres (LINQ)");
            Console.WriteLine("12. Trobar paraules llargues d’una frase (LINQ)");


            Console.WriteLine("0. Sortir");

            Console.Write("Tria una opció: ");
            opcio = Convert.ToInt32(Console.ReadLine());

            switch (opcio)
            {
                case 1:
                    LlistaUsuaris();
                    break;
                case 2:
                    ComencenPer();
                    break;
                case 3:
                    ParaulesDeFrase();
                    break;
                case 4:
                    ProducteMesCar();
                    break;
                case 5:
                    CuaPersones();
                    break;
                case 6:
                    CuaPersonesAmbTemps();
                    break;
                case 7:
                    PantallaActual();
                    break;
                case 8:
                    palindrom();
                    break;
                case 9:
                    numerosUnics();
                    break;
                case 10:
                    hashes();
                    break;
                case 11:
                    LlistaOrdenadaParell();
                    break;
                case 12:
                    paraulesMesLletres();
                    break;
                case 0:
                    Console.WriteLine("Fins aviat!");
                    break;
                default:
                    Console.WriteLine("Opció incorrecta.");
                    break;
            }

            Console.WriteLine();
        }

        static void LlistaUsuaris()
        {
            string nom = " ";
            List<string> nombres = new();
            Console.WriteLine("Introdueix noms (doble enter per acabar):");
            while (true)
            {
                nom = Console.ReadLine();
                if (string.IsNullOrEmpty(nom)) break;
                
                nombres.Add(nom);

            }

            GenerarLlista(nombres);
            Console.Write("Vols eliminar algun nom? (s/n): ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                EliminarNom(nombres);
            }


            GenerarLlista(nombres);

        }
    }

    static void GenerarLlista(List<string> nombres)
    {

        Console.WriteLine("Llista actual:");
        foreach (string nombreSelect in nombres)
        {
            Console.WriteLine("- " + nombreSelect);
        }
    }
    static void EliminarNom(List<string> nombres)
    {
        Console.WriteLine("Insereix el nom en llista: ");
        string nomEliminar = " ";
        while (true)
        {
            nomEliminar = Console.ReadLine();
            if (string.IsNullOrEmpty(nomEliminar))
            {
                break;
            }
            if (nombres.Contains(nomEliminar))
            {
                nombres.Remove(nomEliminar);
                Console.WriteLine($"{nomEliminar} eliminat.");

            }
            else
            {
                Console.WriteLine($"{nomEliminar} no trobat.");
            }

        }

    }

    static void ComencenPer()
    {
        List<string> nombres = new() { "Eric", "Coral", "Pol", "Josep", "Aina", "Macho", "Jaume", "Genis", "Esparta", "Gossa", "Joel", "Ruben", "Manuel" };

        Console.Write("Noms disponibles: " + string.Join(", ", nombres));
        // útil:) -> https://learn.microsoft.com/es-es/dotnet/api/system.string.join?view=net-8.0
        int contar = 0;

        Console.Write("\nIntrodueix una lletra: ");
        char caracter = Convert.ToChar(Console.ReadLine());
        foreach (string nom in nombres)
        {
            if (nom.ToLower()[0] == char.ToLower(caracter))
            {
                Console.WriteLine(nom);
                contar++;
            }
        }
        if (contar == 0)
        {
            Console.WriteLine("No s'han trobat nombs amb aquesta inicial");
        }
    }

    static void ParaulesDeFrase()
    {
        Dictionary<string, int> paraules = new();
        Console.WriteLine("Escriu una frase:");
        string frase = Console.ReadLine();
        foreach (string paraula in frase.Split(' '))
        {
            if (paraules.ContainsKey(paraula))
            {
                paraules[paraula] += 1;
            }
            else
            {
                paraules.Add(paraula, 1);
            }
        }
        Console.WriteLine("Freqüència de paraules:");
        foreach (KeyValuePair<string, int> par in paraules)
        {
            Console.WriteLine("{0}: {1}",
            par.Key, par.Value);
        }

    }

    static void ProducteMesCar()
    {
        Dictionary<string, float> productos = new Dictionary<string, float>
        {
            { "pa", 1.2f },
            { "llet", 0.9f },
            { "formatge", 3.5f },
            { "ous", 2.2f }
        };

        // https://stackoverflow.com/questions/617283/select-a-dictionaryt1-t2-with-linq
        Console.WriteLine("Nombres disponibles: " + string.Join(", ", productos.Select(p => p.Key + ": " + p.Value)));

        // https://stackoverflow.com/questions/10290838/how-to-get-max-value-from-dictionary
        var valorMaxim = productos.Values.Max();
        var clauDeValorMaxim = productos.MaxBy(entry => entry.Value).Key;

        Console.WriteLine($"El producte més car és {clauDeValorMaxim} ({valorMaxim} €)");
    }

    static Queue<string> afegirPersones(Queue<string> persones)
    {
        persones.Enqueue("Anna");
        persones.Enqueue("Joan");
        persones.Enqueue("Maria");
        persones.Enqueue("Pau");
        return persones;
    }
    static void CuaPersones()
    {
        Queue<string> persones = new();
        persones = afegirPersones(persones);

        Console.Write("Clients a la cua: " + string.Join(", ", persones));

        while (persones.Count > 0)
        {
            Console.Write("\nAtentent a {0}", persones.Dequeue());
        };

        Console.WriteLine("\nCua buida");
    }

    static void CuaPersonesAmbTemps()
    {
        Queue<string> persones = new();
        persones = afegirPersones(persones);
        Queue<int> temps = new();
        temps.Enqueue(3);
        temps.Enqueue(5);
        temps.Enqueue(2);
        temps.Enqueue(4);

        var llistaPersones = persones.ToArray();
        var llistaTemps = temps.ToArray();

        Console.WriteLine("Persones a la cua: ");

        for (int i = 0; i < llistaPersones.Length; i++)
        {
            Console.WriteLine($"{llistaPersones[i]} ({llistaTemps[i]} min)");
        }

        string personaAcual;
        int tempsAct = 0;
        int tempsFinal = 0;
        Console.WriteLine("\n--- Atenció al client ---");
        while (persones.Count > 0)
        {
            personaAcual = persones.Dequeue();
            tempsAct = temps.Dequeue();
            tempsFinal += tempsAct;
            Console.Write($"Atentent a {personaAcual} ({tempsAct} min). Temps total: {tempsFinal} min\n");
        }
        ;

        Console.WriteLine("\nTots els clients han estat atesos!");

    }

    static void PantallaActual()
    {
        Stack pantalla = new();
        pantalla.Push("Inici");
        pantalla.Push("Productes");
        pantalla.Push("Detall");
        pantalla.Push("Cistella");

        var pantallaArray = pantalla.ToArray().Reverse();
        Console.WriteLine("Historial: " + string.Join(" -> ", pantallaArray));

        Console.WriteLine($"Pantalla actual: {pantalla.Peek()}");
        pantalla.Pop();
        Console.WriteLine($"Tornes enrere: {pantalla.Peek()}");


    }

    static void palindrom()
    {
        Stack<char> paraula = new();
        Console.Write("Introdueix una paraula: ");
        string frase = Console.ReadLine().ToLower();
        string fraseInversa = "";

        for (int i = 0; i < frase.Length; i++)
        {
            paraula.Push(frase[i]);
        }

        while (paraula.Count > 0)
        {
            fraseInversa += paraula.Peek();
            paraula.Pop();
        }

        Console.WriteLine((frase == fraseInversa) ? "És un palíndrom!" : "No és un palíndrom.");
    }

    static void numerosUnics()
    {
        HashSet<int> numeros = new();

        Console.WriteLine("Introdueix números (doble enter per acabar):");
        while (true)
        {
            string num = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(num))
            {
                break;
            }
            numeros.Add(Convert.ToInt32(num));
        }

        Console.WriteLine("Números únics:");

        foreach (int i in numeros)
        {
            Console.WriteLine("{0}", i);
        }

    }
    static void hashes()
    {
        HashSet<int> hashA = new() { 1, 2, 3, 4, 5 };
        HashSet<int> hashB = new() { 4, 5, 6, 7 };

        Console.WriteLine("Conjunt A: {" + string.Join(", ", hashA) + "}");
        Console.WriteLine("Conjunt B: {" + string.Join(", ", hashB) + "}");

        var interseccio = hashA.Intersect(hashB);
        Console.WriteLine("Intersecció: " + string.Join(", ", interseccio));

        /* 
        Abans de .Intersect:

        foreach (int num1 in hashA)
        {
            foreach (int num2 in hashB)
            {
                if (num1 == num2)
                {
                    Console.Write(num1 + ", ");
                }
            }
        }
        */
    
    }

    static void LlistaOrdenadaParell()
    {
        List<int> llista = new() { 5, 1, 8, 3, 9, 2, 7 };

        Console.Write("Llista original: " + string.Join(", ", llista));


        var resultat = llista
        .Where(x => x % 2 == 0)
        .OrderBy(x => x)
        .ToList();

        Console.WriteLine("Números parells ordenats:");
        foreach (int num in resultat)
        {
            Console.WriteLine(num);
        }

    }
    
    static void paraulesMesLletres()
    {

        Console.Write("Escriu una frase: ");
        string[] frase = Console.ReadLine().Split(" ");
        int maxChar = 4;

        var paraulesLlargues = frase
            .Where(p => p.Length > maxChar)
            .ToList();

        Console.WriteLine($"Paraules de més de {maxChar} lletres:");
            foreach (var paraula in paraulesLlargues)
            {
                Console.WriteLine(paraula);
            }
        /*
        SENSE LINQ :(
        
        Console.Write("Escriu una frase: ");
        string[] frase = Console.ReadLine().Split(" ");
        int maxChar = 4;
        Console.WriteLine($"Paraules de més de {maxChar} lletres:");
        foreach (string paraula in frase)
        {
            if(paraula.Length+1 > maxChar)
            {
             Console.WriteLine(paraula);   
            }
            
        }
        */
    }
    
}
