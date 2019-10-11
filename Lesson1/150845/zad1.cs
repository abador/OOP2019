using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < tab.Length; i++)
                Console.Write($"{tab[i]},");
            Console.Write("\n");
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);

            Console.ReadLine();
        }
    }
}
