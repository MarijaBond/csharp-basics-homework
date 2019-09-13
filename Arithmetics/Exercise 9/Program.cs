using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //BMI = weight x 703 / height ^ 2. Where weight is measured in pounds and height is measured in inches. 

            double weightInPounds = 150;
            double heightInInches = 70;
            double calcBMI = (weightInPounds * 703) / (heightInInches * heightInInches);
            Console.WriteLine(calcBMI);

            void checkMyBMI(double a)
            {
                if (a < 18.5)
                {
                    Console.WriteLine("Your're underweight!");
                }
                else if (a > 25)
                {
                    Console.WriteLine("Your're overweight!");
                }
                else
                {
                    Console.WriteLine("You're fine!");
                }
            }

            checkMyBMI(calcBMI);



        }
    }
}
