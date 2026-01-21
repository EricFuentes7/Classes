namespace VaquesA;

public class Vaques
{
    public Vaques(string nom, int pes, int llitres)
    {
        nomVaca = nom;
        Pes = pes;
        Llitres = llitres;
    }
    private string nomVaca;
    public string Nom { get => nomVaca; set => nomVaca = value; }

    public int Pes { get; private set; }
    public int Llitres { get; private set; }
}