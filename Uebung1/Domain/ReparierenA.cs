namespace Uebung1.Domain;

public class ReparierenA
{
    private string _kunden_name;

    public ReparierenA(string kundenName)
    {
        _kunden_name = kundenName;
    }
    public void Ausführen()
    {
        Console.WriteLine("Reperaturprozess für " + _kunden_name + " wird gestartet...");
    }
}




    
    