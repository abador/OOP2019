using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia02
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Console.WriteLine("Nazwa samochodu: {0}", carName);

            Car car1 = new Car("Renault", 1995);
            Car car2 = new Car("Mitsubishi", 1990);

            //car1 = car2;

            Console.WriteLine("{0}, {1}", car1.pobierzMarke(), car1.pobierzRok());
            Console.WriteLine("{0}, {1}", car2.pobierzMarke(), car2.pobierzRok());

            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Zbigniew";
            dyrektor.nazwisko = "Boniek";
            dyrektor.okulary = false;
            dyrektor.rokUrodzenia = 1956;
            dyrektor.waga = 75;
            dyrektor.wzrost = 181;

            Console.WriteLine(Environment.NewLine + "Imię: " + dyrektor.imie + Environment.NewLine + 
                "Nazwisko: " + dyrektor.nazwisko + Environment.NewLine +
                "Wiek: " +dyrektor.obliczWiek());

            Pacjent chory = new Pacjent();

            chory.imie = "Grzegorz";
            chory.nazwisko = "Lato";
            chory.wzrost = 1.75;
            chory.waga = 73;
            chory.obliczBMI();

            Console.ReadKey();

        }
    }
}