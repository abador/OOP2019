using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Produkt
    {
        string nazwa;
        double cena;

        public Produkt(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            
        }
        public string Nazwa
        {
            get
            {
                return nazwa;
            }
        }
        public double Cena
        {
            get
            {
                return cena;
            }
        }
        public string Poka()
        {
            return nazwa + " Cena: " + cena + " PLN";
        }

    }

}
