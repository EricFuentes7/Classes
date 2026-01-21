namespace VaquesA;

public class Camio
{
    private int pesMaxim;
    private int pesActual;
    private List<Vaques> vaques = new();
    
    //Constructor
    public Camio(int maxim)
    {
        pesMaxim =  maxim;
        pesActual = 0;
    }
    
    //Mètode
    public bool AfegirVaca(Vaques vaca)
    {
        if (pesActual + vaca.Pes <= pesMaxim)
        {
            pesActual += vaca.Pes;
            vaques.Add(vaca);
            return true;
        }

        return false;
    }

    public void DescarregarVaques()
    {
        vaques.Clear();
        pesActual = 0;
    }

    public int QuantsLitresPorta()
    {
        int quants = 0;
        foreach (var vaca in vaques)
        {
            quants += vaca.Llitres;
        }
        return quants;
    }

    public string NomDeLesVaques()
    {
        List<string> noms = new();
        foreach (var vaca in vaques)
        {
            noms.Add(vaca.Nom);
        }

        return string.Join(", ", noms);
    }
}