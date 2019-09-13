using System;
using System.Collections.Generic;
using System.Text;

namespace FuelConsumptionCalculator__part2__FillUp_simulation
{
    public class Car
    {
        private double _firstReading;
        private double _currentMilleage;
        private double _liters;


        public Car(double firstReading, double currentMilleage, double liters)
        {
            this._firstReading = firstReading;
            this._currentMilleage = currentMilleage;
            this._liters = liters;
        }

        public double CalculateConsumption()
        {
            return _liters / (_currentMilleage - _firstReading) * (double) 100;    //returns liters per 100km
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


        public void FillUp(double mileage, double liters) 
        {
            _liters += liters;
            _currentMilleage = mileage;
        }
    }
}
