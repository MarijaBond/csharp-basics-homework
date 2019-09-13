using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    public class Odometer
    {
        public int _mileage;
        public int _maxMileage = 999999;
        public FuelGauge _fuelGauge;


        public Odometer(int mileage)
        {
            this._mileage = mileage;
        }

        public void PrintMileage()
        {
            Console.WriteLine($"The mileage is {_mileage}");
        }



        public static void SwapPoints<SwapPoints>(ref SwapPoints x, ref SwapPoints y)
        {

            SwapPoints tempswap = x;
            x = y;
            y = tempswap;
        }


        public static void incrementMileageByOneKm (ref Odometer obj1, ref FuelGauge obj2)
        {
            if (obj1._mileage < obj1._maxMileage)
            {
               obj1._mileage++;
                if (obj1._mileage % 10 == 0)
                {
                    obj2.decrementFuelAmount();
                }
            }

            else
            {
                obj1._mileage = 0;
            }
        }

    }

}
