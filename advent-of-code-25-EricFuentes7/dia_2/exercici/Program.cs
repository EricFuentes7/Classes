namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        var fitxer = "input";
        var linies = File.ReadAllText(fitxer);
        string[] intervals = linies.Split(",");

        long resultat = NumRepes(intervals);
        Console.WriteLine(resultat);
    }


    public static long NumRepes(string[] intervals)
    {
        long sumaTotal = 0;

        foreach (var linea in intervals)
        {
            string[] parts = linea.Split("-");
            long inici = Convert.ToInt64(parts[0]);
            long final = Convert.ToInt64(parts[1]);

            for (long i = inici; i <= final; i++)
            {
                string item = i.ToString();
                
                if (item.Length % 2 != 0) continue;

                int mitad = item.Length / 2;
                string a = item.Substring(0, mitad);
                string b = item.Substring(mitad, mitad);

                if (a == b)
                {
                    Console.WriteLine(item);
                    sumaTotal += i;
                }
            }
        }

        return sumaTotal;
    }

    /*public static int NumRepes(string[] intervals)
    {
        foreach (var linea in intervals)
        {
            var parts = linea.Split("-");
            int inici = int.Parse(parts[0]);
            int final = int.Parse(parts[1]);

            for (int i = inici; i <= final; i++)
            {
                List<int> llistaI = new();
                llistaI.Add(i);

                foreach (var valor in llistaI)
                {
                    bool found = false;
                    string item = Convert.ToString(valor);

                    int pos = 1; 
                    while (!found && pos < item.Length)
                    {
                        if (item[pos - 1] == item[pos])
                        {
                            Console.WriteLine(item);
                            found = true;
                        }
                        pos++; 
                    }
                }
            }
        }
        return 0;
    }
*/
}
