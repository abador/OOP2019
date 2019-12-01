using Biblioteka;
using Enumerations;
using Osoby;
using System;
using System.Linq;

namespace Makulatura
{
    class Program
    {
        static void Main()
        {

            Autor sapkowski = new Autor("Polska", "Andrzej", "Sapkowski");

            Katalog ksiazki = new Katalog(DzialTematyczny.Ksiazka);
            
            Ksiazka wiedzmin = new Ksiazka(400, sapkowski, "Wiedzmin Krew Elfow", "SuperNowa", DzialTematyczny.Ksiazka, 1994);
            ksiazki.DodajPozycje(wiedzmin);
            
            Ksiazka wiedzmin2 = new Ksiazka(400, sapkowski, "Wiedzmin Czas Pogardy", "SuperNowa", DzialTematyczny.Ksiazka, 1995);
            ksiazki.DodajPozycje(wiedzmin2);

            Katalog czasopisma = new Katalog(DzialTematyczny.Czasopismo);

            Czasopismo newYorkTimes = new Czasopismo(114, "New York Times", "New York Company", DzialTematyczny.Czasopismo, 1951);
            czasopisma.DodajPozycje(newYorkTimes);

            Czasopismo bravoSport = new Czasopismo(4, "Bravo Sport", "ChinChinPao", DzialTematyczny.Czasopismo, 1999);
            czasopisma.DodajPozycje(bravoSport);

            //wiedzmin.WypiszInfo();

            //newYorkTimes.WypiszInfo();

            //czasopisma.WypiszInfo();
            //ksiazki.WypiszInfo();

            ksiazki.WyszukajPoID(1);
            czasopisma.WyszukajPoTytule(bravoSport.Tytul);

            

            

            

            Console.ReadKey();
        }
    }
}
