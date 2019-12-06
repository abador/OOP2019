using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firma.Properties
{
    enum typKontraktu { staz, etat };
    class Kontrakt
    {
        private typKontraktu typkontraktu;
        public int podstawaWynagrodzenia;

        
        public int Pensja()
        {
            return 2000;
        }

        public int Pensja(int iloscNadgodzin)
        {

            return podstawaWynagrodzenia + (iloscNadgodzin * (podstawaWynagrodzenia / 160));
        }
        public Kontrakt(typKontraktu typkontraktu,int podstawaWynagrodzenia)
        {
            this.podstawaWynagrodzenia=podstawaWynagrodzenia;
            this.typkontraktu = typkontraktu;
        }
        public Kontrakt() { }
}
}
