

using Enumerations;

namespace Makulatura
{
    public abstract class Pozycja
    {
        private string tytul;
        private string wydawnictwo;
        private DzialTematyczny dzialTematyczny;

        private int rokWydania;
        

        private int id;
        private static int idCounter;

        public string Tytul 
        { 
            get
            {
                return this.tytul;
            }
            protected set
            {
                this.tytul = value;
            }
        }
        protected string Wydawnictwo
        { 
            get
            {
                return this.wydawnictwo;
            }
            set
            {
                this.wydawnictwo = value;
            }
        }
        protected DzialTematyczny DzialTematyczny
        {
            get
            {
                return this.dzialTematyczny;
            }
            set
            {
                this.dzialTematyczny = value;
            }
        }
        


        protected int RokWydania 
        {
            get
            {
                return this.rokWydania;
            }
            set
            {
                this.rokWydania = value;
            }
        }
        
        public int ID 
        { 
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }
        public static int IdCounter
        {
            get
            {
                return Pozycja.idCounter;
            }

        }

        public Pozycja()
        {

        }

        public Pozycja(string tytul, string wydawnictwo, DzialTematyczny dzialTematyczny, int rokWydania)
        {
            Pozycja.idCounter++;

            this.ID = idCounter;
            this.Tytul = tytul;
            this.Wydawnictwo = wydawnictwo;
            this.DzialTematyczny = dzialTematyczny;
            this.RokWydania = rokWydania;
            
        }

        public abstract void WypiszInfo();
        
    }
}
