using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;
        public Osoba()
        {
            imie = "brak";
            nazwisko = "brak";
        }
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
    public class Autor : Osoba
    {
        private string narodowosc;
        public Autor()
        {
            narodowosc = "brak";
        }
        public Autor(string narodowosc, string imie, string nazwisko) : base(imie, nazwisko)
        {
            this.narodowosc = narodowosc;
        }
    }
    abstract public class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;
        public Pozycja()
        {
            tytul = "brak";
            id = 0;
            wydawnictwo = "brak";
            rokWydania = 0;
        }
        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        abstract public void WypiszInfo();
    }
    public class Ksiazka : Pozycja
    {
        private int liczbaStron;
        //pole referencyjne Autor autor
        public Autor autor;
        public Ksiazka()
        {
            liczbaStron = 0;
        }
        public Ksiazka(Autor autor, int liczbaStron, string tytul, int id, string wydawnictwo, int rokWydania) : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine($"Tytuł - {tytul}");
            Console.WriteLine($"ID - {id}");
            Console.WriteLine($"Wydawnictwo - {wydawnictwo}");
            Console.WriteLine($"Rok Wydania - {rokWydania}");
            Console.WriteLine($"Liczba stron - {liczbaStron}");
            Console.WriteLine($"Autor -  {autor}"); //??
            //throw new NotImplementedException();
        }
    }
    public class Czasopismo : Pozycja
    {
        private int numer;
        public Czasopismo()
        {
            numer = 0;
        }
        public Czasopismo(int numer, string tytul, int id, string wydawnictwo, int rokWydania) : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine($"Tytuł - {tytul}");
            Console.WriteLine($"ID - {id}");
            Console.WriteLine($"Wydawnictwo - {wydawnictwo}");
            Console.WriteLine($"Rok Wydania - {rokWydania}");
            Console.WriteLine($"Numer - {numer}");
            //throw new NotImplementedException();
        }
    }
    public class Katalog
    {
        private string dzialTematyczny;
        //pole referencyjne listaPozycji typu List<Pozycja>
        //public List<Pozycja> listaPozycji;
        public Katalog()
        {
            dzialTematyczny = "brak";
        }
        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }
        //DodajPozycje(pozycja)
        //public void DodajPozycje(Pozycja)
        //{
        //
        //}
    }
    //interface IZarzadzanieKatalogiem
    //{
    //
    //}
}
