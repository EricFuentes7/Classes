namespace JugarFutbol;

class Program
{
    public static (int porters, int davanters, int migcampistes, int defensa) stats = (0, 0, 0, 0);

    static void Main(string[] args)
    {
        List<Jugador> jugadors = new List<Jugador>
        {
            new Jugador("Biel Trencapins", 1, "Porter", "Lesionat"),
            new Jugador("Pau Llamp", 2, "Defensa"),
            new Jugador("Quim Pedragosa", 19, "Defensa"),
            new Jugador("Arnau Trespassos", 5, "Migcampista"),
            new Jugador("Ferran Mitjons", 12, "Defensa"),
            new Jugador("Oriol Culplà", 6, "Migcampista"),
            new Jugador("Martí Galindó", 4, "Defensa"),
            new Jugador("Juan Gómez", 21, "Porter"),
            new Jugador("Pol Gambada", 10, "Davanter"),
            new Jugador("Federico Corner", 11, "Davanter", "Expulsat"),
            new Jugador("Israel Puig", 18, "Migcampista"),
            new Jugador("Ahmed Sharsha", 9, "Davanter"),
            new Jugador("Marcial Rubio \"Marcialinha\"", 8, "Davanter")
        };
        
        Console.Write("Formació? ");
        var parts = Console.ReadLine().Split('-');

        (int, int, int) formacio = (
            int.Parse(parts[0]),
            int.Parse(parts[1]),
            int.Parse(parts[2])
        );

        for (int i = 0; i < jugadors.Count; i++)
        {
            //cridar switch i loop de jugadors
        }
        
    }

    public static void sumarValors(string pos)
    {
        switch (pos){
            case "Porter":
                stats.porters++;
                break;
            case "Davanter":
                stats.davanters++;
                break;
            case "Migcampista":
                stats.migcampistes++;
                break;
            case "Defensa":
                stats.defensa++;
                break;
        }
    }
}