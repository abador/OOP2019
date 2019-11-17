using System;


namespace Zwierzaki
{
    public class Orzel : Zwierze
    {
        public Orzel(string imie, int waga)
            : base(imie, waga)
        {

        }

        public override void CoJem() => Console.WriteLine("Jem mieso");
        public override void JakSiePoruszam() => Console.WriteLine("Latam");
    }
}
