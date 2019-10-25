using System;

namespace Lekcja2.Classes
{
    class Produkt
    {
        private string nazwa;
        private int cena;
        
        public Produkt(string nazwa, int cena)
        {
            this.nazwa = nazwa;
            this.cena = cena; 
        }
        public int Cena 
        { 
            get
            {
                return cena;
            }
        }
        public string Nazwa 
        { 
            get
            {
                return nazwa;
            }
        }

        


    }
}
