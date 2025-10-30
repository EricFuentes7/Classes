namespace exercici4;

class Program
{
    static void Main(string[] args)
    {
        /*
        Els professors de matemàtiques estan tan acostumats a fer coses complicades que
        ara no saben dir si un número és capicua o no ho és. Feu un programa que a partir
        d’un número de tres xifres ens digui si és capicua o no
        Entra el número: 212
        El número és capicua
        */

        Console.Write("Entra el número: ");
        string numero = Console.ReadLine();
        Console.WriteLine((numero[0] == numero[2]) ? "El número és capicua" : "El número no és capicua");
    }
}
