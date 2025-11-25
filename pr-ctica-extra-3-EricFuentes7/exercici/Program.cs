using System.Runtime.InteropServices.Marshalling;

namespace exercici;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        Console.Write("Introdueix el camí de l'arxiu de peticions: ");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("L'arxiu no existeix.");
            return;
        }

        string[] lineas = File.ReadAllLines(path);
        List<string> objectes = new();
        List<string> personesNoCompres = new();

        Dictionary<string,int> repeticioObjectes = new();

        foreach (var linea in lineas)
        {
            var partsLine = linea.Split(':', 2); 
            string nom = partsLine[0].Trim();

            if (partsLine.Length == 2 && !string.IsNullOrWhiteSpace(partsLine[1])) //scary :(
            {
                string[] obj = partsLine[1].Split(',');

                foreach (var dinsObj in obj)
                {
                    objectes.Add(dinsObj.Trim());
                }
            }
            else
            {
                personesNoCompres.Add(nom);
            }

        }

        foreach(var itemInside in objectes)
        {
            if (repeticioObjectes.ContainsKey(itemInside))
            {
                repeticioObjectes[itemInside] += 1;
            }
            else
            {
                repeticioObjectes.Add(itemInside, 1);
            }
        }

        if (personesNoCompres.Count > 0)
        {
            Console.WriteLine($"{personesNoCompres.Count} persones han cancelat la compra");
        }

        Console.WriteLine("Aquestes persones són:\n");
        foreach (var pers in personesNoCompres)
        {
            Console.WriteLine(pers);
        }
        Console.WriteLine();
        
        //https://stackoverflow.com/questions/5949904/c-sharp-sort-dictionary-with-linq
        //https://code-maze.com/sort-dictionary-by-value-dotnet/
        var sortedKeyValuePairs = repeticioObjectes.OrderBy(x => x.Value).ToList();


        int numero = 1;
        int contadorLinea = 0;
        foreach (var par in sortedKeyValuePairs)
        {
            if (contadorLinea % 5 == 0)
            {
                Console.Write($"{numero}. ");
                numero++;
                    
            }
    
            Console.Write($"{par.Key}");

            contadorLinea++;
            if (contadorLinea % 5 == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(", ");
            }
        }

    }
}
