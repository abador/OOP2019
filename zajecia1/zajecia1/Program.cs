using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia1
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1();
            //zad2();
            //zad3();
            zad4();
        }
        static void zad1()
        {
            int[] tablica = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i <= tablica.Length - 1; i++)
            {
                if (i + 1 < tablica.Length)
                    Console.Write(tablica[i] + ",");
                else
                    Console.Write(tablica[i] + "\n");
            }
            for (int i = 0; i <= tablica.Length - 1; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }

            Console.ReadKey();
        }
        static void zad2()
        {
            Console.Write("Podaj a,b,c: ");
            var input = Console.ReadLine();
            for(int i = 0; i < input.Split(',').Length; i++)
            {
                if (Convert.ToDouble(input.Split(',')[i]) <= 0)
                {
                    Console.WriteLine("Jeden z podanych bokow jest <= 0!");
                    Console.ReadKey();
                    return;
                }
            }
            double a = Convert.ToDouble(input.Split(',')[0]);
            double b = Convert.ToDouble(input.Split(',')[1]);
            double c = Convert.ToDouble(input.Split(',')[2]);
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Trojkat o podanych bokach moze istniec");
            }
            else
            {
                Console.WriteLine("Trojkat o podanych bokach nie moze istniec");
            }
            Console.ReadKey();
        }
        static void zad3()
        {
            Console.Write("Podaj liczbe z przedzialu 5-15: ");
            var input = Console.ReadLine();
            int n;
            if(int.TryParse(input, out n) && n > 4 && n <= 15)
            {
                while(n > 0)
                {
                    Console.WriteLine(n);
                    n--;
                }
            }
            else
            {
                Console.WriteLine("Wprowadzona dana nie jest w przedziale lub nie jest liczba!");
            }
            Console.ReadKey();
        }
        static void zad4()
        {
            int input;
            do
            {
                Console.Write("Podaj liczbe: ");
                input = Convert.ToInt32(Console.ReadLine());
            } while (input > 4 && input <= 15);
            Console.WriteLine("OK");
            Console.ReadKey();

        }
    }
}
