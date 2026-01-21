namespace JugarFutbol;

public class Jugador
{
    public bool estaLesionat = false;
    public bool estaExpulsat = false;
    
    public string Nom;
    public int Numero;
    public string Posicio;
    
    public Jugador(string nom, int numero, string posicio)
    {
        Nom = nom;
        Numero = numero;
        Posicio = posicio;
    }
    public Jugador(string nom, int numero, string posicio, string Caracteristica)
    {
        Nom = nom;
        Numero = numero;
        Posicio = posicio;
        if (Caracteristica == "Lesionat")
        {
            estaLesionat = true;
        }
        else
         {
             estaExpulsat = true;
         }
         
    }
}