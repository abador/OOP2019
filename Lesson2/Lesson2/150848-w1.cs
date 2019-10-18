using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz hasło");
            Console.WriteLine();
            string hasloa = Console.ReadLine();
            Console.WriteLine("Wpisz hasło ponownie");
            string haslob = Console.ReadLine();
            if(hasloa == haslob)
                Console.WriteLine("Hasla sa identyczne");
            else
                Console.WriteLine("Hasla sa rozne");
            Console.ReadKey();
        }
    }
}
