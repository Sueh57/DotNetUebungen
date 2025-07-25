namespace Uebung1.Domain;

public class Auto
{
    public string Farbe { get; set; }
    public int MaximaleGeschwindigkeit { get; set; }
    public int AnzahlTueren { get; set; }

    public Auto(string farbe, int maximaleGeschwindigkeit)
    {
        Farbe = farbe;
        MaximaleGeschwindigkeit = maximaleGeschwindigkeit;
    }
}