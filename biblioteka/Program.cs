using System;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Katalog kulinarne = new Katalog();
            Katalog przygodowe = new Katalog();
            Autor autor1 = new Autor();
            Autor tolkien = new Autor("John Ronald Reuel", "Tolkien", "angielska");
            Czasopismo czasopismo1 = new Czasopismo();
            czasopismo1.WypiszInfo();
            Czasopismo stodan1 = new Czasopismo("100 dan jedynie z wody i soli", 742, "Jadwiga INC", 2017, 1);
            Czasopismo stodan2 = new Czasopismo("100 dan jedynie z wody i soli", 743, "Jadwiga INC", 2017, 2);
            Czasopismo obiadek74 = new Czasopismo("Wesoly Obiadek", 194, "Mistrzowie Interesu", 2019, 74);
            kulinarne.DodajPozycje(stodan1);
            kulinarne.DodajPozycje(stodan2);
            kulinarne.DodajPozycje(obiadek74);
            Ksiazka lotr1 = new Ksiazka("Wladca Pierscieni: Druzyna Pierscieni", 1, "Maginarium", 1974, 300, tolkien);
            Ksiazka lotr2 = new Ksiazka("Wladca Pierscieni: Dwie Wieze", 32, "Maginarium", 1976, 320, tolkien);
            Ksiazka lotr3 = new Ksiazka("Wladca Pierscieni: Powrot Krola", 145, "Maginarium", 1978, 363, tolkien);
            Ksiazka title = new Ksiazka("Nieznana Ksiazka", 0, "Nieznany", 2000, 767, autor1);
            Czasopismo kamping17 = new Czasopismo("Kamping dla poczatkujacych", 964, "Wladcy Swiata", 2018, 17);
            przygodowe.DodajPozycje(lotr1);
            przygodowe.DodajPozycje(lotr2);
            przygodowe.DodajPozycje(lotr3);
            przygodowe.DodajPozycje(title);
            przygodowe.DodajPozycje(kamping17);
            Console.ReadKey();
            Console.Clear();
            kulinarne.WyszukajPoTytule("100 dan jedynie z wody i soli");
            Console.ReadKey();
            Console.Clear();
            przygodowe.WyszukajPoId(1);
            Console.ReadKey();
            Console.Clear();
            przygodowe.WypiszWszystko();
            Console.ReadKey();
        }
    }
}