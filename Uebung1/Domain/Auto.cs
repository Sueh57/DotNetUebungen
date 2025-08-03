namespace Uebung1.Domain;

public class Auto
{
    private string marke;

    public string Marke
    {
        get => marke;
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) marke = value; 
            else throw new ArgumentException("Feld darf nicht leer sein");
        }
    }
    
    private string farbe;
    public string Farbe 
    {
        get => farbe;
        set
        {
            if (!string.IsNullOrEmpty(value)) farbe = value; 
            else throw new ArgumentException("Feld darf nicht leer sein");
        }
    }
    private int maximaleGeschwindigkeit;

    public int MaximaleGeschwindigkeit
    {
        get => maximaleGeschwindigkeit; 
        set
        {
            if (value > 0) maximaleGeschwindigkeit = value;
            else throw new ArgumentOutOfRangeException(nameof(MaximaleGeschwindigkeit), "Wert muss über 0 sein");
        }
    }

    private int anzahlTueren;

    public int AnzahlTueren
    {
        get => anzahlTueren; 

        set
        {
            if (value >= 2 && value < 5) anzahlTueren = value;
            else throw new ArgumentOutOfRangeException(nameof(AnzahlTueren), "Wert muss zwischen 2 und 5 liegen");
        }
    }

    public Auto(string Marke, string farbe, int maximaleGeschwindigkeit)
    {
        Marke = marke;
        Farbe = farbe;
        MaximaleGeschwindigkeit = maximaleGeschwindigkeit;
    }
}