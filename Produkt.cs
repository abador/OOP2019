using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Produkt : ICloneable
    {
        public double ilosc;
        public double cenaJednostkowa;
        public string jednostka;
        public string nazwa;
        public double razem;

        public void Kopiowanie()
        {
            
        }
    }
}
