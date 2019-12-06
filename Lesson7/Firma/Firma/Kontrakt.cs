namespace Firma
{
    public enum typyKontraktu
    {
        Staz,
        Etat
    };

    public class Kontrakt
    {
        public typyKontraktu typKontraktu;

        public decimal podstawaWynagrodzenia;

        public Kontrakt()
        {
            this.typKontraktu = typyKontraktu.Staz;
            this.podstawaWynagrodzenia = 2000;
        }

        public Kontrakt(typyKontraktu typKontraktu, decimal podstawaWynagrodzenia)
        {
            this.typKontraktu = typKontraktu;
            this.podstawaWynagrodzenia = podstawaWynagrodzenia;
        }

        public decimal Pensja() => this.podstawaWynagrodzenia;

        public decimal Pensja(int iloscNadgodzin) => this.podstawaWynagrodzenia + iloscNadgodzin * (this.podstawaWynagrodzenia / 160);
    }
}
