namespace exercici3;

class Program
{
    static void Main(string[] args)
    {
        /*
        L’administrador de la xarxa del cendrassos està cansat d’entrar la constrasenya. Us
        demana que li feu un programa que demani l’usuari i si és l’administrador ja el deixi
        entrar i si és algú altre li demani la contrasenya
        Username: administrador
        Benvingut al sistema

        Username: pere
        Password: xxxxxxxxx
        Benvingut al sistema
        */
        Console.Write("Username: ");
        string nom = Console.ReadLine().ToLower();

        switch (nom)
        {
            case "administrador":
                Console.WriteLine("Benvingut al sistema");
                break;
            default:
                Console.Write("Password: ");
                string passwd = Console.ReadLine();
                Console.WriteLine("Benvingut al sistema");
                break;
        }
    }
}
