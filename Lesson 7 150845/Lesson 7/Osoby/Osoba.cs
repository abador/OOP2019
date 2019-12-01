

namespace Osoby
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;

        public string Imie 
        { 
            get
            {
                return this.imie;
            }
            protected set
            {
                this.imie = value;
            }
        }
        public string Nazwisko 
        { 
            get
            {
                return this.nazwisko;
            }
            set
            {
                this.nazwisko = value;
            }
        }



        public Osoba()
        {

        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
