using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            int[] tablica = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                Console.Write(tablica[i] + ",");
            }

            Console.WriteLine("");

            Console.WriteLine("Zadanie 2");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(tablica[i]);
            }

            Console.WriteLine("Zadanie 3");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(tablica[i-1]);
            }

            Console.WriteLine("Zadanie 4");
            int g = 10;
            int h = 20;
            int j = -50;

            if (g > h && g > j) Console.WriteLine("g= "+ g + "jest najwieksze");
            else if (h > g && h > j) Console.WriteLine("h= "+ h + "jest najwieksze");
            else if (j > h && j > g) Console.WriteLine("j= "+ j + "jest najwieksze");

            Console.WriteLine("Zadanie 5");
            {
                Console.WriteLine("podaj 1 wartosc");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("podaj 2 wartosc");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("podaj 3 wartosc");
                int c = int.Parse(Console.ReadLine());

                if (a<b+c && b<a+c && c<a+b) Console.WriteLine("tak");
                else Console.WriteLine("nie");
            }

            //Console.WriteLine("Zadanie 6");

            Console.ReadLine();
        }
    }
}
