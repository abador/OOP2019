using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
   public abstract class Pozycja
    {
        protected internal string tytuł;
        protected internal int id;
        protected string wydawnictwo;
        protected int rokWydania;
        public Pozycja(string tytuł,string wydawnictwo,int id, int rokWydania)
        {
            this.tytuł = tytuł;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        public Pozycja()
        {
            this.tytuł = tytuł;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        public abstract void WypiszInfo();

    }
}
