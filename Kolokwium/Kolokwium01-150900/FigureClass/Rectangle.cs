using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.FigureClass
{
    class Rectangle
    {
        public Point a;
        public Point b;
        public Point c;
        public Point d;

        public string name_field = "Rectangle";

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString() => $"[{this.name_field}] A: ({this.a.x}, {this.a.y}), B ({this.b.x}, {this.b.y}), C: ({this.c.x}, {this.c.y}), D: ({this.d.x}, {this.d.y}).";

        public double CountCircumference() => (float)Math.Sqrt(Math.Pow(this.b.x - this.a.x, 2) + Math.Pow(this.b.y - this.a.y, 2)) + Math.Sqrt(Math.Pow(this.c.x - this.b.x, 2) + Math.Pow(this.c.y - this.b.y, 2)) + Math.Sqrt(Math.Pow(this.d.x - this.c.x, 2) + Math.Pow(this.d.y - this.c.y, 2)) + Math.Sqrt(Math.Pow(this.a.x - this.d.x, 2) + Math.Pow(this.a.y - this.d.y, 2));

        public void TakeDataFromInput()
        {
            var punkty = new List<Point>();

            for (var i = 1; i <= 4; i++)
            {
                Console.WriteLine($"point {i}");

                
                var punkt = new Point();

                punkt.TakeDataFromInput();

                punkty.Add(punkt);
            }
            
            this.a = punkty[0];
            this.b = punkty[1];
            this.c = punkty[2];
            this.d = punkty[3];
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Circumference: {this.CountCircumference()}.");
        }
    }
}
