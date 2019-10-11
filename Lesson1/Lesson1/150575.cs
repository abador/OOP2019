using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] tab1 = { 1, 2, 3, 4 };
            for (int i = 0; i < tab1.Length; i++)
                Console.Write(tab1[i]+" ");
            Console.Write("\n");
            for (int i = 0; i < tab1.Length; i++)
                Console.WriteLine(tab1[i]);
            Console.Write("\n");
            for (int i = tab1.Length-1; i >= 0; i--)
                Console.Write(tab1[i]);
            Console.Write("\n");
            #endregion
            int liczba1,liczba2,liczba3;
            Console.Write("podaj bok a \n");
            liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj bok b \n");
            liczba2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj bok c \n");
            liczba3 = Convert.ToInt32(Console.ReadLine());
            if (liczba1 + liczba2 > liczba3 && liczba1 + liczba3 > liczba2 && liczba3 + liczba2 > liczba1)
                Console.Write("trojkat istnieje\n");
            else
                Console.Write("trojkat nie istnieje\n");
            int liczba4;
            Console.Write("podaj liczbe\n");
            liczba4 = Convert.ToInt32(Console.ReadLine());
            if (liczba4 > 4 && liczba4 < 16)
            {
                while (liczba4 >= 0)
                {
                    Console.WriteLine(liczba4);
                    liczba4--;

                }
            }


            int liczba5;
            do
            {

                Console.Write("podaj liczbe\n");
                liczba5 = Convert.ToInt32(Console.ReadLine());
                if(liczba5 > 10 && liczba5 < 30 && liczba5 != 15)
                    Console.Write("liczba jest prawidlowa");
                else
                    Console.Write("liczba jest nieprawidlowa");




            } while (liczba5 < 10 && liczba5 > 30 && liczba5 != 15);


            Console.ReadKey();

        }
    }
}
