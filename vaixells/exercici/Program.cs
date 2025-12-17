namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        string nomFitx = "input";
        var linies = File.ReadAllLines(nomFitx);

        var resultat = VaixellMesProxim(linies);
        Console.WriteLine($"Ataquem el vaixell {resultat.Item1}, a {resultat.Item2} nusos");
    }

    public static (string, int) VaixellMesProxim(string[] linies)
    {
        List<(string, int)> valorsFinalsTupla = new();

        for (int i = 0; i < linies.Length; i += 2)
        {
            string pais = linies[i];
            string[] filera = linies[i + 1].Split(",");

            List<int> valors = new();

            for (int j = 0; j < filera.Length; j++)
            {
               valors.Add(int.Parse(filera[j]));
            }

            List<int> valorsFinals = new();

            int valorActual = valors[0];
            int comptador = 1;

            for (int j = 1; j < valors.Count; j++)
            {
                if (valors[j] == valorActual)
                {
                    comptador++;
                }
                else
                {
                    if (comptador == valorActual)
                        valorsFinals.Add(valorActual);

                    valorActual = valors[j];
                    comptador = 1;
                }
            }

            if (comptador == valorActual)
            {
                valorsFinals.Add(valorActual);
            }

            string text = "";
            foreach (var v in valorsFinals)
            {
                text += $"{v}";

            }

            int nusos = int.Parse(text);
            if (nusos <= 100)
            {
                valorsFinalsTupla.Add((pais, nusos));
            }
            

        }

        //S'hauria de canviar si no hi haguessin valors (no ingressats o tots superiors a 100)
        var valorsOrdenats = valorsFinalsTupla.OrderBy(item => item.Item2).ToList();
        return (valorsOrdenats[0].Item1, valorsOrdenats[0].Item2);
    }
}
