namespace exercici9;

class Program
{
    static void Main(string[] args)
    {
        /*
        Desenvolupeu un programa que demani cinc números i ens digui quin és més gran
        Entra el número 1: 2
        Entra el número 2: 56
        Entra el número 3: 54
        Entra el número 4: 34
        Entra el número 5: 55
        El número més gran és el 56
        */
        Console.Write("Entra el número: ");
        int paraula1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entra el número: ");
        int paraula2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entra el número: ");
        int paraula3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entra el número: ");
        int paraula4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entra el número: ");
        int paraula5 = Convert.ToInt32(Console.ReadLine());
        int[] array = [paraula1, paraula2, paraula3, paraula4, paraula5];
        Console.WriteLine($"El número més gran és: {array.Max()}");
    }
}
