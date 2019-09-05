using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_4
{
    class FuelGauge
    {
        private int _amountOfLiters;
        private int _maxLevel = 70;

        public FuelGauge(int amountOfLiters)
        {
            this._amountOfLiters = amountOfLiters;
        }

        public void PrintFuelGauge()
        {
            Console.WriteLine($"The amount of car's fuel is {_amountOfLiters}");
        }



    public class Odometer
    {
        private int _mileage;
        private int _maxMileage = 999999;
        private FuelGauge _fuelGauge;


        public Odometer(int mileage)
        {
            this._mileage = mileage;
            _fuelGauge = new FuelGauge(0);
        }

        public void PrintMileage()
        {
            Console.WriteLine($"The mileage of car's fuel is {_mileage}");
        }



    public class NewTest
    {
        static void Main(string[] args)
        {
            FuelGauge firstCar = new FuelGauge(10);
            firstCar.PrintFuelGauge();


        }
    }
}