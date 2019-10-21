using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int waga;
        public int wzrost;
        public bool okulary;
        //public enum plec { K, M };
        String date = DateTime.Now.Date.ToString();
        int Year = DateTime.Now.Year;
        protected int wiek;

        public Osoba(string imie, string nazwisko, int waga, int wzrost, bool okulary, int wiek, plec plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.waga = waga;
            this.wzrost = wzrost;
            this.okulary = okulary;
            this.wiek = wiek;
            Console.Write(Przedrostek(plec));

        }
        public Osoba(string imie, string nazwisko, int waga, int wzrost)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.waga = waga;
            this.wzrost = wzrost;
            
            //Console.Write(BMI(waga, wzrost));
        }
        public string BMI()
        {
            double bmi = 0;
            bmi = waga / Math.Pow(wzrost, 2);
            if(bmi < 18.5)
            {
                return "Niedowaga";
            }
            else if(bmi >= 18.5 && bmi <= 24.99)
            {
                return "Twoje BMI jest poprawne";
            }
            else
            {
                return "Nadwaga";
            }
        }
        string Przedrostek(plec plec)
        {
            if(plec == plec.M)
            {
               return "Pan ";
            }
            else
            {
                return "Pani ";
            }
        }
        
        public int obliczWiek()
        {
            return Year - wiek;
        }
    }
    public enum plec { K, M }
}
