namespace Wettrennen
{
    internal class Fahrzeug
    {

        public double Position { get; set; }

        public int Geschwindigkeit { get; set; }

        public int MaxGeschwindigkeit { get; set; } = 0;

        public int AnzahlRäder { get; set; } = 0;




        public void Bewegen(double anzahlMinuten)
        {
            int stundeInMinuten = 60;
            //km/h/60
            //    120/60 = 2
            //    100/60 = 1.7

            //anzahlMinuten/60 = Position

            Position += (anzahlMinuten/stundeInMinuten) * Geschwindigkeit;

            
            
            
        }
        public void setGeschwindigkeit(int neueGeschwindigkeit)
        {
            
            if(neueGeschwindigkeit <= MaxGeschwindigkeit)
            {
                Geschwindigkeit = neueGeschwindigkeit;
                Console.WriteLine("Geschwindigkeit angepasst.");
            }
            else
            {
                Console.WriteLine("So schnell kann ich nicht fahren alter..");
            }
        }
    }
}