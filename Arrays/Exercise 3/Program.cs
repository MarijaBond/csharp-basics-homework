using System;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            
            //fixme - calculate sum of all array elements 
            var sum = 0;
            int i;


            for (i = 0; i < numbers.Length; i++)
            {
                sum = sum +numbers[i];
            }

            
            // fixme - calculate average value 

            double average = (double)sum / (double)numbers.Length;

            Console.WriteLine("Average value of the array elements is : " + average);

        }
    }
}
