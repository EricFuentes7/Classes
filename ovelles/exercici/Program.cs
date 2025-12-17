namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        var fitxer = "input";
        var linies = File.ReadAllLines(fitxer);
        //string[] linies = ["blanca", "negra"];
        var resultat = QuantesOvelles(linies);
        Console.WriteLine(resultat);
    }

    public static (int, int, int) QuantesOvelles (string[] linies)
    {

        if (linies.Length % 2 != 0) return (0,0,0);

        List<string> colorsPrinc = new();

        (int, int, int) colors = (0,0,0);


        for (int i = 0; i < linies.Length; i++)
        {
            if (i >= linies.Length / 2)
            {
                int j = linies.Length - 1 - i;


                string actual = linies[i].Trim();
                string principal = colorsPrinc[j].Trim();

                if (principal == actual && actual == "blanca") colors.Item1++;
                else if (principal == actual && actual == "negra") colors.Item2++;
                else colors.Item3++;
            }
            else
            {
                colorsPrinc.Add(linies[i].Trim());
            }
        }

        return colors;
    }
}
