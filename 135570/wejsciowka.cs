using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mnoznik = 1.609344;
            Console.WriteLine("Podaj liczbę mil do konwersji na km.");
            double mile = double.Parse(Console.ReadLine());
            Console.WriteLine("Podałeś {0} mil.", mile);
            Console.WriteLine("Wynik wynosi {0} km.", mile*mnoznik);
            Console.ReadKey();

        }
    }
}
