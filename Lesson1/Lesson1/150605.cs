using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperW
{
    class Program
    {
        static void Main(string[] args)
        {
            //string bob = "hello bob";
            //string eva = "hello eva";
            //string userName;
            //Console.WriteLine("Podaj swoje imie ");
            //userName = Console.ReadLine();
            //userName = "Hallo " + userName;
            //Console.WriteLine(userName);
            //Console.ReadKey();
            //int a = 4;
            //int b = 3;
            //int c = 6;
            //int d = 6;
            //double wynik, wynik1, wynik2, wynik3;
            //wynik = b + a;
            //wynik1 = a - b;
            //wynik2 = c / b;
            //wynik3 = c * d;

            //Console.WriteLine(wynik + wynik1);
            // Console.WriteLine(wynik1);
            // Console.WriteLine(wynik2);
            // Console.WriteLine(wynik3);
            //zad1
            int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i = 0; i < 9; i ++)
            {
                Console.Write(liczby[i] + ",");
                
            }
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine(liczby[i]);
            }
            Console.ReadKey();

        }
    }
}
