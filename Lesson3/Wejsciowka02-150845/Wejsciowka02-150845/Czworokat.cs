using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka02_150845
{
    class Czworokat
    {
        int pierwszyBok;
        int drugiBok;
        int trzeciBok;
        int czwartBok;

        public Czworokat(int pierwszyBok, int drugiBok, int trzeciBok, int czwartyBok)
        {
            this.pierwszyBok = pierwszyBok;
            this.drugiBok = drugiBok;
            this.trzeciBok = trzeciBok;
            this.czwartBok = czwartyBok;
        }
        public void CzyRomb()
        {
            if (pierwszyBok <= 0 || drugiBok <= 0 || trzeciBok <= 0 || czwartBok <= 0)
                Console.WriteLine("Nie jest rombem");
            else if (pierwszyBok != drugiBok || pierwszyBok != trzeciBok || pierwszyBok != czwartBok || drugiBok != trzeciBok || drugiBok != czwartBok || trzeciBok != czwartBok)
                Console.WriteLine("Niej jest rombem");
            else
                Console.WriteLine("Jest rombem");
        }

    }
}
