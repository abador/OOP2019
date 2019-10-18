using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        private int rok;
        private string marka;
        private int przebieg;
        //7
        private string model;
        private int iloscDrzwi;
        private int pojemoscSilnika;
        public double srednieSpalanie;
        //przebieg
        public int Jedz(int trasa)
        {
            this.przebieg += trasa;
            return this.przebieg;
        }
        //8
        private double ObliczSpalanie(int dlugoscTrasy)
        {
            return dlugoscTrasy * srednieSpalanie;
        }
        //Car
        public Car(string m, int r, double s)
        {
            marka = m;
            rok = r;
            srednieSpalanie = s;
        }
        public void Pokaz()
        {
            Console.WriteLine("{0,-15}{1,10}", marka, przebieg);
        }
    }
}
