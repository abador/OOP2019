using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Osoba
    {
        protected string Imie;
        protected string Nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
    }

    class Autor : Osoba
    {
        private string narodowosc;

        public Autor(string imie, string nazwisko, string narodowosc) : base(imie, nazwisko)
        {
            this.Imie = imie;
            this.narodowosc = narodowosc;
            this.Nazwisko = nazwisko;

        }
    }

    abstract class Pozycja
    {
        protected string tytuł;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;


        abstract void WypiszInfo()
        {
            
        }
    }

    class Książka : Pozycja
    {
        private int liczbaStron;

        public Książka(int liczbaStron, int id, int rokWydania, string tytuł, string wydawnictwo):base(id, rokWydania, tytuł, wydawnictwo )
        {
            this.liczbaStron = liczbaStron;
            this.wydawnictwo = wydawnictwo;
            this.tytuł = tytuł;
            this.rokWydania = rokWydania;
            this.id = id;

        }

        public void WypiszInfo()
        {
            Console.Write("liczbaStron" + liczbaStron);
            Console.Write("tytuł" + tytuł);
            Console.Write("id" + id);
            Console.Write("wydawnictwo" + wydawnictwo);
            Console.Write("rokWydania" + rokWydania);
        }
    }

    class Czasopismo : Pozycja
    {
        private int numer;
        public Czasopismo(int numer, int id, int rokWydania, string tytuł, string wydawnictwo) : base(id, rokWydania, tytuł, wydawnictwo)
        {
            this.numer = numer;
            this.wydawnictwo = wydawnictwo;
            this.tytuł = tytuł;
            this.rokWydania = rokWydania;
            this.id = id;
        }

        public void WypiszInfo()
        {
            Console.Write("numer" + numer);
            Console.Write("tytuł" + tytuł);
            Console.Write("id" + id);
            Console.Write("wydawnictwo" + wydawnictwo);
            Console.Write("rokWydania" + rokWydania);
        }
    }

    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        List<Pozycja> listaPozycji;

        public Katalog(string dzialTematyczny, List<Pozycja> listaPozycji)
        {
            this.dzialTematyczny = dzialTematyczny;
            this.listaPozycji = listaPozycji;
        }

        public void DodajPozycje()
        {
            string książka;
            List<Pozycja>.Add((Książka) || (Czasopismo));
        }

        public string WyszukajPoTytule()
        {
            string tytuł;
            if (tytuł = string.Parse(Console.ReadLine())) ;
            this.tytuł = tytuł;
        }

        public int WyszukajPole()
        {
            int pole;
            if (pole = int.Parse(Console.ReadLine())) ;
            this.id = pole;
        }

        public void WypiszWszystko()
        {
            Console.Write("Tytul:" + WyszukajPoTytule());
            Console.Write("Pole:" + WyszukajPole());
        }

    }
}
