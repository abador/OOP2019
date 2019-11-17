using System;


namespace Zwierzaki
{
    public class Krokodyl : Zwierze
    {
        public Krokodyl(string imie, int waga)
            : base(imie, waga)
        {

        }
        
        public override void CoJem() => Console.WriteLine("Jem mieso");
        public override void JakSiePoruszam() => Console.WriteLine("Poruszam sie na 4 lapach");
        
    }
}
