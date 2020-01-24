using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.EmployerClass
{
    class Employer
    {
        public string firstName;
        public string secondName;
        public decimal wages;

        public virtual void PrintInfo() => Console.WriteLine($"Name: {this.firstName}, Secondname: {this.secondName}");
        public virtual void Work() => Console.WriteLine($"Employee is working at this moment.");



    }
}
