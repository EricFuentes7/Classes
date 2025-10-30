namespace exercici10;

class Program
{
    static void Main(string[] args)
    {
        /*
        Feu un programa que demani tres números i ens digui quin és el
        número més proper al primer que s’ha entrat
        Si tots dos són igual de propers ho diu
        Entra el número 1: 2
        Entra el número 2: 28
        Entra el número 3: 23
        El número més proper a 2 és el 23
        */
        Console.Write("Entra el número 1: ");
        int numeroReferencial = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entra el número 2: ");
        int primerNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entra el número 3: ");
        int segonNumero = Convert.ToInt32(Console.ReadLine());

        int distancia1 = Math.Abs(numeroReferencial - primerNumero);
        int distancia2 = Math.Abs(numeroReferencial - segonNumero);

        int mesAprop = Math.Min(distancia1, distancia2);

        if (distancia1 == distancia2)
        {
            Console.WriteLine("Les distàncies són iguals");
        }
        else if (distancia1 == mesAprop)
        {
            Console.WriteLine($"El número més proper a {numeroReferencial} és {primerNumero}");
        }
        else if (distancia2 == mesAprop)
        {
            Console.WriteLine($"El número més proper a {numeroReferencial} és {segonNumero}");
        }
    }
}
