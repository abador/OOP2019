using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = 9;
            
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine(tablica[i]);
            }

            int k = 0;
            while( n > k){
                Console.WriteLine(tablica[k]);
                k++;
            }
            int j = 0;
            while( n > j)
            {
                Console.Write(tablica[j] + ",");
                    j++;
            }
            Console.WriteLine("/n");
            for(int b = 8; b >= 0; b--)
            {
                Console.WriteLine(tablica[b]);
            }
            Console.WriteLine("\n");
            int a, c = 0;
            a = 2;
            c = 5;
            if(a > c)
            {
                Console.WriteLine(a + " jest wieksze od " + c);
            }
            else
            {
                Console.WriteLine(c + " jest wieksze od " + a);
            }
            Console.WriteLine("Podaj a");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            int f = int.Parse(Console.ReadLine());
            if(d + e >= f && d + f >= e && f + e >= d)
            {
                Console.WriteLine("Trójkąt istnieje");
            }
            else
            {
                Console.WriteLine("Trójkąt nie istnieje");
            }
            Console.ReadKey();
            Console.WriteLine("Podaj liczbe mniejsza od 15 a wieksza od 5");
            int x = int.Parse(Console.ReadLine());
            while (x < 15 && x > 5)
                
            {
                while(x > 0)
                {
                    x = x - 1;
                    Console.WriteLine(x);
                }
            }

            Console.WriteLine("Podaj liczbe wieksza od 4, rozna od 10 i mniejsza od 15");
            int y = 5;
            do
            {    y = int.Parse(Console.ReadLine());
                Console.WriteLine("Podana liczba spełnia warunek");
            }
            while (y > 4 && y != 10 && y < 15);
        }
    }

}
