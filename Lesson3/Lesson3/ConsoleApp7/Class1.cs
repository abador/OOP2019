using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Szkola
    {
        public int liczbaUczniow;
        public int liczbaLawek;
        public string komunikat;
        public void SprawdzLawki()
        {
            if (liczbaUczniow < liczbaLawek)
            {
                komunikat = "sa lawki";
            }
            else
                komunikat = "nie ma wolnej lawki";
        }
    }
}
