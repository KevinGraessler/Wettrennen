using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wettrennen
{
    internal class Fahrrad : Fahrzeug
    {
        public Fahrrad()
        {
            MaxGeschwindigkeit = 30;
            AnzahlRäder = 2;
        }
    }
}
