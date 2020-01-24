using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.CalculatorClass
{
    class WeirdoCalc : Calculator
    {
        public int AddingModulo(int a, int b)
        {
            var resultOne = 26 % a;
            var resulttwo = 26 % b;
            return Addition(resultOne, resulttwo);
        }

        public void rootExtraction(int a, int b)
        {
            var resultOne = Math.Sqrt(a);
            var resultTwo = Math.Sqrt(b);
            Console.WriteLine($"Sqrt of first value: {resultOne}, Sqrt of second value: {resultTwo}");
        }

        public int TrippleAddition(int a, int b, int c)
        {
            var resultOne = a;
            var resultTwo = b;
            var resultThird = c;
            return AddititionTriple(a, b, c);
        }

    }
}
