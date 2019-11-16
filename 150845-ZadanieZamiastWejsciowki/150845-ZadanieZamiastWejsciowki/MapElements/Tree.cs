using _150845_ZadanieZamiastWejsciowki.MapClass;

namespace _150845_ZadanieZamiastWejsciowki.MapElements
{
    class Tree : MapElement
    {
        public Tree(int x, int y) : base(x, y, 'T')
        {

        }

        public override void Print() => System.Console.WriteLine($"Tree - {this.icon}\n" +
            $" x = {x}, y = {y}");
    }
}
