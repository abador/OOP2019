using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Szkola
    {
        public int liczbaUczniow;
        public int liczbaLawek;

        public void SprawdzLawki()
        {
            if (this.liczbaLawek * 2 >= this.liczbaUczniow)
                Console.WriteLine("Ławek wystarczy dla wszystkich uczniów.");
            else
                Console.WriteLine("Ławek nie wystarczy dla wszystkich uczniów.");
        }
    }
}
