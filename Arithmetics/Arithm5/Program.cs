using System;
using System.Security.Cryptography.X509Certificates;

namespace Arithm5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number from 1-100!");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next(1, 100);


            if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You have guessed!");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine($"Too High! I was thinking of {randomNumber}" );
                }
                else
                {
                    Console.WriteLine($"Too Low! I was thinking of {randomNumber}");
                }
            
        }
    }
}

