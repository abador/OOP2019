using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        private static Car instance = new Car("Opel", 5.5);
        private Car()
        {

        }
        private Car(string marka, double pojemnoscSilnika)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
        }
        public static Car GetMyCar()
        {
            return instance;
        }
    }
}
