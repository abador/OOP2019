using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Car
    {
        public string marka;
        public int rokprodukcji;
        private int przebieg;
        private double pojemnoscSilnika;
        private int iloscDrzwi;
        private string model;
        public double srednieSpalanie;

        public int jedz(int trasa)
        {
            this.przebieg += trasa;
            return this.przebieg;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = srednieSpalanie * dlugoscTrasy;
            return spalanie;
        }
        public double obliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double kosztPrzejazdu = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
            return kosztPrzejazdu;
        }
    }
}
