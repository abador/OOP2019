using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.FigureClass
{
    class Point
    {
        public float x;
        public float y;

        public string name_field = $"Point";

        public override string ToString() => $"[{this.name_field}] {this.x}, {this.y}.";
 
        public double CountCircumference() => 0.0;

        public void PrintInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Circumference: {this.CountCircumference()}.");
        }
        public void TakeDataFromInput()
        {
            string input;

            do
            {
                Console.Write("X: ");

                input = Console.ReadLine();
            }
            while (!float.TryParse(input, out this.x));

            do
            {

                Console.Write("Y: ");

                input = Console.ReadLine();
            }
            while (!float.TryParse(input, out this.y));

        }

    }
}
