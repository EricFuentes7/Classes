namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        var fitxer = "input";
        var linies = File.ReadAllLines(fitxer);
        var resultat = QuinRobotEsQueda(linies);
        Console.WriteLine(resultat);
    }

    public static string QuinRobotEsQueda(string[] linies)
    {
        List<string> robots = new();
        List<int> valors = new();
        foreach (var noms in linies[0].Split(","))
        {
            robots.Add(noms);
        }

        foreach (var val in linies[1].Split(","))
        {
            valors.Add(int.Parse(val));
        }


        int posRob = 0;
        int onComenca = 0;
        
        while (robots.Count > 1)
        {
            int pitos = valors[onComenca];
            posRob = (posRob + pitos - 1) % robots.Count;
            robots.RemoveAt(posRob);
            onComenca++;
        }

        return robots[0];
    }
}
