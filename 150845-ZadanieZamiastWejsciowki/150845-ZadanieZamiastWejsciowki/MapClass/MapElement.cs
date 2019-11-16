
namespace _150845_ZadanieZamiastWejsciowki.MapClass

{
    class MapElement : Point
    {
        protected char icon;

        public char Icon 
        { 
            get
            {
                return this.icon;
            }
        }

        public MapElement(int x, int y, char icon) : base(x, y)
        {
            this.icon = icon;
        }
    }
}
