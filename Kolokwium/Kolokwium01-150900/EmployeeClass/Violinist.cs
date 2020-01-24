using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.EmployerClass
{
    class Violinist : Employer
    {
        public virtual void Work() => Console.WriteLine($"Violnist is working at this moment.");
        public override void PrintInfo() => Console.WriteLine($"Name: {this.firstName}, Secondname: {this.secondName}");


    }
}
