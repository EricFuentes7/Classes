namespace exercici1;

 public class Program
{
    static void Main(string[] args)
    {
        int[] numeros = [2, 3, 1, 5];
        
        Console.WriteLine(CalculNumeroPenultim(numeros));
    }

    public static string CalculNumeroPenultim(int[] numeros){
        //https://stackoverflow.com/questions/9673/how-do-i-remove-duplicates-from-a-c-sharp-array
        
        string res;
        int[] numNoRepes = numeros.Distinct().ToArray();
        Array.Sort(numNoRepes);
        if (numNoRepes.Length <= 1)
        {
            res = "error";
        } else
        {
            res = $"{numNoRepes[numNoRepes.Length-2]}";
        }
        return res;
    }
}
