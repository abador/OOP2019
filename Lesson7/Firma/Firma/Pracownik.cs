namespace Firma
{
    public class Pracownik
    {
        public string imie;
        public string nazwisko;

        public Kontrakt kontrakt;

        public Pracownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;

            this.kontrakt = new Kontrakt();
        }

        public void ZmienKontrakt() => this.kontrakt.typKontaktu = this.kontrakt.typKontaktu == Kontrakt.typyKontaktu.staz ? Kontrakt.typyKontaktu.etat : Kontrakt.typyKontaktu.staz;

        public void ZmienPodstawePensji(decimal pensja) => this.kontrakt.podstawaWynagrodzenia = pensja;

        public decimal Pensja() => this.kontrakt.Pensja();

        public override string ToString() => $"{this.imie} {this.nazwisko} - {this.kontrakt.podstawaWynagrodzenia}zł";

        public Pracownik GlebokaKopia()
        {
            var tymczasowa = new Pracownik(this.imie, this.nazwisko);
            
            tymczasowa.kontrakt = new Kontrakt(this.kontrakt.typKontaktu, this.kontrakt.podstawaWynagrodzenia);
            
            return tymczasowa;
        }
    }
}
