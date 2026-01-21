namespace Monjos;

public class Monjo
{
    public int Identificador;
    public int pedresQueTe;

    public Monjo(int ID)
    {
        Identificador = ID;
    }
    private int d = new Dau().caresQueTe; 
    
    public int agafarPedres()
    {
        Random r = new();
        return r.Next(d);
    }
}