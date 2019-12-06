using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firma.Properties
{
    class Pracownik:Kontrakt, IEquatable<Pracownik>, IComparable<Pracownik>
    {
        private string Imie;
        private string Nazwisko;


        



        public Pracownik(string Imie,string Nazwisko,typKontraktu typkontraktu,int podstawaWynagrodzenia):base(typkontraktu,podstawaWynagrodzenia)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            typkontraktu = typKontraktu.staz;

        }
        public void Awans(typKontraktu typkontraktu)
        {
            typkontraktu = typKontraktu.etat;
            
        }
        public void Degradacja(typKontraktu typkontraktu)
        {
            typkontraktu = typKontraktu.staz;

        }

        public void ZmianaPodstawyWynagrodzenia(int podstawaWynagrodzenia)
        {
            base.podstawaWynagrodzenia = podstawaWynagrodzenia;

        }

        public void WypiszDane()
        {
            Console.WriteLine(Imie);
            Console.WriteLine(Nazwisko);
            
            Console.WriteLine(podstawaWynagrodzenia);
        }
        public void WypiszNazwisko()
        {
            
            Console.WriteLine(Nazwisko);

            
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Pracownik objAsPart = obj as Pracownik;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);

        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(Nazwisko);
        }
        public bool Equals(Pracownik other)
        {
            if (other == null) return false;
            return (this.Nazwisko.Equals(other.Nazwisko));
        }
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        public int CompareTo(Pracownik comparePracownik)
        {
            if (comparePracownik == null)
                return 1;

            else
                return this.Nazwisko.CompareTo(comparePracownik.Nazwisko);
        }
    }
}
