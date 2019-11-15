using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_zamiast_wejsciowki
{
    class User : MapElement //dziedziczy po MapElement poniewaz user tez jest elementem mapy
    {
        private int level;
        private string name;

        public User(string name)
        {
            this.name = name;
            this.level = 1;
        }

        public void PrintUser()
        {
            this.icon = 'U';
            //nie wiem jak wygenerowac losowego pola dla usera na trawie

        }
    }
}
