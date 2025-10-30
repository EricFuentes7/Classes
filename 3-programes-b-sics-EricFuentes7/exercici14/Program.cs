namespace exercici14;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            for (int j = 1; j <= numero; j++)
            {
                if (i == 1 || i == numero)
                {
                    Console.Write("*");
                }
                else if (j == 1 || j == numero)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

// Fotudissim