using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4

            string input;

            double price, percent;

            do
            {
                Console.WriteLine("Podaj kwotę netto: ");

                input = Console.ReadLine();

            } while (!Double.TryParse(input, out price));

            do
            {
                Console.WriteLine("Podaj stawkę podatkową: ");

                input = Console.ReadLine();
            } while (!Double.TryParse(input, out percent));

            double result = (100 + percent) * price / 100;

            Console.WriteLine(result + " brutto");
            Console.ReadKey();
        }
    }
}
