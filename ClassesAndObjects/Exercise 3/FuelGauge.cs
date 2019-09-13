using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    public class FuelGauge
    {
        public int _amountOfLiters;
        public int _maxLevel = 70;


        public FuelGauge(int amountOfLiters)
        {
            this._amountOfLiters = amountOfLiters;
        }

        public void PrintFuelGauge()
        {
            Console.WriteLine($"The amount of car's fuel is {_amountOfLiters}");
        }

        public void incrementFuelAmount()
        {
            if (_amountOfLiters <= _maxLevel)
            {
                _amountOfLiters++;
            }
        }

        public void decrementFuelAmount()
        {
            if (_amountOfLiters == 1)
            {
                Console.WriteLine("Oh no! The are running of your fuel! Time to fill Up!");
                _amountOfLiters--;
            }
            else if (_amountOfLiters == 0)
            {
                Console.WriteLine("Take a jerrycan and good luck finding some fuel station");
                _amountOfLiters--;
            }
            else
            {
                _amountOfLiters--;
            }
           
        }

    }
}
