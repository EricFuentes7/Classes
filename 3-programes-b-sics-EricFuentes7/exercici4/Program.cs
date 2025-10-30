namespace exercici4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingressa el valor: ");
        int entrada = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        for (int i = 0; i <= entrada; i++)
        {
            suma += i;
        }
        Console.WriteLine($"Suma: {suma}");
    }
}
