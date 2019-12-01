

using Enumerations;
using System;

namespace Makulatura
{
    public class Czasopismo : Pozycja
    {
        private int numer;

        private int Numer
        { 
            get
            {
                return this.numer;
            }
            set
            {
                this.numer = value;
            }
        }

        public Czasopismo()
            : this(0, string.Empty, string.Empty, 0, 0)
        {

        }

        public Czasopismo(int numer, string tytul, string wydawnictwo, DzialTematyczny dzialTematyczny, int rokWydania)
            : base(tytul, wydawnictwo, dzialTematyczny,  rokWydania)
        {
            this.Numer = numer;
        }


        public override void WypiszInfo()
        {
            Console.WriteLine($"Czasopismo: \n\n" +
                $"ID: {base.ID}\n" +
                $"Numer wyd: {this.Numer}\n" +
                $"Tytul: {base.Tytul}\n" +
                $"Wydawnictwo: {base.Wydawnictwo}\n" +
                $"Rok wydania: {base.RokWydania}\n");
        }


    }
}
