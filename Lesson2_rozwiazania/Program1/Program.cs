using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Console.WriteLine(carName);
            Car car1 = new Car("Opel", 2014, 6.5, 4, 100);
            Car car2 = new Car("VW", 2011, 2.5, 5.21, 100);
            
            Console.WriteLine(car1.Marka +" " + car1.Rok);
            Console.WriteLine(car2.Marka + " " + car2.Rok);
            //car1 = car2;
            //Console.WriteLine(car1.Marka + " " + car1.Rok);
            car1.PokazKosztPrzejazdu();
            car1.PokazSpalanie();
            
        }
    }
}
