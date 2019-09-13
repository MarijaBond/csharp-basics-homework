using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneKeyPad();
        }

        static void PhoneKeyPad()
        {

            Console.WriteLine("Enter a string");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();


            char[] arrayOfLetters = userInput.ToCharArray();

            foreach (char x in arrayOfLetters)
            {

                switch (x)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        Console.WriteLine(2);
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        Console.WriteLine(3);
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        Console.WriteLine(4);
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        Console.WriteLine(5);
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        Console.WriteLine(6);
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        Console.WriteLine(7);
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        Console.WriteLine(8);
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        Console.WriteLine(9);
                        break;
                    default:
                        Console.WriteLine("Your input should contain letters only!");
                        break;
                }
            }
        }
    }
}
