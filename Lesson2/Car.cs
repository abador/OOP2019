namespace zadania
{
    public class Car
    {
        private string marka;
        private int rok;
        private int przebieg;

        public int jedz(int trasa)
        {
            this.przebieg += trasa;
            return this.przebieg;
        }

        public string pobierzMarke()
        {
            return marka;
        }
        public int pobierzRok()
        {
            return rok;
        }
        public Car (string marka, int rok)
        {
            this.marka = marka;
            this.rok = rok;
        }

        private string model;
        private int iloscDrzwi;
        private float pojemnoscSilnika;
        public double srednieSpalanie;


    }

}