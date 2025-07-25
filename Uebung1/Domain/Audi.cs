using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung1.Domain;

public class Audi : Auto
{
    public Audi(string farbe, int maximaleGeschwindigkeit) : base(farbe, maximaleGeschwindigkeit)
    {
    }
}