using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("Podaj liczbe");
                int n = int.Parse(Console.ReadLine());

                if(n>4 && n<7)
                {
                    Console.WriteLine("Dobrze");
                    break;
                }
                Console.WriteLine("Try again");
            }

            Console.ReadLine();

        }
    }
}
