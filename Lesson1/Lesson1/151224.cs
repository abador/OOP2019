using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby;
            liczby = new int[5];
            liczby[0] = 1;
            liczby[1] = 3;
            liczby[2] = 5;
            liczby[3] = 7;
            liczby[4] = 9;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(liczby[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(liczby[i] + ",");
            }

                Console.ReadKey();
        }
    }
}
