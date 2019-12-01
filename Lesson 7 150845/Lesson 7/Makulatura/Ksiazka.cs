using System;
using Enumerations;
using Osoby;


namespace Makulatura
{
    public class Ksiazka : Pozycja
    {
        private int liczbaStron;

        private Autor autorInfo;

        private int LiczbaStron
        {
            get
            {
                return this.liczbaStron;
            }
                
            set
            {
                this.liczbaStron = value;
            }
        }

        private Autor AutorInfo
        { 
            get
            {
                return this.autorInfo;
            }
            set
            {
                this.autorInfo = value;
            }
        }

        public Ksiazka()
            : this(0, null, string.Empty, string.Empty, 0, 0)
        {

        }

        public Ksiazka(int liczbaStron, Autor autorInfo, string tytul, string wydawnictwo, DzialTematyczny dzialTematyczny, int rokWydania)
            : base(tytul, wydawnictwo, dzialTematyczny, rokWydania)
        {
            this.LiczbaStron = liczbaStron;
            this.AutorInfo = autorInfo;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Autor: \n" +
                $"Imie: {AutorInfo.Imie}\n" +
                $"Nazwisko: {AutorInfo.Nazwisko}\n" +
                $"Narodowosc: {AutorInfo.Narodowosc}\n" +
                $"\n" +
                $"Ksiazka:\n" +
                $"ID: {base.ID}\n" +
                $"Tytul: {base.Tytul}\n" +
                $"Wydawnictwo: {base.Wydawnictwo}\n" +
                $"Rok wydania: {base.RokWydania}\n" +
                $"Liczba stron: {this.LiczbaStron}\n");
        }


    }
}
