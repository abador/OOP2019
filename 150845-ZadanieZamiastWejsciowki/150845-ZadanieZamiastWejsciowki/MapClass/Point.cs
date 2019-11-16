

namespace _150845_ZadanieZamiastWejsciowki.MapClass
{
    class Point
    {
        protected int x;
        protected int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Print()
        {
            System.Console.WriteLine($"Współrzedne:\n" +
                $"x: {x}\n" +
                $"y: {y}");
        }
    }
}
