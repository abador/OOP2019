using System;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("yes", "no");
            Autor autor = new Autor("xD", "yes", "no");
            Ksiazka ksiazka = new Ksiazka();
            ksiazka.WypiszInfo();
            Czasopismo czasopismo = new Czasopismo();
            czasopismo.WypiszInfo();
        }
    }
}
