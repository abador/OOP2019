using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.EmployerClass
{
    class Bookkeeper : Employer
    {
        public override void Work() => Console.WriteLine($"Bookkeeper is working at this moment.");
        public override void PrintInfo() => Console.WriteLine($"Name: {this.firstName}, Secondname: {this.secondName}");


    }
}
