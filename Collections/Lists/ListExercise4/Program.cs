using System;
using System.Collections.Generic;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Create a list and add some colors to the list
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };


            string colors_1 = colors[0];
            Console.WriteLine("First element: " + colors_1);


            string colors_2 = colors[2];
            Console.WriteLine("Third element: " + colors_2);
        }
    }
}