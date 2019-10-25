using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Blok
    {

        public int iloscpieter;
        public bool senior;

        public void CzyWinda()
        {
            if(senior==true)
            {
                Console.WriteLine("winda jest potrzebna");
            }
            else if(iloscpieter>5)
            {

                Console.WriteLine("winda jest potrzebna");
            }

            else
                Console.WriteLine("winda nie jest potrzebna");
        }
    }
    class Program
    {
        public static Blok nr1 { get; private set; }
        public static Blok nr2 { get; private set; }

        static void Main(string[] args)
        {
            nr1 = new Blok();

            nr1.iloscpieter = 7;
            nr1.senior = false;
            nr2 = new Blok();
            nr2.iloscpieter = 3;
            nr2.senior = false;

            nr1.CzyWinda();
            nr2.CzyWinda();
            Console.ReadLine();

        }
    }
}
