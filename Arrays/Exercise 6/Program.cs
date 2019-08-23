using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            Random x = new Random();

            int[] myBestArrayYet = new int[10];
            int[] myBestArrayYetCopy = new int[10];

            for (i = 0; i < 10; i++)
            {
                int myRandomNumber = x.Next(1, 100);
                myBestArrayYet[i] = myRandomNumber;
                myBestArrayYetCopy[i] = myBestArrayYet[i];
            }

            myBestArrayYet[9] = -7;

            Console.WriteLine(string.Join(",", myBestArrayYet));
            Console.WriteLine(string.Join(",", myBestArrayYetCopy));

        }
    }
}
