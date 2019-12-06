using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Osoba osoba1 = new Osoba();
            Autor autor1 = new Autor();
            Pozycja pozycja1 = new Pozycja();
            Książka książka1 = new Książka();
            Czasopismo czasopismo1 = new Czasopismo();
            Katalog katalog1 = new Katalog();

            pozycja1.WypiszInfo();
            książka1.WypiszInfo();
            książka1.liczbaStron = 20;
            książka1.Książka();
            czasopismo1.WypiszInfo();
            katalog1.DodajPozycje();

            Console.ReadKey();
        }
    }
}