using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average = 0;
            const int lowerBound = 1;
            const int upperBound = 100;

            Console.WriteLine($"The sum of 1 to 100 is {SumAverageRunningInt()}.\nThe average is ....");

            int SumAverageRunningInt()
            {
                for (var number = lowerBound; number <= upperBound; number++)
                {
                    sum += number;
                }
                return sum;
            }

            double averageCounter ()
            {
                for (var number = lowerBound; number <= upperBound; number++)
                {
                    average += number/100;
                }
                return average;
            }

        }
        }
    }
/* Write a program called SumAverageRunningInt to produce the sum of 1, 2, 3, ..., to 100. 
 * Store 1 and 100 in variables lower bound and upper bound, so that we can change their values easily.
 * Also compute and display the average.The output shall look like:
                    The sum of 1 to 100 is 5050
                    The average is 50.5*/
