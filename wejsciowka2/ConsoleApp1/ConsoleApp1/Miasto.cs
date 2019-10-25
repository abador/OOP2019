using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Miasto
    {
        public int liczbaLudnosci;
        public string nazwaMiasta;
        public Miasto(int liczbaLudnosci, string nazwaMiasta)
        {
            this.liczbaLudnosci = liczbaLudnosci;
            this.nazwaMiasta = nazwaMiasta;
        }
        public int PodajCeneZaMetr()
        {
            if (liczbaLudnosci > 10000)
            {
                return 150;
            }
            else if (liczbaLudnosci < 100000 & liczbaLudnosci > 25000)
            {
                return 80;
            }
            else return 40;
        }
    }
}
