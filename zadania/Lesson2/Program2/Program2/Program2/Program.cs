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
