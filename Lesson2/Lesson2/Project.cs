using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Console.WriteLine(carName);
            Car car1 = new Car("Subaru", 2000, 7.3);
            Car car2 = new Car("Kia", 2014, 5.6);
            car1.Pokaz();
            car2.Pokaz();
            //Przepisanie car2 do car1
            car2.Jedz(100);
            Console.WriteLine();
            car1 = car2;
            car1.Pokaz();
            car2.Jedz(100);
            car2.Pokaz();
            //Console.WriteLine("{0}"car2.ObliczSpalanie(100));
            Console.ReadKey();
        }
    }
}
