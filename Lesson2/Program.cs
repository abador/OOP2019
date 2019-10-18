using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int mila;
            Console.WriteLine("Podaj mile: ");
            mila = Convert.ToInt32(Console.ReadLine());
            int wynik;
            wynik = (mila * 1,609344);
            wynik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(wynik);
  
            Console.ReadKey();
        }
    }
}
