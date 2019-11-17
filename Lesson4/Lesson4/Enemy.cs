using System;
using System.Collections.Generic;
using System.Text;

namespace Wejściówka
{
    class Enemy: MapElement
    {
        // dziedziczy MapElement gdyż wróg jest również elementem mapy 
        public string name;
        public int level;
        public void EPrint()
        {
            this.icon = 'E';
            Console.WriteLine(this.icon + " x=" + x + " y=" + y);

        }
        


    }
}
