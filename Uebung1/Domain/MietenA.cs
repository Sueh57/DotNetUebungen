namespace Uebung1.Domain;

public class MietenA
{
    private string _kunden_name;

    public MietenA(string kundenName)
    {
        _kunden_name = kundenName;
    }
    public void Ausführen()
    {
        Console.WriteLine("Mietprozess für " + _kunden_name + " wird gestartet...");
    }

}
     