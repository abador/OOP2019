using System;


namespace Lekcja2.Classes
{
    class Zespolone
    {
        int Re;
        int Im;

        public Zespolone(int Re, int Im)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public void Add(int Re, int Im)
        {
            this.Re += Re;
            this.Im += Im;
        }

        public void Subtrack(int Re, int Im)
        {
            this.Re -= Re;
            this.Im -= Im;
        }

        public void Wypisz()
        {
            Console.WriteLine($"{Re}.{Im}");
        }

        public int getRe()
        {
            return Re;
        }

        public int getIm()
        {
            return Im;
        }
    }
}
