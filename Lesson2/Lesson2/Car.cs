using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Car
    {
        private string marka;
        private int rokProdukcji;
        private int przebieg;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public double srednieSpalanie;

        public int jedz(int trasa)
        {
            this.przebieg += trasa;
            return this.przebieg;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            this.srednieSpalanie *= dlugoscTrasy;
            return this.srednieSpalanie;
        }
       public void showCar()
        {
            Console.WriteLine("Marka" + marka);
            Console.WriteLine("rokProdukcji" + rokProdukcji);
            Console.WriteLine("przebieg" + przebieg);
            Console.WriteLine("model" + model);
            Console.WriteLine("iloscDrzwi" + iloscDrzwi);
            Console.WriteLine("pojemnoscSilnika" + pojemnoscSilnika);
            Console.WriteLine("srednieSpalanie" + srednieSpalanie);

        }
    }
}
 
