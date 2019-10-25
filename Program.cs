using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Czworokat
    {
        public double pierwszyBok;
        public double drugiBok;
        public double trzeciBok;
        public double czwartyBok;

        public string CzyRomb()
        {
            if (this.pierwszyBok == this.drugiBok && this.drugiBok == this.trzeciBok && this.trzeciBok == this.czwartyBok && this.pierwszyBok > 0 && this.drugiBok > 0 && this.trzeciBok > 0 && this.czwartyBok > 0)
                return "OK";
            else
                return "NIE";
        }
    }
}
