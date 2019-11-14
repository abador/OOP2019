using System;
using Map;

namespace Lesson4
{
    class User : Point
    {
        public string name { get; set; }
        public int level { get; set; }

        public User(string name, int level, int x, int y) : base(x, y)
        {
            this.name = name;
            this.level = level;
        }

        public override void print()
        {
            Console.WriteLine($"[{this.name}, level {this.level}] X: {this.x} Y: {this.y}");
        }
    }
}
