using System;

namespace Arithm4
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            var result = 1;
            Console.WriteLine(Product1ToN());

           

            int Product1ToN()
            {
                for (var i = 0; i <= 9; i++)
                {
                   
                        number = number + 1;
                        result = result * number;
                     
                    }
                    return result;
                }
            }


        }
    }
