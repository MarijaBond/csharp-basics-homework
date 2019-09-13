using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class SavingsAccount
    {
        private double _startingBalance;
        private double _currentBalance;
        private double _totalInterestEarned = 0;
        public SavingsAccount(double startBalance)
        {
            StartingBalance = startBalance;
            _currentBalance = startBalance;
        }

        public void PrintCurrentBalance()
        {
            Console.WriteLine("$" + _currentBalance);
        }
        public double StartingBalance { get => _startingBalance; set => _startingBalance = value; }

        public void Withdrawal (double amountWithdrawn)
        {
            _currentBalance -= amountWithdrawn;
        }

        public void Deposit (double amountAdded)
        {
            _currentBalance += amountAdded;
        }

        public void MonthlyInterest (int annualInterest)
        {
            double monthlyInterest = (double)annualInterest / (double)12; 
           _currentBalance += (monthlyInterest * _currentBalance / 100); 
           _totalInterestEarned += (monthlyInterest * _currentBalance / 100); 
        }
        public void PrintTotalInterest ()
        {

            Console.WriteLine("Total interest earned: $" + _totalInterestEarned);
        }

    }
}
