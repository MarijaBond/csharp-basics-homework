using System;

namespace Exercise_9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;

            Console.WriteLine("Choose a number from 2 to 12");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            do
            {
                Random x = new Random();
                first = x.Next(1, 7);
                second = x.Next(1, 7);
            }
            while (first + second != userChoice);
            Console.WriteLine("That's nice! Randomly picked numbers " + first + " and " + second + " make sum of " + userChoice);




        }
    }
}
