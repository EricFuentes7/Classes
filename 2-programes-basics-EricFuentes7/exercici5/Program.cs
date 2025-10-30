namespace exercici5;

class Program
{
    static void Main(string[] args)
    {
        /*
        Desenvolupeu un programa que demani tres paraules i ens digui quina de les tres
        és més llarga
        Entra el número: Patata
        Entra el número: Peix
        Entra el número: Pi
        La paraula més llarga és Patata
        */

        Console.Write("Entra la paraula: ");
        string paraula1 = Console.ReadLine();
        Console.Write("Entra la paraula: ");
        string paraula2 = Console.ReadLine();
        Console.Write("Entra la paraula: ");
        string paraula3 = Console.ReadLine();
        string[] paraules = { paraula1, paraula2, paraula3 };
        int[] llargades = { paraula1.Length, paraula2.Length, paraula3.Length };

        int indexMax = 0;
        if (llargades[1] > llargades[indexMax]) indexMax = 1;
        if (llargades[2] > llargades[indexMax]) indexMax = 2;

        Console.WriteLine("La paraula més llarga és: " + paraules[indexMax]);

        //Bona info https://www.todosoluciones.es/2025/02/01/max-la-funcion-esencial-para-encontrar-el-maximo-valor-en-c/
    }
}
