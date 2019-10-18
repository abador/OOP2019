using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Console.WriteLine("Nazwa samochodu: {0}", carName);

            Car car1 = new Car("Renault", 1995);
            Car car2 = new Car("Mitsubishi", 1990);

            //car1 = car2;

            Console.WriteLine("{0}, {1}", car1.pobierzMarke(), car1.pobierzRok());
            Console.WriteLine("{0}, {1}", car2.pobierzMarke(), car2.pobierzRok());



            Console.ReadKey();

        }
    }
}
