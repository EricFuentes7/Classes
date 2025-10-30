namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escriu la mitja de pràctiques (40%): ");
        double practiques = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escriu la mitja de exàmens (60%): ");
        double examens = Convert.ToDouble(Console.ReadLine());
        double resultado = practiques * 0.4 + examens * 0.6;
        double final = Math.Round(resultado);

        Console.WriteLine(final);
    }
}
