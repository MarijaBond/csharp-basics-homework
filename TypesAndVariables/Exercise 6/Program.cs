using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a single digit number!");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another single digit number!");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another single digit number!");
            int userInput3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another single digit number!");
            int userInput4 = Convert.ToInt32(Console.ReadLine());

            //count the sum of all inputs
            int userInputSum = userInput1 + userInput2 + userInput3 + userInput4;
            Console.WriteLine($"The sum of all numbers is {userInputSum}.");

        }
    }
}
