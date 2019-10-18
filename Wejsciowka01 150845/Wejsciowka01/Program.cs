using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka01
{
    class Program
    {
        static void Main(string[] args)
        {
            int masa = 85;
            double wzrost = 1.9;

            Console.WriteLine($"Masa = {masa}\nWzrost = {wzrost}\nBMI  = {bmi(masa, wzrost)}");

            Console.ReadLine();
        }

        static double bmi(int masa, double wzrost)
        {
            double bmi = masa / (wzrost * wzrost);

            return bmi;
        }
    }
}
