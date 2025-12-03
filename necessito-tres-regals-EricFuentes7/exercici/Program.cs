namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = {2, 7, 5, 1};
        int diners = 8;
        (int, int, int) valorResultat = SumaNumeros(numeros, diners);
        if (valorResultat == (-1, -1, -1))
        {
            Console.WriteLine("IMPOSSIBLE");
        }
        else
        {
            Console.WriteLine($"Els regals escollits són el de {valorResultat.Item1}€, el de {valorResultat.Item2}€ i el de {valorResultat.Item3}€");
        }
    }
    public static (int, int, int) SumaNumeros(int[] numeros, int diners)
    {
        (int, int, int) valorResultat = (-1, -1, -1);
        for (int i = 0; i < numeros.Length - 2; i++)
        {
            for (int j = i + 1; j < numeros.Length - 1; j++)
            {
                for (int k = j + 1; k < numeros.Length; k++)
                {
                    int suma = numeros[i] + numeros[j] + numeros[k];
                    if (suma == diners)
                    {
                        return (numeros[i], numeros[j], numeros[k]);
                    }
                }
            }
        }
        return valorResultat;
    }
}