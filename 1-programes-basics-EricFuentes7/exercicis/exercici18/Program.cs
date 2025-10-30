namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hora actual: ");
        int horaActual = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hora a incrementar: ");
        int horesIncrementar = Convert.ToInt32(Console.ReadLine());

        int horaResultat = (horaActual + horesIncrementar) % 12;
        if (horaResultat == 0) { horaResultat = 12; }

        Console.WriteLine($"D'aquí {horesIncrementar} hora/es serán la/es {horaResultat}");
        
        //Estada mig fotut per pensar
    }
}
