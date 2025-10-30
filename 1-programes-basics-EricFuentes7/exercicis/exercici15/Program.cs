namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        string nom = "eric";
        string cognom = "fuentes";
        nom = char.ToUpper(nom[0]) + nom.Substring(1);
        cognom = char.ToUpper(cognom[0]) + cognom.Substring(1);
        Console.WriteLine(nom + " " + cognom);

        //Estava fotut eh
    }
}
