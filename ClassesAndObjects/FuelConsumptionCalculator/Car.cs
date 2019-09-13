using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;


        public Car(double startOdo, double endingOdo, double liters)
        {
            this._startKilometers = startOdo;
            this._endKilometers = endingOdo;
            this._liters = liters;
        }

        public double CalculateConsumption()
        {
            return ((_liters / (_endKilometers - _startKilometers)) * (double)100);  //returns liters per 100km
        }

        public bool GasHog()
        {
            if (CalculateConsumption() > 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EconomyCar()
        {
            if (CalculateConsumption() < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
