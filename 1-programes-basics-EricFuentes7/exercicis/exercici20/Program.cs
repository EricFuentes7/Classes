namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        //No es la millor forma, però funciona.
        Console.Write("Insereix un número de 3 xifres: ");
        string numero = Console.ReadLine();
        char primerNum = numero[0];
        char segonNum = numero[1];
        char tercerNum = numero[2];
        int fin = Convert.ToInt32($"{tercerNum}{segonNum}{primerNum}");
        
        Console.WriteLine($"El numero invertit es {fin}");
    }
}
