
namespace Osoby
{
    public class Autor : Osoba
    {
        private string narodowosc;

        public string Narodowosc
        {
            get
            {
                return narodowosc;
            }
            private set
            {
                narodowosc = value;
            }
        }

        public Autor()
        {

        }

        public Autor(string narodowosc, string imie, string nazwisko)
            : base(imie, nazwisko)
        {
            this.narodowosc = narodowosc;
        }
    }
}
