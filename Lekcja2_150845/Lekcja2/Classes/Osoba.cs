using System;
using Lekcja2.Enums;
namespace Lekcja2.Classes
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private int rokUrodzenia;
        private int waga;
        private int wzrost;
        private bool okulary;
        protected Plec plec;
        //public = dostepne for all
        //private = dostepne tylko w klasie
        //protected = dostepne w klasie i dla klas podrzednych
        //internal = dostepne w namespace w ktorym jest stworzone

        public Osoba(string imie, string nazwisko, int wzrost, int waga, Plec plec)

        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wzrost = wzrost;
            this.waga = waga;
            this.plec = plec;
        }

        
        public string Imie 
        { 
            get
            {
                Plec test = plec;
                if (test == Plec.K)
                    return "Pani " + imie;
                return "Pan " + imie;
            }
        }

        public string Nazwisko 
        { 
            get
            {
                return nazwisko;
            }
             
        }
           
        public int ObliczWiek(int rokUrodzenia)
        {
            this.rokUrodzenia = rokUrodzenia;
            return DateTime.Now.Year - this.rokUrodzenia;
        }

        public string bmi()
        {
            double wynik = (double)waga / (((double)wzrost / 100) * ((double)wzrost / 100));

            if (wynik >= 30)
                return $"BMI = {wynik}. Masz otylosc";
            else if (wynik >= 25 && wynik <= 29.99)
                return $"BMI = {wynik}. Masz nadwage";
            else if (wynik >= 18.5 && wynik <= 24.99)
                return $"BMI = {wynik}. Twoja waga jest prawidlowa";
            else if (wynik >= 17 && wynik <= 18.49)
                return $"BMI = {wynik}. Masz niedowage";
            else if (wynik >= 16 && wynik <= 16.99)
                return $"BMI = {wynik}. Jestes wychudzony/a";

            return $"BMI = {wynik:N2}. Jestes wyglodzony/a";

        }

    }
}
