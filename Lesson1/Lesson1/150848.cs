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

            int[] tabela = new int[] { 1, 3, 5, 7, 9, 6, 9 };

            for (int i = 0; i < tabela.Length; i++)
            {
                Console.Write(tabela[i] + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.WriteLine(tabela[i]);
            }
            Console.WriteLine();
            for (int i = tabela.Length - 1; i >= 0; i--)
            {
                Console.Write(tabela[i] + ", ");
            }
            Console.WriteLine();
            int a = 19;
            int b = 2;
            int c = 43;

            if (a >= b && a >= c)
                Console.WriteLine("Pierwsza liczba jest najwieksza");
            else if (b >= a && b >= c)
                Console.WriteLine("Druga liczba jest najwieksza");
            else
                Console.WriteLine("Trzecia liczba jest najwieksza");
            Console.WriteLine();
            Console.WriteLine("podaj 3 liczby");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Moze istniec taki trojkat");
            else if (a <= 0 || b <= 0 || c <= 0)
                Console.WriteLine("wymiary musza byc wieksze od zera");
            else
                Console.WriteLine("Taki trojkat nie moze istniec");
            Console.WriteLine();
            int x = 0;
            Console.WriteLine("podaj liczbe od 5 do 15");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 5 || x > 15)
                Console.WriteLine("liczba nie miesci sie w zakresie");
            else
                while (x >= 0)
                {
                    Console.Write(x + ", ");
                    x--;
                }
            Console.WriteLine();
            int y = 0;
            do
            {
                Console.WriteLine("Podaj liczbe parzysta wieksza od 7");
                y = Convert.ToInt32(Console.ReadLine());
            } while (!(y > 7 && y % 2 == 0));
            Console.WriteLine("Poprawna liczba");


            Console.ReadKey();
        }
    }
}
