using System;


namespace Zwierzaki
{
    public class Wilk : Zwierze
    {
        public Wilk(string imie, int waga)
            : base(imie, waga)
        {

        }

        public override void CoJem() => Console.WriteLine("Jem glownie mieso, ale z braku laku...");
        public override void JakSiePoruszam() => Console.WriteLine("Poruszam sie na 4 lapach");
    }
}
