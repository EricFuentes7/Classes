namespace exercici11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Frase: ");
        string frase = Console.ReadLine();
        string fraseFinal = "";
        char[] caracters = ['a', 'A', 'u', 'U', 's', 'S'];
        for (int i = 0; i < frase.Length; i++)
        {
            if (!caracters.Contains(frase[i]))
            {
                fraseFinal += frase[i];
            }
        }
        Console.WriteLine(fraseFinal);
    }
}
