using System;
using System.Collections.Generic;
using System.Text;

namespace zajecia02
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public enum plec { k, m };

        public int obliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }

    }
}