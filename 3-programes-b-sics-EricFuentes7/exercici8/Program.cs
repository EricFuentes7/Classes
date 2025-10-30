namespace exercici8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            for (int x = 0; x < i; x++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
