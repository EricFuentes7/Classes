namespace exercici10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Frase: ");
        string frase = Console.ReadLine();
        string fraseReversa = "";
        for (int i = frase.Length - 1; i >= 0; i--)
        {
            fraseReversa += frase[i];
        }
        Console.WriteLine(fraseReversa);
    }
}
