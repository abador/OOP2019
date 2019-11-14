using System;

namespace Map
{
    class MapElement : Point
    {
        public char icon { get; set; }

        public MapElement(int x, int y, char icon) : base(x, y)
        {
            this.icon = icon;
        }
    }
}
