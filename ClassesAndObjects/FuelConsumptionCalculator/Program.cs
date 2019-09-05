using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers, endKilometers, liters;

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second reading: ");
            endKilometers = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter liters consumed: ");
            liters = Convert.ToDouble(Console.ReadLine());

            Car userCar = new Car(startKilometers, endKilometers, liters);
            Console.WriteLine("Your fuel consumption is " + userCar.CalculateConsumption() + " liters per 100 km");
            if (userCar.GasHog())
            {
                Console.WriteLine("OMG! Your fuel consumption is higher than 15.0 l / 100 km!");
            }
            else if (userCar.EconomyCar())
            {
                Console.WriteLine("Congrats! Your fuel consumption is lower than 5.0 l / 100 km :)");
            }
        }
    }
}
