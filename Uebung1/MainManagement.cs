using Uebung1.Domain;
namespace Uebung1;

public class MainManagement
{
        static void Main(string[] args)
    {
    

            Console.WriteLine("Willkommen bei Suehi Automobile! Wie heißen Sie?");
            string name = Console.ReadLine();
            SagHallo(name);

            Console.WriteLine(
                "Geben Sie bitte anhand dieser Optionen, Ihr Anliegen an: \nA: Auto kaufen\nB: Auto mieten\nC: Auto reparieren lassen");
            string anliegen = Console.ReadLine();

            while (anliegen != "A" && anliegen != "B" && anliegen != "C")
            {
                Console.WriteLine("Geben Sie bitte eine gültige Eingabe ein");
                anliegen = Console.ReadLine();
            }

            switch (anliegen)
            {
                case "A":
                    Console.WriteLine("Sie möchten also ein Auto kaufen.");
                    KaufenA kauf = new KaufenA(name);
                    kauf.Ausführen();
                    break;
                case "B":
                    Console.WriteLine("Sie möchten also ein Auto mieten.");
                    MietenA mieten = new MietenA(name);
                    mieten.Ausführen();
                    break;
                case "C":
                    Console.WriteLine("Sie möchten also ihr Auto reparieren lassen.");
                    ReparierenA reparieren = new ReparierenA(name);
                    reparieren.Ausführen();
                    break;
            }
        }

            public static void SagHallo(string? name)
            {
            Console.WriteLine("Hallo " + name + "! Wie kann ich Ihnen behilflich sein?");
            }
    
    
    }

    
    