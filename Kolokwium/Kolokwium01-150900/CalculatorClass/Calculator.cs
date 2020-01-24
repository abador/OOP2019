using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.CalculatorClass
{
    class Calculator
    {
        internal int Addition(int a, int b) => a + b;
        internal int AddititionTriple(int a, int b, int c) => a + b + c;
        internal int Substraction(int a, int b) => a - b;
        internal int Multiply(int a, int b) => a * b;

        internal int Division(int a, int b)
        {
            if (b == 0) throw new System.Exception("Do not divide by a zero! ");
            return a / b;
        }


    }
}
