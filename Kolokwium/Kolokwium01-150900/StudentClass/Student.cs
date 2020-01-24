using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolokwium01_150900.Interfaces;

namespace Kolokwium01_150900.StudentClass
{
    class Student : IPerson
    {

        public string name;
        public string secondName;

        public Student(string name, string secondName)
        {
            this.name = name;
            this.secondName = secondName;
        }
        
        public void Describe()
        {
            throw new NotImplementedException();
        }
    }
}
