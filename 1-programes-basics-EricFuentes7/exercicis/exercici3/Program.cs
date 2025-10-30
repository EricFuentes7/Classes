namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string nomProducte = "Cafè amb sucre";
        double preuProducte = 1.99;
        bool enEstoc = true;
        Console.WriteLine($"Nom del producte: {nomProducte}\nPreu: {preuProducte}€\n{(enEstoc ? "Està en estoc" : "No està en estoc")}. ");
    }
}
