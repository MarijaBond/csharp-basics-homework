using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            var maxInput = Math.Max(Math.Max(input1, input2), input3);
            Console.WriteLine(maxInput);

            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */
        }
    }
}
