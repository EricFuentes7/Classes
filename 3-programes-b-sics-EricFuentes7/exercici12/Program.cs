namespace exercici12;

class Program
{
    static void Main(string[] args)
    {
        /* int valorX = 1;
        int valorY = 0;

        while (!((valorX >= 10) && (valorY >= 10)))
        {
            
            if (valorY >= 10)
            {
                valorY = 0;
                valorX++;
            }

            valorY++;
            Console.WriteLine($"{valorX} * {valorY} = {valorX * valorY}");
        }
        */
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}
