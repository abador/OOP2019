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
            Console.WriteLine("1: ");
            string haslo1 = Console.ReadLine();
            Console.WriteLine("2: ");
            string haslo2 = Console.ReadLine();

            if (haslo1 == haslo2)
                Console.WriteLine("takie same");
            else
                Console.WriteLine("inne");

            Console.ReadKey();
        }
    }
}
