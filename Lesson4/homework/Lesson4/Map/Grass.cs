using System;

namespace Map
{
    class Grass : MapElement
    {
        public Grass(int x, int y) : base(x, y, 'G')
        {

        }

        public override void print()
        {
            Console.WriteLine($"[Grass] X: {this.x} Y: {this.y}");
        }
    }
}
