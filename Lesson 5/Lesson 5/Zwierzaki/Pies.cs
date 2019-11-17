using System;


namespace Zwierzaki
{
    public class Pies : Zwierze
    {
        public Pies(string imie, int waga)
            : base(imie, waga)
        {

        }

        public override void CoJem() => Console.WriteLine("Jem wszystko");
        public override void JakSiePoruszam() => Console.WriteLine("Poruszam sie na 4 lapach");
    }
}
