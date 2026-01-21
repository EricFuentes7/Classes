namespace AliensHosties;

class Program
{
    static void Main(string[] args)
    {
        List<Alien> llistaAliens =
        [
            new Alien([5, 3, 7, 2, 9, 12]),
            new Alien([1, 2, 3, 4 ,5 ,6]),
            new Alien([6, 5, 4, 3, 2, 1])
        ];
        
        var hosties = CalcularHosties(llistaAliens);
        Console.WriteLine($"Hem de donar {hosties} hosties.");
    }

    private static int CalcularHosties(List<Alien> llistaAliens)
    {
        int hosties = 0;
        foreach (var alien in llistaAliens)
        {
            while (!alien.EstaArreglat())
            {
                alien.FotreHosties();
                hosties++;
            }
        }

        return hosties;
    }
}