namespace exercici1;

/* Escriviu un programa que demani el nom i el cognom de l’usuari i que el presenti com en James Bond

Entra el nom: Pere
Entra el cognom: González

Em dic González, Pere González

Entra el nom: Joan
Entra el cognom: Pi

Em dic Pi, Joan Pi 

*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el nom: ");
        string nom = Console.ReadLine();
        Console.Write("Entra el cognom: ");
        string cognom = Console.ReadLine();

        Console.WriteLine($"Em dic {cognom}, {nom} {cognom}");
    }
}
