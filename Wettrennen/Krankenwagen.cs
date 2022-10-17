using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wettrennen
{
    internal class Krankenwagen : Auto
    {
        public Krankenwagen()
        {
            MaxGeschwindigkeit = 80;
        }
        public bool isBlaulicht { get; set; } = false;

        public void switchBlaulicht()
        {
            if(isBlaulicht == false)
            {
                isBlaulicht = true;
            }
            else
            {
                isBlaulicht = false;
            }
            /*
             * Selbe Implementierung kürzere schreibweise
            if (!isBlaulicht)
                isBlaulicht = true;
            else
                isBlaulicht = false;
            */
            /* !(not) 
            isBlaulicht = !isBlaulicht;
            */

            
        }


    }
}
