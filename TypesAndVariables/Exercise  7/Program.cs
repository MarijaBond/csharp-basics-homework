using System;

namespace Exercise__7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prompts the user to enter a string and displays the number of the uppercase letters in the string.
            Console.Write("Enter a string!");
            string userInput = Console.ReadLine();

            int countUppercaseChars = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (char.IsUpper(userInput[i]))
                    countUppercaseChars++;
            }


            Console.WriteLine($"The number of the uppercase letters in your string is {countUppercaseChars}.");
        }
    }
}
