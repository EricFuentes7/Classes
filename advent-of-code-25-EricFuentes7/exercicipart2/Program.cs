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
        int ZerosEx2 = 0;

        foreach (var linia in linies)
        {
            char dir = linia[0];
            int dist = Convert.ToInt32(linia.Substring(1));

            if (dir == 'L')
            {
                for (int i = 0; i < dist; i++)
                {
                    posicio = (posicio - 1 + 100) % 100;
                    if (posicio == 0) ZerosEx2++;
                }
            }
            else if (dir == 'R')
            {
                for (int i = 0; i < dist; i++)
                {
                    posicio = (posicio + 1) % 100;
                    if (posicio == 0) ZerosEx2++;
                }
            }
        }

        return ZerosEx2;
    }
}
