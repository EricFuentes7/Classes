namespace AliensHosties;

public class Alien
{
    private List<int> ADN;

    public Alien(List<int> adn)
    {
        ADN = adn;
    }

    public void FotreHosties()
    {
        for (int i = 1; i < ADN.Count; i++)
        {
            if (ADN[i] < ADN[i - 1])
            {
                ADN[i]++;
                return;
            }
        }
    }

    public bool EstaArreglat()
    {
        for (int i = 1; i < ADN.Count; i++)
        {
            if (ADN[i] < ADN[i - 1])
            {
                return false;
            }
        }
        return true;
    }
}