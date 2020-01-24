using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.CarClass
{
    class Car
    {
        private float engineCapacity;
        private string nrVIN;
        public int yearOfProduction;
        public string name;
        public float avarageConsumption;

        public enum typeOfRoad
        {
            t_0_8,
            t1,
            t1_3
        }

        private Car()
        {

        }

        public static Car CarCreateObject(float engineCapacity, string nrVIN, int yearOfProduction, string name,
            float avarageConsumption) => new Car()
        {
            engineCapacity = engineCapacity,
            nrVIN = nrVIN,
            yearOfProduction = yearOfProduction,
            name = name,
            avarageConsumption = avarageConsumption
        };

        public double CountConsumption(float routeLength, typeOfRoad typeRoad)
        {
            switch (typeRoad)
            {
                case Car.typeOfRoad.t_0_8: return this.avarageConsumption * routeLength * 0.8;
                default:
                case Car.typeOfRoad.t1_3: return this.avarageConsumption * routeLength;
                case Car.typeOfRoad.t1: return this.avarageConsumption * routeLength * 1.3;
            }

        }
    }
}
