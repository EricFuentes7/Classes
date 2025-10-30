namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        string carrer = "Carrer nou";
        int numero = 3;
        int codiPostal = 17600;
        string poblacio = "Figueres";

        Console.WriteLine(carrer + ", " + numero + ", " + codiPostal + ", " + poblacio);
    }
}
