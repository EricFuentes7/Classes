using System.Runtime.CompilerServices;

namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        var fitxer = "input";
        var linies = File.ReadAllLines(fitxer);

        var resultat = QuantsZeros(50, linies);
        Console.WriteLine(resultat);
    }

    public static int QuantsZeros(int posicio, string[] linies)
    {
        int zeros = 0;
        
        foreach (var linia in linies)
        {
            char dir = linia[0];
            int lineabest = Convert.ToInt32(linia.Substring(1));

            if (dir == 'L')
            {
                posicio = (posicio -= lineabest)%100;
                
                if(posicio == 0) zeros++;
            } else if (dir == 'R')
            {
                posicio = (posicio += lineabest)%100;
                if(posicio == 0) zeros++;
            }
        }

        return zeros;
    }
}
