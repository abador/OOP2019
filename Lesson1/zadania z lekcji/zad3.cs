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
            int a = 5;
            int b = 9;

            if(a>b)
            {
                Console.WriteLine($"{a}>{b}");
            }
            else
            {
                Console.WriteLine($"{b}>{a}");
            }

            Console.ReadLine();
        }
    }
}
