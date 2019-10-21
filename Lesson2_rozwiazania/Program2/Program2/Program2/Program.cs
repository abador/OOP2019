using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena = 0;
            int n;
            Program aaa = new Program();
            Console.WriteLine(aaa.opiszTyp(1.25));
            Console.WriteLine(aaa.opiszTyp(2));
            
            Osoba dyrektor = new Osoba("Alina", "Kowalska", 95, 173, true, 21, plec.K);
            Console.WriteLine(dyrektor.imie);
            //zad 13
            Console.WriteLine(dyrektor.obliczWiek());
            //W pliku Osoba.cs zmień dostępy do pól na private, internal, protected - co się zmieni?
            // przy private program sie nie skompiluje
            // przy internal program dziala
            // przy protected program również się nie kompiluje
            Osoba pacjent = new Osoba("Jan", "Kowalski", 75, 192);
            Console.WriteLine(pacjent.imie);
            Console.WriteLine(pacjent.BMI());
            
            Produkt produkt1 = new Produkt("Mleko", 2.5);
            Produkt produkt2 = new Produkt("Kawa", 4);
            Produkt produkt3 = new Produkt("Piwo", 3);
            Produkt produkt4 = new Produkt("Ziemniaki", 3);
            Console.WriteLine();
            //List<Produkt> koszyk = new List<Produkt>();
           Console.WriteLine("Wybierz produkt");
            List<string> lista_towarow = new List<string>();
            
            Console.WriteLine("1 = " + produkt1.Poka());
            Console.WriteLine("2 = " + produkt2.Poka());
            Console.WriteLine("3 = " + produkt3.Poka());
            Console.WriteLine("4 = " + produkt4.Poka());
            Console.WriteLine("0 = Wyjście");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {

                if (n == 1)
                {
                  lista_towarow.Add(produkt1.Nazwa);
                    cena = cena + produkt1.Cena;
                    Console.WriteLine("Wybierz produkt");
                    n = int.Parse(Console.ReadLine());
                    
                }
                if(n == 2)
                {
                    lista_towarow.Add(produkt2.Nazwa);
                    cena = cena + produkt2.Cena;
                    Console.WriteLine("Wybierz produkt");
                    n = int.Parse(Console.ReadLine());
                }
                if (n == 3)
                {
                    lista_towarow.Add(produkt3.Nazwa);
                    cena += produkt3.Cena;
                    Console.WriteLine("Wybierz produkt");
                    n = int.Parse(Console.ReadLine());
                }
                if (n == 4)
                {
                    lista_towarow.Add(produkt4.Nazwa);
                    cena = cena + produkt4.Cena;
                    Console.WriteLine("Wybierz produkt");
                    n = int.Parse(Console.ReadLine());
                }
                if(n == 5)
                {
                    
                    Console.WriteLine("Koszt zakupow wynosi " +cena + " PLN");
                    Console.ReadKey();
                    n = 0;
               }
            } 





            Console.ReadKey();
            

        }

        public String opiszTyp(double a)
        {
            return "typ 1";
        }
        public String opiszTyp(int a)
        {
            return "typ 2";
        }
    }
}
