using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _151024D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj temperature w celsjuszach");
            double celsjusz;
            celsjusz=(Convert.ToDouble(Console.ReadLine()));
            double konwersja=0;
          

            konwersja = (celsjusz * 1.8) + 32;
            Console.Write("temperatura przed konwersja:");
            Console.WriteLine(celsjusz);
            Console.Write("temperatura po konwersji:");
            Console.WriteLine(konwersja);
            Console.ReadLine();




        }
    }
}
