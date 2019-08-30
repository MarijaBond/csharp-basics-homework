using System;

namespace Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CheckNumber(10, 5));

             bool CheckNumber(int choice1, int choice2)
            {

                if (choice1 == 15 || choice2 == 15)
                {
                    return true;

                }

                else if (choice1 + choice2 == 15)
                {
                    return true;

                }


                else if (choice1 - choice2 == 15)
                {
                    return true;

                }

                else if (choice2 - choice1 == 15)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
        }
    }
}
