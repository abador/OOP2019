using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07
{
    public class Kontrakt
    {
        public enum typKontraktu { staż, etat};
        public double podstawaWynagrodzenia;
        public typKontraktu typ;
        public Kontrakt()
        {
            this.podstawaWynagrodzenia = 2000;
        }
        double Pensja()
        {
            return this.podstawaWynagrodzenia;
        }
        double Pensja(int iloscNadgodzin)
        {
            return (podstawaWynagrodzenia + iloscNadgodzin) * (podstawaWynagrodzenia / 160);
        }
    }
    class Pracownik: Kontrakt
    {
        public string imie;
        public string nazwisko;
           
        public static Pracownik Parse(string imie, string nazwisko, double podstawaWynagrodzenia = 2000, typKontraktu typ = typKontraktu.staż)
        {
            var pracownik = new Pracownik();
            pracownik.imie = imie;
            pracownik.nazwisko = nazwisko;
            pracownik.podstawaWynagrodzenia = podstawaWynagrodzenia;
            pracownik.typ = typ;
            return pracownik;
        }
        public typKontraktu swapType()
        {
            if (typ == typKontraktu.staż)
                typ = typKontraktu.etat;
            else
                typ = typKontraktu.staż;
            return typ;
        }
        public override string ToString()
        {
            return "imię: " + imie + ", "  + "nazwisko: " + nazwisko + ", " + "podstawa: " + podstawaWynagrodzenia;
        }       
        public Pracownik DeepCopy()
        {
            Pracownik pracownik = (Pracownik)this.MemberwiseClone();
            pracownik.imie = imie;
            pracownik.nazwisko = nazwisko;
            pracownik.podstawaWynagrodzenia = podstawaWynagrodzenia;
            pracownik.typ = typ;
            return pracownik;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> sortedList = new List<Pracownik>();
            var pracownik1 = Pracownik.Parse("Pierwszy", "Pracownik1", 2000, Kontrakt.typKontraktu.etat);
            sortedList.Add(pracownik1);
            pracownik1.swapType();            
            var pracownik2 = Pracownik.Parse("Drugi", "Pracownik2", 3121, Kontrakt.typKontraktu.staż);
            sortedList.Add(pracownik2);
            var pracownik3 = Pracownik.Parse("Trzeci", "Pracownik3", 23232, Kontrakt.typKontraktu.staż);
            sortedList.Add(pracownik3);
            var pracownik4 = pracownik3.DeepCopy();
            sortedList.Add(pracownik4);
            pracownik3.swapType();
            sortingObj(sortedList);
            Console.ReadKey();
        }
        public static void sortingObj(List<Pracownik> sortedList)
        {
            List<Pracownik> newSortedList = sortedList.OrderBy(o => o.imie).ToList();
            foreach (var elem in newSortedList)
            {
                Console.WriteLine(elem.ToString());
            }
        }
    }

}
