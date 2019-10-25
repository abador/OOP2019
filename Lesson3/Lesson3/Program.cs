using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2

            Szkola sz = new Szkola();

            sz.liczbaUczniow = 100;
            sz.liczbaLawek = 50;

            sz.SprawdzLawki();

            Console.ReadKey();
        }
    }
}
