using System;

namespace FuelConsumptionCalculator__part2__FillUp_simulation
{
    class Program
    {
        private static void Main(string[] args)
        {
            double firstReading, currentMilleage, liters;

            Console.WriteLine("Enter first reading: ");
            firstReading = Convert.ToDouble(Console.ReadLine());
            currentMilleage = firstReading;
            liters = 0;

            Car userCar = new Car(firstReading, currentMilleage, liters);
            Console.WriteLine("How many liters would you like to fill up with?");
            double fillupLiters = Convert.ToDouble(Console.ReadLine());
            userCar.FillUp(currentMilleage, fillupLiters);

            Console.WriteLine("How many liters would you like to fill up with?");
            fillupLiters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current odometer reading?");
            currentMilleage = Convert.ToDouble(Console.ReadLine());
            userCar.FillUp(currentMilleage, fillupLiters);

            Console.WriteLine("How many liters would you like to fill up with?");
            fillupLiters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current odometer reading?");
            currentMilleage = Convert.ToDouble(Console.ReadLine());
            userCar.FillUp(currentMilleage, fillupLiters);

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


