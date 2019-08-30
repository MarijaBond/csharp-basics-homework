using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int figureSize = 7; // define the size of a figure

            for (var i = 0; i < figureSize; i++)
            {

                int a = (16 - (i * 4));
                int b = i * 4 * 2;


                string[] repeatedArray1 = new String('+', a).Replace("+", "/").Split(',');
                string[] repeatedArray2 = new String('+', b).Replace("+", "*").Split(',');
                string[] repeatedArray3 = new String('+', a).Replace("+", "\\").Split(',');

                string z = (string.Join("", repeatedArray1));
                string w = (string.Join("", repeatedArray2));
                string y = (string.Join("", repeatedArray3));
                Console.WriteLine(z + w + y);


            }

        }
    }
}