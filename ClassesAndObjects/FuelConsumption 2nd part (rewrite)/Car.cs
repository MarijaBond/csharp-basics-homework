using System;
using System.Collections.Generic;
using System.Text;

namespace FuelConsumption_2nd_part__rewrite_
{
    public class Car
    {
        private double _CurentMileage;
        private double _liters;


        public Car(double startOdo, double endingOdo, double liters)
        {
            this._startKilometers = startOdo;
            this._endKilometers = endingOdo;
            this._liters = liters;
        }

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) / _liters;
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

        public void FillUp(int mileage, double liters)
        {
            _liters += liters;
            _Currentmileage += mileage;
        }

    }
}
