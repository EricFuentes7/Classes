namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        double nota1 = 7.5;
        double nota2 = 8.3;
        double nota3 = 6.4;
        double mitjana = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"La mitjana de la nota és: {mitjana}");
    }
}
