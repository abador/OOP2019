using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Kontrakt
    {
        public enum typyKontaktu
        {
            staz,
            etat
        };

        public typyKontaktu typKontaktu;

        public decimal podstawaWynagrodzenia;

        public Kontrakt()
        {
            this.typKontaktu = typyKontaktu.staz;
            this.podstawaWynagrodzenia = 2000;
        }

        public Kontrakt(typyKontaktu typKontaktu, decimal podstawaWynagrodzenia)
        {
            this.typKontaktu = typKontaktu;
            this.podstawaWynagrodzenia = podstawaWynagrodzenia;
        }

        public decimal Pensja() => this.podstawaWynagrodzenia;

        public decimal Pensja(int iloscNadgodzin) => this.podstawaWynagrodzenia + iloscNadgodzin * (this.podstawaWynagrodzenia / 160);
    }
}
