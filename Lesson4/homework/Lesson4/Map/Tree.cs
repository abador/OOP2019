using System;

namespace Map
{
    class Tree : MapElement
    {
        public Tree(int x, int y) : base(x, y, 'T')
        {

        }

        public override void print()
        {
            Console.WriteLine($"[Tree] X: {this.x} Y: {this.y}");
        }
    }
}
