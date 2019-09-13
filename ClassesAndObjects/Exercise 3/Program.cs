using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            FuelGauge firstCar = new FuelGauge(10);
            firstCar.PrintFuelGauge();
            firstCar.incrementFuelAmount();
            firstCar.decrementFuelAmount();

            Odometer firstOdometer = new Odometer(30);
            firstOdometer.PrintMileage();
            Odometer.incrementMileageByOneKm(ref firstOdometer, ref firstCar);



            Console.WriteLine("Time to fill up for a 5 liters!");
            for (var i = 1; i <= 5; i++)
            {
                firstCar.incrementFuelAmount();
            }


            for (var i = 0; i < 149; i++)
            {
                Odometer.incrementMileageByOneKm(ref firstOdometer, ref firstCar);
                firstCar.PrintFuelGauge();
                firstOdometer.PrintMileage();
            }

        }
    }
}