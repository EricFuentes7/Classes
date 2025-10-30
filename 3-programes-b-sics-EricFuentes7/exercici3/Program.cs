namespace exercici3;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int suma = 0;
        int vegades = 0;
        while (suma <= 100)
        {
            int random = r.Next(1, 7);
            Console.WriteLine("Tira el dau: " + random);
            suma += random;
            vegades++;
        }
        Console.WriteLine($"Has hagut de llançar el dau {vegades} vegades.");
    }
}
