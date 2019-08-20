using System;

namespace Exercise_8__Hangman_
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int a = 1;
            int testing = 0;
            Random x = new Random();
            string[] favCities = { "Ventspils", "Daugavpils", "Valmiera", "Akapulko", "Copenhagen", "Stockholm" };

            int wIndex = x.Next(0, favCities.Length);
            string guessThisRandomWord = favCities[wIndex].ToLower();

            char[] letters = guessThisRandomWord.ToCharArray();
            char[] displayedWord = new char[guessThisRandomWord.Length];
            Console.WriteLine("Testing..." + guessThisRandomWord);



            for (a = 1; a <= 10; a++) // User gets 10 shots maximum
            {
                Console.WriteLine("Enter a letter!");
                char userGuess = Convert.ToChar(Console.ReadLine());
                for (i = 0; i < letters.Length; i++)
                    testing = 0;
                {
                    if (letters[i] == userGuess)
                    {
                        letters[i] = userGuess;
                        Console.WriteLine("Congrats! You have guessed!   " + string.Join("", displayedWord));
                        testing = 1;
                    }
                    else
                    {
                        displayedWord[i] = '_';
                    }
                }

                if (testing != 1)
                {
                    Console.WriteLine($"You haven't guessed. Try again! " + "You have " + (10 - a) + "shots left");
                }
            }

        }
    }
}