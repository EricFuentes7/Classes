using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.AccessControl;

namespace exercici;

public class Program
{

    //HASHSET O DICCIONARIO, SE PONEN TODAS LAS ARRAYS, SI SE SOLAPAN, SIGUEN,  SE SEPARA POR DIFERENCIA D EMÁS DE 1.
    static void Main(string[] args)
    {
        int[,] numeros = {
            {4, 6},
            {5, 7},
            {5, 6},
            {1, 2}
        };

        foreach(var entrega in CalculMolecular(numeros))
        {
            Console.Write(entrega);
        }

    }

    public static List<string> CalculMolecular(int[,] numeros)
    {
        List<string> aRetornar = new();

        if (numeros.Length != 0)
        {
            HashSet<int> coordenades = new();

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = numeros[i, 0]; j <= numeros[i, 1]; j++)
                {
                    coordenades.Add(j);
                }
            }

            // LINQ :(
            var llista = coordenades.OrderBy(n => n).ToList();

            int CordInici = llista[0];
            int CordPrevia = llista[0];

            foreach (var cord in llista.Skip(1))
            {
                if (cord != CordPrevia + 1)
                {
                    aRetornar.Add($"[{CordInici}..{CordPrevia}]");
                    CordInici = cord;
                }
                CordPrevia = cord;
            }

            aRetornar.Add($"[{CordInici}..{CordPrevia}]");

            } else {
                // Se es buit.
                aRetornar.Add("");
            }
        

        return aRetornar;
    }

}
