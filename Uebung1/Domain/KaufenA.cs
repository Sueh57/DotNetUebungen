namespace Uebung1.Domain;

public class KaufenA
{
    private string _kunden_name;

    public KaufenA(string kundenName)
    {
        _kunden_name = kundenName;
    }
    public void Ausführen()
    {
        Console.WriteLine("Kaufprozess für " + _kunden_name +  " wird gestartet...");
    }

   
}