using System;

namespace Lekcja2.Classes
{
    class Car
    {
        private string marka;
        private int rokProdukcji;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public Car(string marka, string model, int rokProdukcji,double srednieSpalanie)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.srednieSpalanie = srednieSpalanie;
        }

        public string Marka 
        { 
            get
            {
                return marka;
            }
             
        }
        public int RokProdukcji 
        { 
            get
            {
                return rokProdukcji;
            }
             
        }
        public string Model 
        { 
            get
            {
                return model;
            }
             
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = dlugoscTrasy * (srednieSpalanie / 100);
            return spalanie;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double kosztPrzejazdu = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
            return kosztPrzejazdu;
        }


    }
}
