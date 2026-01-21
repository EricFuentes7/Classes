namespace BoxeCombat;

public class Boxejador
{
    public string Nom;
    private int maxRebre = 10;
    private int copsRebuts = 0;
    
    public string[] puntsFebles = { "panxa", "dreta", "esquerra", "cap" };
    
    public Boxejador(string nom,  int MaxRebre)
    {
        Nom = nom;
        maxRebre = MaxRebre;
    }

    public string Picar()
    {
        Random r = new Random();
        int index = r.Next(0, puntsFebles.Length);
        return puntsFebles[index];
    }

    public string Rebre(string nomRebut)
    {
        
        Random r = new Random();
        int index = r.Next(0, puntsFebles.Length);
        if (nomRebut == puntsFebles[index])
        {
            copsRebuts++;
            return (puntsFebles[index]); //cop donat
            Console.WriteLine($"\t{Nom} ha rebut un cop a {puntsFebles[index]}\n");
        }
            return ("Protegit!"); // defensa

    }

    public bool estaDerribat()
    {
        return copsRebuts >= maxRebre;
    }
}