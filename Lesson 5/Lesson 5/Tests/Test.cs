using System;


namespace Tests
{
    public class Test : ICloneable
    {
        public int numb;

        public Test2 poleTestowe;

        
        public Test()
        {
            poleTestowe = new Test2();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Test DeepCopy()
        {
            Test tempTest = new Test();
            tempTest.numb = this.numb;
            tempTest.poleTestowe.word = this.poleTestowe.word;

            return tempTest;
        }
    }
}
