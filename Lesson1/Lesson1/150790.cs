using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region zadanie1
            int[] tablica = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < tablica.Length; i++)
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
            #endregion
            #region zadanie2
            Console.Write("Podaj a,b,c (trojkat): ");
            var inputTrojkat = Console.ReadLine();
            for (int i = 0; i < inputTrojkat.Split(',').Length; i++)
            {
                if (Convert.ToDouble(inputTrojkat.Split(',')[i]) <= 0)
                {
                    Console.WriteLine("Jeden z podanych bokow jest <= 0!");
                    Console.ReadKey();
                    return;
                }
            }
            double a = Convert.ToDouble(inputTrojkat.Split(',')[0]);
            double b = Convert.ToDouble(inputTrojkat.Split(',')[1]);
            double c = Convert.ToDouble(inputTrojkat.Split(',')[2]);
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Trojkat o podanych bokach moze istniec");
            }
            else
            {
                Console.WriteLine("Trojkat o podanych bokach nie moze istniec");
            }
            #endregion
            #region zadanie3
            Console.Write("Podaj liczbe z przedzialu 5-15: ");
            var inputPrzedzial = Console.ReadLine();
            int n;
            if (int.TryParse(inputPrzedzial, out n) && n > 4 && n <= 15)
            {
                while (n > 0)
                {
                    Console.WriteLine(n);
                    n--;
                }
            }
            else
            {
                Console.WriteLine("Wprowadzona dana nie jest w przedziale lub nie jest liczba!");
            }
            #endregion
            #region zadanie4
            int inputDoWhile;
            do
            {
                Console.Write("Podaj liczbe: ");
                inputDoWhile = Convert.ToInt32(Console.ReadLine());
            } while (inputDoWhile > 4 && inputDoWhile < 15);
            Console.WriteLine("POPRAWNA LICZBA");
            Console.ReadKey();
            #endregion
}
}
}
