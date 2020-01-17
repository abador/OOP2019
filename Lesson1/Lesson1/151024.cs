using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danielzamojski
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userName;
            //Console.WriteLine("podaj imie");
            //userName = Console.ReadLine();
            //userName = "hello " + userName;
            //Console.WriteLine(userName);
            //Console.ReadLine();
            ////string bob = "Hello Bob";
            ////string eva = "hello eva";
            ////Console.WriteLine(bob);
            ////Console.WriteLine(eva);
            //Console.ReadLine();
            //bool czymaly;
            //double wzrost;
            //Console.WriteLine("podaj wzrost");
            //wzrost = double.Parse(Console.ReadLine());
            //czymaly = (wzrost < 175);
            //Console.WriteLine(czymaly);
            //Console.ReadLine();
            //int x;
            //int[] tab = { 2, 4, 5, 6, 7, 8, 1, 2, 3, 4, 6, 2, 3, 1, 2, 6, 2, 3, 1, 2};
            //for(x=0;x<20;x++)
            //{
            //Console.WriteLine(tab[x]);
            // Console.Write(tab[x]);
            // Console.Write(",");
            //}
            //for (x=19;x>-1;x--)
            //{

            //    Console.Write(tab[x]);

            //}

            //int y=9;
            //int z=12;
            //int j=4;

            //if (y > z &&  y>j)
            //{
            //    Console.Write(y);
            //    Console.Write("jest najwiekszy");
            //    if(z>j)
            //    {
            //        Console.Write(z);
            //        Console.Write("jest srednie a najmniejsze jest");
            //        Console.Write(j);
            //    }
            //    else if(j>z)
            //    {
            //        Console.Write(j);
            //        Console.Write("jest srednie a najmniejsze jest");
            //        Console.Write(z);
            //    }
            //}
            //else if (z > y && z > j)
            //{
            //    Console.Write(z);
            //    Console.Write("jest najwiekszy");
            //    if (y > j)
            //    {
            //        Console.Write(y);
            //        Console.Write("jest srednie a najmniejsze jest");
            //        Console.Write(j);
            //    }
            //    else if (j > y)
            //    {
            //        Console.Write(j);
            //        Console.Write("jest srednie a najmniejsze jest");
            //        Console.Write(y);
            //    }
            //}
            //else if (j > z && j > y)
            //{
            //    Console.Write(j);
            //    Console.Write("jest najwiekszy");
            //    if (j > y)
            //    {
            //        Console.Write(j);
            //        Console.Write("jest srednie a najmniejsze jest");
            //        Console.Write(y);
            //    }
            //    else if (y > j)
            //    {
            //        Console.Write(y);
            //        Console.Write("jest srednie a najmniejsze jest");
            //        Console.Write(j);
            //    }
            //}




            //int p = int.Parse(Console.ReadLine());
            //int l = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if(p<=0 || l<=0 || c<=0)
            //{
            //    Console.WriteLine("podano zle liczby");
            //}
            //if(p+l>c && p+c>l && l+c>p)
            //{
            //    Console.WriteLine("taki trojkat istnieje");
            //}
            //else
            //{
            //    Console.WriteLine("taki trojkat nie istnieje");
            //}


            //int q = int.Parse(Console.ReadLine());

           
            //int q = int.Parse(Console.ReadLine());

            //if (q > 5 && q<15)
            //{
            //    while (q != 0)
            //    {
            //        q--;
            //        Console.WriteLine(q);
            //    }
                
            //}
            //else
            //{
            //    Console.WriteLine("podano zla liczbe");
            //}
            int g;
            do
            {
                g = int.Parse(Console.ReadLine());

                if (g <= 6)
                {
                    Console.WriteLine("podano dobra liczbe");
                    break;
                }
                if (g > 6)
                {
                    Console.WriteLine("podano zla liczbe, podaj kolejna");

                }
            } while (g > 6);
            //int pierwszaLiczba = 10, drugaLiczba = 20, i=9, j=2, k=3;
            //Console.WriteLine("pierwszaLiczba: " + pierwszaLiczba);
            //Console.WriteLine("drugaLiczba: " + drugaLiczba);
            //Console.WriteLine("zmienna i: " + i);
            //Console.WriteLine("zmienna j: " + j);
            //Console.WriteLine("zmienna k: " + k);
            //Console.ReadKey();

            //int x1 = 5;
            //int x2 = 9;
            //int x3 = 13;

            //Console.WriteLine(x1/x2);
            //Console.WriteLine(x1 / x2);
            //Console.WriteLine(x1 / x3);
            //Console.WriteLine(x2 / x1);
            //Console.WriteLine(x2 / x3);
            //Console.WriteLine(x3 / x1);
            //Console.WriteLine(x3 / x2);







            Console.ReadLine();
        }
    }
}
