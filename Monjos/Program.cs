namespace Monjos;

class Program
{
    static void Main(string[] args)
    {
        Jugar();
    }

    public static void Jugar()
    {
        Dau dau = new Dau();
        Console.Write("Preu del bitllet: ");
        int preuBitllet = Convert.ToInt32(Console.ReadLine());
        Console.Write("Quantitat de monjos: ");
        int quantitatMonjos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Diners dels monjos: ");
        int dinersMonjos = Convert.ToInt32(Console.ReadLine());

        List<Monjo> monjes= CrearMonjes(quantitatMonjos);
        int ronda = 0;
        var bitllets = dinersMonjos / quantitatMonjos;
        while (monjes.Count * preuBitllet > dinersMonjos)
        {
            Random r = new Random();
            int num = r.Next(dau.caresQueTe);
            ronda++;
            Console.WriteLine($"---- RONDA {ronda} ----");
            
            for (int i = monjes.Count - 1; i >= 0; i--)
            {
                int agafat = monjes[i].agafarPedres();
                Console.WriteLine($"Monjo {monjes[i].Identificador} treu {agafat}");
                if (agafat == num)
                {
                    Console.WriteLine($"\tMonjo {monjes[i].Identificador} s'ha suïcidat");
                    monjes.RemoveAt(i);
                }
            }
            Console.WriteLine($"Resultat dau: {num}");
        }

        if (monjes.Count <= 0 || bitllets == 0)
        {
            Console.WriteLine("Tots Suïcidats");
        }
        else
        {
            Console.WriteLine(monjes.Count + " MONJOS VAN A LA MUNTANYA SAGRADA");

        }
    }
    public static List<Monjo> CrearMonjes(int quantitat)
    {
        List<Monjo> monjos = new List<Monjo>();

        for (int i = 0; i < quantitat; i++)
        {
            monjos.Add(new Monjo(i));
        }

        return monjos;
    }
}