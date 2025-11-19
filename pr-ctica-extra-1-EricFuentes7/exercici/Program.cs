namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        List<int> plantesSospitoses = new();
        Console.WriteLine("Introdueix plantes (doble enter per acabar):");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            int nom = Convert.ToInt32(input);
            plantesSospitoses.Add(nom);
        }
        Console.Write("Insereix el nom de l'arxiu: ");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("L'arxiu no existeix.");
            return;
        }

        string contenido = File.ReadAllText(filePath);

        char[] arrayCaracteres = contenido.ToCharArray();
        int planta = 0;
        bool finalitzat = false;
        
        foreach (char c in arrayCaracteres)
        {
            if(c == 'U')
            {
               planta +=1; 
            }
            else if (c == 'D'){
                planta-=1;
            }
            else if (c == '*')
            {
                foreach (int pSos in plantesSospitoses)
                {
                    if (planta == pSos){
                        Console.WriteLine("SI");
                        finalitzat = true;
                        return;
                    }
                }
            }
        }
        if (!finalitzat)
        {
            Console.WriteLine("NO");
        }
    }
}
