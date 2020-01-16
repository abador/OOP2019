using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2019
{
    public class Postaci
    {
        public string nazwa;
        public int obrażenia;
        public int obrona;
        public int zwinność;
        public int zdrowie;

        public int dmg = 0;
        public int def = 0;
        public int hp = 0;
        public int move = 0;
        public Postaci()
        {
            this.nazwa = "Brak";
            this.obrażenia = 0;
            this.obrona = 0;
            this.zwinność = 0;
            this.zdrowie = 0;
        }
        public Postaci(string nazwa, int obrażenia, int obrona, int zwinność, int zdrowie)
        {
            this.nazwa = nazwa;
            this.obrażenia = obrażenia;
            this.obrona = obrona;
            this.zwinność = zwinność;
            this.zdrowie = zdrowie;
        }
        public Postaci(int obrażenia, int obrona, int zdrowie)
        {
            this.obrażenia = obrażenia;
            this.obrona = obrona;
            this.zdrowie = zdrowie;
            this.hp = zdrowie;
            this.dmg = 0;
            this.def = 0;
        }
        public void Reset_Rundy()
        {
            this.move = zwinność;
            this.dmg = 0;
            this.def = 0;
        }
        public void Kalkulator()
        {
            this.move = zwinność;
            this.hp = zdrowie;
        }
        public void Kalkulator(int a, int b, int c, int d)
        {
            this.move = this.move + d;
            this.dmg = this.dmg + a;
            this.def = this.def + b;
            if (this.hp + c > zdrowie)
            {
                this.hp = zdrowie;
            }
            else
                this.hp = this.hp + c;
        }
    }
    public class Wojownik : Postaci
    {
        public Wojownik()
        {
            this.nazwa = "Wojownik";
            this.obrażenia = 3;
            this.obrona = 4;
            this.zwinność = 3;
            this.zdrowie = 20;
        }
    }
    public class Łucznik : Postaci
    {
        public Łucznik()
        {
            this.nazwa = "Łucznik";
            this.obrażenia = 3;
            this.obrona = 3;
            this.zwinność = 5;
            this.zdrowie = 15;
        }
    }
    public class Mag : Postaci
    {
        public Mag()
        {
            this.nazwa = "Mag";
            this.obrażenia = 4;
            this.obrona = 2;
            this.zwinność = 4;
            this.zdrowie = 10;
        }
    }
}
