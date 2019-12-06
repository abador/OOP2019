using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Katalog przygodowe = new Katalog("Przygodowy");
            Autor sapkowski = new Autor("Polska", "Andrzej", "Sapkowski");
            Książka wiedzmin = new Książka(450, sapkowski, "Krew i Wino", "GREG", 1, 2012, przygodowe);
            przygodowe.DodajPozycje(wiedzmin);
            przygodowe.WypiszWszystko();
            Console.ReadKey();
            Console.Clear();
            Katalog motoryzacja = new Katalog("Motoryzacyjny");
            Czasopismo motoryzacja1 = new Czasopismo(1, "TurboMotoryzacja", "TVN TURBO", 1, 2019);
            motoryzacja.DodajPozycje(motoryzacja1);
            motoryzacja.WypiszWszystko();
            Console.ReadKey();

        }
    }
}
