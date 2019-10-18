using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Car car1 = new Car();
            Car car2 = new Car();
            car2.marka = "Honda";
            car2.rokprodukcji = 1999;
            Console.WriteLine("car2 marka = {0}, rok = {1}", car2.marka, car2.rokprodukcji);
            car1 = car2;
            Console.WriteLine("car1 marka = {0}, rok = {1}", car1.marka, car1.rokprodukcji);
            Console.ReadKey();
        }
    }
}
