namespace exercici7;

class Program
{
    static void Main(string[] args)
    {
        /*
        El periodista d’esports del diari de la comarca de la Caseta està
        cansat de fer les cròniques del partit entre el VilaMongat FC i la
        Unió Esportiva Fontverda.
        Per això us demana un programa on ell entri el resultat i li faci la
        crònica (sempre tindrà el mateix text, els lectors són molt fanàtics
        i no se n’adonaran)
        FC Vilamongat: 2
        UE Fontverda: 0
        Gran partit del Vilamongat que ha superat a la UE Fontverda per 2 a 0
        */
        string equip1 = "FC Vilamongat";
        string equip2 = "UE Fontverda";
        Console.Write($"{equip1}: ");
        int primerEquip = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{equip2}: ");
        int segonEquip = Convert.ToInt32(Console.ReadLine());
        string equipGuanyador;
        string equipPerdedor;

        if (primerEquip > segonEquip)
        {
            equipGuanyador = equip1;
            equipPerdedor = equip2;
            Console.WriteLine($"Gran partit del {equipGuanyador} que ha superat a la {equipPerdedor} per {primerEquip} a {segonEquip}.");    

        }
        else if (segonEquip > primerEquip)
        {
            equipGuanyador = equip2;
            equipPerdedor = equip1;
            Console.WriteLine($"Gran partit del {equipGuanyador} que ha superat a la {equipPerdedor} per {segonEquip} a {primerEquip}.");    
        }
        else
        {
            Console.WriteLine($"Partit molt igualat entre els dos rivals que ha acabat en empat {primerEquip} a {segonEquip} tot i els esforços dels dos equips.");
        }

    }
}
