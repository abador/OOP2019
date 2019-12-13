using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();
            obiekt1.liczba = 255;
            obiekt2 = obiekt1;
            obiekt3 = obiekt1.GlebokaKopia();
            obiekt1.liczba = 347;
            Console.WriteLine(obiekt1.liczba);
            Console.WriteLine(obiekt2.liczba);
            Console.WriteLine(obiekt3.liczba);
            obiekt1.poleTestowe.słowo = "słowo";
            obiekt1.poleTestowe.słowo = "kaczka";
            Console.WriteLine(obiekt1.poleTestowe.słowo);

            Console.ReadKey();
        }
    }
}
