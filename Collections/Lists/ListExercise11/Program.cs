using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            var myList = new List<string> { };

            //TODO: Add 10 values to list
            string[] array = { "pen", "pencil", "potato", "penguin", "puppy", "puzzle", "penicelin", "pickle", "poison", "parmesan" };

            myList.AddRange(array);
            Console.WriteLine(string.Join(",", myList));

            //TODO: Add new value at 5th position
            myList.Insert(4, "postmodernism");
            Console.WriteLine(string.Join(",", myList));
            //TODO: Change value at last position (Calculate last position programmatically)

            myList.RemoveAt(myList.Count - 1);
            myList.Insert(myList.Count, "president");
            Console.WriteLine(string.Join(",", myList));


            //TODO: Sort your list in alphabetical order

            myList.Sort();
            Console.WriteLine(string.Join(",", myList));

            //TODO: Check if your list contains "Foobar" element
            if (myList.Contains("Foobar"))
            {
                Console.Write("Contains!");
            }
            else
            {
                Console.WriteLine("Doesn't contain!");
            }


            //TODO: Print each element of list using loop
            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}











