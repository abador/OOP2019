using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();
            car1.Ride();
            bicycle1.Ride();
            
            Osoba osoba1 = new Osoba();
            IGitarzysta osoba2 = new Osoba();
            ISkrzypek osoba3 = new Osoba();
            osoba1.Graj();
            osoba2.Graj();
            osoba3.Graj();
            Console.ReadKey();
        }
    }
}
