namespace exercici;

class Program
{
    static void Main(string[] args)
    {
        var fitxer = "input";
        var linies = File.ReadAllLines(fitxer);

        var resultat = NumeroMesGran(linies);
        Console.WriteLine(resultat);
    }

    public static int NumeroMesGran (string[] linies){

        var resultat = 0;
        foreach(var linea in linies){
            char max = '0';
            int posicio = 0;
            for(int i = 0; i < linea.Length - 1; i++){
                if (linea[i] > max){
                    max = linea[i];
                    posicio = i;
                }
            }
            char max2 = '0';
            for(int i = posicio+1; i < linea.Length; i++){
                if (linea[i] > max2){
                    max2 = linea[i];
                }
            }
            
            var numero = int.Parse($"{max}{max2}");
            //Console.WriteLine(numero);

            resultat += numero;
        }
        return resultat;
        /*
        char primeraPosicio = '0';
        char segonaPosicio = '0';

        List<string> valors= new();

        foreach (string linea in linies){

            primeraPosicio = '0';
            segonaPosicio = '0';
            
            for (int i = 0; i <= linea.Length-2; i++){
                
                if(i > Convert.ToInt32(primeraPosicio.ToString())){
                    primeraPosicio = linea[i];
                }

                for (int j = i+1; j<=linea.Length-1; j++){

                    
                    if(j > Convert.ToInt32(segonaPosicio.ToString())){
                        segonaPosicio = linea[j];
                    }
                }
            }
            valors.Add($"{primeraPosicio}{segonaPosicio}");
        }

        foreach(var valor in valors){
            Console.WriteLine(valor);
        }

        return 0;
        */
    }
}
