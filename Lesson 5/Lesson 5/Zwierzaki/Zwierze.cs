using Interfaces;
using System;

namespace Zwierzaki
{
    public abstract class Zwierze : IZwierzaki, ICloneable
    {
        public string imie;

        public int waga;

        protected Zwierze(string imie, int waga)
        {
            this.imie = imie;
            this.waga = waga;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public virtual void CoJem()
        {
            throw new NotImplementedException();
        }

        public virtual void JakSiePoruszam()
        {
            throw new NotImplementedException();
        }
    }
}

