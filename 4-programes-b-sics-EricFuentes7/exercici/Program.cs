using System;

class Program
{
    static void Main()
    {
        int opcio = 1;

        while (opcio != 0)
        {
            Console.WriteLine("===== MENÚ DE LOOPS =====");
            Console.WriteLine("1. Comptar vocals detalladament (per a, e, i, o, u)");
            Console.WriteLine("2. Dibuixar un triangle d’asteriscs buit");
            Console.WriteLine("3. Mostrar nombres entre 1 i N divisibles per 3 o 5 (però no tots dos)");
            Console.WriteLine("4. Joc del dau fins arribar a 50 punts exactes");
            Console.WriteLine("5. Comptar quants dígits té un número");
            Console.WriteLine("6. Comptar quantes paraules comencen per vocal");
            Console.WriteLine("7. Calcular el factorial d’un número amb multiplicacions parcials");
            Console.WriteLine("8. Revertir una frase (lletra a lletra, sense Reverse)");
            Console.WriteLine("9. Mostrar la taula de multiplicar d’un número");
            Console.WriteLine("10. Endevinar un número entre 1 i 100");
            Console.WriteLine("0. Sortir");

            Console.Write("Tria una opció: ");
            opcio = Convert.ToInt32(Console.ReadLine());

            switch (opcio)
            {
                case 1:
                    ComptarVocalsDetall();
                    break;
                case 2:
                    TriangleBuit();
                    break;
                case 3:
                    NumDivisibles();
                    break;
                case 4:
                    DauPerfecte();
                    break;
                case 5:
                    ComptarDigits();
                    break;
                case 6:
                    ParaulesPerVocal();
                    break;
                case 7:
                    Factorial();
                    break;
                case 8:
                    FraseInversa();
                    break;
                case 9:
                    TaulaMultiplicar();
                    break;
                case 10:
                    AdivinaNumero();
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
    }
    static void ComptarVocalsDetall()
    {
        Console.Write("Dona’m una frase: ");
        string frase = Console.ReadLine().ToLower();
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char vocal in vocales)
        {
            int contador = 0;
            foreach (char caracter in frase)
            {
                if (caracter == vocal)
                {
                    contador++;
                }
            }
            Console.WriteLine($"{vocal}: {contador}");
        }
        /*
        ANTIC
        
        Console.Write("Dona’m una frase: ");
        string frase = Console.ReadLine().ToLower();
        char actual = ' ';
        char[] caracters = ['a', 'e', 'i', 'o', 'u'];
        int[] contar = [0, 0, 0, 0, 0];
        for (int i = 0; i < frase.Length; i++)
        {
            actual = frase[i];
            foreach (char caracter in caracters)
            {
                if (actual == caracter)
                {
                    switch (caracter)
                    {
                        case 'a':
                            contar[0]++;
                            break;
                        case 'e':
                            contar[1]++;
                            break;
                        case 'i':
                            contar[2]++;
                            break;
                        case 'o':
                            contar[3]++;
                            break;
                        case 'u':
                            contar[4]++;
                            break;
                    }
                }
            }

        }
        Console.WriteLine($"a: {contar[0]}\ne: {contar[1]}\ni: {contar[2]}\no: {contar[3]}\nu: {contar[4]}");
        */
    }

    static void TriangleBuit()
    {
        Console.Write("Número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= num; j++)
            {

                if (j == 1 || j == i)
                {
                    Console.Write('*');
                }
                else if (i == num)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    static void NumDivisibles()
    {
        Console.Write("Introdueix un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int contar = 0;
        Console.WriteLine("Nombres divisibles per 3 o per 5 (però no per tots dos):");
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
            }
            else if (i % 3 == 0 || i % 5 == 0)
            {
                Console.WriteLine(i);
                contar++;
            }
        }
                    Console.WriteLine($"En total hi ha {contar} nombres que compleixen la condició.");

    }

    static void DauPerfecte()
    {
        Console.WriteLine("Joc del dau fins arribar a 50 punts exactes\n------------------------------------------");
        Random r = new Random();
        int sumaRandom = 0;
        int random = 0;
        int tirada = 0;
        while (sumaRandom != 50)
        {
            if (sumaRandom < 50)
            {
                tirada++;
                random = r.Next(1, 7);
                sumaRandom += random;

                Console.WriteLine($"Tirada {tirada}: {random} (total: {sumaRandom})");
            }
            else
            {
                Console.WriteLine("ens passem! Reinici del comptador a 0");
                sumaRandom = 0;
                random = 0;
                Console.WriteLine();
            }

        }
        Console.WriteLine($"Enhorabona! Has arribat exactament a 50 punts en {tirada} tirades");
    }

    static void ComptarDigits()
    {
        Console.Write("Insereix un numero natural: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int comptades = 0;
        while (num != 0)
        {
            num /= 10;
            comptades++;
        }
        Console.WriteLine($"Dígits: {comptades}");
    }

    static void ParaulesPerVocal()
    {
        Console.Write("Introdueix una frase: ");
        string frase = " " + Console.ReadLine().ToLower();
        int sumaParaules = 0;
        char[] caracters = ['a', 'e', 'i', 'o', 'u'];
        for (int i = 1; i < frase.Length; i++)
        {
            char paraulaAnterior = frase[i - 1];
            char paraula = frase[i];
            string junt = $"{paraulaAnterior}{paraula}";
            foreach (char carac in caracters)
            {
                if (junt == $" {carac}")
                {
                    sumaParaules++;
                }

                paraulaAnterior = paraula;
            }

        }
        Console.WriteLine($"Hi ha {sumaParaules} paraules que comencen per vocal");
    }

    static void Factorial()
    {
        Console.Write("Introdueix un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int numClon = num;
        Console.WriteLine($"Càlcul del factorial de {num}:");

        for (int i = num - 1; i > 0; i--)
        {
            Console.WriteLine($"{numClon} * {i} = {numClon * i}");
            numClon *= i;

        }
        Console.WriteLine($"El factorial de {num} és {numClon}");
    }

    static void FraseInversa()
    {
        Console.Write("Introdueix una frase: ");
        string frase = Console.ReadLine();
        string fraseReversa = "";
        for (int i = frase.Length - 1; i >= 0; i--)
        {
            fraseReversa += frase[i];
        }
        Console.WriteLine($"Frase girada: {fraseReversa}");
    }

    static void TaulaMultiplicar()
    {
        Console.Write("Introdueix un número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Taula de multiplicar del 4:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }

    static void AdivinaNumero()
    {
        Console.Write("He triat un número entre 1 i 100. Intenta endevinar-lo!");
        Console.WriteLine();
        Random r = new Random();
        int numAdivinar = r.Next(1, 101);
        int entrada = 0;
        int intents = 0;
        while (entrada != numAdivinar)
        {
            Console.Write("Introdueix un número: ");
            entrada = Convert.ToInt32(Console.ReadLine());

            if (entrada > numAdivinar)
            {
                Console.WriteLine("Massa alt!");
            }
            else if(entrada < numAdivinar)
            {
                Console.WriteLine("Massa baix!");
            }
            Console.WriteLine();
            intents++;
        }
        Console.WriteLine($"Correcte! Has endevinat el número en {intents} intents.");
    }
}
