using System.Reflection.PortableExecutable;

namespace exercici7;

class Program
{
    static void Main(string[] args)
    {
        
        char[] vocals = ['a', 'e', 'i', 'o', 'u', 'é', 'è', 'á', 'à', 'í', 'ì', 'ó', 'ò', 'ú', 'ù'];
        int vocalsQueHiHan = 0;

        Console.Write("Insereix la frase: ");
        string frase = Console.ReadLine().ToLower();

        for (int i = 0; i < frase.Length - 1; i++)
        {
            foreach(char caracter in vocals)
            {
                    if (caracter == frase[i])
                    {
                        vocalsQueHiHan++;
                    }
                }
        }
        Console.WriteLine($"En aquesta frase hi han {vocalsQueHiHan} vocals.");
    }
}


// No accepta accencts per l'encoding.