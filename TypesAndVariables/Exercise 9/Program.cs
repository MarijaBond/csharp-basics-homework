using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# program to takes the user for a distance (in meters) and the time was taken (as three numbers: hours, minutes, seconds),
            and display the speed, in meters per second, kilometers per hour and miles per hour (hint: 1 mile = 1609 meters).
            
            Test Data
            Input distance in meters: 2500
            Input hour: 5
            Input minutes: 56
            Input seconds: 23
            Expected Output :
            Your speed in meters / second is 0.11691531
            Your speed in km / h is 0.42089513
            Your speed in miles / h is 0.26158804
            */

            Console.Write("Enter the distance (in meters)!");
            int distanceInMeters = Convert.ToInt32(Console.ReadLine());

            /* solution for the 1st (more complicated) input way: [INPUT STRING -> ARRAY OF INTEGERS]
            Console.Write("Enter the time taken (as three numbers: hours, minutes, seconds)!");
            string totalTime = Console.ReadLine();
            string[] nums = totalTime.Split(',');
            int[] timeTaken = Array.ConvertAll<string, int>(nums, int.Parse); // an array of integers
            int hours_ = timeTaken[0];
            int minutes_ = timeTaken[1];
            int seconds_ = timeTaken[2];
            Console.WriteLine($"The distance of {distanceInMeters} meters took you {hours_} hours, {minutes_} minutes and {seconds_} seconds!");
            */

            Console.WriteLine("Enter hours");
            decimal hours = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter minutes");
            decimal minutes = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter seconds");
            decimal seconds = Convert.ToDecimal(Console.ReadLine());

            decimal metersPerSecond = distanceInMeters / (seconds + minutes * 60 + hours * 60 * 60);
            decimal kmPerHours = distanceInMeters / 1000 / (hours + minutes/60 + seconds/60/60);
            decimal milesPerHours = distanceInMeters / 1609 / (hours + minutes / 60 + seconds / 60 / 60);

            Console.WriteLine($"Your speed in meters / second is {metersPerSecond:0.########}");
            Console.WriteLine($"Your speed in km / h is {kmPerHours:0.########}");
            Console.WriteLine($"Your speed in miles / h is {milesPerHours:0.########}");
        }
    }
}
