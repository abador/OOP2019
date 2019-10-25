using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            if(numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                    Console.Write($"{numbers[i]}, ");

                Console.WriteLine(numbers[numbers.Length - 1]);
            }

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            for (int i = numbers.Length - 1; i >= 0; i--)
                Console.WriteLine(numbers[i]);

            Console.ReadKey();
            Console.Clear();

            int a = 1, b = 2;

            Console.WriteLine($"a = {a}\nb = {b}");

            if (a > b)
                Console.WriteLine($"a > b -> {a} > {b}");
            else if (a < b)
                Console.WriteLine($"a < b -> {a} < {b}");
            else
                Console.WriteLine($"a = b -> {a} = {b}");

            Console.ReadKey();
            Console.Clear();

            numbers = new int[3];

            int j = 0;

            while(j < numbers.Length)
            {
                Console.WriteLine($"{j + 1} liczba: ");

                string input = Console.ReadLine();

                if (Int32.TryParse(input, out numbers[j]))
                    j++;

                Console.Clear();
            }

            if ((numbers[0] + numbers[1] > numbers[2]) && (numbers[0] + numbers[2] > numbers[1]) && (numbers[1] + numbers[2] > numbers[0]))
                Console.Write("Można.");
            else
                Console.Write("Nie można.");

            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.Write("Podaj liczbę a = ");

                string input = Console.ReadLine();
                Int32.TryParse(input, out a);

                Console.Clear();
            } while (a < 5 || a > 15);

            while (a >= 0)
            {
                Console.WriteLine(a);
                a--;
            }

            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.Write("Podaj liczbę z przedziału (4, 7)\na = ");

                string input = Console.ReadLine();
                Int32.TryParse(input, out a);

                Console.Clear();
            } while (a <= 4 || a >= 7);

            Console.WriteLine($"a = {a}");

            Console.ReadKey();
        }
    }
}
