﻿using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write a C# program to insert an element into the array list at the first position.

            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine(string.Join(",", colors));

            //TODO: Add new color at the first and third position of the list

            colors.Insert(0, "Pink");
            colors.Insert(2, "Navy blue");

            //Print the list
            Console.WriteLine(string.Join(",", colors));
        }
    }
}