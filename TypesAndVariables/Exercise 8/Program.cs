using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to convert minutes into a number of years and days.

            double minutes = 1000000;
            double years = minutes / (60 * 24 * 365);
            int roundYears = Convert.ToInt32(Math.Floor(years)); // rounds the years down;
            double convertToRemainingDays = Math.Floor((years - roundYears) * 365);
            
            Console.WriteLine(years);
            Console.WriteLine(roundYears);
            Console.WriteLine($"{minutes} makes {roundYears} years and {convertToRemainingDays} days");
        }
    }
}
