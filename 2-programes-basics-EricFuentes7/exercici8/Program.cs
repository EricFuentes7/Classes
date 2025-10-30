namespace exercici8;

class Program
{
    static void Main(string[] args)
    {
        /*
        En un casal d’estiu han de dividir els nens en quatre grups:
        a. Grup vermell: Els nens que viuen en cases amb números d'1 a 20
        b. Grup blau: Els nens que viuen en cases amb números de 21 a 40
        c. Grup verd: Els nens que viuen en cases amb números de 41 a 60
        d. Grup blanc: Els nens que viuen en cases amb números a partir
        del 61
        Necessiten un programa per classificar els nens en el grup adequat:
        Entra el número: 23
        Va al grup blau
        */
        Console.Write("Entra el número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        string grup = "";
        if (numero >= 1 && numero < 21)
        {
            grup = "vermell";
        }
        else if (numero > 20 && numero < 41)
        {
            grup = "blau";
        }
        else if (numero > 40 && numero < 61)
        {
            grup = "verd";
        }
        else if (numero > 60)
        {
            grup = "blanc";
        }

        if (grup != "")
        {
            Console.WriteLine($"Estàs al grup {grup}");
        } else {Console.WriteLine("Insereix un valor vàlid (començant per 1)");}
    }
}
