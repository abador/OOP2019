using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Obliczenia
    {
        private int a, b;

        public int Dodawanie() => this.a + this.b;
        public int Odejmowanie() => this.a - this.b;
        public int Mnozenie() => this.a * this.b;
        public int Dzielenie() => this.b != 0 ? this.a / this.b : throw new DivideByZeroException();


        public Obliczenia(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
