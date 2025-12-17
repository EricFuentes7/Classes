namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        var fitxer = "input";
        var linies = File.ReadAllLines(fitxer);
        List<List<char>> mapa = new();

        foreach (var linea in linies)
        {
            var lletres = linea.ToCharArray();
            mapa.Add(lletres.ToList());
        }

        int resultat = MesRotllosPaper(mapa);
        Console.WriteLine(resultat);
    }

    public static int MesRotllosPaper(List<List<char>> mapa)
    {
        int files = mapa.Count;
        int columnes = mapa[0].Count;
        int papers = 0;
        for (int i = 0; i < files; i++)
        {
            for (int j = 0; j < columnes; j++)
            {

                if (mapa[i][j] == '@')
                {
                    int contar = 0;
                    if (i > 0 && mapa[i - 1][j] == '@') contar++;
                    if (i > 0 && j < columnes - 1 && mapa[i - 1][j + 1] == '@') contar++;
                    if (i > 0 && j > 0 && mapa[i - 1][j - 1] == '@') contar++;
                    if (j > 0 && mapa[i][j - 1] == '@') contar++;
                    if (i < files - 1 && mapa[i + 1][j] == '@') contar++;
                    if (i < files - 1 && j < columnes - 1 && mapa[i + 1][j + 1] == '@') contar++;
                    if (i < files - 1 && j > 0 && mapa[i + 1][j - 1] == '@') contar++;
                    if (j < columnes - 1 && mapa[i][j + 1] == '@') contar++;
                    
                    // i-1,j+1
                    //i+1,j-1
                    if (contar<4){
                    papers++;
                }

                }
                
            }
        }

        return papers;
    }
}
