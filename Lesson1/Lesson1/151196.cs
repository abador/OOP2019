using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1,2,3,4,5,6,7,8,9,10 };
            {
                Console.WriteLine(string.Join(",", tablica));
            }
            for(int i= 0; i<tablica.GetLength(0); i++)
            {
                Console.WriteLine(tablica[i]);
            }

            Array.Reverse(tablica);
            Console.WriteLine(string.Join(",", tablica));
        



            int liczba1 = 1, liczba2 = 1, liczba3 = 2, liczba4 = 3;
            if(liczba1 == liczba2)            
                Console.WriteLine("Sa takie same");
            else
                Console.WriteLine("Sa inne");


            if (liczba3 == liczba4)
                Console.WriteLine("Sa takie same");
            else
                Console.WriteLine("Sa inne");




            Console.WriteLine("Podaj 3 liczby: ");
            int l1, l2, l3;
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());
            if((l1+l2) > l3)
                Console.WriteLine("Istnieje trojkat");
            else
                Console.WriteLine("Nie istnieje");


            Console.WriteLine("Podaj liczbe ");
            int cyfra, wynik = 0;
            cyfra = int.Parse(Console.ReadLine());
            if(cyfra < 15 && cyfra >5)
                while (cyfra != 0)
            {
                    cyfra-=1;
                    wynik += cyfra;
            }





            Console.WriteLine("Podaj liczbe ");
            int liczba;
            liczba = int.Parse(Console.ReadLine());
            if ((liczba > 4 && liczba < 7) && (liczba != 10))
                Console.WriteLine("Koniec");
            else
                while ((liczba < 4 && liczba > 7) && (liczba == 10))
                {
                    Console.WriteLine("Podaj liczbe ponownie");
                }
        }
    }
}







/* Console.ReadLine();
bool stop = false;
while (stop!= true)
 {
    Console.WriteLine(Nie podałeś imienia);
    stop = true;
 }
*/
