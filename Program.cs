using System;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość x");
            int x_length = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość y");
            int y_length = int.Parse(Console.ReadLine() + Environment.NewLine);

            char[] symbols = { 'G', 'T', 'R' };
            Random random = new Random();
            char[,] array = new char[x_length, y_length];
            for (int i = 0; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    array[i, j] = symbols[random.Next(0, symbols.Count())];
                    Console.Write(string.Format("{0}", array[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);

            for (int i = 0; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    Console.WriteLine(("[" + i, j + "] = " + array[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadKey();
        }
    }

