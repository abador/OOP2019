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
            int n;
            while (true)
            {
                Console.WriteLine("Podaj liczbe");
                n = int.Parse(Console.ReadLine());
                if (n >= 5 && n <= 15)
                    break;
            }
            
            while (n>=0)
            {

                Console.WriteLine(n);
                n--;
            }
            Console.ReadLine();
        }
    }
}
