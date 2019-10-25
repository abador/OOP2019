using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Szkola uczniowie = new Szkola();
            uczniowie.liczbaLawek = 20;
            uczniowie.liczbaUczniow = 10;
            
            uczniowie.SprawdzLawki();
            Console.WriteLine(uczniowie.komunikat);
            Console.WriteLine(uczniowie.liczbaLawek);
            Console.ReadKey();
        }
    }
}
