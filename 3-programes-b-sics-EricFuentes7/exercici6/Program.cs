namespace exercici6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra un múltiple de 10: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        int valorResultant = valor;
        int elevatA = 0;
        while (!(valor % 10 == 0))
        {
            Console.WriteLine("INCORRECTE");
            Console.Write("Entra un múltiple de 10: ");
            valor = Convert.ToInt32(Console.ReadLine());
            valorResultant = valor;
        }

         while (valor % 10 == 0)
        {
            valor /= 10;
            elevatA++;
        }
        multiplicacio = valor;


        Console.Write($"CORRECTE {multiplicacio} per 10 elevat a {elevatA} = {valorResultant}");

        
    }
}

// Molt fotut.