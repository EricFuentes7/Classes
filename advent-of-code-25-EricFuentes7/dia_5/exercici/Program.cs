namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        var fitxer = "input";
        var linies = File.ReadAllLines(fitxer);
        List<string> intervals = new();
        List<long> valors = new();

        long valor = 0;
        foreach (var linea in linies)
        {
            if(string.IsNullOrWhiteSpace(linea)){
                valor++;
            }

            else if (valor == 0){
                intervals.Add(linea);
            } else  {
                valors.Add(Convert.ToInt64(linea));
            }
        }

        int resultat = ValorsAInterval(intervals, valors);
        Console.WriteLine(resultat);
    }

    public static int ValorsAInterval (List<string> intervals, List<long> valors){
        
        int freshes = 0;

        List<(long, long)> valorsInterval = new();

        foreach (var interval in intervals)
        {
            var parts = interval.Split('-');
            long inici = long.Parse(parts[0]);
            long final = long.Parse(parts[1]);
            valorsInterval.Add((inici, final));
        }

        foreach (long val in valors)
        {
            foreach (var (start, end) in valorsInterval)
            {
                if (val >= start && val <= end)
                {
                    freshes++;
                    break;
                }
            }
        }


        
        /*
        List<(long, long)> valorsInterval = new();

        foreach (var interval in intervals){
            var parts = interval.Split('-');
            long inici = long.Parse(parts[0]);
            long final = long.Parse(parts[1]);
            valorsInterval.Add((inici, final));
        }
        HashSet<long> valorsIrrepetibles = new();

        foreach (var val in valorsInterval)
        {
            for (long i = val.Item1; i <= val.Item2; i++)
            {
                valorsIrrepetibles.Add(i);
            }
        }

        foreach (long val in valors)
        {
            if (valorsIrrepetibles.Contains(val))
            {
                freshes++;
            }
        }
        */
        return freshes;
    }
}
