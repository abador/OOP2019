using System;
using System.Collections.Generic;

namespace Biblioteka
{

    class Osoba
    {
        protected internal string imie;
        protected internal string nazwisko;

        public Osoba()
        {
            this.imie = "Adam";
            this.nazwisko = "Kowalski";
        }

        public Osoba(string name, string surname)
        {
            this.imie = name;
            this.nazwisko = surname;
        }
    }



    class Autor : Osoba
    {
        private string narodowsc;

        public Autor()
        {
            this.narodowsc = "Polska";
        }
        public Autor(string name, string surname, string nationality)
        {
            this.imie = name;
            this.nazwisko = surname;
            this.narodowsc = nationality;
        }
    }


    abstract class Pozycja
    {
        protected internal string tytul;
        protected internal int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja()
        {
            this.tytul = "O psie ktory jezdzil koleja";
            this.id = 1;
            this.wydawnictwo = "GREG";
            this.rokWydania = 2016;
        }

        public Pozycja(string title, int index, string publisher, int date)
        {
            this.tytul = title;
            this.id = index;
            this.wydawnictwo = publisher;
            this.rokWydania = date;
        }

        public abstract void WypiszInfo();

    }


    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        public Autor autor;

        public Ksiazka()
        {
            this.liczbaStron = 279;
            this.autor = new Autor();
        }

        public Ksiazka(string title, int index, string publisher, int date, int pages, Autor author)
        {
            this.tytul = title;
            this.id = index;
            this.wydawnictwo = publisher;
            this.rokWydania = date;
            this.liczbaStron = pages;
            this.autor = author;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł - {0}|Id - {1}|Wydawnictwo - {2}|Rok Wydania - {3}|Liczba Stron - {4}|Autor - {5}", this.tytul, this.id, this.wydawnictwo, this.rokWydania, this.liczbaStron, autor.imie + " " + autor.nazwisko);
        }

    }


    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo()
        {
            this.numer = 1;
        }

        public Czasopismo(string title, int index, string publisher, int date, int number)
        {
            this.tytul = title;
            this.id = index;
            this.wydawnictwo = publisher;
            this.rokWydania = date;
            this.numer = number;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł - {0}|Id - {1}|Wydawnictwo - {2}|Rok Wydania - {3}|Numer - {4}", this.tytul, this.id, this.wydawnictwo, this.rokWydania, this.numer);
        }
    }


    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        List<Pozycja> listaPozycji = new List<Pozycja>();

        public Katalog()
        {
            this.dzialTematyczny = "biografie";
        }

        public Katalog(string theme)
        {
            this.dzialTematyczny = theme;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            listaPozycji.Add(pozycja);
        }

        public void WypiszWszystko()
        {
            foreach (Pozycja element in listaPozycji)
            {
                element.WypiszInfo();
            }
        }

        public void WyszukajPoId(int index)
        {
            foreach (Pozycja element in listaPozycji)
            {
                if (element.id == index)
                {
                    element.WypiszInfo();
                }
            }
        }

        public void WyszukajPoTytule(string title)
        {
            foreach (Pozycja element in listaPozycji)
            {
                if (element.tytul == title)
                {
                    element.WypiszInfo();
                }
            }
        }
    }
}