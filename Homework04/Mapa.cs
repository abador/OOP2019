using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Mapa : IMapa
    {
        public int arrlen;

        public Mapa(int arrlen)
        {
            this.arrlen = arrlen;
        }

        void IMapa.generate()
        {
            int[] array = new int[this.arrlen];
        }

        void IMapa.list()
        {
            throw new NotImplementedException();
        }

        void IMapa.show()
        {
            throw new NotImplementedException();
        }
    }
}
