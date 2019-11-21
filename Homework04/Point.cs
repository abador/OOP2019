using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void showCoor()
        {
            Console.WriteLine("Współrzędne x i y to: " + "(" + this.x + ","+this.y+")");
        }
    }
}
