using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float zmienna2;
            string zmienna = NewMethod();
            zmienna2 = float.Parse(zmienna);
            float zmienna3;
            zmienna = NewMethod2();
            zmienna3 = float.Parse(zmienna);
            float zmienna4 = zmienna2 * zmienna3 + zmienna2;
            Console.WriteLine("Wartośc brutto to");
            Console.Write(zmienna4);
            Console.ReadKey();
        }

        private static string NewMethod()
        {
            Console.WriteLine("Podaj wartość netto");
            return Console.ReadLine();
        }
        private static string NewMethod2()
        {
            Console.WriteLine("Podaj stawkę podatkową");
            return Console.ReadLine();
        }
    }
}
