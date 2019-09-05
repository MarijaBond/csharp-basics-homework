using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string _clientName;
        private double _currentBalance;

        public Account (string name, double balance)
        {
            this._clientName = name;
            this._currentBalance = balance;
        }

        public void withdrawal (double howMuch)
        {
            _currentBalance -= howMuch;
        }

        public void deposit (double howMuch)
        {
            _currentBalance += howMuch;
        }

        public void PrintBalance ()
        {
            Console.WriteLine(_clientName + " balance is: " + string.Format("{0:0.00}",_currentBalance));
        }
        public static void Transfer(Account from, Account to, double howMuch)
        {
            from._currentBalance -= howMuch;
            to._currentBalance += howMuch;
        }
    }
}
