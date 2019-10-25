using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Blok
    {
        public int iloscPieter;
        public bool senior;

        public string CzyWinda(int iloscPieter, bool senior)
        {
            string tak = "Winda jest potrzebna";
            string nie = "Winda nie jest potrzebna";
            if(senior==1)
            {
                return tak;
            }
            else if (iloscPieter>4)
            {
                return tak;
            }
            else
            {
                return nie;
            }
        }

    }
    Blok blok1 = new Blok();
    blok1.iloscPieter = 6;
    blok1.senior = 0;
    Console.WriteLine(CzyWinda(blok1.iloscPieter, blok1.senior));
}
