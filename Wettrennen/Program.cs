using System;
using System.Drawing;
using System.Net.Http.Headers;

namespace Wettrennen
{
    class Program
    {
        static void Main(string[]args)
        {
            Fahrzeug fahrrad = new Fahrrad();
            Fahrzeug auto = new Auto();
            Fahrzeug krankenwagen = new Krankenwagen();
            Fahrzeug rennwagen = new Rennwagen();


            fahrrad.setGeschwindigkeit(20);
            //höher als die mögliche geschwindigkeit
            auto.setGeschwindigkeit(150);
            krankenwagen.setGeschwindigkeit(80);
            rennwagen.setGeschwindigkeit(200);

            fahrrad.Bewegen(300);
            auto.Bewegen(60);
            krankenwagen.Bewegen(60);
            rennwagen.Bewegen(60);

            Console.WriteLine(fahrrad.Position);
            Console.WriteLine(auto.Position);
            Console.WriteLine(krankenwagen.Position);
            Console.WriteLine(rennwagen.Position);
        }
        
    }

   
}
