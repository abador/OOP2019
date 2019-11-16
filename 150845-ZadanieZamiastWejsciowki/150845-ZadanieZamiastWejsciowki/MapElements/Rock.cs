using _150845_ZadanieZamiastWejsciowki.MapClass;

namespace _150845_ZadanieZamiastWejsciowki.MapElements
{
    class Rock : MapElement
    {
        
        public Rock(int x, int y) : base(x, y, 'R')
        {

        }

        public override void Print() => System.Console.WriteLine($"Rock - {this.icon}\n" +
            $" x = {x}, y = {y}");
    }
}
