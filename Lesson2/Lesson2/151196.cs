using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe:");
            double liczba;
            liczba = double.Parse(Console.ReadLine());
            Console.Write(liczba);
            liczba *= 1.609344;
            Console.Write(liczba);
        }
    }
}
