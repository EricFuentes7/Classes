namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix els euros");
        double euros = Convert.ToDouble(Console.ReadLine());
        int pessetes = Convert.ToInt32(euros * 166.386);
        Console.WriteLine($"El valor en pessetes és de: {pessetes:F0} pstes");
    }
} 
