using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperature Celcjusza");
            double a = 0;
            a = double.Parse(Console.ReadLine());
            double temperatura = 0;
            temperatura = (a * 1.8) + 32;
            Console.WriteLine("Podałeś " + a + " Stopni Celcjusza");
            Console.WriteLine("Podana temperatura równa się " + temperatura + " stopni Fahrenheita");
            Console.ReadKey();
        }
    }
}
