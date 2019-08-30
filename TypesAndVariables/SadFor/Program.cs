using System;

namespace SadFor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test1();
        }

        private static void Test1()
        {
            //fixme so I would compile

            for (var i = 0; i < 10; i++)
            {
                if (Math.Sqrt(i) > 2.5)
                {
                    Console.WriteLine(i);
                }
            }
        }
        }
    }








/*          int[] niceArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for (var i = 0; i < 10; i++)
            {
                if (Math.Sqrt(niceArray[i]) > 2.5)
                {
                    Console.WriteLine(niceArray[i]); //Prints only integers with sqrt>2.5); 
                }
                }
                */
 