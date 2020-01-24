using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolokwium01_150900.Exception;
using Kolokwium01_150900.Interfaces;

namespace Kolokwium01_150900.FigureClass
{
    class Triangle : ICloneable, IFigure
    {
        public Point a;
        public Point b; 
        public Point c;

        public string name_field = "Triangle";

        public Triangle()
        {

        }

        public Triangle(Point a, Point b, Point c)
        {
            double ab = Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2)),
                ac = Math.Sqrt(Math.Pow(c.x - a.x, 2) + Math.Pow(c.y - a.y, 2)),
                bc = Math.Sqrt(Math.Pow(c.x - b.x, 2) + Math.Pow(c.y - b.y, 2));

            if (!(ab + bc > ac) || !(ab + ac > bc) || !(bc + ac > ab)) return;
            this.a = a;
            this.b = b;
            this.c = c;

            throw new CantCreateATriangle();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString() =>
            $"Name {this.name_field} : A: {this.a.x}, {this.a.y}, B: {this.b.x} {this.b.y}, C: {this.c.x} {this.c.y}";

        public double CountCircumference()
        {
            return (float)Math.Sqrt(Math.Pow(this.b.x - this.a.x, 2) + Math.Pow(this.b.y - this.a.y, 2)) + Math.Sqrt(Math.Pow(this.c.x - this.b.x, 2) + Math.Pow(this.c.y - this.b.y, 2)) + Math.Sqrt(Math.Pow(this.c.x - this.a.x, 2) + Math.Pow(this.c.y - this.a.y, 2));
        }
        public void TakeDataFromInput()
        {
            var points = new List<Point>();

            for (var i = 1; i <= 3; i++)
            {
                Console.WriteLine($"point {i}");

                var point = new Point();

                point.TakeDataFromInput();

                points.Add(point);
            }
            
            double ab = Math.Sqrt(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2)), bc = Math.Sqrt(Math.Pow(points[2].x - points[1].x, 2) + Math.Pow(points[2].y - points[1].y, 2)), ac = Math.Sqrt(Math.Pow(points[2].x - points[0].x, 2) + Math.Pow(points[2].y - points[1].y, 2));

            if (ab + bc <= ac || ab + ac <= bc || bc + ac <= ab) throw new CantCreateATriangle();

            this.a = points[0];
            this.b = points[1];
            this.c = points[2];
        }

        public void Print()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Circumference: {this.CountCircumference()}.");
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Circumference: {this.CountCircumference()}");
        }


    }
}
