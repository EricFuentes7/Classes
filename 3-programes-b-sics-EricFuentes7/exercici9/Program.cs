using System.Security.Cryptography;

namespace exercici5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Frase: ");
        string frase = " " + Console.ReadLine().ToLower();
        int sumaParaules = 0;

        for (int i = 1; i < frase.Length; i++)
        {
            char paraulaAnterior = frase[i - 1];
            char paraula = frase[i];
            string junt = $"{paraulaAnterior}{paraula}";

            if (junt == " a")
            {
                sumaParaules++;
            }

            paraulaAnterior = paraula;
            }
        Console.WriteLine($"Hi ha {sumaParaules} paraules que comencen per a");
    }
}
