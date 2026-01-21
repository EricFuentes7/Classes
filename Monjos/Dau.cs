namespace Monjos;

public class Dau
{
    public int caresQueTe = 6;

    public int llancarDau()
    {
        Random r = new();
        return r.Next(caresQueTe);
    }
}