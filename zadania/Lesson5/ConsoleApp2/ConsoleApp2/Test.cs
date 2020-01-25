using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Test : ICloneable
    {
        public Test GlebokaKopia()
        {
            Test tempTest = new Test();
            tempTest.liczba = this.liczba;
            tempTest.poleTestowe.słowo = this.poleTestowe.słowo;
            return tempTest;
        }
        public Test2 poleTestowe;
        public Test()
        {
            Test2 obiekt1 = new Test2();
        }
        public int liczba;
        public Object Clone()
        {
            return MemberwiseClone();
        } 
    }
}
