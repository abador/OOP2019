using System;
using Lekcja2.Classes;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string carName = "Moj samochod";
            //Console.WriteLine(carName);

            Car car1 = new Car("Mazda", "6", 2004, 6);
            Car car2 = new Car("Audi", "A3", 2003, 4);
            Console.WriteLine($"{car1.Marka} rok produkcji: {car1.RokProdukcji}");
            Console.WriteLine($"{car2.Marka} {car2.Model} rok produkcji: {car2.RokProdukcji}");

            /*car1 = car2;
            Console.WriteLine($"{car1.Marka} rok produkcji: {car1.RokProdukcji}");
            Console.WriteLine($"{car2.Marka} {car2.Model} rok produkcji: {car2.RokProdukcji}");
            Wszystkie pola car1 zostaly zamienione na pola car2*/

            Console.WriteLine($"Samochod {car2.Marka} {car2.Model} 1234 km spali srednio benzyny za {car2.ObliczKosztPrzejazdu(1234, 4.84):N2} zlotych");

            Console.WriteLine(OpiszTyp.opiszTyp(5));

            Osoba dyrektor = new Osoba("Jan", "Kowalski", 185, 105, Enums.Plec.M);

            Console.WriteLine($"{dyrektor.Imie} {dyrektor.Nazwisko} ma {dyrektor.ObliczWiek(1967)} lat");

            Osoba pacjent = new Osoba("Karolina", "Winda", 151, 31, Enums.Plec.K);

            Console.WriteLine($"{pacjent.Imie} {pacjent.Nazwisko}\nWskaznik  {pacjent.bmi()}");

            Produkt pralka = new Produkt("Pralka", 990);
            Produkt laptop = new Produkt("Laptop", 2200);

            Koszyk klient = new Koszyk();

            klient.Add(pralka);
            klient.Add(laptop);
            klient.ShowKoszyk();
            klient.CenaKoszyka();

            Zespolone l = new Zespolone(12, 1);
            l.Wypisz();
            l.Add(1, 2);
            l.Wypisz();
            l.Subtrack(1, 2);
            l.Wypisz();


            Console.ReadKey();
        }
    }
}
