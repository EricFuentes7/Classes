using System;

namespace Tasca
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] fanals = [3, 5, 7, 9, 10];
            Console.WriteLine($"Fanals: {string.Join(", ", fanals)}");
            Console.WriteLine($"Solució: {CalculFanals(fanals)}");
        }

        public static double CalculFanals(int[] fanals){
            
            Array.Sort(fanals);

            int anterior = 0;
            int max = 0;
            int anteriorFin = 0;
            foreach (var ubi in fanals)
            {
                int diferencia = ubi - anterior;
                if (diferencia > max)
                {
                    max = diferencia;
                    anteriorFin = ubi;
                }
                anterior = ubi;
            }
            
            return Math.Round(anteriorFin - max/2.0);
            //Console.WriteLine($"Fanals: {string.Join(", ", fanals)}");
            //Console.WriteLine($"Solució: {Math.Round(anteriorFin - max/2.0)}");
        }
    }
}