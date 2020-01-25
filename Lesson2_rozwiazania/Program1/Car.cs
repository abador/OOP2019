using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Car
    {
        private string marka;
        private int rok;
       // private string model;
       // private int iloscDrzwi;
       // private double pojemnoscSilnika;
        public double srednieSpalanie;
        double spalanie;
        double kosztPrzejazdu;
        double ileSpali;
        public double cenaPaliwa;
        public double dlugoscTrasy;



        public Car(string marka, int rok, double srednieSpalanie, double cenaPaliwa, double dlugoscTrasy)
        {
            this.marka = marka;
            this.rok = rok;
            this.srednieSpalanie = srednieSpalanie;
            this.cenaPaliwa = cenaPaliwa;
            this.dlugoscTrasy = dlugoscTrasy;
            spalanie = ObliczSpalanie(srednieSpalanie, dlugoscTrasy);
            kosztPrzejazdu = ObliczKosztPrzejazdu(spalanie, cenaPaliwa);
        }

        public string Marka
        {
            get
            {
                return marka;
            }
        }
        public int Rok
        {
            get
            {
                return rok;
            }
        }
        private double ObliczSpalanie(double srednieSpalanie, double dlugoscTrasy)
        {
           
            return srednieSpalanie * dlugoscTrasy;
        }
        public double ObliczKosztPrzejazdu(double spalanie, double cenaPaliwa)
        {
            return spalanie * cenaPaliwa;
        }
        public void PokazSpalanie()
        {
            Console.WriteLine("Spalanie wynosi " + spalanie);
        }
        public void PokazKosztPrzejazdu()
        {
            Console.WriteLine("Koszt przejazdu wynosi " + kosztPrzejazdu + " zł");
        }

    }
}
