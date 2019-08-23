using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalary = 0;
            var hoursOvervorked = 0;
            string payCheckAmount(double basePay, int HoursWorked)
            {
                if (basePay >= 8.00 && HoursWorked <= 40)
                {
                    totalSalary = Convert.ToDecimal(basePay * HoursWorked);
                    return totalSalary.ToString("0.##");
                }
                else if (basePay < 8.00)
                {
                        return "Error!";
                }
                else if (HoursWorked > 60)
                {
                    return "Error!";
                }

                else 
                {
                    hoursOvervorked = HoursWorked - 40;
                    totalSalary = Convert.ToDecimal(basePay * 40 + basePay * hoursOvervorked * 1.5);
                    return totalSalary.ToString("0.##");
                }
            }
            Console.WriteLine(payCheckAmount(7.50, 35));
            Console.WriteLine(payCheckAmount(8.20, 47));
            Console.WriteLine(payCheckAmount(10.00, 73));



        }
    }
}
