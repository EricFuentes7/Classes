namespace exercici2;

class Program
{
    static void Main(string[] args)
    {
        /*
        Feu un programa que demani un nombre i ens digui si el nombre que hem entrat és
        parell o senar?
        Entra el número: 23
        El número és senar
        */
        Console.Write("Entra el número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((numero % 2 == 0) ? "El número és parell" : "El número es senar");
    }
}
