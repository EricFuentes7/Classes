namespace exercici17;

/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Inserta el número lleig: ");
        double numeroLleig = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"el numero maravellós és: : {(numeroLleig - Math.Truncate(numeroLleig)):F2}");
    }
}
