using System;
using System.Collections.Generic;
using System.Text;

namespace _151212w2
{
    public class Czworokat
    {
        public int pierwszyBok;
        public int drugiBok;
        public int trzeciBok;
        public int czwartyBok;
        public void CzyRomb(int pierwszyBok,int drugiBok,int trzeciBok, int czwartyBok)
        {
            if (pierwszyBok == drugiBok & drugiBok == trzeciBok & trzeciBok == czwartyBok & pierwszyBok > 0)
                Console.WriteLine("Czworokąt jest rombem");
            if (pierwszyBok == drugiBok & drugiBok == trzeciBok & trzeciBok == czwartyBok & pierwszyBok <= 0)
                Console.WriteLine("Nie jest rombem- wartości ujemne lub zerowe");
            if(pierwszyBok == drugiBok & drugiBok == trzeciBok & trzeciBok != czwartyBok )
                Console.WriteLine("Nie jest rombem- boki są różne");
        }

    }
}
