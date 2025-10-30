namespace exercici2;

class Program
{
    static void Main(string[] args)
    {
        int nombressenars = 100;
        for (int i = 0; i <= (nombressenars * 2); i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
