using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.EmployerClass
{
    class Salesman : Employer
    {
        public override void Work() => Console.WriteLine($"Salesman is working at this moment.");
        public override void PrintInfo() => Console.WriteLine($"Name: {this.firstName}, Secondname: {this.secondName}");



    }
}
