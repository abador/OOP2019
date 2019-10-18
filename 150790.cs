using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj mile do przeliczenia: ");
            string mile = Console.ReadLine();
            mile = mile.Replace('.', ',');
            double kilometry = Convert.ToDouble(mile) / 1.609344;
            Console.WriteLine("Wczytana wartosc: " + mile + "mil");
            Console.WriteLine("Przeliczone: " + kilometry + "kilometrow");

            Console.ReadKey();
        }
    }
}
