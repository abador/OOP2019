using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Miasto Warszawa = new Miasto(500000, "Warszawa");
            Miasto Ciechanow = new Miasto(18000, "Ciechanow");
            Miasto Wroclaw = new Miasto(60000, "Wroclaw");
            Console.WriteLine(Warszawa.nazwaMiasta + " Cena za metr " + Warszawa.PodajCeneZaMetr());
            Console.ReadKey();
        }
    }
}
