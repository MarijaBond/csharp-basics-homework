﻿using System;

namespace Exercise2
{
    class Program
    {
        //TODO: Write a C# program to sum values of an array.
        private static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sum = 0;
            int i;


            for (i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }

            Console.WriteLine("The sum is " + sum);
        
        }
    }
}
