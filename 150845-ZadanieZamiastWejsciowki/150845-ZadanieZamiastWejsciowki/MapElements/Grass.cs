using _150845_ZadanieZamiastWejsciowki.MapClass;

namespace _150845_ZadanieZamiastWejsciowki.MapElements
{
    class Grass : MapElement
    {
        public Grass(int x, int y) : base(x, y, 'G')
        {
            
        }

        public override void Print() => System.Console.WriteLine($"Grass - {this.icon}\n" +
            $" x = {x}, y = {y}");
    }
}
