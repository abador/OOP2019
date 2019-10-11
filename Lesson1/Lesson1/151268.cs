using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica1 = { 420, 69, 14, 42, 1337, 2137 };
            //potrzebne zmienne
            int i = 0;
            int x = 0;
            int a = 15;
            int b = 21;
            int c = 31;
            //jeden pod drugim
            do
            {
                Console.WriteLine(tablica1[i]);
                i++;
            } while (i < 6);
            //jeden obok drugiego
            i = 0;
            do
            {
                Console.Write(tablica1[i] + ", ");
                i++;
            } while (i < 6);
            Console.WriteLine("");
            //odwrotna kolejność
            i = 5;
            do
            {
                Console.Write(tablica1[i] + ", ");
                i--;
            } while (i >= 0);
            Console.WriteLine("");
            //porównywanie
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("{0} to największa liczba", a);
                else
                    Console.WriteLine("{0} to największa liczba", c);
            }
            else
            {
                if (b > c)
                    Console.WriteLine("{0} to największa liczba", b);
                else
                    Console.WriteLine("{0} to największa liczba", c);
            }
            //trójkąt
            Console.Write("Podaj pierwszy bok trójkąta: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugi bok trójkąta: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzeci bok trójkąta: ");
            c = int.Parse(Console.ReadLine());
            if ((a+b) > c && (a+c) > b && (b+c) > a)
                Console.WriteLine("Z takich boków powstanie trójkąt.");
            else
                Console.WriteLine("Z takich boków nie powstanie trójkąt.");
            //pętla while
            while (x < 5 || x > 15)
            {
                Console.Write("Podaj liczbę całkowitą nie mniejszą niż 5 oraz nie większą niż 15: ");
                x = int.Parse(Console.ReadLine());
            }
            while (x >= 0)
            {
                Console.WriteLine(x);
                x--;
            }
            //do while
            do
            {
                Console.Write("Podaj liczbę parzystą, niepodzielną przez 10: ");
                x = int.Parse(Console.ReadLine());
            } while (x%2 == 1 || x%10 == 0);
            Console.WriteLine("{0} to poprawna liczba :)",x);
            Console.ReadKey();
        }
    }
}
