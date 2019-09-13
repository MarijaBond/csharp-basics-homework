using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of your starting balance");
            double startBalance = Convert.ToDouble(Console.ReadLine());
            SavingsAccount bankAccount = new SavingsAccount(startBalance);

            Console.WriteLine("Enter the annual interest rate");
            int annualRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many months ago the account has been opened?");
            int months = Convert.ToInt32(Console.ReadLine());      ///!!! = i

            double totalDeposit = 0;
            double totalWithdrawn = 0;

            for (var i = 1; i <= months; i++)
            {          
            Console.WriteLine("Enter amount deposited for month: " + i);
            double deposit = Convert.ToDouble(Console.ReadLine());
            bankAccount.Deposit(deposit);
            Console.WriteLine("Enter amount withdrawn for month: " + i);
            double withdrawn = Convert.ToDouble(Console.ReadLine());
            bankAccount.Withdrawal(withdrawn);
            bankAccount.MonthlyInterest(annualRate);
                totalDeposit += deposit;
                totalWithdrawn += withdrawn;
        }


            Console.WriteLine("Total deposited: $" + totalDeposit);
            Console.WriteLine("Total withdrawn: $" + totalWithdrawn);
            bankAccount.PrintTotalInterest();
            Console.WriteLine("Ending balance: ");
            bankAccount.PrintCurrentBalance();
        }
    }
}
