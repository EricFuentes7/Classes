namespace VaquesA;

class Program
{
    static void Main(string[] args)
    {
        Camio camio = new Camio(700);
        List<Vaques> vaques = new()
        {
            new Vaques("Maria", 360, 40),
            new Vaques("Pepa", 250, 35),
            new Vaques("Flor", 400, 43),
            new Vaques("Toñi", 180, 28),
            new Vaques("Conxita", 50, 12),
            new Vaques("Blanca", 90, 13),
        };

        foreach (var vaca in vaques)
        {
            // Si no entra al camió
            if (!camio.AfegirVaca(vaca))
            {
                Console.WriteLine($"{camio.NomDeLesVaques()} : {camio.QuantsLitresPorta()}");
                //Descarrega
                camio.DescarregarVaques();
                // Afegir la vaca que no habia entrat al camió
                camio.AfegirVaca(vaca);
            }
        }
        Console.WriteLine($"{camio.NomDeLesVaques()} : {camio.QuantsLitresPorta()}");
        
    }
}