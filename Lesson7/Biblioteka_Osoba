using System;
using System.Collections.Generic;
using System.Text;

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

        public Autor(string imie, string nazwisko) : base(imie, nazwisko)
        {
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
            Console.Write("tytuł" + tytuł);
            Console.Write("id" + id);
            Console.Write("wydawnictwo" + wydawnictwo);
            Console.Write("rokWydania" + rokWydania);
        }
    }

    class Książka : Pozycja
    {
        private int liczbaStron;

        public Książka(int liczbaStron)
        {
            this.liczbaStron = liczbaStron;
        }

        public void WypiszInfo()
        {
            Console.Write("liczbaStron" + liczbaStron);
        }
    }

    class Czasopismo : Pozycja
    {
        private int numer;

        public void WypiszInfo()
        {
            Console.Write("numer" + numer);
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
            List<Pozycja>.Add((Książka) || (Czasopismo));
        }

        public string WyszukajPoTytule()
        {
            string tytuł;
            if (tytuł = string.Parse(Console.ReadLine()));
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
