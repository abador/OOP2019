using System;

namespace Map
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void print()
        {
            Console.WriteLine($"X: {this.x} Y: {this.y}");
        }
    }
}
