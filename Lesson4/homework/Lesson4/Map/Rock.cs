using System;

namespace Map
{
    class Rock : MapElement
    {
        public Rock(int x, int y) : base(x, y, 'R')
        {

        }

        public override void print()
        {
            Console.WriteLine($"[Rock] X: {this.x} Y: {this.y}");
        }
    }
}
