using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount marija = new BankAccount("Marija Bondarenko", -0.1);
            marija.ShowUserNameAndBalance();
        }
    }

    class BankAccount
    {
        private string _userName;
        private double _userBalance;

        public BankAccount (string name, double balance)
        {
            this._userName = name;
            UserBalance = balance;
        }

        public double UserBalance
        {
            get
            {
                return this._userBalance;
            }
            set
            {
                if (value < 0)
                {
                    this._userBalance = Math.Abs(value);                   
                }
                else 
                {
                    this._userBalance = value;
                }
            }
        }

         public void ShowUserNameAndBalance ()
        {
            Console.WriteLine(this._userName + ", $" + string.Format("{0:0.00}", this._userBalance));
        }
    }
}
